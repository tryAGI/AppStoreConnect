
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaGroupType
    {
        /// <summary>
        /// 
        /// </summary>
        BetaGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupType value)
        {
            return value switch
            {
                BetaGroupType.BetaGroups => "betaGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupType? ToEnum(string value)
        {
            return value switch
            {
                "betaGroups" => BetaGroupType.BetaGroups,
                _ => null,
            };
        }
    }
}