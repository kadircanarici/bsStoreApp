using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Category
{
    public record CategoryDto
    {
        [Key]
        public int CategoryId { get; set; }
        public String? CategoryName { get; set; }
    }
}
