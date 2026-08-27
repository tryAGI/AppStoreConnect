
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupUpdateRequestDataType value)
        {
            return value switch
            {
                BetaGroupUpdateRequestDataType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaGroupUpdateRequestDataType.BetaGroups,
                _ => null,
            };
        }
    }
}