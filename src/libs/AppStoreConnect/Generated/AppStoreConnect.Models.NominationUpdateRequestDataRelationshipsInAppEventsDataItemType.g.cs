
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationUpdateRequestDataRelationshipsInAppEventsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationUpdateRequestDataRelationshipsInAppEventsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationUpdateRequestDataRelationshipsInAppEventsDataItemType value)
        {
            return value switch
            {
                NominationUpdateRequestDataRelationshipsInAppEventsDataItemType.AppEvents => "appEvents",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationUpdateRequestDataRelationshipsInAppEventsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appEvents" => NominationUpdateRequestDataRelationshipsInAppEventsDataItemType.AppEvents,
                _ => null,
            };
        }
    }
}