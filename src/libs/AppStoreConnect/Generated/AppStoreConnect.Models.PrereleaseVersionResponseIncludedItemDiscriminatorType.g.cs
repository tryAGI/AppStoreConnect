
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PrereleaseVersionResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        Builds,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PrereleaseVersionResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PrereleaseVersionResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                PrereleaseVersionResponseIncludedItemDiscriminatorType.Apps => "apps",
                PrereleaseVersionResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PrereleaseVersionResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => PrereleaseVersionResponseIncludedItemDiscriminatorType.Apps,
                "builds" => PrereleaseVersionResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}