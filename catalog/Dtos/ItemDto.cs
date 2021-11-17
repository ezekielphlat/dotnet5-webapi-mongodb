using System;

namespace Catalog.Dtos
{
   public record ItemDto
    {
        public Guid Id {get; init;} //means after creation you cannot modify this property
        public string Name {get; init;}
        public decimal Price { get; init; }  
        public DateTimeOffset CreatedDate {get; init;}

    }
}