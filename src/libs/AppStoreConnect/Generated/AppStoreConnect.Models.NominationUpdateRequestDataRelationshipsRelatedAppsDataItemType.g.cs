
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationUpdateRequestDataRelationshipsRelatedAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType value)
        {
            return value switch
            {
                NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => NominationUpdateRequestDataRelationshipsRelatedAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}