
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionBuildLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionBuildLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionBuildLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionBuildLinkageResponseDataType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionBuildLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppStoreVersionBuildLinkageResponseDataType.Builds,
                _ => null,
            };
        }
    }
}