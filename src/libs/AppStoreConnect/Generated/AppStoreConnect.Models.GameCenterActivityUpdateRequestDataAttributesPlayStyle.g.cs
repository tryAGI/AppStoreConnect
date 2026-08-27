
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityUpdateRequestDataAttributesPlayStyle
    {
        /// <summary>
        /// 
        /// </summary>
        Asynchronous,
        /// <summary>
        /// 
        /// </summary>
        Synchronous,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterActivityUpdateRequestDataAttributesPlayStyleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityUpdateRequestDataAttributesPlayStyle value)
        {
            return value switch
            {
                GameCenterActivityUpdateRequestDataAttributesPlayStyle.Asynchronous => "ASYNCHRONOUS",
                GameCenterActivityUpdateRequestDataAttributesPlayStyle.Synchronous => "SYNCHRONOUS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityUpdateRequestDataAttributesPlayStyle? ToEnum(string value)
        {
            return value switch
            {
                "ASYNCHRONOUS" => GameCenterActivityUpdateRequestDataAttributesPlayStyle.Asynchronous,
                "SYNCHRONOUS" => GameCenterActivityUpdateRequestDataAttributesPlayStyle.Synchronous,
                _ => null,
            };
        }
    }
}