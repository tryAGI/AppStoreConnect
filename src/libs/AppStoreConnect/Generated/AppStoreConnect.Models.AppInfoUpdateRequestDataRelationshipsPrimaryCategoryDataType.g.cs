
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType value)
        {
            return value switch
            {
                AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoUpdateRequestDataRelationshipsPrimaryCategoryDataType.AppCategories,
                _ => null,
            };
        }
    }
}