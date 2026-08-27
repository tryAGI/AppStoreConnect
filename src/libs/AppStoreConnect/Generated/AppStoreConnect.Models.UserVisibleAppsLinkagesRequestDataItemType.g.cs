
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserVisibleAppsLinkagesRequestDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserVisibleAppsLinkagesRequestDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserVisibleAppsLinkagesRequestDataItemType value)
        {
            return value switch
            {
                UserVisibleAppsLinkagesRequestDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserVisibleAppsLinkagesRequestDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserVisibleAppsLinkagesRequestDataItemType.Apps,
                _ => null,
            };
        }
    }
}