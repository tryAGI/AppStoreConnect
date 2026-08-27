
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem
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
    public static class CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem value)
        {
            return value switch
            {
                CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem.AppStoreEligible => "APP_STORE_ELIGIBLE",
                CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem.InternalOnly => "INTERNAL_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "APP_STORE_ELIGIBLE" => CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem.AppStoreEligible,
                "INTERNAL_ONLY" => CiBuildRunsBuildsGetToManyRelatedFilterBuildAudienceTypeItem.InternalOnly,
                _ => null,
            };
        }
    }
}