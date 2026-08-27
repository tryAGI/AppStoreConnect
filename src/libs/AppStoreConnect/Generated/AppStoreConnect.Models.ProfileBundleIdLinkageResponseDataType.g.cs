
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileBundleIdLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileBundleIdLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileBundleIdLinkageResponseDataType value)
        {
            return value switch
            {
                ProfileBundleIdLinkageResponseDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileBundleIdLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => ProfileBundleIdLinkageResponseDataType.BundleIds,
                _ => null,
            };
        }
    }
}