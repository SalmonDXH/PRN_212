// See https://aka.ms/new-console-template for more information


using OOP4_Dictionary;

Category Laptop = new Category();
Laptop.Id = 1;
Laptop.Name = "Danh Mục Laptop";

Product dell = new Product()
{
    Id = 1,
    Name = "Dell",
    Quantity = 100,
    Price = 100000
};

Product dell2 = new Product()
{
    Id = 2,
    Name = "Dell2",
    Quantity = 1,
    Price = 2000
};

Product hp = new Product()
{
    Id = 3,
    Name = "hp",
    Quantity = 1,
    Price = 40230
};

Laptop.AddProduct(dell);
Laptop.AddProduct(dell2);
Laptop.AddProduct(hp);

Console.WriteLine("Danh sach san pham");
Laptop.PrintAllProducts();

Console.WriteLine("Nhap ma san pham:");
int pid = int.Parse(Console.ReadLine());
Product p = Laptop.GetProduct(pid);
if (p == null){
    Console.WriteLine("Ko tim thay san pham");
} else
{
    Console.WriteLine("Tim thay san pham:");
    Console.WriteLine(p.ToString());
}



Product newp = new Product();

newp.Id = 4;

Console.ReadLine(); 

