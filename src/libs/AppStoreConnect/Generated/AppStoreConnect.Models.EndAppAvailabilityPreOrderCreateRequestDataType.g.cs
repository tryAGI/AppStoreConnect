
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum EndAppAvailabilityPreOrderCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        EndAppAvailabilityPreOrders,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EndAppAvailabilityPreOrderCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EndAppAvailabilityPreOrderCreateRequestDataType value)
        {
            return value switch
            {
                EndAppAvailabilityPreOrderCreateRequestDataType.EndAppAvailabilityPreOrders => "endAppAvailabilityPreOrders",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EndAppAvailabilityPreOrderCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "endAppAvailabilityPreOrders" => EndAppAvailabilityPreOrderCreateRequestDataType.EndAppAvailabilityPreOrders,
                _ => null,
            };
        }
    }
}