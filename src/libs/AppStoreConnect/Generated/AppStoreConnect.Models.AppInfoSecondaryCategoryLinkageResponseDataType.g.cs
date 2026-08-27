
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppInfoSecondaryCategoryLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCategories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppInfoSecondaryCategoryLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppInfoSecondaryCategoryLinkageResponseDataType value)
        {
            return value switch
            {
                AppInfoSecondaryCategoryLinkageResponseDataType.AppCategories => "appCategories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppInfoSecondaryCategoryLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCategories" => AppInfoSecondaryCategoryLinkageResponseDataType.AppCategories,
                _ => null,
            };
        }
    }
}