
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum WinBackOfferAttributesPriority
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
    public static class WinBackOfferAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferAttributesPriority value)
        {
            return value switch
            {
                WinBackOfferAttributesPriority.High => "HIGH",
                WinBackOfferAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => WinBackOfferAttributesPriority.High,
                "NORMAL" => WinBackOfferAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}