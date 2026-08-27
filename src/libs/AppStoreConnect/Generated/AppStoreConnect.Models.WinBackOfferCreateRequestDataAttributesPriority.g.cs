
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOfferCreateRequestDataAttributesPriority
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
    public static class WinBackOfferCreateRequestDataAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferCreateRequestDataAttributesPriority value)
        {
            return value switch
            {
                WinBackOfferCreateRequestDataAttributesPriority.High => "HIGH",
                WinBackOfferCreateRequestDataAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferCreateRequestDataAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => WinBackOfferCreateRequestDataAttributesPriority.High,
                "NORMAL" => WinBackOfferCreateRequestDataAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}