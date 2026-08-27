
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType value)
        {
            return value switch
            {
                InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType.Actors => "actors",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => InAppPurchaseOfferCodeCustomCodeRelationshipsDeactivatedByActorDataType.Actors,
                _ => null,
            };
        }
    }
}