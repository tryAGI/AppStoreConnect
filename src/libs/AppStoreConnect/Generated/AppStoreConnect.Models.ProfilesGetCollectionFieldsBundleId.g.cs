
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetCollectionFieldsBundleId
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
    public static class ProfilesGetCollectionFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFieldsBundleId value)
        {
            return value switch
            {
                ProfilesGetCollectionFieldsBundleId.App => "app",
                ProfilesGetCollectionFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                ProfilesGetCollectionFieldsBundleId.Identifier => "identifier",
                ProfilesGetCollectionFieldsBundleId.Name => "name",
                ProfilesGetCollectionFieldsBundleId.Platform => "platform",
                ProfilesGetCollectionFieldsBundleId.Profiles => "profiles",
                ProfilesGetCollectionFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => ProfilesGetCollectionFieldsBundleId.App,
                "bundleIdCapabilities" => ProfilesGetCollectionFieldsBundleId.BundleIdCapabilities,
                "identifier" => ProfilesGetCollectionFieldsBundleId.Identifier,
                "name" => ProfilesGetCollectionFieldsBundleId.Name,
                "platform" => ProfilesGetCollectionFieldsBundleId.Platform,
                "profiles" => ProfilesGetCollectionFieldsBundleId.Profiles,
                "seedId" => ProfilesGetCollectionFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}