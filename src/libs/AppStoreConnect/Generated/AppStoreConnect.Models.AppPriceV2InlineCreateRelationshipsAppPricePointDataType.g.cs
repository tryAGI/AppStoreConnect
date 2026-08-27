
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPriceV2InlineCreateRelationshipsAppPricePointDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceV2InlineCreateRelationshipsAppPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceV2InlineCreateRelationshipsAppPricePointDataType value)
        {
            return value switch
            {
                AppPriceV2InlineCreateRelationshipsAppPricePointDataType.AppPricePoints => "appPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceV2InlineCreateRelationshipsAppPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppPriceV2InlineCreateRelationshipsAppPricePointDataType.AppPricePoints,
                _ => null,
            };
        }
    }
}