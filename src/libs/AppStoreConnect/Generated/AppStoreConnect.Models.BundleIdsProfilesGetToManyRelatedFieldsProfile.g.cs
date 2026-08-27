
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BundleIdsProfilesGetToManyRelatedFieldsProfile
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
    public static class BundleIdsProfilesGetToManyRelatedFieldsProfileExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BundleIdsProfilesGetToManyRelatedFieldsProfile value)
        {
            return value switch
            {
                BundleIdsProfilesGetToManyRelatedFieldsProfile.BundleId => "bundleId",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.Certificates => "certificates",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.CreatedDate => "createdDate",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.Devices => "devices",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.ExpirationDate => "expirationDate",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.Name => "name",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.Platform => "platform",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileContent => "profileContent",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileState => "profileState",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileType => "profileType",
                BundleIdsProfilesGetToManyRelatedFieldsProfile.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BundleIdsProfilesGetToManyRelatedFieldsProfile? ToEnum(string value)
        {
            return value switch
            {
                "bundleId" => BundleIdsProfilesGetToManyRelatedFieldsProfile.BundleId,
                "certificates" => BundleIdsProfilesGetToManyRelatedFieldsProfile.Certificates,
                "createdDate" => BundleIdsProfilesGetToManyRelatedFieldsProfile.CreatedDate,
                "devices" => BundleIdsProfilesGetToManyRelatedFieldsProfile.Devices,
                "expirationDate" => BundleIdsProfilesGetToManyRelatedFieldsProfile.ExpirationDate,
                "name" => BundleIdsProfilesGetToManyRelatedFieldsProfile.Name,
                "platform" => BundleIdsProfilesGetToManyRelatedFieldsProfile.Platform,
                "profileContent" => BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileContent,
                "profileState" => BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileState,
                "profileType" => BundleIdsProfilesGetToManyRelatedFieldsProfile.ProfileType,
                "uuid" => BundleIdsProfilesGetToManyRelatedFieldsProfile.Uuid,
                _ => null,
            };
        }
    }
}