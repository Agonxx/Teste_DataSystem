using System.ComponentModel;
using System.Reflection;
using TesteDS.Domain.Enums;

namespace TesteDS.Domain.Utils
{
    public static class EnumsEx
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo field = value.GetType().GetField(value.ToString());
            DescriptionAttribute attribute = field?.GetCustomAttribute<DescriptionAttribute>();
            return attribute?.Description ?? value.ToString();
        }

        public static int GetValue(this Enum value)
        {
            return Convert.ToInt32(value);
        }

        public static TEnum ToEnum<TEnum>(this string value, TEnum defaultValue = default) where TEnum : struct, Enum
        {
            return Enum.TryParse(value, true, out TEnum result) ? result : defaultValue;
        }

        public static IEnumerable<TEnum> GetEnumList<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
        }

        public static List<(TEnum Value, string Text)> ToListDescription<TEnum>() where TEnum : Enum
        {
            return Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => (
                    Value: e,
                    Text: e.GetType()
                        .GetField(e.ToString())?
                        .GetCustomAttribute<DescriptionAttribute>()?
                        .Description ?? e.ToString()
                )).ToList();
        }
    }
    public class StatusFilter
    {
        public EStatus EValue { get; set; }
        public string EDescription { get; set; }
    }
}
