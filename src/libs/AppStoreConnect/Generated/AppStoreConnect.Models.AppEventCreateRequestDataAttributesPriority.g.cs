
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventCreateRequestDataAttributesPriority
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
    public static class AppEventCreateRequestDataAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventCreateRequestDataAttributesPriority value)
        {
            return value switch
            {
                AppEventCreateRequestDataAttributesPriority.High => "HIGH",
                AppEventCreateRequestDataAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventCreateRequestDataAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => AppEventCreateRequestDataAttributesPriority.High,
                "NORMAL" => AppEventCreateRequestDataAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}