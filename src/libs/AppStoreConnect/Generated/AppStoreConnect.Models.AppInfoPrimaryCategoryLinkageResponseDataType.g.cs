
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoPrimaryCategoryLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoPrimaryCategoryLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoPrimaryCategoryLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoPrimaryCategoryLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoPrimaryCategoryLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoPrimaryCategoryLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}