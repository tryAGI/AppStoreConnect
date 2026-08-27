
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                UserInvitationsGetInstanceIncludeItem.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "visibleApps" => UserInvitationsGetInstanceIncludeItem.VisibleApps,
                _ => null,
            };
        }
    }
}