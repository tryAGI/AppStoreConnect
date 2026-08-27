
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationAttributesState
    {
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Draft,
        /// <summary>
        ///
        /// </summary>
        Submitted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationAttributesStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationAttributesState value)
        {
            return value switch
            {
                NominationAttributesState.Archived => "ARCHIVED",
                NominationAttributesState.Draft => "DRAFT",
                NominationAttributesState.Submitted => "SUBMITTED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationAttributesState? ToEnum(string value)
        {
            return value switch
            {
                "ARCHIVED" => NominationAttributesState.Archived,
                "DRAFT" => NominationAttributesState.Draft,
                "SUBMITTED" => NominationAttributesState.Submitted,
                _ => null,
            };
        }
    }
}