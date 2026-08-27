
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        App,
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreReleaseVersionsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionIncludeItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionIncludeItem.App => "app",
                PreReleaseVersionsGetCollectionIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => PreReleaseVersionsGetCollectionIncludeItem.App,
                "builds" => PreReleaseVersionsGetCollectionIncludeItem.Builds,
                _ => null,
            };
        }
    }
}