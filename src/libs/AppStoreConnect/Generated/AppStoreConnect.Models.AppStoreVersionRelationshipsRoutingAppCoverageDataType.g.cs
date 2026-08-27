
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionRelationshipsRoutingAppCoverageDataType
    {
        /// <summary>
        ///
        /// </summary>
        RoutingAppCoverages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionRelationshipsRoutingAppCoverageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionRelationshipsRoutingAppCoverageDataType value)
        {
            return value switch
            {
                AppStoreVersionRelationshipsRoutingAppCoverageDataType.RoutingAppCoverages => "routingAppCoverages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionRelationshipsRoutingAppCoverageDataType? ToEnum(string value)
        {
            return value switch
            {
                "routingAppCoverages" => AppStoreVersionRelationshipsRoutingAppCoverageDataType.RoutingAppCoverages,
                _ => null,
            };
        }
    }
}