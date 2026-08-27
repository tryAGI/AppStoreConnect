
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetInstanceIncludeItem
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
    public static class ProfilesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetInstanceIncludeItem value)
        {
            return value switch
            {
                ProfilesGetInstanceIncludeItem.BundleId => "bundleId",
                ProfilesGetInstanceIncludeItem.Certificates => "certificates",
                ProfilesGetInstanceIncludeItem.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => ProfilesGetInstanceIncludeItem.BundleId,
                "certificates" => ProfilesGetInstanceIncludeItem.Certificates,
                "devices" => ProfilesGetInstanceIncludeItem.Devices,
                _ => null,
            };
        }
    }
}