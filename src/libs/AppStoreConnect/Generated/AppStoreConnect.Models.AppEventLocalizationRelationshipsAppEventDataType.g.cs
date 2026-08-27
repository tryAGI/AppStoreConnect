
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationRelationshipsAppEventDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationRelationshipsAppEventDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationRelationshipsAppEventDataType value)
        {
            return value switch
            {
                AppEventLocalizationRelationshipsAppEventDataType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationRelationshipsAppEventDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => AppEventLocalizationRelationshipsAppEventDataType.AppEvents,
                _ => null,
            };
        }
    }
}