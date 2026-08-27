
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppAttributesContentRightsDeclaration
    {
        /// <summary>
        /// 
        /// </summary>
        DoesNotUseThirdPartyContent,
        /// <summary>
        /// 
        /// </summary>
        UsesThirdPartyContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAttributesContentRightsDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAttributesContentRightsDeclaration value)
        {
            return value switch
            {
                AppAttributesContentRightsDeclaration.DoesNotUseThirdPartyContent => "DOES_NOT_USE_THIRD_PARTY_CONTENT",
                AppAttributesContentRightsDeclaration.UsesThirdPartyContent => "USES_THIRD_PARTY_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAttributesContentRightsDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "DOES_NOT_USE_THIRD_PARTY_CONTENT" => AppAttributesContentRightsDeclaration.DoesNotUseThirdPartyContent,
                "USES_THIRD_PARTY_CONTENT" => AppAttributesContentRightsDeclaration.UsesThirdPartyContent,
                _ => null,
            };
        }
    }
}