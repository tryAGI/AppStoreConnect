
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdProfilesLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdProfilesLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdProfilesLinkagesResponseDataItemType value)
        {
            return value switch
            {
                BundleIdProfilesLinkagesResponseDataItemType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdProfilesLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "profiles" => BundleIdProfilesLinkagesResponseDataItemType.Profiles,
                _ => null,
            };
        }
    }
}