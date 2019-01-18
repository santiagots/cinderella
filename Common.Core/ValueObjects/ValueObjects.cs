using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Core.ValueObjects
{
    public abstract class ValueObjects<T> 
        where T: ValueObjects<T>
    {
        public override bool Equals(object obj)
        {
            var valueObjects = obj as T;

            if (ReferenceEquals(valueObjects, null))
                return false;

            return EqualsCore(valueObjects);
        }

        protected abstract bool EqualsCore(T other);

        public override int GetHashCode()
        {
            return GetHashCodeCore();
        }

        protected abstract int GetHashCodeCore();

        public static bool operator ==(ValueObjects<T> a, ValueObjects<T> b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObjects<T> a, ValueObjects<T> b)
        {
            return !(a == b);
        }
    }
}
