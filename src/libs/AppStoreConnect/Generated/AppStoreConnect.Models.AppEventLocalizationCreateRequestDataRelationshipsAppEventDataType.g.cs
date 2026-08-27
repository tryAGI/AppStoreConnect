
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventLocalizationCreateRequestDataRelationshipsAppEventDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationCreateRequestDataRelationshipsAppEventDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationCreateRequestDataRelationshipsAppEventDataType value)
        {
            return value switch
            {
                AppEventLocalizationCreateRequestDataRelationshipsAppEventDataType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationCreateRequestDataRelationshipsAppEventDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => AppEventLocalizationCreateRequestDataRelationshipsAppEventDataType.AppEvents,
                _ => null,
            };
        }
    }
}