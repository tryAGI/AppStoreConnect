
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoRelationshipsAppDataType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsAppDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppInfoRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}