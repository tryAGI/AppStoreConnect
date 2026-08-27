
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildIconType
    {
        /// <summary>
        /// 
        /// </summary>
        BuildIcons,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildIconTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildIconType value)
        {
            return value switch
            {
                BuildIconType.BuildIcons => "buildIcons",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildIconType? ToEnum(string value)
        {
            return value switch
            {
                "buildIcons" => BuildIconType.BuildIcons,
                _ => null,
            };
        }
    }
}