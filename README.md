# VehiclesApi-dotnet
## Dev
1. Ejecutar(En el manejador de SqlServer) el scriptDatabase.sql, que contiene create Database.
2. En el archivo appsettings.json cambia las credenciales de conexión.
3.Ejecutar los siguientes comandos de dotnet en la terminal, debe estar posicionado en  la ruta del proyecto: 

```$ dotnet ef migrations add initial ```

 ```$ dotnet ef database update ```
