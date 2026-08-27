
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum WinBackOfferUpdateRequestDataAttributesPriority
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
    public static class WinBackOfferUpdateRequestDataAttributesPriorityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WinBackOfferUpdateRequestDataAttributesPriority value)
        {
            return value switch
            {
                WinBackOfferUpdateRequestDataAttributesPriority.High => "HIGH",
                WinBackOfferUpdateRequestDataAttributesPriority.Normal => "NORMAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WinBackOfferUpdateRequestDataAttributesPriority? ToEnum(string value)
        {
            return value switch
            {
                "HIGH" => WinBackOfferUpdateRequestDataAttributesPriority.High,
                "NORMAL" => WinBackOfferUpdateRequestDataAttributesPriority.Normal,
                _ => null,
            };
        }
    }
}