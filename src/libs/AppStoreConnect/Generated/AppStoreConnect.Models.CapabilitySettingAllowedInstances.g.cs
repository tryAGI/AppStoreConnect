
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CapabilitySettingAllowedInstances
    {
        /// <summary>
        /// 
        /// </summary>
        Entry,
        /// <summary>
        /// 
        /// </summary>
        Multiple,
        /// <summary>
        /// 
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CapabilitySettingAllowedInstancesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CapabilitySettingAllowedInstances value)
        {
            return value switch
            {
                CapabilitySettingAllowedInstances.Entry => "ENTRY",
                CapabilitySettingAllowedInstances.Multiple => "MULTIPLE",
                CapabilitySettingAllowedInstances.Single => "SINGLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CapabilitySettingAllowedInstances? ToEnum(string value)
        {
            return value switch
            {
                "ENTRY" => CapabilitySettingAllowedInstances.Entry,
                "MULTIPLE" => CapabilitySettingAllowedInstances.Multiple,
                "SINGLE" => CapabilitySettingAllowedInstances.Single,
                _ => null,
            };
        }
    }
}