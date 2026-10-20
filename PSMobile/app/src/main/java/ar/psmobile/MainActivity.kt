package ar.psmobile

import android.os.Bundle
import androidx.activity.ComponentActivity
import androidx.activity.compose.setContent
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.background
import androidx.compose.ui.graphics.Brush
import androidx.compose.foundation.BorderStroke
import androidx.compose.foundation.lazy.LazyColumn
import androidx.compose.foundation.lazy.items
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import kotlinx.coroutines.launch
import java.time.LocalDate
import java.time.LocalTime

private val green = Color(0xFFB59AFF)
private val background = Color(0xFF0B1022)
private val panel = Color(0xFF18213A)
private val muted = Color(0xFFAAB5D0)
private val accent = Color(0xFF7654E8)
class MainActivity : ComponentActivity() {
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        val dao = ClinicDatabase.get(this).dao()
        setContent {
            MaterialTheme(
                colorScheme = darkColorScheme(primary = green, onPrimary = background, background = background, surface = panel, onSurface = Color(0xFFF4F5FF), onBackground = Color(0xFFF4F5FF), surfaceVariant = Color(0xFF273354), onSurfaceVariant = muted, secondaryContainer = Color(0xFF302652)),
                shapes = Shapes(medium = RoundedCornerShape(18.dp), large = RoundedCornerShape(24.dp))
            ) { ClinicApp(dao) }
        }
    }
}
@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun ClinicApp(dao: ClinicDao) {
    val clients by dao.clients().collectAsState(initial = emptyList())
    val turns by dao.appointments().collectAsState(initial = emptyList())
    val scope = rememberCoroutineScope()
    var section by remember { mutableIntStateOf(0) }
    var search by remember { mutableStateOf("") }
    var editingClient by remember { mutableStateOf<Client?>(null) }
    var editingTurn by remember { mutableStateOf<Appointment?>(null) }
    var clientDialog by remember { mutableStateOf(false) }
    var turnDialog by remember { mutableStateOf(false) }
    var removeClient by remember { mutableStateOf<Client?>(null) }
    var removeTurn by remember { mutableStateOf<Appointment?>(null) }
    var notice by remember { mutableStateOf("") }
    val snackbar = remember { SnackbarHostState() }
    LaunchedEffect(notice) {
        if (notice.isNotBlank()) { snackbar.showSnackbar(notice); notice = "" }
    }
    Scaffold(
        containerColor = background,
        topBar = {
            CenterAlignedTopAppBar(title = {
                Column {
                    Text("PS  /  MOBILE", fontWeight = FontWeight.ExtraBold, letterSpacing = 1.5.sp)
                    Text("DASHBOARD · CONSULTORIO", style = MaterialTheme.typography.labelSmall, color = muted)
                }
            }, colors = TopAppBarDefaults.centerAlignedTopAppBarColors(containerColor = background))
        },
        snackbarHost = { SnackbarHost(snackbar) },
        bottomBar = {
            NavigationBar(containerColor = panel) {
                listOf("Inicio", "Agenda", "Clientes").forEachIndexed { index, label ->
                    NavigationBarItem(selected = section == index, onClick = { section = index },
                        icon = { Text(listOf("⌂", "▦", "●")[index]) }, label = { Text(label) })
                }
            }
        },
        floatingActionButton = {
            FloatingActionButton(onClick = {
                if (section == 2) { editingClient = null; clientDialog = true }
                else { editingTurn = null; turnDialog = true }
            }, containerColor = accent, contentColor = Color.White) { Text("+", style = MaterialTheme.typography.headlineMedium) }
        }
    ) { padding ->
        LazyColumn(Modifier.fillMaxSize().padding(padding), contentPadding = PaddingValues(20.dp),
            verticalArrangement = Arrangement.spacedBy(14.dp)) {
            if (section == 0) {
                item {
                    Text("Tu centro de control", style = MaterialTheme.typography.headlineMedium, fontWeight = FontWeight.ExtraBold)
                    Text("Actividad y estadísticas · " + LocalDate.now(), color = muted)
                }
                item {
                    Card(colors = CardDefaults.cardColors(containerColor = Color.Transparent), shape = RoundedCornerShape(24.dp)) {
                        Column(Modifier.fillMaxWidth().background(Brush.linearGradient(listOf(Color(0xFF5836A9), Color(0xFF2C3982), Color(0xFF1D2752)))).padding(20.dp)) {
                            Text("RESUMEN GENERAL", color = Color(0xFFE4DDFF), style = MaterialTheme.typography.labelMedium)
                            Text("El día de tu consultorio", color = Color.White, style = MaterialTheme.typography.titleLarge, fontWeight = FontWeight.Bold)
                            Spacer(Modifier.height(14.dp))
                            Row(horizontalArrangement = Arrangement.spacedBy(12.dp)) {
                                Metric("Turnos de hoy", turns.count { it.date == LocalDate.now().toString() }, Modifier.weight(1f))
                                Metric("Próximos", turns.count { it.date >= LocalDate.now().toString() }, Modifier.weight(1f))
                            }
                        }
                    }
                }
                item {
                    Row(horizontalArrangement = Arrangement.spacedBy(12.dp)) {
                        Metric("Clientes", clients.size, Modifier.weight(1f))
                        Metric("Sesiones registradas", turns.size, Modifier.weight(1f))
                    }
                }
                item {
                    Text("Accesos rápidos", style = MaterialTheme.typography.titleLarge, fontWeight = FontWeight.Bold)
                    Row(horizontalArrangement = Arrangement.spacedBy(12.dp)) {
                        Button(onClick = { editingTurn = null; turnDialog = true }, modifier = Modifier.weight(1f)) { Text("Nuevo turno") }
                        OutlinedButton(onClick = { editingClient = null; clientDialog = true }, modifier = Modifier.weight(1f)) { Text("Nuevo cliente") }
                    }
                }
                item { Text("Agenda de hoy", style = MaterialTheme.typography.titleLarge, fontWeight = FontWeight.Bold) }
                val today = turns.filter { it.date == LocalDate.now().toString() }
                if (today.isEmpty()) item { Empty("Tu agenda está libre", "Agregá un turno para comenzar.") }
                else items(today, key = { it.id }) { turn ->
                    TurnCard(turn, clients.find { it.id == turn.clientId }?.name ?: "Cliente", { editingTurn = turn; turnDialog = true }, { removeTurn = turn })
                }
            }
            if (section == 1) {
                item {
                    Text("Agenda de sesiones", style = MaterialTheme.typography.headlineMedium, fontWeight = FontWeight.Bold)
                    Text("Turnos registrados: " + turns.size, color = muted)
                }
                if (turns.isEmpty()) item { Empty("Sin turnos", "Tocá + para agendar una sesión.") }
                else items(turns.sortedWith(compareBy<Appointment> { it.date }.thenBy { it.time }), key = { it.id }) { turn ->
                    TurnCard(turn, clients.find { it.id == turn.clientId }?.name ?: "Cliente", { editingTurn = turn; turnDialog = true }, { removeTurn = turn })
                }
            }
            if (section == 2) {
                item {
                    Text("Directorio de clientes", style = MaterialTheme.typography.headlineMedium, fontWeight = FontWeight.Bold)
                    Text("Fichas registradas: " + clients.size, color = muted)
                }
                item { OutlinedTextField(search, { search = it }, label = { Text("Buscar nombre o teléfono") }, modifier = Modifier.fillMaxWidth(), singleLine = true) }
                val filtered = clients.filter { it.name.contains(search, true) || it.phone.contains(search, true) }
                if (filtered.isEmpty()) item { Empty("Sin resultados", "Agregá un cliente o cambiá la búsqueda.") }
                else items(filtered, key = { it.id }) { client ->
                    Card(colors = CardDefaults.cardColors(containerColor = panel)) {
                        Column(Modifier.fillMaxWidth().padding(16.dp)) {
                            Text(client.name, style = MaterialTheme.typography.titleMedium, fontWeight = FontWeight.Bold)
                            Text(client.phone.ifBlank { "Sin teléfono" }, color = muted)
                            Text("Turnos: " + turns.count { it.clientId == client.id }, color = green)
                            Row {
                                TextButton(onClick = { editingClient = client; clientDialog = true }) { Text("Editar") }
                                TextButton(onClick = { editingTurn = Appointment(clientId = client.id, date = LocalDate.now().toString(), time = "09:00", note = ""); turnDialog = true }) { Text("Agendar") }
                                TextButton(onClick = { removeClient = client }) { Text("Eliminar") }
                            }
                        }
                    }
                }
            }
        }
    }
    if (clientDialog) ClientForm(editingClient, { clientDialog = false }) { name, phone ->
        scope.launch {
            try {
                val original = editingClient
                if (original == null) dao.addClient(Client(name = name, phone = phone))
                else dao.updateClient(original.copy(name = name, phone = phone))
                clientDialog = false
                notice = "Cliente guardado"
            } catch (_: Exception) { notice = "No se pudo guardar" }
        }
    }
    if (turnDialog) TurnForm(editingTurn, clients, { turnDialog = false }) { clientId, date, time, note ->
        scope.launch {
            try {
                val original = editingTurn
                if (original == null || original.id == 0L) dao.addAppointment(Appointment(clientId = clientId, date = date, time = time, note = note))
                else dao.updateAppointment(original.copy(clientId = clientId, date = date, time = time, note = note))
                turnDialog = false
                notice = "Turno guardado"
            } catch (_: Exception) { notice = "No se pudo guardar" }
        }
    }
    removeTurn?.let { entry ->
        ConfirmDelete("Eliminar turno", "¿Eliminar este turno?", { removeTurn = null }) {
            scope.launch { dao.deleteAppointment(entry); removeTurn = null; notice = "Turno eliminado" }
        }
    }
    removeClient?.let { entry ->
        val blocked = turns.any { it.clientId == entry.id }
        ConfirmDelete("Eliminar cliente", if (blocked) "Primero eliminá sus turnos registrados." else "¿Eliminar la ficha de " + entry.name + "?", { removeClient = null }, blocked) {
            scope.launch { dao.deleteClient(entry); removeClient = null; notice = "Cliente eliminado" }
        }
    }
}
@Composable
private fun Metric(title: String, number: Int, modifier: Modifier) {
    Card(modifier, colors = CardDefaults.cardColors(containerColor = panel)) {
        Column(Modifier.padding(18.dp)) {
            Text(number.toString(), style = MaterialTheme.typography.headlineLarge, fontWeight = FontWeight.ExtraBold, color = green)
            Text(title, style = MaterialTheme.typography.bodyMedium)
        }
    }
}
@Composable
private fun Empty(title: String, subtitle: String) {
    Card(colors = CardDefaults.cardColors(containerColor = panel), modifier = Modifier.fillMaxWidth()) {
        Column(Modifier.padding(28.dp)) {
            Text(title, style = MaterialTheme.typography.titleMedium)
            Text(subtitle, color = muted)
        }
    }
}
@Composable
private fun TurnCard(turn: Appointment, name: String, edit: () -> Unit, delete: () -> Unit) {
    Card(colors = CardDefaults.cardColors(containerColor = panel)) {
        Column(Modifier.fillMaxWidth().padding(16.dp)) {
            Text(turn.date + "  ·  " + turn.time, color = green, fontWeight = FontWeight.Bold)
            Text(name, style = MaterialTheme.typography.titleMedium)
            Text(turn.note.ifBlank { "Sesión programada" }, color = muted)
            Row {
                TextButton(onClick = edit) { Text("Editar") }
                TextButton(onClick = delete) { Text("Eliminar") }
            }
        }
    }
}
@Composable
private fun ConfirmDelete(title: String, description: String, dismiss: () -> Unit, blocked: Boolean = false, delete: () -> Unit) {
    AlertDialog(onDismissRequest = dismiss, title = { Text(title) }, text = { Text(description) },
        confirmButton = { TextButton(enabled = !blocked, onClick = delete) { Text("Eliminar") } },
        dismissButton = { TextButton(onClick = dismiss) { Text("Cancelar") } })
}
@Composable
private fun ClientForm(original: Client?, dismiss: () -> Unit, save: (String, String) -> Unit) {
    var name by remember(original) { mutableStateOf(original?.name ?: "") }
    var phone by remember(original) { mutableStateOf(original?.phone ?: "") }
    AlertDialog(onDismissRequest = dismiss, title = { Text(if (original == null) "Nuevo cliente" else "Editar cliente") },
        text = {
            Column(verticalArrangement = Arrangement.spacedBy(10.dp)) {
                OutlinedTextField(name, { name = it }, label = { Text("Nombre y apellido") }, singleLine = true)
                OutlinedTextField(phone, { phone = it }, label = { Text("Teléfono") }, singleLine = true,
                    keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Phone))
            }
        },
        confirmButton = { Button(enabled = name.isNotBlank(), onClick = { save(name.trim(), phone.trim()) }) { Text("Guardar") } },
        dismissButton = { TextButton(onClick = dismiss) { Text("Cancelar") } })
}
@Composable
private fun TurnForm(original: Appointment?, clients: List<Client>, dismiss: () -> Unit, save: (Long, String, String, String) -> Unit) {
    var selected by remember(original) { mutableStateOf(original?.clientId ?: clients.firstOrNull()?.id) }
    var date by remember(original) { mutableStateOf(original?.date ?: LocalDate.now().toString()) }
    var time by remember(original) { mutableStateOf(original?.time ?: "09:00") }
    var note by remember(original) { mutableStateOf(original?.note ?: "") }
    var expanded by remember { mutableStateOf(false) }
    val validDate = runCatching { LocalDate.parse(date) }.isSuccess && date.length == 10
    val validTime = runCatching { LocalTime.parse(time) }.isSuccess && time.length == 5
    AlertDialog(onDismissRequest = dismiss, title = { Text("Turno") },
        text = {
            Column(verticalArrangement = Arrangement.spacedBy(10.dp)) {
                if (clients.isEmpty()) Text("Primero registrá un cliente.")
                else {
                    Box {
                        OutlinedButton(onClick = { expanded = true }) { Text(clients.find { it.id == selected }?.name ?: "Elegir cliente") }
                        DropdownMenu(expanded = expanded, onDismissRequest = { expanded = false }) {
                            clients.forEach { client ->
                                DropdownMenuItem(text = { Text(client.name) }, onClick = { selected = client.id; expanded = false })
                            }
                        }
                    }
                    OutlinedTextField(date, { date = it }, label = { Text("Fecha AAAA-MM-DD") }, isError = !validDate)
                    OutlinedTextField(time, { time = it }, label = { Text("Hora HH:MM") }, isError = !validTime)
                    OutlinedTextField(note, { note = it }, label = { Text("Observaciones") })
                }
            }
        },
        confirmButton = { Button(enabled = selected != null && validDate && validTime,
            onClick = { selected?.let { save(it, date, time, note.trim()) } }) { Text("Guardar") } },
        dismissButton = { TextButton(onClick = dismiss) { Text("Cancelar") } })
}
