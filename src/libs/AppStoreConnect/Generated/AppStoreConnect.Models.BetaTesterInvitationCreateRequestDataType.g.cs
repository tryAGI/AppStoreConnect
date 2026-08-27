
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterInvitationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesterInvitations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterInvitationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterInvitationCreateRequestDataType value)
        {
            return value switch
            {
                BetaTesterInvitationCreateRequestDataType.BetaTesterInvitations => "betaTesterInvitations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterInvitationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesterInvitations" => BetaTesterInvitationCreateRequestDataType.BetaTesterInvitations,
                _ => null,
            };
        }
    }
}