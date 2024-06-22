using System;
using Contact_CRUD.Models;
using Contact_CRUD.Services;

namespace Contact_CRUD;
internal abstract class Program
{
    private static void Main()
    {
        var contactService = new ContactService();

        while (true)
        {
            Console.WriteLine("Welcome to contact app");
            Console.WriteLine("Press 1 to add new Contact");
            Console.WriteLine("Press 2 to edit Contact");
            Console.WriteLine("Press 3 to remove Contact");
            Console.WriteLine("Press 4 to view all Contacts");
            Console.WriteLine("Press 5 to exit");
            Console.Write("Select an option: ");
            
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact(contactService);
                    break;
                case "2":
                    EditContact(contactService);
                    break;
                case "3":
                    RemoveContact(contactService);
                    break;
                case "4":
                    ViewAllContacts(contactService);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }

    private static void AddContact(ContactService contactService)
    {
        Console.Write("Enter name: ");
        var name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        var phoneNumber = Console.ReadLine();
        
        contactService.AddContact(name, phoneNumber);
    }

    private static void EditContact(ContactService contactService)
    {
        Console.Write("Enter the ID of the contact to edit: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {   
            var contact = new Contact{Id = id};
            
            Console.Write("Enter new name (leave blank to keep current): ");
            var newName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newName))
            {
                contact.Name = newName;
            }
            
            Console.Write("Enter new phone number (leave blank to keep current): ");
            var newPhoneNumber = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newPhoneNumber))
            {
                contact.PhoneNumber = newPhoneNumber;
            }
            
            contactService.EditContact(contact);
        }
        else
        {
            Console.WriteLine("Invalid Id.");
        }
    }

    private static void RemoveContact(ContactService contactService)
    {
        Console.Write("Enter the Id of the contact to remove: ");

        if (int.TryParse(Console.ReadLine(), out int id))
        {
            contactService.RemoveContact(id);
        }
        else
        {
            Console.WriteLine("Invalid Id.");
        }
    }

    private static void ViewAllContacts(ContactService contactService)
    {
        contactService.ViewAllContacts();
    }
}

