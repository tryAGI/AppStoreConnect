
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInvitationsGetCollectionIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        VisibleApps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationsGetCollectionIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetCollectionIncludeItem value)
        {
            return value switch
            {
                UserInvitationsGetCollectionIncludeItem.VisibleApps => "visibleApps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetCollectionIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "visibleApps" => UserInvitationsGetCollectionIncludeItem.VisibleApps,
                _ => null,
            };
        }
    }
}