
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventAttributesPriority
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Normal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventAttributesPriority value)
        {
            return value switch
            {
                AppEventAttributesPriority.High => "HIGH",
                AppEventAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => AppEventAttributesPriority.High,
                "NORMAL" => AppEventAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}