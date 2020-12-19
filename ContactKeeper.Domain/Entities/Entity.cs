using System;
using System.Diagnostics.CodeAnalysis;

namespace ContactKeeper.Domain.Entities
{
    public class Entity : IEquatable<Entity>
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals([AllowNull] Entity other)
        {
            return Id == other.Id;
        }
    }
}