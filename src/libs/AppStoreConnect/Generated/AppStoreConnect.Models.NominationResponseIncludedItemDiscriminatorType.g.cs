
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Actors,
        /// <summary>
        ///
        /// </summary>
        AppEvents,
        /// <summary>
        ///
        /// </summary>
        Apps,
        /// <summary>
        ///
        /// </summary>
        Territories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                NominationResponseIncludedItemDiscriminatorType.Actors => "actors",
                NominationResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                NominationResponseIncludedItemDiscriminatorType.Apps => "apps",
                NominationResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => NominationResponseIncludedItemDiscriminatorType.Actors,
                "appEvents" => NominationResponseIncludedItemDiscriminatorType.AppEvents,
                "apps" => NominationResponseIncludedItemDiscriminatorType.Apps,
                "territories" => NominationResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}