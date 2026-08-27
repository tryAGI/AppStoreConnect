
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionRoutingAppCoverageLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRoutingAppCoverageLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRoutingAppCoverageLinkageResponseDataType value)
        {
            return value switch
            {
                AppStoreVersionRoutingAppCoverageLinkageResponseDataType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRoutingAppCoverageLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "routingAppCoverages" => AppStoreVersionRoutingAppCoverageLinkageResponseDataType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}