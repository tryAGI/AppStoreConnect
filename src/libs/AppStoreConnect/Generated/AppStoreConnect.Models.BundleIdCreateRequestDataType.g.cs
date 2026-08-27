
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdCreateRequestDataType value)
        {
            return value switch
            {
                BundleIdCreateRequestDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => BundleIdCreateRequestDataType.BundleIds,
                _ => null,
            };
        }
    }
}