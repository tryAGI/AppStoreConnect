
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationRelationshipsInAppEventsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationRelationshipsInAppEventsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationRelationshipsInAppEventsDataItemType value)
        {
            return value switch
            {
                NominationRelationshipsInAppEventsDataItemType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationRelationshipsInAppEventsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => NominationRelationshipsInAppEventsDataItemType.AppEvents,
                _ => null,
            };
        }
    }
}