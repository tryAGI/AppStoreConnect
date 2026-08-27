
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationCreateRequestDataRelationshipsInAppEventsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationCreateRequestDataRelationshipsInAppEventsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationCreateRequestDataRelationshipsInAppEventsDataItemType value)
        {
            return value switch
            {
                NominationCreateRequestDataRelationshipsInAppEventsDataItemType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationCreateRequestDataRelationshipsInAppEventsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => NominationCreateRequestDataRelationshipsInAppEventsDataItemType.AppEvents,
                _ => null,
            };
        }
    }
}