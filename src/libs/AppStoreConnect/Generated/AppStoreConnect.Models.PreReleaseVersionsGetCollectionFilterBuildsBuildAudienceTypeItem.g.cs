
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem
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
    public static class PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem.AppStoreEligible => "APP_STORE_ELIGIBLE",
                PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem.InternalOnly => "INTERNAL_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ELIGIBLE" => PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem.AppStoreEligible,
                "INTERNAL_ONLY" => PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem.InternalOnly,
                _ => null,
            };
        }
    }
}