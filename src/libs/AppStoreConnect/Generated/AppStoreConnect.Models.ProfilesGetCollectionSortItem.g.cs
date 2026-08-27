
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProfilesGetCollectionSortItem
    {
        /// <summary>
        /// 
        /// </summary>
        Minusid,
        /// <summary>
        /// 
        /// </summary>
        Minusname,
        /// <summary>
        /// 
        /// </summary>
        MinusprofileState,
        /// <summary>
        /// 
        /// </summary>
        MinusprofileType,
        /// <summary>
        /// 
        /// </summary>
        Id,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        ProfileState,
        /// <summary>
        /// 
        /// </summary>
        ProfileType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesGetCollectionSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionSortItem value)
        {
            return value switch
            {
                ProfilesGetCollectionSortItem.Minusid => "-id",
                ProfilesGetCollectionSortItem.Minusname => "-name",
                ProfilesGetCollectionSortItem.MinusprofileState => "-profileState",
                ProfilesGetCollectionSortItem.MinusprofileType => "-profileType",
                ProfilesGetCollectionSortItem.Id => "id",
                ProfilesGetCollectionSortItem.Name => "name",
                ProfilesGetCollectionSortItem.ProfileState => "profileState",
                ProfilesGetCollectionSortItem.ProfileType => "profileType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-id" => ProfilesGetCollectionSortItem.Minusid,
                "-name" => ProfilesGetCollectionSortItem.Minusname,
                "-profileState" => ProfilesGetCollectionSortItem.MinusprofileState,
                "-profileType" => ProfilesGetCollectionSortItem.MinusprofileType,
                "id" => ProfilesGetCollectionSortItem.Id,
                "name" => ProfilesGetCollectionSortItem.Name,
                "profileState" => ProfilesGetCollectionSortItem.ProfileState,
                "profileType" => ProfilesGetCollectionSortItem.ProfileType,
                _ => null,
            };
        }
    }
}