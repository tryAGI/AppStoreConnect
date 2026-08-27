
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipRelationshipsAppDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipRelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipRelationshipsAppDataType value)
        {
            return value switch
            {
                AppClipRelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipRelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppClipRelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}