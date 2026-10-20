package ar.psmobile

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import androidx.compose.ui.unit.dp
import kotlinx.coroutines.launch

class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        val dao = ClinicDatabase.get(this).dao()
        setContent { MaterialTheme { ClinicApp(dao) } }
    }
}

@Composable
fun ClinicApp(dao: ClinicDao) {
    val clients by dao.clients().collectAsState(initial = emptyList())
    val appointments by dao.appointments().collectAsState(initial = emptyList())
    val scope = rememberCoroutineScope()
    var tab by remember { mutableIntStateOf(0) }
    var name by remember { mutableStateOf("") }
    var phone by remember { mutableStateOf("") }
    var selected by remember { mutableStateOf<Long?>(null) }
    var date by remember { mutableStateOf("") }
    var time by remember { mutableStateOf("") }
    var note by remember { mutableStateOf("") }
    var message by remember { mutableStateOf("") }

    Scaffold(topBar = { Surface(tonalElevation = 3.dp) {
        Text("PS Mobile · Consultorio", style = MaterialTheme.typography.titleLarge, modifier = Modifier.fillMaxWidth().padding(18.dp))
    } }) { padding ->
        Column(Modifier.padding(padding).padding(16.dp), verticalArrangement = Arrangement.spacedBy(12.dp)) {
            TabRow(selectedTabIndex = tab) {
                Tab(selected = tab == 0, onClick = { tab = 0 }, text = { Text("Clientes") })
                Tab(selected = tab == 1, onClick = { tab = 1 }, text = { Text("Turnos") })
            }
            if (tab == 0) {
                OutlinedTextField(name, { name = it }, label = { Text("Nombre y apellido") }, singleLine = true, modifier = Modifier.fillMaxWidth())
                OutlinedTextField(phone, { phone = it }, label = { Text("Teléfono") }, singleLine = true, modifier = Modifier.fillMaxWidth())
                Button(enabled = name.isNotBlank(), onClick = {
                    scope.launch {
                        dao.addClient(Client(name = name.trim(), phone = phone.trim()))
                        name = ""; phone = ""; message = "Cliente guardado localmente"
                    }
                }) { Text("Guardar cliente") }
                Text("Clientes registrados: ${clients.size}", style = MaterialTheme.typography.titleMedium)
                LazyColumn {
                    items(clients, key = { it.id }) { client ->
                        ListItem(headlineContent = { Text(client.name) }, supportingContent = { Text(client.phone) })
                        HorizontalDivider()
                    }
                }
            } else {
                Text("Nuevo turno", style = MaterialTheme.typography.titleMedium)
                if (clients.isEmpty()) Text("Primero registrá un cliente.")
                else {
                    var expanded by remember { mutableStateOf(false) }
                    val chosen = clients.find { it.id == selected }
                    Box {
                        OutlinedButton(onClick = { expanded = true }) { Text(chosen?.name ?: "Elegir cliente") }
                        DropdownMenu(expanded = expanded, onDismissRequest = { expanded = false }) {
                            clients.forEach { client ->
                                DropdownMenuItem(text = { Text(client.name) }, onClick = { selected = client.id; expanded = false })
                            }
                        }
                    }
                    OutlinedTextField(date, { date = it }, label = { Text("Fecha (AAAA-MM-DD)") }, singleLine = true)
                    OutlinedTextField(time, { time = it }, label = { Text("Hora (HH:MM)") }, singleLine = true)
                    OutlinedTextField(note, { note = it }, label = { Text("Motivo / observación breve") })
                    Button(enabled = selected != null && Regex("\\d{4}-\\d{2}-\\d{2}").matches(date) && Regex("\\d{2}:\\d{2}").matches(time), onClick = {
                        val id = selected ?: return@Button
                        scope.launch {
                            dao.addAppointment(Appointment(clientId = id, date = date, time = time, note = note))
                            date = ""; time = ""; note = ""; message = "Turno guardado localmente"
                        }
                    }) { Text("Guardar turno") }
                }
                Text("Turnos registrados: ${appointments.size}", style = MaterialTheme.typography.titleMedium)
                LazyColumn {
                    items(appointments, key = { it.id }) { appt ->
                        val client = clients.find { it.id == appt.clientId }
                        ListItem(headlineContent = { Text("${appt.date} · ${appt.time}") },
                            supportingContent = { Text("${client?.name ?: "Cliente"} — ${appt.note}") })
                        HorizontalDivider()
                    }
                }
            }
            if (message.isNotBlank()) Text(message, color = MaterialTheme.colorScheme.primary)
        }
    }
}
