
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataType value)
        {
            return value switch
            {
                BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaTesterInvitationCreateRequestDataRelationshipsBetaTesterDataType.BetaTesters,
                _ => null,
            };
        }
    }
}