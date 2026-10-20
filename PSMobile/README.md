# PS Mobile — Android (offline)

Aplicación nativa de administración de consultorio de masajes. Proyecto **nuevo e independiente** del código Windows en `App1/`.

## MVP
- Kotlin + Jetpack Compose + Material 3
- Room/SQLite local, sin conexión a Internet
- Alta y listado de clientes
- Alta y listado de turnos
- Historial de atención: siguiente etapa
- Sin permisos de red, sin servidores, sin sincronización

## Seguridad
Información personal y potencialmente sanitaria: el prototipo no debe usarse con pacientes reales hasta implementar cifrado en reposo, bloqueo de aplicación, exportación segura y política de copias de seguridad. `allowBackup=false` evita copias automáticas en la nube. No migrar las credenciales SQL Server del sistema Windows.

## Compilación
GitHub Actions → *PS Mobile APK* → `app-debug.apk` (artefacto). El APK debug es solamente para pruebas. No hay firma de distribución permanente.

## Próximos pasos
- Verificar CI y funcionamiento en Android
- Formularios con validación y edición; calendario
- Ficha clínica y evolución de sesiones
- Control de acceso, cifrado de base local, exportación/importación cifrada
- Evaluar importación de datos existentes de SQL Server desde un archivo de migración **sin credenciales**
