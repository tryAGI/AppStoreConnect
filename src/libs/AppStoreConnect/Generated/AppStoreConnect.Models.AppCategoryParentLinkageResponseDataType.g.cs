
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoryParentLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoryParentLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoryParentLinkageResponseDataType value)
        {
            return value switch
            {
                AppCategoryParentLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoryParentLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppCategoryParentLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}