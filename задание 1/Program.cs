using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id;
    public string Name;
    public decimal Price;
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("--- Управление инвентарем ---");

        var items = new List<Product>();
        items.Add(new Product { Id = 1, Name = "Молоко", Price = 80.50m });
        items.Add(new Product { Id = 2, Name = "Хлеб", Price = 40.00m });
        items.Add(new Product { Id = 3, Name = "Сыр", Price = 450.99m });

        Console.WriteLine("Добавлен товар: " + items[0].Name);
        Console.WriteLine("Добавлен товар: " + items[1].Name);
        Console.WriteLine("Добавлен товар: " + items[2].Name);

        Console.WriteLine();

        Console.WriteLine("--- Поиск товара с ID 2 ---");
        Product found = items.FirstOrDefault(x => x.Id == 2);

        if (found != null)
        {
            Console.WriteLine("Найден товар: " + found.Name);
        }
        else
        {
            Console.WriteLine("Товар с ID 2 не найден.");
        }

        Console.WriteLine();

        Console.WriteLine("--- Поиск товара с ID 99 ---");
        Product notFound = items.FirstOrDefault(x => x.Id == 99);

        if (notFound != null)
        {
            Console.WriteLine("Найден товар: " + notFound.Name);
        }
        else
        {
            Console.WriteLine("Товар с ID 99 не найден.");
        }
    }
}