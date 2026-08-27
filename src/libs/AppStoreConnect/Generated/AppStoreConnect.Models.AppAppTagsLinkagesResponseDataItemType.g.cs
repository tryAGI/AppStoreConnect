
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAppTagsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppTags,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAppTagsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAppTagsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppAppTagsLinkagesResponseDataItemType.AppTags => "appTags",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAppTagsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appTags" => AppAppTagsLinkagesResponseDataItemType.AppTags,
                _ => null,
            };
        }
    }
}