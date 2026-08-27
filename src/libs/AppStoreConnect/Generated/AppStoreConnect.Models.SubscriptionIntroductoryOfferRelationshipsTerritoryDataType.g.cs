
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionIntroductoryOfferRelationshipsTerritoryDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionIntroductoryOfferRelationshipsTerritoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionIntroductoryOfferRelationshipsTerritoryDataType value)
        {
            return value switch
            {
                SubscriptionIntroductoryOfferRelationshipsTerritoryDataType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionIntroductoryOfferRelationshipsTerritoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "territories" => SubscriptionIntroductoryOfferRelationshipsTerritoryDataType.Territories,
                _ => null,
            };
        }
    }
}