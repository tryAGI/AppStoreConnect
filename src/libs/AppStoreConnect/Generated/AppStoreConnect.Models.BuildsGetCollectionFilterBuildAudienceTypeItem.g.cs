
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFilterBuildAudienceTypeItem
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
    public static class BuildsGetCollectionFilterBuildAudienceTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFilterBuildAudienceTypeItem value)
        {
            return value switch
            {
                BuildsGetCollectionFilterBuildAudienceTypeItem.AppStoreEligible => "APP_STORE_ELIGIBLE",
                BuildsGetCollectionFilterBuildAudienceTypeItem.InternalOnly => "INTERNAL_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFilterBuildAudienceTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ELIGIBLE" => BuildsGetCollectionFilterBuildAudienceTypeItem.AppStoreEligible,
                "INTERNAL_ONLY" => BuildsGetCollectionFilterBuildAudienceTypeItem.InternalOnly,
                _ => null,
            };
        }
    }
}