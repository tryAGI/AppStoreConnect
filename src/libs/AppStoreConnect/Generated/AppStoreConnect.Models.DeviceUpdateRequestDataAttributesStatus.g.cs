
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceUpdateRequestDataAttributesStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeviceUpdateRequestDataAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceUpdateRequestDataAttributesStatus value)
        {
            return value switch
            {
                DeviceUpdateRequestDataAttributesStatus.Disabled => "DISABLED",
                DeviceUpdateRequestDataAttributesStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceUpdateRequestDataAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => DeviceUpdateRequestDataAttributesStatus.Disabled,
                "ENABLED" => DeviceUpdateRequestDataAttributesStatus.Enabled,
                _ => null,
            };
        }
    }
}