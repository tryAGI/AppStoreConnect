
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetCollectionFieldsProfile
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
    public static class ProfilesGetCollectionFieldsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFieldsProfile value)
        {
            return value switch
            {
                ProfilesGetCollectionFieldsProfile.BundleId => "bundleId",
                ProfilesGetCollectionFieldsProfile.Certificates => "certificates",
                ProfilesGetCollectionFieldsProfile.CreatedDate => "createdDate",
                ProfilesGetCollectionFieldsProfile.Devices => "devices",
                ProfilesGetCollectionFieldsProfile.ExpirationDate => "expirationDate",
                ProfilesGetCollectionFieldsProfile.Name => "name",
                ProfilesGetCollectionFieldsProfile.Platform => "platform",
                ProfilesGetCollectionFieldsProfile.ProfileContent => "profileContent",
                ProfilesGetCollectionFieldsProfile.ProfileState => "profileState",
                ProfilesGetCollectionFieldsProfile.ProfileType => "profileType",
                ProfilesGetCollectionFieldsProfile.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFieldsProfile? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => ProfilesGetCollectionFieldsProfile.BundleId,
                "certificates" => ProfilesGetCollectionFieldsProfile.Certificates,
                "createdDate" => ProfilesGetCollectionFieldsProfile.CreatedDate,
                "devices" => ProfilesGetCollectionFieldsProfile.Devices,
                "expirationDate" => ProfilesGetCollectionFieldsProfile.ExpirationDate,
                "name" => ProfilesGetCollectionFieldsProfile.Name,
                "platform" => ProfilesGetCollectionFieldsProfile.Platform,
                "profileContent" => ProfilesGetCollectionFieldsProfile.ProfileContent,
                "profileState" => ProfilesGetCollectionFieldsProfile.ProfileState,
                "profileType" => ProfilesGetCollectionFieldsProfile.ProfileType,
                "uuid" => ProfilesGetCollectionFieldsProfile.Uuid,
                _ => null,
            };
        }
    }
}