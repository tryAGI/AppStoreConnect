
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoryType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoryTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoryType value)
        {
            return value switch
            {
                AppCategoryType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoryType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppCategoryType.AppCategories,
                _ => null,
            };
        }
    }
}