
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PreReleaseVersionsGetCollectionSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        Minusversion,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PreReleaseVersionsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionSortItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionSortItem.Minusversion => "-version",
                PreReleaseVersionsGetCollectionSortItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-version" => PreReleaseVersionsGetCollectionSortItem.Minusversion,
                "version" => PreReleaseVersionsGetCollectionSortItem.Version,
                _ => null,
            };
        }
    }
}