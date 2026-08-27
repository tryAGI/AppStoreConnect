
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileResponseIncludedItemDiscriminatorType
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
    public static class ProfileResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ProfileResponseIncludedItemDiscriminatorType.BundleIds => "bundleIds",
                ProfileResponseIncludedItemDiscriminatorType.Certificates => "certificates",
                ProfileResponseIncludedItemDiscriminatorType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => ProfileResponseIncludedItemDiscriminatorType.BundleIds,
                "certificates" => ProfileResponseIncludedItemDiscriminatorType.Certificates,
                "devices" => ProfileResponseIncludedItemDiscriminatorType.Devices,
                _ => null,
            };
        }
    }
}