
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildAudienceType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreEligible,
        /// <summary>
        ///
        /// </summary>
        InternalOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildAudienceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAudienceType value)
        {
            return value switch
            {
                BuildAudienceType.AppStoreEligible => "APP_STORE_ELIGIBLE",
                BuildAudienceType.InternalOnly => "INTERNAL_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAudienceType? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ELIGIBLE" => BuildAudienceType.AppStoreEligible,
                "INTERNAL_ONLY" => BuildAudienceType.InternalOnly,
                _ => null,
            };
        }
    }
}