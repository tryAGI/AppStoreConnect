
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PrereleaseVersionRelationshipsBuildsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrereleaseVersionRelationshipsBuildsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrereleaseVersionRelationshipsBuildsDataItemType value)
        {
            return value switch
            {
                PrereleaseVersionRelationshipsBuildsDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrereleaseVersionRelationshipsBuildsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => PrereleaseVersionRelationshipsBuildsDataItemType.Builds,
                _ => null,
            };
        }
    }
}