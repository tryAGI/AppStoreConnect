
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetCollectionFieldsDevice
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
    public static class ProfilesGetCollectionFieldsDeviceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFieldsDevice value)
        {
            return value switch
            {
                ProfilesGetCollectionFieldsDevice.AddedDate => "addedDate",
                ProfilesGetCollectionFieldsDevice.DeviceClass => "deviceClass",
                ProfilesGetCollectionFieldsDevice.Model => "model",
                ProfilesGetCollectionFieldsDevice.Name => "name",
                ProfilesGetCollectionFieldsDevice.Platform => "platform",
                ProfilesGetCollectionFieldsDevice.Status => "status",
                ProfilesGetCollectionFieldsDevice.Udid => "udid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFieldsDevice? ToEnum(string value)
        {
            return value switch
            {
                "addedDate" => ProfilesGetCollectionFieldsDevice.AddedDate,
                "deviceClass" => ProfilesGetCollectionFieldsDevice.DeviceClass,
                "model" => ProfilesGetCollectionFieldsDevice.Model,
                "name" => ProfilesGetCollectionFieldsDevice.Name,
                "platform" => ProfilesGetCollectionFieldsDevice.Platform,
                "status" => ProfilesGetCollectionFieldsDevice.Status,
                "udid" => ProfilesGetCollectionFieldsDevice.Udid,
                _ => null,
            };
        }
    }
}