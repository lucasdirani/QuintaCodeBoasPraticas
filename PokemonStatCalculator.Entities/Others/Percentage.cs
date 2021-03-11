using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using PokemonStatCalculator.Utils.ExtensionMethods;

namespace PokemonStatCalculator.Entities.Others
{
    public class Percentage : IComparable<Percentage>, IEquatable<Percentage>
    {
        public Percentage(decimal value)
        {
            if (!value.IsBetween(0, 1))
            {
                throw new ArgumentOutOfRangeException("Value must be between 0 and 1.");
            }

            Value = value;
        }

        public decimal Value { get; private set; }

        public static explicit operator Percentage(decimal d)
        {
            return new Percentage(d);
        }

        public static implicit operator decimal(Percentage p)
        {
            return p.Value;
        }

        public static bool operator >(Percentage p1, Percentage p2)
        {
            if (p1 is null)
            {
                return false;
            }

            if (p2 is null)
            {
                return true;
            }

            return p1.CompareTo(p2) > 0;
        }

        public static bool operator >=(Percentage p1, Percentage p2)
        {
            return p1 > p2 || p1 == p2;
        }

        public static bool operator <(Percentage p1, Percentage p2)
        {
            return !(p1 >= p2);
        }

        public static bool operator <=(Percentage p1, Percentage p2)
        {
            return !(p1 > p2);
        }

        public static bool operator ==(Percentage p1, Percentage p2)
        {
            if (p1 is null)
            {
                return false;
            }

            if (p2 is null)
            {
                return false;
            }

            return p1.Equals(p2);
        }

        public static bool operator !=(Percentage p1, Percentage p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return string.Format("{0}%", Value);
        }

        public int CompareTo([AllowNull] Percentage other)
        {
            if (other is null)
            {
                return 1;
            }

            return Value.CompareTo(other.Value);
        }

        public bool Equals([AllowNull] Percentage other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return EqualityComparer<decimal>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((Percentage)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}