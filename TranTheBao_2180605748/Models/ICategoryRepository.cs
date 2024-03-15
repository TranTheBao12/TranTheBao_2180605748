namespace TranTheBao_2180605748.Models
{
    using System.Collections.Generic;
    using TranTheBao_2180605748.Models;
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
