
using DecorStudio;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product
        {
            Name = "Proizvod 1",
            Description = "Opis 1",
            Price = 600,
            Available = true
        };

        Product product2 = new Product
        {
            Name = "Proizvod 2",
            Description = "Opis 2",
            Price = 100,
            Available = false
        };

        Product product3 = new Product
         {
            Name = "Proizvod 3",
            Description = "Opis 3",
            Price = 200,
            Available = true
        };

        //klonovi klase Product
        Product product1Clone = product1.Clone() as Product;
        Product product2Clone = product2.Clone() as Product;
        Product product3Clone = product3.Clone() as Product;

        Supplier supplier1 = new Supplier
        {
            Name = "Dobavljac 1",
            Address = "Adresa 1",
            Products = new List<Product>
            {
                product1Clone,
                product2Clone
            }
        };

        Supplier supplier2 = new Supplier
        {
            Name = "Dobavljac 2",
            Address = "Adresa 2",
            Products = new List<Product>
            {
                product3Clone
            }
        };

        Warehouse warehouse1 = new Warehouse
        {
            Name = "Skladiste 1",
            Address = "Adresa 1",
            Size = 32,
            Products = new List<Product>
            {
                product1Clone,
                product2Clone,
                product3Clone 
            }
        };

        Warehouse warehouse2 = new Warehouse
        {
            Name = "Skladiste 2",
            Address = "Adresa 2",
            Size = 64,
            Products = new List<Product>
            {
                product1Clone
            }
        };

        //klonovi klase Warehouse
        Warehouse warehouse1Clone = warehouse1.Clone() as Warehouse;
        Warehouse warehouse2Clone = warehouse2.Clone() as Warehouse;

        //klonovi klase Supplier
        Supplier supplier1Clone = supplier1.Clone() as Supplier;
        Supplier supplier2Clone = supplier2.Clone() as Supplier;

        Store store = new Store
        {
            Name = "Radnja 1",
            Address = "Adresa 1",
            Size = 32,
            NumberOfEmployees = 143,
            Suppliers = new List<Supplier>
            { 
                supplier1Clone,
                supplier2Clone
            },
            Warehouses = new List<Warehouse>
            {
                warehouse1Clone,
                warehouse2Clone
            }
        };

        Store storeClone = store.Clone() as Store;
        storeClone.StoreInformation();

        Console.ReadLine();
    }

}
