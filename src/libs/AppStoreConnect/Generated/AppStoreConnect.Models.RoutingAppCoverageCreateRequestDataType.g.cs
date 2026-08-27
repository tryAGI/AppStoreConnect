
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum RoutingAppCoverageCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoutingAppCoverageCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoutingAppCoverageCreateRequestDataType value)
        {
            return value switch
            {
                RoutingAppCoverageCreateRequestDataType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoutingAppCoverageCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "routingAppCoverages" => RoutingAppCoverageCreateRequestDataType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}