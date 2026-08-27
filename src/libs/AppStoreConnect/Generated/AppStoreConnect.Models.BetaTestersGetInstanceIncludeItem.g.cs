
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTestersGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        BetaGroups,
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTestersGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTestersGetInstanceIncludeItem value)
        {
            return value switch
            {
                BetaTestersGetInstanceIncludeItem.Apps => "apps",
                BetaTestersGetInstanceIncludeItem.BetaGroups => "betaGroups",
                BetaTestersGetInstanceIncludeItem.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTestersGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BetaTestersGetInstanceIncludeItem.Apps,
                "betaGroups" => BetaTestersGetInstanceIncludeItem.BetaGroups,
                "builds" => BetaTestersGetInstanceIncludeItem.Builds,
                _ => null,
            };
        }
    }
}