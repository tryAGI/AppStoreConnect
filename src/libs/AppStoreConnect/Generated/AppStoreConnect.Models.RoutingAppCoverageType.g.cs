
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum RoutingAppCoverageType
    {
        /// <summary>
        /// 
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingAppCoverageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoverageType value)
        {
            return value switch
            {
                RoutingAppCoverageType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoverageType? ToEnum(string value)
        {
            return value switch
            {
                "routingAppCoverages" => RoutingAppCoverageType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}