
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsBuildsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsBuildsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsBuildsDataItemType value)
        {
            return value switch
            {
                AppRelationshipsBuildsDataItemType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsBuildsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "builds" => AppRelationshipsBuildsDataItemType.Builds,
                _ => null,
            };
        }
    }
}