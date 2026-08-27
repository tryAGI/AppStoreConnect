
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdRelationshipsProfilesDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdRelationshipsProfilesDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdRelationshipsProfilesDataItemType value)
        {
            return value switch
            {
                BundleIdRelationshipsProfilesDataItemType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdRelationshipsProfilesDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "profiles" => BundleIdRelationshipsProfilesDataItemType.Profiles,
                _ => null,
            };
        }
    }
}