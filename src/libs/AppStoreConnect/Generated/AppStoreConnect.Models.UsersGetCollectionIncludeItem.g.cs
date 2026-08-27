
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetCollectionIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetCollectionIncludeItem value)
        {
            return value switch
            {
                UsersGetCollectionIncludeItem.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "visibleApps" => UsersGetCollectionIncludeItem.VisibleApps,
                _ => null,
            };
        }
    }
}