
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionAppStoreVersionExperimentsV2LinkagesResponseDataItemType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}