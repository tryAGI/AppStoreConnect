
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterInvitationType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesterInvitations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterInvitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterInvitationType value)
        {
            return value switch
            {
                BetaTesterInvitationType.BetaTesterInvitations => "betaTesterInvitations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterInvitationType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesterInvitations" => BetaTesterInvitationType.BetaTesterInvitations,
                _ => null,
            };
        }
    }
}