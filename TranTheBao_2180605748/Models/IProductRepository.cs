﻿namespace TranTheBao_2180605748.Models
{
    using System.Collections.Generic;
    using TranTheBao_2180605748.Models;
    public interface IProductRepository
    {
       IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
    }
}
