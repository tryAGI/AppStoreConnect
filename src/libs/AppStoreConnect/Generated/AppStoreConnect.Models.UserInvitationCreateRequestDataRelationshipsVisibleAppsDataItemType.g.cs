
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemType value)
        {
            return value switch
            {
                UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserInvitationCreateRequestDataRelationshipsVisibleAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}