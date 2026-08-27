
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ProfilesGetCollectionFilterProfileStateItem
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Invalid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProfilesGetCollectionFilterProfileStateItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProfilesGetCollectionFilterProfileStateItem value)
        {
            return value switch
            {
                ProfilesGetCollectionFilterProfileStateItem.Active => "ACTIVE",
                ProfilesGetCollectionFilterProfileStateItem.Invalid => "INVALID",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProfilesGetCollectionFilterProfileStateItem? ToEnum(string value)
        {
            return value switch
            {
                "ACTIVE" => ProfilesGetCollectionFilterProfileStateItem.Active,
                "INVALID" => ProfilesGetCollectionFilterProfileStateItem.Invalid,
                _ => null,
            };
        }
    }
}