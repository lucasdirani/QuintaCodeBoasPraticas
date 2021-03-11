using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Newtonsoft.Json;

namespace PokemonStatCalculator.Utils.ExtensionMethods
{
    public static class GenericExtensionMethod
    {
        public static bool IsBetween<T>(this T value, T start, T end)
            where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(value, start) >= 0 && Comparer<T>.Default.Compare(value, end) <= 0;
        }

        public static bool IsNotBetween<T>(this T value, T start, T end)
            where T : IComparable<T>
        {
            return !IsBetween(value, start, end);
        }

        public static string GetDescription<T>(this T enumerationValue)
            where T : struct
        {
            Type type = enumerationValue.GetType();

            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());

            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return enumerationValue.ToString();
        }

        public static string ToJson<T>(this T value)
        {
            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };

            return JsonConvert.SerializeObject(value, Formatting.Indented, settings);
        }
    }
}