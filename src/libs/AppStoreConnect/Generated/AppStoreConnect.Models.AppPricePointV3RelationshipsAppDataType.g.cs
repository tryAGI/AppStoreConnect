
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPricePointV3RelationshipsAppDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPricePointV3RelationshipsAppDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPricePointV3RelationshipsAppDataType value)
        {
            return value switch
            {
                AppPricePointV3RelationshipsAppDataType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPricePointV3RelationshipsAppDataType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => AppPricePointV3RelationshipsAppDataType.Apps,
                _ => null,
            };
        }
    }
}