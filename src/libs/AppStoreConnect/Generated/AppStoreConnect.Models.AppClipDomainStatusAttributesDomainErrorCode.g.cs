
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppClipDomainStatusAttributesDomainErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        BadHttpResponse,
        /// <summary>
        /// 
        /// </summary>
        BadJsonContent,
        /// <summary>
        /// 
        /// </summary>
        BadPkcs7Signature,
        /// <summary>
        /// 
        /// </summary>
        CannotReachAasaFile,
        /// <summary>
        /// 
        /// </summary>
        CrossSiteRedirectsForbidden,
        /// <summary>
        /// 
        /// </summary>
        DnsError,
        /// <summary>
        /// 
        /// </summary>
        InsecureRedirectsForbidden,
        /// <summary>
        /// 
        /// </summary>
        InvalidEntitlementMissingSection,
        /// <summary>
        /// 
        /// </summary>
        InvalidEntitlementSyntaxError,
        /// <summary>
        /// 
        /// </summary>
        InvalidEntitlementUnhandledSection,
        /// <summary>
        /// 
        /// </summary>
        InvalidEntitlementUnknownId,
        /// <summary>
        /// 
        /// </summary>
        NetworkError,
        /// <summary>
        /// 
        /// </summary>
        NetworkErrorTemporary,
        /// <summary>
        /// 
        /// </summary>
        OtherError,
        /// <summary>
        /// 
        /// </summary>
        Timeout,
        /// <summary>
        /// 
        /// </summary>
        TlsError,
        /// <summary>
        /// 
        /// </summary>
        TooManyRedirects,
        /// <summary>
        /// 
        /// </summary>
        UnexpectedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipDomainStatusAttributesDomainErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipDomainStatusAttributesDomainErrorCode value)
        {
            return value switch
            {
                AppClipDomainStatusAttributesDomainErrorCode.BadHttpResponse => "BAD_HTTP_RESPONSE",
                AppClipDomainStatusAttributesDomainErrorCode.BadJsonContent => "BAD_JSON_CONTENT",
                AppClipDomainStatusAttributesDomainErrorCode.BadPkcs7Signature => "BAD_PKCS7_SIGNATURE",
                AppClipDomainStatusAttributesDomainErrorCode.CannotReachAasaFile => "CANNOT_REACH_AASA_FILE",
                AppClipDomainStatusAttributesDomainErrorCode.CrossSiteRedirectsForbidden => "CROSS_SITE_REDIRECTS_FORBIDDEN",
                AppClipDomainStatusAttributesDomainErrorCode.DnsError => "DNS_ERROR",
                AppClipDomainStatusAttributesDomainErrorCode.InsecureRedirectsForbidden => "INSECURE_REDIRECTS_FORBIDDEN",
                AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementMissingSection => "INVALID_ENTITLEMENT_MISSING_SECTION",
                AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementSyntaxError => "INVALID_ENTITLEMENT_SYNTAX_ERROR",
                AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementUnhandledSection => "INVALID_ENTITLEMENT_UNHANDLED_SECTION",
                AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementUnknownId => "INVALID_ENTITLEMENT_UNKNOWN_ID",
                AppClipDomainStatusAttributesDomainErrorCode.NetworkError => "NETWORK_ERROR",
                AppClipDomainStatusAttributesDomainErrorCode.NetworkErrorTemporary => "NETWORK_ERROR_TEMPORARY",
                AppClipDomainStatusAttributesDomainErrorCode.OtherError => "OTHER_ERROR",
                AppClipDomainStatusAttributesDomainErrorCode.Timeout => "TIMEOUT",
                AppClipDomainStatusAttributesDomainErrorCode.TlsError => "TLS_ERROR",
                AppClipDomainStatusAttributesDomainErrorCode.TooManyRedirects => "TOO_MANY_REDIRECTS",
                AppClipDomainStatusAttributesDomainErrorCode.UnexpectedError => "UNEXPECTED_ERROR",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipDomainStatusAttributesDomainErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "BAD_HTTP_RESPONSE" => AppClipDomainStatusAttributesDomainErrorCode.BadHttpResponse,
                "BAD_JSON_CONTENT" => AppClipDomainStatusAttributesDomainErrorCode.BadJsonContent,
                "BAD_PKCS7_SIGNATURE" => AppClipDomainStatusAttributesDomainErrorCode.BadPkcs7Signature,
                "CANNOT_REACH_AASA_FILE" => AppClipDomainStatusAttributesDomainErrorCode.CannotReachAasaFile,
                "CROSS_SITE_REDIRECTS_FORBIDDEN" => AppClipDomainStatusAttributesDomainErrorCode.CrossSiteRedirectsForbidden,
                "DNS_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.DnsError,
                "INSECURE_REDIRECTS_FORBIDDEN" => AppClipDomainStatusAttributesDomainErrorCode.InsecureRedirectsForbidden,
                "INVALID_ENTITLEMENT_MISSING_SECTION" => AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementMissingSection,
                "INVALID_ENTITLEMENT_SYNTAX_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementSyntaxError,
                "INVALID_ENTITLEMENT_UNHANDLED_SECTION" => AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementUnhandledSection,
                "INVALID_ENTITLEMENT_UNKNOWN_ID" => AppClipDomainStatusAttributesDomainErrorCode.InvalidEntitlementUnknownId,
                "NETWORK_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.NetworkError,
                "NETWORK_ERROR_TEMPORARY" => AppClipDomainStatusAttributesDomainErrorCode.NetworkErrorTemporary,
                "OTHER_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.OtherError,
                "TIMEOUT" => AppClipDomainStatusAttributesDomainErrorCode.Timeout,
                "TLS_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.TlsError,
                "TOO_MANY_REDIRECTS" => AppClipDomainStatusAttributesDomainErrorCode.TooManyRedirects,
                "UNEXPECTED_ERROR" => AppClipDomainStatusAttributesDomainErrorCode.UnexpectedError,
                _ => null,
            };
        }
    }
}