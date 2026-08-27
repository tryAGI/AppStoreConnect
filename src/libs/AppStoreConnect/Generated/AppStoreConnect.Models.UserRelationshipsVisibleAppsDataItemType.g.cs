
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserRelationshipsVisibleAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRelationshipsVisibleAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRelationshipsVisibleAppsDataItemType value)
        {
            return value switch
            {
                UserRelationshipsVisibleAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRelationshipsVisibleAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserRelationshipsVisibleAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}