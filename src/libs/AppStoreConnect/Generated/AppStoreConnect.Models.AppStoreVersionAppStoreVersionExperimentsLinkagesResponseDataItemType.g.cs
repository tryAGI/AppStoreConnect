
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionAppStoreVersionExperimentsLinkagesResponseDataItemType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}