
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum DeviceAttributesStatus
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
    public static class DeviceAttributesStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeviceAttributesStatus value)
        {
            return value switch
            {
                DeviceAttributesStatus.Disabled => "DISABLED",
                DeviceAttributesStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeviceAttributesStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => DeviceAttributesStatus.Disabled,
                "ENABLED" => DeviceAttributesStatus.Enabled,
                _ => null,
            };
        }
    }
}