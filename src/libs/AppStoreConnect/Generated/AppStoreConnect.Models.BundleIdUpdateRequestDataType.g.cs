
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdUpdateRequestDataType value)
        {
            return value switch
            {
                BundleIdUpdateRequestDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => BundleIdUpdateRequestDataType.BundleIds,
                _ => null,
            };
        }
    }
}