
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsCiProductGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        BundleId,
        /// <summary>
        /// 
        /// </summary>
        PrimaryRepositories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsCiProductGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCiProductGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                AppsCiProductGetToOneRelatedIncludeItem.App => "app",
                AppsCiProductGetToOneRelatedIncludeItem.BundleId => "bundleId",
                AppsCiProductGetToOneRelatedIncludeItem.PrimaryRepositories => "primaryRepositories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCiProductGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsCiProductGetToOneRelatedIncludeItem.App,
                "bundleId" => AppsCiProductGetToOneRelatedIncludeItem.BundleId,
                "primaryRepositories" => AppsCiProductGetToOneRelatedIncludeItem.PrimaryRepositories,
                _ => null,
            };
        }
    }
}