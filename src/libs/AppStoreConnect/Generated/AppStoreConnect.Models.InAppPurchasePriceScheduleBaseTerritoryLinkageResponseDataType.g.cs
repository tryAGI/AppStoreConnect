
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => InAppPurchasePriceScheduleBaseTerritoryLinkageResponseDataType.Territories,
                _ => null,
            };
        }
    }
}