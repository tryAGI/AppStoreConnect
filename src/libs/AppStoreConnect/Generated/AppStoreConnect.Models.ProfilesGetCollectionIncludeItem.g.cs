
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        BundleId,
        /// <summary>
        /// 
        /// </summary>
        Certificates,
        /// <summary>
        /// 
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionIncludeItem value)
        {
            return value switch
            {
                ProfilesGetCollectionIncludeItem.BundleId => "bundleId",
                ProfilesGetCollectionIncludeItem.Certificates => "certificates",
                ProfilesGetCollectionIncludeItem.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => ProfilesGetCollectionIncludeItem.BundleId,
                "certificates" => ProfilesGetCollectionIncludeItem.Certificates,
                "devices" => ProfilesGetCollectionIncludeItem.Devices,
                _ => null,
            };
        }
    }
}