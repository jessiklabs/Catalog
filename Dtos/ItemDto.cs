using System;

namespace Catalog1.Dtos
{
    public record ItemDto
    {
        public Guid Id  { get; init; }
        public string Name { get; init; }
        public decimal Age { get; init; }
        
        public string Birthplace {get; init;}
        
        public string Element{get; init;}
        
        public string Description{get; init;}
        public string Bio{get;init;}
        public DateTimeOffset CreatedDate { get; set; }
    }
}