
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType value)
        {
            return value switch
            {
                AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppScreenshotCreateRequestDataRelationshipsAppScreenshotSetDataType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}