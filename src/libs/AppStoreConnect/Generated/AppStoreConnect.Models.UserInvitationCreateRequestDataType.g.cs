
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInvitationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        UserInvitations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationCreateRequestDataType value)
        {
            return value switch
            {
                UserInvitationCreateRequestDataType.UserInvitations => "userInvitations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "userInvitations" => UserInvitationCreateRequestDataType.UserInvitations,
                _ => null,
            };
        }
    }
}