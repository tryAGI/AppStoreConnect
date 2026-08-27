
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildRelationshipsPreReleaseVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildRelationshipsPreReleaseVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildRelationshipsPreReleaseVersionDataType value)
        {
            return value switch
            {
                BuildRelationshipsPreReleaseVersionDataType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildRelationshipsPreReleaseVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "preReleaseVersions" => BuildRelationshipsPreReleaseVersionDataType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}