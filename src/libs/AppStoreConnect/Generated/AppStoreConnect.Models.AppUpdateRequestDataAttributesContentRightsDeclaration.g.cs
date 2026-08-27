
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppUpdateRequestDataAttributesContentRightsDeclaration
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
    public static class AppUpdateRequestDataAttributesContentRightsDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppUpdateRequestDataAttributesContentRightsDeclaration value)
        {
            return value switch
            {
                AppUpdateRequestDataAttributesContentRightsDeclaration.DoesNotUseThirdPartyContent => "DOES_NOT_USE_THIRD_PARTY_CONTENT",
                AppUpdateRequestDataAttributesContentRightsDeclaration.UsesThirdPartyContent => "USES_THIRD_PARTY_CONTENT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppUpdateRequestDataAttributesContentRightsDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "DOES_NOT_USE_THIRD_PARTY_CONTENT" => AppUpdateRequestDataAttributesContentRightsDeclaration.DoesNotUseThirdPartyContent,
                "USES_THIRD_PARTY_CONTENT" => AppUpdateRequestDataAttributesContentRightsDeclaration.UsesThirdPartyContent,
                _ => null,
            };
        }
    }
}