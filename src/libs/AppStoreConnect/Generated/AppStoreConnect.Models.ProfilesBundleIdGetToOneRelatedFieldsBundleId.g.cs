
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesBundleIdGetToOneRelatedFieldsBundleId
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
    public static class ProfilesBundleIdGetToOneRelatedFieldsBundleIdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesBundleIdGetToOneRelatedFieldsBundleId value)
        {
            return value switch
            {
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.App => "app",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.BundleIdCapabilities => "bundleIdCapabilities",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.Identifier => "identifier",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.Name => "name",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.Platform => "platform",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.Profiles => "profiles",
                ProfilesBundleIdGetToOneRelatedFieldsBundleId.SeedId => "seedId",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesBundleIdGetToOneRelatedFieldsBundleId? ToEnum(string value)
        {
            return value switch
            {
                "app" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.App,
                "bundleIdCapabilities" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.BundleIdCapabilities,
                "identifier" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.Identifier,
                "name" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.Name,
                "platform" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.Platform,
                "profiles" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.Profiles,
                "seedId" => ProfilesBundleIdGetToOneRelatedFieldsBundleId.SeedId,
                _ => null,
            };
        }
    }
}