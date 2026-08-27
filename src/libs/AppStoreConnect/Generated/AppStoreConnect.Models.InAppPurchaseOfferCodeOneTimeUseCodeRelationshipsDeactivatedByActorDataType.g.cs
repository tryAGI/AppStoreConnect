
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => InAppPurchaseOfferCodeOneTimeUseCodeRelationshipsDeactivatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}