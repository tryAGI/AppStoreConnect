
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildPreReleaseVersionLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        PreReleaseVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildPreReleaseVersionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildPreReleaseVersionLinkageResponseDataType value)
        {
            return value switch
            {
                BuildPreReleaseVersionLinkageResponseDataType.PreReleaseVersions => "preReleaseVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildPreReleaseVersionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "preReleaseVersions" => BuildPreReleaseVersionLinkageResponseDataType.PreReleaseVersions,
                _ => null,
            };
        }
    }
}