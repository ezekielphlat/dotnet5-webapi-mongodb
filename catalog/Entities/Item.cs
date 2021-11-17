using System;

namespace Catalog.Entities
{
    public record Item
    {
        public Guid Id {get; init;} //means after creation you cannot modify this property
        public string Name {get; init;}
        public decimal Price { get; init; }  
        public DateTimeOffset CreatedDate {get; init;}

    }
    
}