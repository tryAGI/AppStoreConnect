
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType
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
    public static class AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType value)
        {
            return value switch
            {
                AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Fax => "FAX",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Landline => "LANDLINE",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Mobile => "MOBILE",
                AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Tollfree => "TOLLFREE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType? ToEnum(string value)
        {
            return value switch
            {
                "FAX" => AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Fax,
                "LANDLINE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Landline,
                "MOBILE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Mobile,
                "TOLLFREE" => AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType.Tollfree,
                _ => null,
            };
        }
    }
}