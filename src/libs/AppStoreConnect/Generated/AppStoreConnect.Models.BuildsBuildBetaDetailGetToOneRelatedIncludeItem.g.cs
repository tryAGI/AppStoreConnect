
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildsBuildBetaDetailGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Build,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildsBuildBetaDetailGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsBuildBetaDetailGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                BuildsBuildBetaDetailGetToOneRelatedIncludeItem.Build => "build",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsBuildBetaDetailGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "build" => BuildsBuildBetaDetailGetToOneRelatedIncludeItem.Build,
                _ => null,
            };
        }
    }
}