# q-hard

<h2>Tutorial para setear el backend en sus compus</h2>

- Tener Visual Studio 2022 actualizado y sql server encendido y todo
- Abren el proyecto, seleccionan src en el explorador y le dan build, luego en la barra de arriba de visual se van a Tools > Nuget Package Manager > Packet Manager Console
- En la consola ponen el comando "Update-Database" obvio sin comillas y le dan enter y les debería funcar y generar la base de datos (revisan con sql management studio)
- Si da algún error ejecuten el comando "Add-Migration Initial" y luego vuelven a ejecutar el comando anterior (Update-Database) aunque no debería ser necesario porque la migración que yo hice en mi compu se metió con el commit

<h2>Como ponerle a los commits</h2>

```bash
<type>(<scope>): <subject>
```

<h3>Tipos:</h3>

- build : Cambios relacionados con la construcción del código (por ejemplo, agregar dependencias npm o bibliotecas externas).
- chore: Cambios que no afectan al usuario externo (por ejemplo, actualizar el archivo .gitignore o el archivo .prettierrc).
- feat: Una nueva característica.
- fix: Una corrección de errores.
- docs: Cambios relacionados a la documentación.
- refactor: Código que no corrige errores ni agrega una característica. (por ejemplo: pueden usar esto cuando hayan cambios semánticos, como cambiar el nombre de una variable/función).
- perf: Código que mejora el rendimiento
- style: Código relacionado al estilo y diseño.
- test: Agregar un test o realizar cambios en un test existente

fuentes/más info:

<https://www.conventionalcommits.org/en/v1.0.0/>

<https://medium.com/@naandalist/creating-a-git-commit-message-convention-for-your-team-acb4b3edfc44>

los tqm

![IMG_3546 (1)](https://github.com/alfres2503/q-hard/assets/90797014/68d5e8ce-b93b-405e-9934-10cd4747cda2)
