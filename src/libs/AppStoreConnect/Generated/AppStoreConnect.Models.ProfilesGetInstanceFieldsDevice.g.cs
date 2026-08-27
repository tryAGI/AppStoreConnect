
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetInstanceFieldsDevice
    {
        /// <summary>
        /// 
        /// </summary>
        AddedDate,
        /// <summary>
        /// 
        /// </summary>
        DeviceClass,
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        Status,
        /// <summary>
        /// 
        /// </summary>
        Udid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesGetInstanceFieldsDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetInstanceFieldsDevice value)
        {
            return value switch
            {
                ProfilesGetInstanceFieldsDevice.AddedDate => "addedDate",
                ProfilesGetInstanceFieldsDevice.DeviceClass => "deviceClass",
                ProfilesGetInstanceFieldsDevice.Model => "model",
                ProfilesGetInstanceFieldsDevice.Name => "name",
                ProfilesGetInstanceFieldsDevice.Platform => "platform",
                ProfilesGetInstanceFieldsDevice.Status => "status",
                ProfilesGetInstanceFieldsDevice.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetInstanceFieldsDevice? ToEnum(string value)
        {
            return value switch
            {
                "addedDate" => ProfilesGetInstanceFieldsDevice.AddedDate,
                "deviceClass" => ProfilesGetInstanceFieldsDevice.DeviceClass,
                "model" => ProfilesGetInstanceFieldsDevice.Model,
                "name" => ProfilesGetInstanceFieldsDevice.Name,
                "platform" => ProfilesGetInstanceFieldsDevice.Platform,
                "status" => ProfilesGetInstanceFieldsDevice.Status,
                "udid" => ProfilesGetInstanceFieldsDevice.Udid,
                _ => null,
            };
        }
    }
}