
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventUpdateRequestDataAttributesPurpose
    {
        /// <summary>
        /// 
        /// </summary>
        AppropriateForAllUsers,
        /// <summary>
        /// 
        /// </summary>
        AttractNewUsers,
        /// <summary>
        /// 
        /// </summary>
        BringBackLapsedUsers,
        /// <summary>
        /// 
        /// </summary>
        KeepActiveUsersInformed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventUpdateRequestDataAttributesPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventUpdateRequestDataAttributesPurpose value)
        {
            return value switch
            {
                AppEventUpdateRequestDataAttributesPurpose.AppropriateForAllUsers => "APPROPRIATE_FOR_ALL_USERS",
                AppEventUpdateRequestDataAttributesPurpose.AttractNewUsers => "ATTRACT_NEW_USERS",
                AppEventUpdateRequestDataAttributesPurpose.BringBackLapsedUsers => "BRING_BACK_LAPSED_USERS",
                AppEventUpdateRequestDataAttributesPurpose.KeepActiveUsersInformed => "KEEP_ACTIVE_USERS_INFORMED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventUpdateRequestDataAttributesPurpose? ToEnum(string value)
        {
            return value switch
            {
                "APPROPRIATE_FOR_ALL_USERS" => AppEventUpdateRequestDataAttributesPurpose.AppropriateForAllUsers,
                "ATTRACT_NEW_USERS" => AppEventUpdateRequestDataAttributesPurpose.AttractNewUsers,
                "BRING_BACK_LAPSED_USERS" => AppEventUpdateRequestDataAttributesPurpose.BringBackLapsedUsers,
                "KEEP_ACTIVE_USERS_INFORMED" => AppEventUpdateRequestDataAttributesPurpose.KeepActiveUsersInformed,
                _ => null,
            };
        }
    }
}