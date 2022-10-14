using Catalog1.Dtos;
using Catalog1.Entities;

namespace Catalog1
{
    public static class Extensions{
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto{
                Id = item.Id,
                Name = item.Name,
                Age = item.Age,
                Birthplace = item.Birthplace,
                Element = item.Element,
                Description = item.Description,
                Bio = item.Bio,
                ImgUrl = item.ImgUrl,
                CreatedDate = item.CreatedDate
            };
        }
    }
}