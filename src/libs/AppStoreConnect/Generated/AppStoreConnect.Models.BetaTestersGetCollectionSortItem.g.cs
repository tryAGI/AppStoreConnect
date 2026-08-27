
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersGetCollectionSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusemail,
        /// <summary>
        ///
        /// </summary>
        MinusfirstName,
        /// <summary>
        ///
        /// </summary>
        MinusinviteType,
        /// <summary>
        ///
        /// </summary>
        MinuslastName,
        /// <summary>
        ///
        /// </summary>
        Minusstate,
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        FirstName,
        /// <summary>
        ///
        /// </summary>
        InviteType,
        /// <summary>
        ///
        /// </summary>
        LastName,
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTestersGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetCollectionSortItem value)
        {
            return value switch
            {
                BetaTestersGetCollectionSortItem.Minusemail => "-email",
                BetaTestersGetCollectionSortItem.MinusfirstName => "-firstName",
                BetaTestersGetCollectionSortItem.MinusinviteType => "-inviteType",
                BetaTestersGetCollectionSortItem.MinuslastName => "-lastName",
                BetaTestersGetCollectionSortItem.Minusstate => "-state",
                BetaTestersGetCollectionSortItem.Email => "email",
                BetaTestersGetCollectionSortItem.FirstName => "firstName",
                BetaTestersGetCollectionSortItem.InviteType => "inviteType",
                BetaTestersGetCollectionSortItem.LastName => "lastName",
                BetaTestersGetCollectionSortItem.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-email" => BetaTestersGetCollectionSortItem.Minusemail,
                "-firstName" => BetaTestersGetCollectionSortItem.MinusfirstName,
                "-inviteType" => BetaTestersGetCollectionSortItem.MinusinviteType,
                "-lastName" => BetaTestersGetCollectionSortItem.MinuslastName,
                "-state" => BetaTestersGetCollectionSortItem.Minusstate,
                "email" => BetaTestersGetCollectionSortItem.Email,
                "firstName" => BetaTestersGetCollectionSortItem.FirstName,
                "inviteType" => BetaTestersGetCollectionSortItem.InviteType,
                "lastName" => BetaTestersGetCollectionSortItem.LastName,
                "state" => BetaTestersGetCollectionSortItem.State,
                _ => null,
            };
        }
    }
}