
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppBuildsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppBuildsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppBuildsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppBuildsLinkagesResponseDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppBuildsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppBuildsLinkagesResponseDataItemType.Builds,
                _ => null,
            };
        }
    }
}