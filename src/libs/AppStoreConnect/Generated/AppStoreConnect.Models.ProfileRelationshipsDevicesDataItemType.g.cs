
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfileRelationshipsDevicesDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Devices,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfileRelationshipsDevicesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfileRelationshipsDevicesDataItemType value)
        {
            return value switch
            {
                ProfileRelationshipsDevicesDataItemType.Devices => "devices",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfileRelationshipsDevicesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "devices" => ProfileRelationshipsDevicesDataItemType.Devices,
                _ => null,
            };
        }
    }
}