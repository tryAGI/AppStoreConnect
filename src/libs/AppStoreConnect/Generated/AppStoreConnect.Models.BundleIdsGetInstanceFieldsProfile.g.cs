
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BundleIdsGetInstanceFieldsProfile
    {
        /// <summary>
        /// 
        /// </summary>
        BundleId,
        /// <summary>
        /// 
        /// </summary>
        Certificates,
        /// <summary>
        /// 
        /// </summary>
        CreatedDate,
        /// <summary>
        /// 
        /// </summary>
        Devices,
        /// <summary>
        /// 
        /// </summary>
        ExpirationDate,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        Platform,
        /// <summary>
        /// 
        /// </summary>
        ProfileContent,
        /// <summary>
        /// 
        /// </summary>
        ProfileState,
        /// <summary>
        /// 
        /// </summary>
        ProfileType,
        /// <summary>
        /// 
        /// </summary>
        Uuid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BundleIdsGetInstanceFieldsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetInstanceFieldsProfile value)
        {
            return value switch
            {
                BundleIdsGetInstanceFieldsProfile.BundleId => "bundleId",
                BundleIdsGetInstanceFieldsProfile.Certificates => "certificates",
                BundleIdsGetInstanceFieldsProfile.CreatedDate => "createdDate",
                BundleIdsGetInstanceFieldsProfile.Devices => "devices",
                BundleIdsGetInstanceFieldsProfile.ExpirationDate => "expirationDate",
                BundleIdsGetInstanceFieldsProfile.Name => "name",
                BundleIdsGetInstanceFieldsProfile.Platform => "platform",
                BundleIdsGetInstanceFieldsProfile.ProfileContent => "profileContent",
                BundleIdsGetInstanceFieldsProfile.ProfileState => "profileState",
                BundleIdsGetInstanceFieldsProfile.ProfileType => "profileType",
                BundleIdsGetInstanceFieldsProfile.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetInstanceFieldsProfile? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => BundleIdsGetInstanceFieldsProfile.BundleId,
                "certificates" => BundleIdsGetInstanceFieldsProfile.Certificates,
                "createdDate" => BundleIdsGetInstanceFieldsProfile.CreatedDate,
                "devices" => BundleIdsGetInstanceFieldsProfile.Devices,
                "expirationDate" => BundleIdsGetInstanceFieldsProfile.ExpirationDate,
                "name" => BundleIdsGetInstanceFieldsProfile.Name,
                "platform" => BundleIdsGetInstanceFieldsProfile.Platform,
                "profileContent" => BundleIdsGetInstanceFieldsProfile.ProfileContent,
                "profileState" => BundleIdsGetInstanceFieldsProfile.ProfileState,
                "profileType" => BundleIdsGetInstanceFieldsProfile.ProfileType,
                "uuid" => BundleIdsGetInstanceFieldsProfile.Uuid,
                _ => null,
            };
        }
    }
}