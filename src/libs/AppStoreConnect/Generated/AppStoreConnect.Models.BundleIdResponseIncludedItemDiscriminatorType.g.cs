
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdResponseIncludedItemDiscriminatorType
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
    public static class BundleIdResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                BundleIdResponseIncludedItemDiscriminatorType.Apps => "apps",
                BundleIdResponseIncludedItemDiscriminatorType.BundleIdCapabilities => "bundleIdCapabilities",
                BundleIdResponseIncludedItemDiscriminatorType.Profiles => "profiles",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => BundleIdResponseIncludedItemDiscriminatorType.Apps,
                "bundleIdCapabilities" => BundleIdResponseIncludedItemDiscriminatorType.BundleIdCapabilities,
                "profiles" => BundleIdResponseIncludedItemDiscriminatorType.Profiles,
                _ => null,
            };
        }
    }
}