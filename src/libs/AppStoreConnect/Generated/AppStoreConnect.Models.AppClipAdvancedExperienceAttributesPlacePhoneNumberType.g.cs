
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceAttributesPlacePhoneNumberType
    {
        /// <summary>
        ///
        /// </summary>
        Fax,
        /// <summary>
        ///
        /// </summary>
        Landline,
        /// <summary>
        ///
        /// </summary>
        Mobile,
        /// <summary>
        ///
        /// </summary>
        Tollfree,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppClipAdvancedExperienceAttributesPlacePhoneNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceAttributesPlacePhoneNumberType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Fax => "FAX",
                AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Landline => "LANDLINE",
                AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Mobile => "MOBILE",
                AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Tollfree => "TOLLFREE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceAttributesPlacePhoneNumberType? ToEnum(string value)
        {
            return value switch
            {
                "FAX" => AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Fax,
                "LANDLINE" => AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Landline,
                "MOBILE" => AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Mobile,
                "TOLLFREE" => AppClipAdvancedExperienceAttributesPlacePhoneNumberType.Tollfree,
                _ => null,
            };
        }
    }
}