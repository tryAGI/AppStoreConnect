
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileCreateRequestDataRelationshipsBundleIdDataType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileCreateRequestDataRelationshipsBundleIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileCreateRequestDataRelationshipsBundleIdDataType value)
        {
            return value switch
            {
                ProfileCreateRequestDataRelationshipsBundleIdDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileCreateRequestDataRelationshipsBundleIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => ProfileCreateRequestDataRelationshipsBundleIdDataType.BundleIds,
                _ => null,
            };
        }
    }
}