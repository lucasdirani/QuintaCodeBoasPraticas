using System;

namespace PokemonStatCalculator.Utils.ExtensionMethods
{
    public static class StringExtensionMethod
    {
        public static T ToEnum<T>(this string value, out bool valueExists)
        {
            try
            {
                valueExists = true;

                return (T)Enum.Parse(typeof(T), value, true);
            }
            catch (ArgumentException)
            {
                valueExists = false;

                return default;
            }
        }
    }
}