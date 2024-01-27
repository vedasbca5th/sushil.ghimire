using System;
using System.Collections.Generic;

// Generic Container class to hold items of any type
class Container<T>
{
    private List<T> items;

    public Container()
    {
        items = new List<T>();
    }

    public void AddItem(T item)
    {
        items.Add(item);
    }

    public void DisplayItems()
    {
        Console.WriteLine("Container Items:");
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// Example: Creating a hierarchy of classes for different types of items

// Base class representing an item
class Item
{
    public string Name { get; set; }

    public Item(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Item: {Name}";
    }
}

// Derived class representing a Book item
class Book : Item
{
    public string Author { get; set; }

    public Book(string name, string author)
        : base(name)
    {
        Author = author;
    }

    public override string ToString()
    {
        return $"Book: {Name} by {Author}";
    }
}

// Derived class representing a ElectronicDevice item
class ElectronicDevice : Item
{
    public string Manufacturer { get; set; }

    public ElectronicDevice(string name, string manufacturer)
        : base(name)
    {
        Manufacturer = manufacturer;
    }

    public override string ToString()
    {
        return $"Electronic Device: {Name} (Manufacturer: {Manufacturer})";
    }
}

class Program
{
    static void Main543()
    {
        // Creating a generic Container for items
        Container<Item> itemContainer = new Container<Item>();

        // Adding different types of items to the container
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        ElectronicDevice device1 = new ElectronicDevice("Smartphone", "Samsung");
        ElectronicDevice device2 = new ElectronicDevice("Laptop", "Dell");

        itemContainer.AddItem(book1);
        itemContainer.AddItem(book2);
        itemContainer.AddItem(device1);
        itemContainer.AddItem(device2);

        // Displaying items in the container
        itemContainer.DisplayItems();
    }
}
