
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterState
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Installed,
        /// <summary>
        ///
        /// </summary>
        Invited,
        /// <summary>
        ///
        /// </summary>
        NotInvited,
        /// <summary>
        ///
        /// </summary>
        Revoked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterState value)
        {
            return value switch
            {
                BetaTesterState.Accepted => "ACCEPTED",
                BetaTesterState.Installed => "INSTALLED",
                BetaTesterState.Invited => "INVITED",
                BetaTesterState.NotInvited => "NOT_INVITED",
                BetaTesterState.Revoked => "REVOKED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterState? ToEnum(string value)
        {
            return value switch
            {
                "ACCEPTED" => BetaTesterState.Accepted,
                "INSTALLED" => BetaTesterState.Installed,
                "INVITED" => BetaTesterState.Invited,
                "NOT_INVITED" => BetaTesterState.NotInvited,
                "REVOKED" => BetaTesterState.Revoked,
                _ => null,
            };
        }
    }
}