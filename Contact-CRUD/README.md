# Contact APP

Contact App is a simple console application for managing a phone book using CRUD (Create, Read, Update, Delete) operations. This application is written in C# and demonstrates basic functionality for adding, editing, removing, and viewing contacts.

## Features

- Add a new contact with a unique ID, name, and phone number.
- Edit an existing contact's name and phone number.
- Remove a contact by ID.
- View all contacts in the phone book.

## Project Structure

The project is structured as follows:

- **Models/Contact.cs**: Defines the `Contact` class with properties for `Id`, `Name`, and `PhoneNumber`.
- **Services/ContactService.cs**: Contains the business logic for managing the phone book, including methods for adding, editing, removing, and viewing contacts.
- **Program.cs**: The main entry point of the application, handling user interaction and delegating operations to the `PhoneBookService`.

## Getting Started

### Prerequisites

- .NET SDK 6.0 or later
- A code editor (e.g., Rider)

### Installation

1. Clone the repository:

    ```sh
    https://github.com/dotnet-run-developer/Contact-CRUD
    cd Contact-CRUD
    ```

2. Restore dependencies (if any):

    ```sh
    dotnet restore
    ```

### Usage

1. Run the application:

    ```sh
    dotnet run
    ```

2. Follow the on-screen prompts to add, edit, remove, or view contacts.

### Example

Contact App

1. Add Contact
2. Edit Contact
3. Remove Contact
4. View All Contacts
5. Exit

###### Select an option: 1
Enter name: John Doe,
Enter phone number: 123-456-7890,
Contact added successfully.