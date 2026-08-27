
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum NominationsResponseIncludedItemDiscriminatorType
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
    public static class NominationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                NominationsResponseIncludedItemDiscriminatorType.Actors => "actors",
                NominationsResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                NominationsResponseIncludedItemDiscriminatorType.Apps => "apps",
                NominationsResponseIncludedItemDiscriminatorType.Territories => "territories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "actors" => NominationsResponseIncludedItemDiscriminatorType.Actors,
                "appEvents" => NominationsResponseIncludedItemDiscriminatorType.AppEvents,
                "apps" => NominationsResponseIncludedItemDiscriminatorType.Apps,
                "territories" => NominationsResponseIncludedItemDiscriminatorType.Territories,
                _ => null,
            };
        }
    }
}