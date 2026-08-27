
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
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
    public static class ProfilesResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ProfilesResponseIncludedItemDiscriminatorType.BundleIds => "bundleIds",
                ProfilesResponseIncludedItemDiscriminatorType.Certificates => "certificates",
                ProfilesResponseIncludedItemDiscriminatorType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => ProfilesResponseIncludedItemDiscriminatorType.BundleIds,
                "certificates" => ProfilesResponseIncludedItemDiscriminatorType.Certificates,
                "devices" => ProfilesResponseIncludedItemDiscriminatorType.Devices,
                _ => null,
            };
        }
    }
}