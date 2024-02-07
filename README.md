# q-hard

<h2>Tutorial para setear el backend en sus compus</h2>

- Tener Visual Studio 2022 actualizado y sql server encendido y todo
- Abren el proyecto y en la barra de arriba de visual se van a Tools > Nuget Package Manager > Packet Manager Console
- En la consola ponen el comando "Update-Database" obvio sin comillas y le dan enter y les debería funcar y generar la base de datos (revisan con sql management studio)
- Si da algún error ejecuten el comando "Add-Migration Initial" y luego vuelven a ejecutar el comando anterior (Update-Database) aunque no debería ser necesario porque la migración que yo hice en mi compu se metió con el commit

los tqm

![IMG_3546 (1)](https://github.com/alfres2503/q-hard/assets/90797014/68d5e8ce-b93b-405e-9934-10cd4747cda2)
