
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RoutingAppCoverageUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingAppCoverageUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoverageUpdateRequestDataType value)
        {
            return value switch
            {
                RoutingAppCoverageUpdateRequestDataType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoverageUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "routingAppCoverages" => RoutingAppCoverageUpdateRequestDataType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}