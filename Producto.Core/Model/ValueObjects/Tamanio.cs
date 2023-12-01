using Common.Core.ValueObjects;

namespace Common.Core.Model.ValueObjects
{
    public class Tamanio : ValueObjects<Tamanio>
    {
        public decimal? X { get; internal set; }
        public decimal? Y { get; internal set; }
        public decimal? Z { get; internal set; }

        protected Tamanio()
        {
        }

        protected override bool EqualsCore(Tamanio other)
        {
            return X == other.X && Y == other.Y && Z == other.Z ;
        }

        protected override int GetHashCodeCore()
        {
            return (X + Y + Z).GetHashCode();
        }
    }
}
