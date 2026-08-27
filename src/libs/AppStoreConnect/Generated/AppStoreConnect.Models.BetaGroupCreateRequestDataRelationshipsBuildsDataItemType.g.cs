
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGroupCreateRequestDataRelationshipsBuildsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGroupCreateRequestDataRelationshipsBuildsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGroupCreateRequestDataRelationshipsBuildsDataItemType value)
        {
            return value switch
            {
                BetaGroupCreateRequestDataRelationshipsBuildsDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGroupCreateRequestDataRelationshipsBuildsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaGroupCreateRequestDataRelationshipsBuildsDataItemType.Builds,
                _ => null,
            };
        }
    }
}