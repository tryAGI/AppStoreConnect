
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsCiProductGetToOneRelatedFieldsBundleId
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        BundleIdCapabilities,
        /// <summary>
        ///
        /// </summary>
        Identifier,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        Profiles,
        /// <summary>
        ///
        /// </summary>
        SeedId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsCiProductGetToOneRelatedFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsCiProductGetToOneRelatedFieldsBundleId value)
        {
            return value switch
            {
                AppsCiProductGetToOneRelatedFieldsBundleId.App => "app",
                AppsCiProductGetToOneRelatedFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                AppsCiProductGetToOneRelatedFieldsBundleId.Identifier => "identifier",
                AppsCiProductGetToOneRelatedFieldsBundleId.Name => "name",
                AppsCiProductGetToOneRelatedFieldsBundleId.Platform => "platform",
                AppsCiProductGetToOneRelatedFieldsBundleId.Profiles => "profiles",
                AppsCiProductGetToOneRelatedFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsCiProductGetToOneRelatedFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsCiProductGetToOneRelatedFieldsBundleId.App,
                "bundleIdCapabilities" => AppsCiProductGetToOneRelatedFieldsBundleId.BundleIdCapabilities,
                "identifier" => AppsCiProductGetToOneRelatedFieldsBundleId.Identifier,
                "name" => AppsCiProductGetToOneRelatedFieldsBundleId.Name,
                "platform" => AppsCiProductGetToOneRelatedFieldsBundleId.Platform,
                "profiles" => AppsCiProductGetToOneRelatedFieldsBundleId.Profiles,
                "seedId" => AppsCiProductGetToOneRelatedFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}