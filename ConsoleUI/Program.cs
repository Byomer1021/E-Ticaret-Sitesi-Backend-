﻿// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//Data Transformation Object
//SOLID
//Open Closed Principle mevcut koda dokunmadan yeni bir özellik eklemek
ProductTest();
//CategoryTest();

static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

    var result = productManager.GetProductDetails();

    if(result.Success==true )
    {
        foreach (var product in result.Data )
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }else
    { Console.WriteLine(result.Message); }

   
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}