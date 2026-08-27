
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdAppLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdAppLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdAppLinkageResponseDataType value)
        {
            return value switch
            {
                BundleIdAppLinkageResponseDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdAppLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BundleIdAppLinkageResponseDataType.Apps,
                _ => null,
            };
        }
    }
}