
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationsGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusemail,
        /// <summary>
        ///
        /// </summary>
        MinuslastName,
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        LastName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationsGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationsGetCollectionSortItem value)
        {
            return value switch
            {
                UserInvitationsGetCollectionSortItem.Minusemail => "-email",
                UserInvitationsGetCollectionSortItem.MinuslastName => "-lastName",
                UserInvitationsGetCollectionSortItem.Email => "email",
                UserInvitationsGetCollectionSortItem.LastName => "lastName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationsGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-email" => UserInvitationsGetCollectionSortItem.Minusemail,
                "-lastName" => UserInvitationsGetCollectionSortItem.MinuslastName,
                "email" => UserInvitationsGetCollectionSortItem.Email,
                "lastName" => UserInvitationsGetCollectionSortItem.LastName,
                _ => null,
            };
        }
    }
}