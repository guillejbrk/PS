package ar.psmobile

import androidx.compose.foundation.background
import androidx.compose.foundation.clickable
import androidx.compose.foundation.layout.*
import androidx.compose.foundation.shape.RoundedCornerShape
import androidx.compose.material3.*
import androidx.compose.runtime.*
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import java.time.LocalDate
import java.time.YearMonth
import java.time.format.TextStyle
import java.util.Locale

private val purple = Color(0xFFA78BFA)
private val blue = Color(0xFF60A5FA)
private val panelColor = Color(0xFF18213A)
private val mutedColor = Color(0xFFAAB5D0)
private val spanish = Locale("es", "AR")

@Composable
fun AppointmentCalendar(turns: List<Appointment>, selected: LocalDate, onSelect: (LocalDate) -> Unit) {
    var month by remember { mutableStateOf(YearMonth.from(selected)) }
    val firstOffset = month.atDay(1).dayOfWeek.value - 1
    val countByDay = remember(turns) { turns.groupingBy { it.date }.eachCount() }
    Card(colors = CardDefaults.cardColors(containerColor = panelColor), shape = RoundedCornerShape(20.dp)) {
        Column(Modifier.fillMaxWidth().padding(16.dp), verticalArrangement = Arrangement.spacedBy(12.dp)) {
            Row(verticalAlignment = Alignment.CenterVertically) {
                Text(month.month.getDisplayName(TextStyle.FULL, spanish).replaceFirstChar { it.uppercase() } + " " + month.year,
                    color = Color.White, fontWeight = FontWeight.Bold, fontSize = 18.sp, modifier = Modifier.weight(1f))
                TextButton(onClick = { month = month.minusMonths(1) }) { Text("‹", fontSize = 23.sp) }
                TextButton(onClick = { month = month.plusMonths(1) }) { Text("›", fontSize = 23.sp) }
            }
            Row {
                listOf("L", "M", "M", "J", "V", "S", "D").forEach { label ->
                    Box(Modifier.weight(1f), contentAlignment = Alignment.Center) {
                        Text(label, color = mutedColor, fontSize = 12.sp)
                    }
                }
            }
            val total = firstOffset + month.lengthOfMonth()
            repeat((total + 6) / 7) { week ->
                Row(horizontalArrangement = Arrangement.spacedBy(3.dp)) {
                    repeat(7) { dayOfWeek ->
                        val d = week * 7 + dayOfWeek - firstOffset + 1
                        if (d in 1..month.lengthOfMonth()) {
                            val date = month.atDay(d)
                            val active = selected == date
                            Column(
                                Modifier.weight(1f).height(50.dp)
                                    .background(if (active) Color(0xFF6748B7) else Color.Transparent, RoundedCornerShape(12.dp))
                                    .clickable { onSelect(date) },
                                horizontalAlignment = Alignment.CenterHorizontally,
                                verticalArrangement = Arrangement.Center
                            ) {
                                Text(d.toString(), color = Color.White, fontWeight = if (active) FontWeight.Bold else FontWeight.Normal)
                                if ((countByDay[date.toString()] ?: 0) > 0) Text("•", color = blue, fontSize = 13.sp)
                            }
                        } else Spacer(Modifier.weight(1f).height(50.dp))
                    }
                }
            }
            Text("Punto azul: día con turnos", color = mutedColor, fontSize = 11.sp)
        }
    }
}

@Composable
fun ActivityAnalytics(turns: List<Appointment>) {
    val today = LocalDate.now()
    val monday = today.minusDays((today.dayOfWeek.value - 1).toLong())
    val values = (3 downTo 0).map { offset ->
        val start = monday.minusWeeks(offset.toLong())
        val end = start.plusDays(6)
        val count = turns.count {
            val day = runCatching { LocalDate.parse(it.date) }.getOrNull()
            day != null && !day.isBefore(start) && !day.isAfter(end)
        }
        Pair(start.dayOfMonth.toString() + "/" + start.monthValue, count)
    }
    val maximum = (values.maxOfOrNull { it.second } ?: 0).coerceAtLeast(1)
    Card(colors = CardDefaults.cardColors(containerColor = panelColor), shape = RoundedCornerShape(20.dp)) {
        Column(Modifier.fillMaxWidth().padding(20.dp), verticalArrangement = Arrangement.spacedBy(14.dp)) {
            Text("Actividad · 4 semanas", fontWeight = FontWeight.Bold, color = Color.White, fontSize = 18.sp)
            Text("Turnos registrados por semana", color = mutedColor, fontSize = 12.sp)
            Row(Modifier.fillMaxWidth().height(155.dp), horizontalArrangement = Arrangement.spacedBy(15.dp),
                verticalAlignment = Alignment.Bottom) {
                values.forEach { (label, count) ->
                    Column(Modifier.weight(1f), horizontalAlignment = Alignment.CenterHorizontally,
                        verticalArrangement = Arrangement.Bottom) {
                        Text(count.toString(), color = Color.White, fontSize = 13.sp)
                        Spacer(Modifier.height(6.dp))
                        Box(Modifier.fillMaxWidth(0.65f).height((12f + count.toFloat() / maximum * 96f).dp)
                            .background(if (count == 0) Color(0xFF354263) else purple, RoundedCornerShape(topStart = 9.dp, topEnd = 9.dp)))
                        Spacer(Modifier.height(7.dp))
                        Text(label, color = mutedColor, fontSize = 11.sp)
                    }
                }
            }
        }
    }
}
