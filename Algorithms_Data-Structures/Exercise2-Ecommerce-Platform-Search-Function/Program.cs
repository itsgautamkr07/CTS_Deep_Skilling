using System;

class Program
{
    static void Main()
    {
        string[] products = { "Laptop", "Phone", "Tablet", "Watch" };
        string searchItem = "Phone";

        int index = Array.IndexOf(products, searchItem);

        if (index != -1)
            Console.WriteLine(searchItem + " found at position " + index);
        else
            Console.WriteLine("Product not found");
    }
}
