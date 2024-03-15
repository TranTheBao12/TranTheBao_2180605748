namespace TranTheBao_2180605748.Models
{
    using System.Collections.Generic;
    using TranTheBao_2180605748.Models;
    public class MockCategoryRepository : ICategoryRepository
    {
        private List<Category> _categoryList;
        public MockCategoryRepository()
        {

            _categoryList = new List<Category>{
                new Category { Id = 1,Name="Laptop"},
                new Category { Id = 2,Name = "Destop"},
            };
        }
        public IEnumerable<Category> GetAllCategories()
            {
                return _categoryList;
            }
        }
    } 

