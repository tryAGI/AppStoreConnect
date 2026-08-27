
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreVersionExperimentV2RelationshipsControlVersionsDataItemType.AppStoreVersions,
                _ => null,
            };
        }
    }
}