
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAppCustomProductPagesLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppCustomProductPagesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppCustomProductPagesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppCustomProductPagesLinkagesResponseDataItemType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppCustomProductPagesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppAppCustomProductPagesLinkagesResponseDataItemType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}