
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetInstanceFieldsProfile
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
    public static class ProfilesGetInstanceFieldsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetInstanceFieldsProfile value)
        {
            return value switch
            {
                ProfilesGetInstanceFieldsProfile.BundleId => "bundleId",
                ProfilesGetInstanceFieldsProfile.Certificates => "certificates",
                ProfilesGetInstanceFieldsProfile.CreatedDate => "createdDate",
                ProfilesGetInstanceFieldsProfile.Devices => "devices",
                ProfilesGetInstanceFieldsProfile.ExpirationDate => "expirationDate",
                ProfilesGetInstanceFieldsProfile.Name => "name",
                ProfilesGetInstanceFieldsProfile.Platform => "platform",
                ProfilesGetInstanceFieldsProfile.ProfileContent => "profileContent",
                ProfilesGetInstanceFieldsProfile.ProfileState => "profileState",
                ProfilesGetInstanceFieldsProfile.ProfileType => "profileType",
                ProfilesGetInstanceFieldsProfile.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetInstanceFieldsProfile? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => ProfilesGetInstanceFieldsProfile.BundleId,
                "certificates" => ProfilesGetInstanceFieldsProfile.Certificates,
                "createdDate" => ProfilesGetInstanceFieldsProfile.CreatedDate,
                "devices" => ProfilesGetInstanceFieldsProfile.Devices,
                "expirationDate" => ProfilesGetInstanceFieldsProfile.ExpirationDate,
                "name" => ProfilesGetInstanceFieldsProfile.Name,
                "platform" => ProfilesGetInstanceFieldsProfile.Platform,
                "profileContent" => ProfilesGetInstanceFieldsProfile.ProfileContent,
                "profileState" => ProfilesGetInstanceFieldsProfile.ProfileState,
                "profileType" => ProfilesGetInstanceFieldsProfile.ProfileType,
                "uuid" => ProfilesGetInstanceFieldsProfile.Uuid,
                _ => null,
            };
        }
    }
}