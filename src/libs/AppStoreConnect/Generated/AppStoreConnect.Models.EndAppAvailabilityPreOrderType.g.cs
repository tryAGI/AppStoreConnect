
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndAppAvailabilityPreOrderType
    {
        /// <summary>
        /// 
        /// </summary>
        EndAppAvailabilityPreOrders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndAppAvailabilityPreOrderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndAppAvailabilityPreOrderType value)
        {
            return value switch
            {
                EndAppAvailabilityPreOrderType.EndAppAvailabilityPreOrders => "endAppAvailabilityPreOrders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndAppAvailabilityPreOrderType? ToEnum(string value)
        {
            return value switch
            {
                "endAppAvailabilityPreOrders" => EndAppAvailabilityPreOrderType.EndAppAvailabilityPreOrders,
                _ => null,
            };
        }
    }
}