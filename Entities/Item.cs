using System;
namespace Catalog1.Entities
{
    public record Item
    {
        public Guid Id  { get; init; }
        public string Name { get; init; }
        
        public decimal Age { get; init; }
        
        public string Birthplace {get; init;}
        
        public string Element{get; init;}
        
        public string Description{get; init;}
        public string Bio{get; init;}
        public string ImgUrl{get; init;}
        public DateTimeOffset CreatedDate { get; init; }
    }
}