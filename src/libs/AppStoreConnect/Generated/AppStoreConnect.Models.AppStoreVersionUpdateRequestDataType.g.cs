
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionUpdateRequestDataType value)
        {
            return value switch
            {
                AppStoreVersionUpdateRequestDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => AppStoreVersionUpdateRequestDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}