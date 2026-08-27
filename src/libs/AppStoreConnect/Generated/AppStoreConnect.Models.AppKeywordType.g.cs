
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppKeywordType
    {
        /// <summary>
        /// 
        /// </summary>
        AppKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppKeywordTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppKeywordType value)
        {
            return value switch
            {
                AppKeywordType.AppKeywords => "appKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppKeywordType? ToEnum(string value)
        {
            return value switch
            {
                "appKeywords" => AppKeywordType.AppKeywords,
                _ => null,
            };
        }
    }
}