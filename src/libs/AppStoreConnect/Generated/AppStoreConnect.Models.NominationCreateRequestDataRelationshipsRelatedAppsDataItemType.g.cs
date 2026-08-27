
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationCreateRequestDataRelationshipsRelatedAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationCreateRequestDataRelationshipsRelatedAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationCreateRequestDataRelationshipsRelatedAppsDataItemType value)
        {
            return value switch
            {
                NominationCreateRequestDataRelationshipsRelatedAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationCreateRequestDataRelationshipsRelatedAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => NominationCreateRequestDataRelationshipsRelatedAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}