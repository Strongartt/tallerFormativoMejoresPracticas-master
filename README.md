# Taller Formativo: Mejores Prácticas de Diseño de Software

Este proyecto corresponde al desarrollo práctico de un taller donde se aplicaron patrones de diseño para resolver requerimientos funcionales en una aplicación de gestión de automóviles. Se trabajó a partir de una base incompleta, y se implementaron soluciones siguiendo buenas prácticas de programación orientada a objetos.




## Comenzando 🚀

Estas instrucciones te permitirán obtener una copia del proyecto funcional en tu máquina local para propósitos de desarrollo o análisis de patrones de diseño aplicados.




## Pre-requisitos 📋

- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022](https://visualstudio.microsoft.com/es/) con soporte para ASP.NET Core MVC

Ejemplo:

```bash
dotnet --version
# Debe retornar 6.x.x
```

Instalación 🔧
Clona el repositorio:

```
git clone https://github.com/Strongartt/tallerFormativoMejoresPracticas-master.git
cd tallerFormativoMejoresPracticas-master/DesignPatterns
```
Restaura las dependencias:

```
dotnet restore
```
Ejecuta el proyecto:

```
dotnet run
```
Abre el navegador en:

```
https://localhost:5001
```
## Resolución del Taller 🧩
A continuación se detallan los patrones de diseño utilizados y cómo resolvieron los requerimientos del taller:


### 🏭 Patrón Fábrica (Factory)
Se implementó el patrón Fábrica para encapsular la lógica de creación de vehículos específicos:

FordMustangFactory

FordExplorerFactory

FordEscapeFactory

Cada una de estas clases hereda de una clase base CarFactory, y se encargan de construir vehículos preconfigurados sin exponer la lógica de creación directamente al controlador.

Esto permitió cumplir con el requerimiento de agregar vehículos (Mustang y Explorer) de forma limpia, reutilizable y extensible.

### 📦 Patrón Repositorio
Se implementó el patrón Repositorio para separar la lógica de acceso a datos del resto de la aplicación:

IVehicleRepository: define la interfaz común para el almacenamiento de vehículos.

MyVehiclesRepository: implementación concreta utilizada para almacenar vehículos en memoria.

Este patrón facilitó una arquitectura desacoplada, manteniendo la lógica de almacenamiento aislada y reemplazable.

## 🎯 Resultado Final
Desde la vista principal, el usuario puede agregar vehículos específicos (Mustang, Explorer).

El controlador (HomeController.cs) se comunica con una fábrica correspondiente para crear el vehículo.

Una vez creado, el vehículo es guardado mediante la interfaz IVehicleRepository.

Esta solución cumple de forma estructurada con los requerimientos del taller, aplicando dos patrones fundamentales para garantizar un diseño limpio, escalable y fácil de mantener.


## Construido con 🛠️
ASP.NET Core MVC – Framework principal del proyecto.

Patrón Fábrica (Factory) – Para encapsular la creación de vehículos.

Patrón Repositorio – Para separar la lógica de almacenamiento.

Visual Studio 2022 – Entorno de desarrollo utilizado.

## Autor
Desarrollado por Ricardo Perez
Repositorio: https://github.com/Strongartt/tallerFormativoMejoresPracticas-master
