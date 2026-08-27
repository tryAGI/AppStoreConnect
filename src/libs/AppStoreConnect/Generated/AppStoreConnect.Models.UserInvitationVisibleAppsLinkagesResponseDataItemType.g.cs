
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationVisibleAppsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationVisibleAppsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationVisibleAppsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                UserInvitationVisibleAppsLinkagesResponseDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationVisibleAppsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserInvitationVisibleAppsLinkagesResponseDataItemType.Apps,
                _ => null,
            };
        }
    }
}