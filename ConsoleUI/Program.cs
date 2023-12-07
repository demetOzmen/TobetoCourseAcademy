using Business.Concretes;
using TobetoETrade.Concretes;

Product product1 = new Product();
product1.Id= 1;
product1.Name = "Kalem";
product1.UnitPrice = 10;

ProductManager productManager = new ProductManager();
productManager.Add(product1);