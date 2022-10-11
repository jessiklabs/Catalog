using System.ComponentModel.DataAnnotations;

namespace Catalog1.Dtos
{
    public class UpdateItemDto
    {
        [Required]
        public string Name { get; init; }
        [Required]
        
        public decimal Age { get; init; }
        [Required]
        public string Birthplace {get; init;}
        [Required]
        public string Element{get; init;}
        
        public string Description{get; init;}
        public string Bio{get;init;}
    }
}