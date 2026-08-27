
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventUpdateRequestDataAttributesPriority
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
    public static class AppEventUpdateRequestDataAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventUpdateRequestDataAttributesPriority value)
        {
            return value switch
            {
                AppEventUpdateRequestDataAttributesPriority.High => "HIGH",
                AppEventUpdateRequestDataAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventUpdateRequestDataAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => AppEventUpdateRequestDataAttributesPriority.High,
                "NORMAL" => AppEventUpdateRequestDataAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}