
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "versions" => AppStoreVersionsAlternativeDistributionPackageGetToOneRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}