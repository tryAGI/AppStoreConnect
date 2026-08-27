
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionType
    {
        /// <summary>
        ///
        /// </summary>
        CiBuildActions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionType value)
        {
            return value switch
            {
                CiBuildActionType.CiBuildActions => "ciBuildActions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildActions" => CiBuildActionType.CiBuildActions,
                _ => null,
            };
        }
    }
}