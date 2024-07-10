# AppLogger

`AppLogger` es una biblioteca .NET para gestionar dependencias directas e indirectas entre elementos. Este paquete es útil cuando se necesita calcular las dependencias transitivas de un conjunto de elementos.

## Características

- Agregar dependencias directas entre elementos.
- Calcular y obtener todas las dependencias transitivas para un elemento dado.

## Instalación

Puedes instalar el paquete `AppLogger` desde NuGet Package Manager en Visual Studio o usando el comando de la consola de NuGet:

 ```
dotnet add package AppLogger

```
# API
AddDirect(string item, List<string> dependencies)
Agrega dependencias directas para un elemento.

item: El elemento principal.
dependencies: Una lista de elementos de los que item depende directamente.
List<string> DependenciesFor(string item)
Obtiene todas las dependencias transitivas para un elemento.

item: El elemento para el cual se desean obtener las dependencias.
Devuelve una lista de todas las dependencias directas e indirectas de item.

# Contribuir
Si deseas contribuir a este proyecto, por favor sigue los siguientes pasos:

Haz un fork del repositorio.
Crea una nueva rama (git checkout -b feature/nueva-característica).
Realiza tus cambios y haz commit (git commit -am 'Agrega nueva característica').
Sube tu rama (git push origin feature/nueva-característica).
Crea un nuevo Pull Request.

# Licencia
Este proyecto está licenciado bajo la Licencia MIT. Consulta el archivo LICENSE para más detalles.
