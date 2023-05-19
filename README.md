# ProjectOrigin
Hola soy Ezequiel Vera estoy estudiando ingenieria en sistemas y ya voy a tener un año de experiencia como desarrollador Backend con .Net

Me gustaria seguir en este proceso de seleccion y poder tener la siguiente entrevista para poder conocer mas de la empresa y hablar de este proyecto que hice
Desde ya muchas gracias y saludos

>Para poder correr el *Backend* se va a necesitar :
* tener instalado la version .NetCore 5
https://dotnet.microsoft.com/es-es/download/dotnet/5.0 <- Desde esa pagina se podra instalarlo en caso de no tenerlo
-  Como tambien una version de visual studio -> https://visualstudio.microsoft.com/es/downloads/
- Una vez instalado ambos abrir el archivo ProjectOrigin.sln
- En la consola de Visual studio utilizar el comando ->  dotnet restore
- Y luego el comando dotnet build
- En este momento ya deberia tener instalados los diferentes packages que use en el proyecto de no se asi descargar manualmente desde la consola de nuget package

Los packages usado son:
    * Automapper version 5.2
    * Microsoft.EntityFrameworkCore version 5.0
    * Microsoft.EntityFrameworkCore.Design version 5.0
    * Microsoft.EntityFrameworkCore.SqlServer version 5.0
    * Microsoft.EntityFrameworkCore.Tools version 5.0
    * Swashbuckle.AspNetCore version 5.6.3

- Utilizar los dos siguientes comandos para crear una base de datos
    * Add-Migration "ELEGIRUNNOMBRE"
    * Update-Database

Esto va a crear 4 tablas cuenta, registros y tarjetas.
Como tambien un historial de migraciones llamado "EFMigrationsHistory"

- Luego para poblar la base de datos cree unos metodos auxiliares que se pueden correr en swagger 
InsertUsuario te permite poblar cuenta y tarjeta con un registros relacionado para cada una
Y GetUsuarios te trae todo los usuarios disponibles

>Para poder correr el *Frontend* se va a necesitar seguir ciertos pasos
* Tener instalado node.js, en caso de no tenerlo entrar a  -> https://nodejs.org/en
* Instalar angular CLI utilizando el comando -> npm install -g @angular/cli
* Instalar dependencias utilizando el comando -> npm install
* Y por ultimo correr el proyecto utilizando el comando  -> ng serve


Todos estos pasos mencionado es teniendo en cuenta que ya se clono bien el proyecto desde el repositorio ( https://github.com/Illamani/ProjectOrigin )
De no ser asi con " https://github.com/Illamani/ProjectOrigin.git " esa direccion abrir visual studio nuevo y en la seccion donde dice clonar repositorio insertar esa direccion y esperar