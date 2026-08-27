
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoRelationshipsSecondarySubcategoryTwoDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoRelationshipsSecondarySubcategoryTwoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoRelationshipsSecondarySubcategoryTwoDataType value)
        {
            return value switch
            {
                AppInfoRelationshipsSecondarySubcategoryTwoDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoRelationshipsSecondarySubcategoryTwoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoRelationshipsSecondarySubcategoryTwoDataType.AppCategories,
                _ => null,
            };
        }
    }
}