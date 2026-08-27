
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildRelationshipsIconsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        BuildIcons,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsIconsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsIconsDataItemType value)
        {
            return value switch
            {
                BuildRelationshipsIconsDataItemType.BuildIcons => "buildIcons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsIconsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "buildIcons" => BuildRelationshipsIconsDataItemType.BuildIcons,
                _ => null,
            };
        }
    }
}