# BookStoreAPI
## Bookstore | Using ASP.NET Core 5.0 and MongoDB

### Welcome to the Bookstore project! This is a web application designed to manage and display a collection of books. The project is built using ASP.NET Core and MongoDB, and it provides a RESTful API for performing CRUD (Create, Read, Update, Delete) operations on books.


## Features
The Bookstore project, located in the Bookstore.Core namespace, offers the following features:

Get Books: Retrieve a list of all books.

Get Book by ID: Retrieve a specific book by its unique identifier.

Add Book: Add a new book to the collection.

Update Book: Update the details of an existing book.

Delete Book: Remove a book from the collection.

## Getting Started
To run this project locally or deploy it to a server, follow these steps:

## Clone the Repository:
bash
Copy code
git clone https://github.com/yourusername/bookstore.git
Configure MongoDB:

Ensure you have a MongoDB instance set up. You may need to modify the connection string in the appsettings.json file to match your MongoDB server's configuration.

json
Copy code
{
  "BookstoreDbConfig": {
    "Connection_String": "mongodb://localhost:27017", // Update this
    "Database_Name": "BookstoreDB" // Update this
  }
}
Build and Run:

Build and run the project using your preferred IDE or by using the command line.

## Access the API:

Once the project is running, you can access the API using a tool like Postman or by making HTTP requests from your application.

API Endpoints
The API endpoints for managing books are exposed via the BooksController:

GET /Books: Get a list of all books.
GET /Books/{id}: Get a specific book by its ID.
POST /Books: Add a new book to the collection.
PUT /Books: Update the details of an existing book.
DELETE /Books/{id}: Delete a book from the collection.
Dependencies
ASP.NET Core - The web framework used.
MongoDB - The NoSQL database used for data storage.
Microsoft.Extensions.Options - For configuration.


# Screen Shots:

![image](https://github.com/ibrahimkedir10/BookStoreAPIGIT/assets/93158833/76d6d50c-8dd6-469f-9f2e-562721e50577)
![image](https://github.com/ibrahimkedir10/BookStoreAPIGIT/assets/93158833/9fa6264e-be1f-4c6c-bb1e-2464763f7215)

