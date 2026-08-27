
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildAppStoreVersionLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildAppStoreVersionLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildAppStoreVersionLinkageResponseDataType value)
        {
            return value switch
            {
                BuildAppStoreVersionLinkageResponseDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildAppStoreVersionLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => BuildAppStoreVersionLinkageResponseDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}