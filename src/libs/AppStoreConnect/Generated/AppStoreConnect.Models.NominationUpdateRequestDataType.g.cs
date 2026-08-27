
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum NominationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        Nominations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class NominationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this NominationUpdateRequestDataType value)
        {
            return value switch
            {
                NominationUpdateRequestDataType.Nominations => "nominations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static NominationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "nominations" => NominationUpdateRequestDataType.Nominations,
                _ => null,
            };
        }
    }
}