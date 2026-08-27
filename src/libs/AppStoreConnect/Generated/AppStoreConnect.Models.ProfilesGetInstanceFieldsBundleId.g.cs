
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetInstanceFieldsBundleId
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
    public static class ProfilesGetInstanceFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetInstanceFieldsBundleId value)
        {
            return value switch
            {
                ProfilesGetInstanceFieldsBundleId.App => "app",
                ProfilesGetInstanceFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                ProfilesGetInstanceFieldsBundleId.Identifier => "identifier",
                ProfilesGetInstanceFieldsBundleId.Name => "name",
                ProfilesGetInstanceFieldsBundleId.Platform => "platform",
                ProfilesGetInstanceFieldsBundleId.Profiles => "profiles",
                ProfilesGetInstanceFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetInstanceFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => ProfilesGetInstanceFieldsBundleId.App,
                "bundleIdCapabilities" => ProfilesGetInstanceFieldsBundleId.BundleIdCapabilities,
                "identifier" => ProfilesGetInstanceFieldsBundleId.Identifier,
                "name" => ProfilesGetInstanceFieldsBundleId.Name,
                "platform" => ProfilesGetInstanceFieldsBundleId.Platform,
                "profiles" => ProfilesGetInstanceFieldsBundleId.Profiles,
                "seedId" => ProfilesGetInstanceFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}