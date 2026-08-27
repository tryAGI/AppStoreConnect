
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsAppStoreVersionExperimentsV2DataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsAppStoreVersionExperimentsV2DataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsAppStoreVersionExperimentsV2DataItemType value)
        {
            return value switch
            {
                AppRelationshipsAppStoreVersionExperimentsV2DataItemType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsAppStoreVersionExperimentsV2DataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppRelationshipsAppStoreVersionExperimentsV2DataItemType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}