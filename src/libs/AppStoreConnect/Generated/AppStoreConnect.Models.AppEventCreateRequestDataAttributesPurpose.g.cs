
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventCreateRequestDataAttributesPurpose
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
    public static class AppEventCreateRequestDataAttributesPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventCreateRequestDataAttributesPurpose value)
        {
            return value switch
            {
                AppEventCreateRequestDataAttributesPurpose.AppropriateForAllUsers => "APPROPRIATE_FOR_ALL_USERS",
                AppEventCreateRequestDataAttributesPurpose.AttractNewUsers => "ATTRACT_NEW_USERS",
                AppEventCreateRequestDataAttributesPurpose.BringBackLapsedUsers => "BRING_BACK_LAPSED_USERS",
                AppEventCreateRequestDataAttributesPurpose.KeepActiveUsersInformed => "KEEP_ACTIVE_USERS_INFORMED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventCreateRequestDataAttributesPurpose? ToEnum(string value)
        {
            return value switch
            {
                "APPROPRIATE_FOR_ALL_USERS" => AppEventCreateRequestDataAttributesPurpose.AppropriateForAllUsers,
                "ATTRACT_NEW_USERS" => AppEventCreateRequestDataAttributesPurpose.AttractNewUsers,
                "BRING_BACK_LAPSED_USERS" => AppEventCreateRequestDataAttributesPurpose.BringBackLapsedUsers,
                "KEEP_ACTIVE_USERS_INFORMED" => AppEventCreateRequestDataAttributesPurpose.KeepActiveUsersInformed,
                _ => null,
            };
        }
    }
}