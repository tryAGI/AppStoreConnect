
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType value)
        {
            return value switch
            {
                BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => BundleIdCapabilityCreateRequestDataRelationshipsBundleIdDataType.BundleIds,
                _ => null,
            };
        }
    }
}