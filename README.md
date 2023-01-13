# DoubleVPartnersWeb

This project was generated with .Net Core version 3.1.

## Development server

Run `dotnet run` for a dev server. will automatically raise a new browser with the path https://localhost:44306/api/tickets.

## Configuración de cadena de conexión 

Go to the file located at the root of the project named *appsettings.json*. There modify the *ConexionDB* tag with your database credentials. The tag will look like this:

     "ConnectionStrings": {
    "ConexionDB": "Server=<YOUR_SERVER>S;Database=DoubleVPartnersDB;User ID=YOUR_USER;Password=YOUR_PASSWORD;Trusted_Connection=True;MultipleActiveResultSets=true"
  }

## Creacion de base de datos: 

Si esta con el editor Visual Studio, diríjase a la opción  *Tools => NuGet Package Manager => NuGet Package Manager console* . Esto le abrirá una consola que le permitira migrar la base de datos con los siguientes comandos: 
> Creacion de query para base de datos 

    add-migration <NAME_MIGRATION>
> Ejecución de query en motor de base de datos local 

    update-database
