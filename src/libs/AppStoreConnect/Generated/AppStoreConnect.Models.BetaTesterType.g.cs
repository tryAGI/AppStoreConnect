
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTesterType
    {
        /// <summary>
        ///
        /// </summary>
        BetaTesters,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterType value)
        {
            return value switch
            {
                BetaTesterType.BetaTesters => "betaTesters",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterType? ToEnum(string value)
        {
            return value switch
            {
                "betaTesters" => BetaTesterType.BetaTesters,
                _ => null,
            };
        }
    }
}