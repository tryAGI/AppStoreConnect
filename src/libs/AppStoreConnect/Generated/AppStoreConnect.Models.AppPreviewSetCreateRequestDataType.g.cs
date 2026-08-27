
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetCreateRequestDataType value)
        {
            return value switch
            {
                AppPreviewSetCreateRequestDataType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppPreviewSetCreateRequestDataType.AppPreviewSets,
                _ => null,
            };
        }
    }
}