
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoRelationshipsPrimaryCategoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsPrimaryCategoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsPrimaryCategoryDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsPrimaryCategoryDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsPrimaryCategoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoRelationshipsPrimaryCategoryDataType.AppCategories,
                _ => null,
            };
        }
    }
}