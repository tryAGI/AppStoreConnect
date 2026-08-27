
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UsersGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        MinuslastName,
        /// <summary>
        ///
        /// </summary>
        Minususername,
        /// <summary>
        ///
        /// </summary>
        LastName,
        /// <summary>
        ///
        /// </summary>
        Username,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UsersGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UsersGetCollectionSortItem value)
        {
            return value switch
            {
                UsersGetCollectionSortItem.MinuslastName => "-lastName",
                UsersGetCollectionSortItem.Minususername => "-username",
                UsersGetCollectionSortItem.LastName => "lastName",
                UsersGetCollectionSortItem.Username => "username",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UsersGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-lastName" => UsersGetCollectionSortItem.MinuslastName,
                "-username" => UsersGetCollectionSortItem.Minususername,
                "lastName" => UsersGetCollectionSortItem.LastName,
                "username" => UsersGetCollectionSortItem.Username,
                _ => null,
            };
        }
    }
}