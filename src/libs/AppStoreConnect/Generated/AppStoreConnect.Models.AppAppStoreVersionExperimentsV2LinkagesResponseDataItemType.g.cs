
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppStoreVersionExperimentsV2LinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppStoreVersionExperimentsV2LinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppStoreVersionExperimentsV2LinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppStoreVersionExperimentsV2LinkagesResponseDataItemType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppStoreVersionExperimentsV2LinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppAppStoreVersionExperimentsV2LinkagesResponseDataItemType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}