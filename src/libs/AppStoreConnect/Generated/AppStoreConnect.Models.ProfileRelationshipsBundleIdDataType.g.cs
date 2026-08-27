
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileRelationshipsBundleIdDataType
    {
        /// <summary>
        ///
        /// </summary>
        BundleIds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileRelationshipsBundleIdDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileRelationshipsBundleIdDataType value)
        {
            return value switch
            {
                ProfileRelationshipsBundleIdDataType.BundleIds => "bundleIds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileRelationshipsBundleIdDataType? ToEnum(string value)
        {
            return value switch
            {
                "bundleIds" => ProfileRelationshipsBundleIdDataType.BundleIds,
                _ => null,
            };
        }
    }
}