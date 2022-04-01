# EsolMediaMarkt
Prueba web api 5.0 + Reaccionar

Este repositorio está hecho para prueba asignada.

                      Cómo funciona el proyecto:
El proyecto está realizado con SQL Server, Microsoft .Net 5 C# y React.JS con Typescript.

Se creó una base de datos llamado 'MediaMarkt', posteriormente se creó una tabla llamada 'Producto' con los campos 'Nombre', 'Descripcion', 'Precio', 'Familia_Producto'.

En la aplicación webApi con .Net 5 C#, se crearon los métodos 'GET' y 'POST' para la manipulación del modelo en la base de datos.

En la aplicación con ReactJS, se utilizaron componentes 'PrimeReact' para las pantallas. Se usó 'Hooks' de la versión 16.8. 

La aplicación React tiene dos vistas o pantalla. El primero es listar los productos y buscar uno, donde la aplicación .Net 5 (con el método 'GET'), llama a los datos en SQL Server y luego los muestra con react.js. Y el segundo (un Modal) es agregar un producto en la base de datos, donde el usuario proporciona información en un formulario, y luego, se introduce en la base de datos con la aplicación .NET 5 (con el método 'POST').

Se puede ver la información del producto al dar clic a una fila de los elementos que salen en la lista. En la parte superior puede ver el estado de los botones cuando se hace clic en ellos (Muestra cuantos clics a los botónes se han realizado). Se creó un búscador en la parte superior derecho de la lista, el cuál, realiza una búsqueda en las columnas 'Nombre' y 'Descripción' y muestra aquellos elementos que coinciden.

                  Cómo ejecutar el proyecto .Net 5:
1- Descargue o clone el proyecto a Visual Studio.
2- Ejecutar el proyecto, le mostrará a Swagger los servicios creados en webApi. 

                  Cómo ejecutar el proyecto React.js:
1- Ejecutar proyecto de .Net5.                  
2- Descargue o clone el proyecto a Visual Studio Code.
3- Instalar paquete npm.
4- Instalar paquete de componentes 'PrimeReact'.
5- Ejecutar en consola de Visual Studio Code 'npm start' para iniciar el proyecto.
