
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoRelationshipsSecondarySubcategoryOneDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsSecondarySubcategoryOneDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsSecondarySubcategoryOneDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsSecondarySubcategoryOneDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsSecondarySubcategoryOneDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoRelationshipsSecondarySubcategoryOneDataType.AppCategories,
                _ => null,
            };
        }
    }
}