using System.ComponentModel.DataAnnotations;

namespace Entities.DataTransferObjects.Category
{
    public abstract record CategoryDtoForManipulation
    {
        [Required(ErrorMessage = "CategoryName is a required field.")]
        [MinLength(2, ErrorMessage = "CategoryName must consist of at least 2 characters.")]
        [MaxLength(50, ErrorMessage = "CategoryName must consist of at maximum 50 characters.")]
        public String? CategoryName { get; set; }
    }
}
