
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPriceV2RelationshipsAppPricePointDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPricePoints,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPriceV2RelationshipsAppPricePointDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPriceV2RelationshipsAppPricePointDataType value)
        {
            return value switch
            {
                AppPriceV2RelationshipsAppPricePointDataType.AppPricePoints => "appPricePoints",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPriceV2RelationshipsAppPricePointDataType? ToEnum(string value)
        {
            return value switch
            {
                "appPricePoints" => AppPriceV2RelationshipsAppPricePointDataType.AppPricePoints,
                _ => null,
            };
        }
    }
}