using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecorStudio
{
    public class Store : IPrototype
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Size { get; set; }
        public int NumberOfEmployees { get; set; }
        public List<Warehouse> Warehouses { get; set; }
        public List<Supplier> Suppliers { get; set; }

      
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }

        public void StoreInformation()
        {
            Console.WriteLine($"Naziv Radnje: {Name}");
            Console.WriteLine($"Adresa: {Address}");
            Console.WriteLine($"Velicina: {Size} m2");
            Console.WriteLine($"Broj zaposlenih: {NumberOfEmployees}");
            Console.WriteLine("---------------------------------------------------");
            if (Suppliers.Count > 0)
            {
                Console.WriteLine($"Radnju '{Name}' snabdeva ${Suppliers.Count} snabdevaca i to su:");
                foreach ( var item in Suppliers )
                {
                    Console.WriteLine($"Naziv: {item.Name}");
                    Console.WriteLine($"Adresa: {item.Address}");
                    Console.WriteLine($"Broj prizvoda u koje nudi: {item.Products.Count}");
                    Console.WriteLine("---------------------------------------------------");
                    foreach (var p in item.Products)
                    {
                        Console.WriteLine($"Naziv proizvoda: {p.Name}");
                        Console.WriteLine($"Opis proizvoda: {p.Description}");
                        Console.WriteLine($"Cena proizvoda: {p.Price}");
                        Console.WriteLine($"Dostupnost proizvoda: {p.Available}");
                        Console.WriteLine("------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Radnju '{Name}' ne snabdeva nijedan snabdevac");
            }
            if (Warehouses.Count > 0)
            {
                Console.WriteLine($"Radnja '{Name}' ima magacine i to su:");
                foreach( var item in Warehouses )
                {
                    Console.WriteLine($"Naziv: {item.Name}");
                    Console.WriteLine($"Adresa: {item.Address}");
                    Console.WriteLine($"Velicina: {item.Size}");
                    Console.WriteLine($"Broj prizvoda u magacinu: {item.Products.Count}");
                    Console.WriteLine("---------------------------------------------------");
                    foreach (var p in item.Products)
                    {
                        Console.WriteLine($"Naziv proizvoda: {p.Name}");
                        Console.WriteLine($"Opis proizvoda: {p.Description}");
                        Console.WriteLine($"Cena proizvoda: {p.Price}");
                        Console.WriteLine($"Dostupnost proizvoda: {p.Available}");
                        Console.WriteLine("------------------------------------");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Radnja '{Name}' nema nijedan magacin");
            }
        }

    }
}
