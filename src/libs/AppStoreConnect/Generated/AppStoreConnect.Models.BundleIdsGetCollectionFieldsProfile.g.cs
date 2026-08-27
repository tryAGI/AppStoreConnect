
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsGetCollectionFieldsProfile
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
    public static class BundleIdsGetCollectionFieldsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsGetCollectionFieldsProfile value)
        {
            return value switch
            {
                BundleIdsGetCollectionFieldsProfile.BundleId => "bundleId",
                BundleIdsGetCollectionFieldsProfile.Certificates => "certificates",
                BundleIdsGetCollectionFieldsProfile.CreatedDate => "createdDate",
                BundleIdsGetCollectionFieldsProfile.Devices => "devices",
                BundleIdsGetCollectionFieldsProfile.ExpirationDate => "expirationDate",
                BundleIdsGetCollectionFieldsProfile.Name => "name",
                BundleIdsGetCollectionFieldsProfile.Platform => "platform",
                BundleIdsGetCollectionFieldsProfile.ProfileContent => "profileContent",
                BundleIdsGetCollectionFieldsProfile.ProfileState => "profileState",
                BundleIdsGetCollectionFieldsProfile.ProfileType => "profileType",
                BundleIdsGetCollectionFieldsProfile.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsGetCollectionFieldsProfile? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => BundleIdsGetCollectionFieldsProfile.BundleId,
                "certificates" => BundleIdsGetCollectionFieldsProfile.Certificates,
                "createdDate" => BundleIdsGetCollectionFieldsProfile.CreatedDate,
                "devices" => BundleIdsGetCollectionFieldsProfile.Devices,
                "expirationDate" => BundleIdsGetCollectionFieldsProfile.ExpirationDate,
                "name" => BundleIdsGetCollectionFieldsProfile.Name,
                "platform" => BundleIdsGetCollectionFieldsProfile.Platform,
                "profileContent" => BundleIdsGetCollectionFieldsProfile.ProfileContent,
                "profileState" => BundleIdsGetCollectionFieldsProfile.ProfileState,
                "profileType" => BundleIdsGetCollectionFieldsProfile.ProfileType,
                "uuid" => BundleIdsGetCollectionFieldsProfile.Uuid,
                _ => null,
            };
        }
    }
}