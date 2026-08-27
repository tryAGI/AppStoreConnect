
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductRelationshipsBundleIdDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductRelationshipsBundleIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductRelationshipsBundleIdDataType value)
        {
            return value switch
            {
                CiProductRelationshipsBundleIdDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductRelationshipsBundleIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => CiProductRelationshipsBundleIdDataType.BundleIds,
                _ => null,
            };
        }
    }
}