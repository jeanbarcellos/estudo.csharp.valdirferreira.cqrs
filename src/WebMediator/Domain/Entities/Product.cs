using System;
namespace WebMediator.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public Product(string name, decimal value)
        {
            Id = Guid.NewGuid();
            Name = name;
            Value = value;
        }

    }
}
