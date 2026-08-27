
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Apps,
        /// <summary>
        /// 
        /// </summary>
        BundleIdCapabilities,
        /// <summary>
        /// 
        /// </summary>
        Profiles,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BundleIdsResponseIncludedItemDiscriminatorType.Apps => "apps",
                BundleIdsResponseIncludedItemDiscriminatorType.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdsResponseIncludedItemDiscriminatorType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BundleIdsResponseIncludedItemDiscriminatorType.Apps,
                "bundleIdCapabilities" => BundleIdsResponseIncludedItemDiscriminatorType.BundleIdCapabilities,
                "profiles" => BundleIdsResponseIncludedItemDiscriminatorType.Profiles,
                _ => null,
            };
        }
    }
}