
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionRelationshipsAppStoreVersionExperimentsV2DataItemType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}