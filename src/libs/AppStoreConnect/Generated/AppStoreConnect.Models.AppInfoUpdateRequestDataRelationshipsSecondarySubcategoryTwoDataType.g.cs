
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryTwoDataType.AppCategories,
                _ => null,
            };
        }
    }
}