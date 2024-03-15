using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TranTheBao_2180605748.Models
{
    public class Product
    {
        [Required]
        [DisplayName("mã sách")]
            public int Id { get; set; }
        [Required, StringLength(100)]
        [DisplayName("Tên sách")]
        public string Name { get; set; }
        [Range(0.01, 10000.00)]
        [Required]
        [DisplayName("giá sách")]
        public decimal Price { get; set; }
        [Required]
        [DisplayName("Mô tả")]
        public string Description { get; set; }
        [DisplayName("loại sách")]
        public int CategoryId { get; set; }
        public string? ImageUrl { get; set; } 
        public List<string>? ImageUrls { get; set; }
    }
}
