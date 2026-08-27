
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionBuildLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionBuildLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionBuildLinkageRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionBuildLinkageRequestDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionBuildLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppStoreVersionBuildLinkageRequestDataType.Builds,
                _ => null,
            };
        }
    }
}