using System;
using System.Collections.Generic;
using System.Linq;
using Contact_CRUD.Models;

namespace Contact_CRUD.Services;

public class ContactService
{
    private readonly List<Contact> _contacts = [];
    private int _nextId = 1;

    public void AddContact(string name, string phoneNumber)
    {
        var newContact = new Contact
        {
            Id = _nextId++,
            Name = name,
            PhoneNumber = phoneNumber
        };
        _contacts.Add(newContact);
        Console.WriteLine("Contact added successfully");
    }

    public void EditContact(Contact updatedContact)
    {
        var contact = _contacts.FirstOrDefault(c => c.Id == updatedContact.Id);

        if (contact != null)
        {
            contact.Name = updatedContact.Name;
            contact.PhoneNumber = updatedContact.PhoneNumber;
            Console.WriteLine("Contact updated successfully");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    public void RemoveContact(int id)
    {
        var contact = _contacts.FirstOrDefault(c => c.Id == id);

        if (contact != null)
        {
            _contacts.Remove(contact);
            Console.WriteLine("Contact removed successfully");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }

    public void ViewAllContacts()
    {
        if (_contacts.Count == 0)
        {
            Console.WriteLine("No contacts available");
        }
        else
        {
            Console.WriteLine("Contacts:");
            foreach (var contact in _contacts)
            {
                Console.WriteLine($"Id: {contact.Id}, Name: {contact.Name}, Phone number: {contact.PhoneNumber}");
            }
        }
    }
}