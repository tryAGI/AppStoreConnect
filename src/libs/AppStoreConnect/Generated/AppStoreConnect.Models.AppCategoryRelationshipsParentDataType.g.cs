
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCategoryRelationshipsParentDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCategoryRelationshipsParentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCategoryRelationshipsParentDataType value)
        {
            return value switch
            {
                AppCategoryRelationshipsParentDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCategoryRelationshipsParentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppCategoryRelationshipsParentDataType.AppCategories,
                _ => null,
            };
        }
    }
}