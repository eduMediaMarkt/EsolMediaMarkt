# EsolMediaMarkt
Prueba web api 5.0 + React

This repository is made for test, to join the Media Markt team.

                      How the project works:
The project is made with SQL Server, Microsoft .Net 5 C# and React.JS with Typescript.

Made a table called 'Product' with the fields 'Nombre', 'Descripcion', 'Precio', 'Familia_Producto'.

In application with .Net 5 C#, made method 'GET' and 'POST' for the manipulation of model in database.

In application with ReactJS and Typescript, used components 'PrimeReact' for the screens. Used 'Hooks' of the version 16.8. And, 'Redux' for to save general states of the application. In 'Redux' we will have saved the state the loading of the application and products list that we get when searching.

React application have two views or screen. The first is to list and to search a product, where application .Net 5 (with method 'GET'), call datas in SQL Server and then show with react.js. And the second is to add a product in database, where the user provides information in the form of React.js application, and then, is introduced in database with .NET 5 application (with method 'POST').

                  How to execute project:
Execute the application in .Net 5.

Execute the application in React.js.
