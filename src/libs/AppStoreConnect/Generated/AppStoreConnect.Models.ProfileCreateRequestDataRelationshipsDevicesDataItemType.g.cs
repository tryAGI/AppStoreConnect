
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfileCreateRequestDataRelationshipsDevicesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileCreateRequestDataRelationshipsDevicesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileCreateRequestDataRelationshipsDevicesDataItemType value)
        {
            return value switch
            {
                ProfileCreateRequestDataRelationshipsDevicesDataItemType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileCreateRequestDataRelationshipsDevicesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "devices" => ProfileCreateRequestDataRelationshipsDevicesDataItemType.Devices,
                _ => null,
            };
        }
    }
}