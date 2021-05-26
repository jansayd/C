using aula_linq_com_lambda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace aula_linq_com_lambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> produtocs = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90.00, Category = c1},
                new Product() {Id = 3, Name = "TV", Price = 1700.00, Category = c3},
                new Product() {Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80.00, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700.00, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 700.00, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350.00, Category = c3},
                new Product() {Id = 9, Name = "MacBook", Price = 1800.00, Category = c1},
                new Product() {Id = 10, Name = "Sound Bar", Price = 700.00, Category = c3},
                new Product() {Id = 11, Name = "Level", Price = 70.00, Category = c1}
            };

            var r1 = produtocs.Where(x => x.Price < 900 && x.Category.Tier == 1);
            Print("TIER 1 and PRICE < 900", r1);

            var r2 = produtocs.Where(x => x.Category.Name == "Tools").Select(x => x.Name);
            Print("NAME OF PRODUCTS FROM TOOLS", r2);

            var r3 = produtocs.Where(x => x.Name[0] == 'C').Select(x => new { x.Name, x.Price, CategoryName = x.Category.Name });
            Print("NAMES STARTED WITH C AND ANONYMOUS OBJETCS", r3);

            var r4 = produtocs.Where(x => x.Category.Tier == 1).OrderBy(x => x.Price).ThenBy(x => x.Name);
            Print("TIER 1 ORDER BY PRICE THE BY NAME", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("TIER 1 ORDER BY PRICE THE BY NAME SKIP 2 TAKE 4", r5);

            var r6 = produtocs.FirstOrDefault();
            Console.WriteLine("First or Default: " + r6);

            var r7 = produtocs.Where(x => x.Id == 3).SingleOrDefault();
            Console.WriteLine("Single or Default: " + r7);

            var r8 = produtocs.Max(x => x.Price);
            Console.WriteLine("Max Price: " + r8);

            var r9 = produtocs.Min(x => x.Price);
            Console.WriteLine("Min Price: " + r9);

            var r10 = produtocs.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            Console.WriteLine("Category 1 Sum Price: " + r10);

            var r11 = produtocs.Where(x => x.Category.Id == 1).Average(x => x.Price);
            Console.WriteLine("Category 1 Average Price: " + r11);

            var r12 = produtocs.Where(x => x.Category.Id == 1).Select(x => x.Price).Aggregate((x, y) => x + y);
            Console.WriteLine("Category 1 aggregate Sum: " + r12);

            Console.WriteLine();
            var r13 = produtocs.GroupBy(x => x.Category);
            foreach (IGrouping<Category, Product> group in r13)
            {
                Console.WriteLine("Category: " + group.Key.Name + "");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
