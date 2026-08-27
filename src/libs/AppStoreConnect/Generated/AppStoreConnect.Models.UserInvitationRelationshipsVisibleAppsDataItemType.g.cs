
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserInvitationRelationshipsVisibleAppsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserInvitationRelationshipsVisibleAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserInvitationRelationshipsVisibleAppsDataItemType value)
        {
            return value switch
            {
                UserInvitationRelationshipsVisibleAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserInvitationRelationshipsVisibleAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserInvitationRelationshipsVisibleAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}