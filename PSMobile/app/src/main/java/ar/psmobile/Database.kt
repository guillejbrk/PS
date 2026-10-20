package ar.psmobile

import android.content.Context
import androidx.room.*
import kotlinx.coroutines.flow.Flow

@Entity(tableName = "clients")
data class Client(
    @PrimaryKey(autoGenerate = true) val id: Long = 0,
    val name: String,
    val phone: String
)

@Entity(tableName = "appointments", foreignKeys = [ForeignKey(entity = Client::class, parentColumns = ["id"], childColumns = ["clientId"], onDelete = ForeignKey.RESTRICT)], indices = [Index("clientId")])
data class Appointment(
    @PrimaryKey(autoGenerate = true) val id: Long = 0,
    val clientId: Long,
    val date: String,
    val time: String,
    val note: String
)

@Dao
interface ClinicDao {
    @Query("SELECT * FROM clients ORDER BY name COLLATE NOCASE")
    fun clients(): Flow<List<Client>>
    @Insert suspend fun addClient(client: Client)
    @Query("SELECT * FROM appointments ORDER BY date, time")
    fun appointments(): Flow<List<Appointment>>
    @Insert suspend fun addAppointment(appointment: Appointment)
}

@Database(entities = [Client::class, Appointment::class], version = 1, exportSchema = false)
abstract class ClinicDatabase : RoomDatabase() {
    abstract fun dao(): ClinicDao
    companion object {
        @Volatile private var instance: ClinicDatabase? = null
        fun get(context: Context): ClinicDatabase =
            instance ?: synchronized(this) {
                instance ?: Room.databaseBuilder(context.applicationContext, ClinicDatabase::class.java, "ps-mobile.db").build().also { instance = it }
            }
    }
}
