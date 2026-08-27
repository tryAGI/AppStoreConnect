
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesDevicesGetToManyRelatedFieldsDevice
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
    public static class ProfilesDevicesGetToManyRelatedFieldsDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesDevicesGetToManyRelatedFieldsDevice value)
        {
            return value switch
            {
                ProfilesDevicesGetToManyRelatedFieldsDevice.AddedDate => "addedDate",
                ProfilesDevicesGetToManyRelatedFieldsDevice.DeviceClass => "deviceClass",
                ProfilesDevicesGetToManyRelatedFieldsDevice.Model => "model",
                ProfilesDevicesGetToManyRelatedFieldsDevice.Name => "name",
                ProfilesDevicesGetToManyRelatedFieldsDevice.Platform => "platform",
                ProfilesDevicesGetToManyRelatedFieldsDevice.Status => "status",
                ProfilesDevicesGetToManyRelatedFieldsDevice.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesDevicesGetToManyRelatedFieldsDevice? ToEnum(string value)
        {
            return value switch
            {
                "addedDate" => ProfilesDevicesGetToManyRelatedFieldsDevice.AddedDate,
                "deviceClass" => ProfilesDevicesGetToManyRelatedFieldsDevice.DeviceClass,
                "model" => ProfilesDevicesGetToManyRelatedFieldsDevice.Model,
                "name" => ProfilesDevicesGetToManyRelatedFieldsDevice.Name,
                "platform" => ProfilesDevicesGetToManyRelatedFieldsDevice.Platform,
                "status" => ProfilesDevicesGetToManyRelatedFieldsDevice.Status,
                "udid" => ProfilesDevicesGetToManyRelatedFieldsDevice.Udid,
                _ => null,
            };
        }
    }
}