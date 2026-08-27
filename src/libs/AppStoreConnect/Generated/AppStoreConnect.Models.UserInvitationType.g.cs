
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInvitationType
    {
        /// <summary>
        /// 
        /// </summary>
        UserInvitations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationType value)
        {
            return value switch
            {
                UserInvitationType.UserInvitations => "userInvitations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationType? ToEnum(string value)
        {
            return value switch
            {
                "userInvitations" => UserInvitationType.UserInvitations,
                _ => null,
            };
        }
    }
}