
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum UserUpdateRequestDataRelationshipsVisibleAppsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserUpdateRequestDataRelationshipsVisibleAppsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserUpdateRequestDataRelationshipsVisibleAppsDataItemType value)
        {
            return value switch
            {
                UserUpdateRequestDataRelationshipsVisibleAppsDataItemType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserUpdateRequestDataRelationshipsVisibleAppsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => UserUpdateRequestDataRelationshipsVisibleAppsDataItemType.Apps,
                _ => null,
            };
        }
    }
}