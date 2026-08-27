
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsResponseIncludedItemDiscriminatorType
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
    public static class PreReleaseVersionsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                PreReleaseVersionsResponseIncludedItemDiscriminatorType.Apps => "apps",
                PreReleaseVersionsResponseIncludedItemDiscriminatorType.Builds => "builds",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "apps" => PreReleaseVersionsResponseIncludedItemDiscriminatorType.Apps,
                "builds" => PreReleaseVersionsResponseIncludedItemDiscriminatorType.Builds,
                _ => null,
            };
        }
    }
}