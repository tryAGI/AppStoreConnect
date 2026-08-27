
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundleRelationshipsBuildBundleFileSizesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildBundleFileSizes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleRelationshipsBuildBundleFileSizesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleRelationshipsBuildBundleFileSizesDataItemType value)
        {
            return value switch
            {
                BuildBundleRelationshipsBuildBundleFileSizesDataItemType.BuildBundleFileSizes => "buildBundleFileSizes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleRelationshipsBuildBundleFileSizesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildBundleFileSizes" => BuildBundleRelationshipsBuildBundleFileSizesDataItemType.BuildBundleFileSizes,
                _ => null,
            };
        }
    }
}