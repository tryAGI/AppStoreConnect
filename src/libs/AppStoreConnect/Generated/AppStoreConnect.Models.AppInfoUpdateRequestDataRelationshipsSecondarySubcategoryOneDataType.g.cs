
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoUpdateRequestDataRelationshipsSecondarySubcategoryOneDataType.AppCategories,
                _ => null,
            };
        }
    }
}