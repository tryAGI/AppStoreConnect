
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdType value)
        {
            return value switch
            {
                BundleIdType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => BundleIdType.BundleIds,
                _ => null,
            };
        }
    }
}