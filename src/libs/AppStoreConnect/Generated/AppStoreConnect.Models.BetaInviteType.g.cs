
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaInviteType
    {
        /// <summary>
        ///
        /// </summary>
        Email,
        /// <summary>
        ///
        /// </summary>
        PublicLink,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInviteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInviteType value)
        {
            return value switch
            {
                BetaInviteType.Email => "EMAIL",
                BetaInviteType.PublicLink => "PUBLIC_LINK",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInviteType? ToEnum(string value)
        {
            return value switch
            {
                "EMAIL" => BetaInviteType.Email,
                "PUBLIC_LINK" => BetaInviteType.PublicLink,
                _ => null,
            };
        }
    }
}