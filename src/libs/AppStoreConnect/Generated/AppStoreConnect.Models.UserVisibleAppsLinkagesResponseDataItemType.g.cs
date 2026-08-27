
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserVisibleAppsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserVisibleAppsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserVisibleAppsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                UserVisibleAppsLinkagesResponseDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserVisibleAppsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserVisibleAppsLinkagesResponseDataItemType.Apps,
                _ => null,
            };
        }
    }
}