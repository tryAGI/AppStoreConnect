
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildRelationshipsBuildBundlesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildBundles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsBuildBundlesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsBuildBundlesDataItemType value)
        {
            return value switch
            {
                BuildRelationshipsBuildBundlesDataItemType.BuildBundles => "buildBundles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsBuildBundlesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildBundles" => BuildRelationshipsBuildBundlesDataItemType.BuildBundles,
                _ => null,
            };
        }
    }
}