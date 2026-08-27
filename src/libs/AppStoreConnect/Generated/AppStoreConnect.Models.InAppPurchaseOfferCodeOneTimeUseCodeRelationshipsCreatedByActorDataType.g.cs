
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsCreatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}