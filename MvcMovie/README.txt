2024-05-16 
Vandan Ashok Patel

Part 1

1331 UDT
Web application created with VS2022 .Net 7
Checked on https://localhost:7005/

Changed name from "Welcome" to "MVC Movie" in Index.cshtml file in views folder.
Successfully changed name

Part 2

Add a Controller

Created controller "HelloWorldController.cs" in Controller Folder (2 controllers).
   - in controller I have  created "Index" and "Welcome" string or page
   - I had faced error, but solved it.
   - Successfully created pages "HelloWorld" and "Welcome" page.

Created img to add on home page and given path accurately with any error.
-- add under wwwroot folder created img folder.
Successfully add image
Checked on https://localhost:7005/

Part 3

2024-05-23
1432 UDT

Add a view

I have created in view folder index.cshtml file and, build index and welcome file
I was able to create and able to access successfully on web browser
Checked on https://localhost:7005/HelloWorld/Welcome?name=Vandan&numtimes=4

After that, 
I have create privacy file under home to set policy.
checked on https://localhost:7005/Home/Privacy

Part 4

Add a Model

I have add from tool add migration folder and added some model so that I can create movie list on web page.
checked on https://localhost:7005/Movies/Create

Part 5

I have added movies and created list for all
checked on https://localhost:7005/Movies

This is migration timestamp:

20240523184542_InitialCreate

Part 6 
I have added data in this part in my file such as controller, movies and many folders

Part 7
2024-05-30
1305 UDT


In these part i updated the index method inside MoviesController.cs
The var movies in _context.Movie creates the LINQ query.
I navigated inside index file and appended the query string.
I changed all parameter to ID and changes all the occurences of searchstring.
I updated those commands for that.


Now I run the program to pass the search title as route instead of query string value.
Now in Index.cshtml I added form markup that contains movie name, index and searchstring.
And then added the HttpPost index method in it. After adding that method i checked by running it in browser whether these method runs or not.
As the search parameter is in the request body so I cannot capture the search information.
I added the command to add search by genre.
Again i updated the Index.cshtml file for adding search by genre to index view.
I examined by running it and yes it works.
https://localhost:7021/Movies/Edit/1
https://localhost:7021/Movies

Part 8

2024-05-30
1425 UDT

In these part I updated the movie.cs file with given code.
After that, I added Rating action method.


Again i edited the Index.cshtml file with rating field.
Also updated the rating command in create.cshtml file from view and movies folder.
I updated the command inside seeddata file having Rating class that provides value for new column.
From tools menu I used NuGet Package Manager and then Package Manager Console.
In the powershell package manager I added migration rating and then updated those database.
https://localhost:7021/Movies

If to create or add new movies so use this
https://localhost:7021/Movies/Create

This is Rating.cs
20240530171440_Rating

Part 8

2024-05-30
1445 UDT

I have created Rating in this part, and the page is here
https://localhost:7021/Movies/Edit/1

Time - 30
Total Time - 3 hours


2024-05-30
1508
Created GitHub id
Recovered from GitHub