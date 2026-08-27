
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventAttributesPurpose
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
    public static class AppEventAttributesPurposeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventAttributesPurpose value)
        {
            return value switch
            {
                AppEventAttributesPurpose.AppropriateForAllUsers => "APPROPRIATE_FOR_ALL_USERS",
                AppEventAttributesPurpose.AttractNewUsers => "ATTRACT_NEW_USERS",
                AppEventAttributesPurpose.BringBackLapsedUsers => "BRING_BACK_LAPSED_USERS",
                AppEventAttributesPurpose.KeepActiveUsersInformed => "KEEP_ACTIVE_USERS_INFORMED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventAttributesPurpose? ToEnum(string value)
        {
            return value switch
            {
                "APPROPRIATE_FOR_ALL_USERS" => AppEventAttributesPurpose.AppropriateForAllUsers,
                "ATTRACT_NEW_USERS" => AppEventAttributesPurpose.AttractNewUsers,
                "BRING_BACK_LAPSED_USERS" => AppEventAttributesPurpose.BringBackLapsedUsers,
                "KEEP_ACTIVE_USERS_INFORMED" => AppEventAttributesPurpose.KeepActiveUsersInformed,
                _ => null,
            };
        }
    }
}