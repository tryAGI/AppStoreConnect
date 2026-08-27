
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaTesterCreateRequestDataRelationshipsBuildsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTesterCreateRequestDataRelationshipsBuildsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTesterCreateRequestDataRelationshipsBuildsDataItemType value)
        {
            return value switch
            {
                BetaTesterCreateRequestDataRelationshipsBuildsDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTesterCreateRequestDataRelationshipsBuildsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => BetaTesterCreateRequestDataRelationshipsBuildsDataItemType.Builds,
                _ => null,
            };
        }
    }
}