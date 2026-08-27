
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetInstanceIncludeItem value)
        {
            return value switch
            {
                UsersGetInstanceIncludeItem.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "visibleApps" => UsersGetInstanceIncludeItem.VisibleApps,
                _ => null,
            };
        }
    }
}