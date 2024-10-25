﻿// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


//SOLID
//Open Closed Principle mevcut koda dokunmadan yeni bir özellik eklemek
//ProductTest();
CategoryManager categoryManager=new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetByUnitPrice(40, 100))
    {
        Console.WriteLine(product.ProductName);
    }
}
