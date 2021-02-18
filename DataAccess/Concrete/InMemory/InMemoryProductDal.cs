﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        private List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
           {
               new Product{CategoryId = 1,ProductId =1,ProductName = "Bardak", UnitInStok = 15, UnitPrice = 15},
               new Product{CategoryId = 1,ProductId =2,ProductName = "Kamera", UnitInStok = 3, UnitPrice = 500},
               new Product{CategoryId = 2,ProductId =3,ProductName = "Telefon", UnitInStok = 2, UnitPrice = 1500},
               new Product{CategoryId = 2,ProductId =4,ProductName = "Klavye", UnitInStok = 65, UnitPrice = 150},
               new Product{CategoryId = 2,ProductId =5,ProductName = "Fare", UnitInStok = 1, UnitPrice = 85}
           };
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            Product productToDelete = null;

            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);


        }
    }
}