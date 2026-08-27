
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration
    {
        /// <summary>
        ///
        /// </summary>
        DeviceFamily,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        SupportsAudioDescriptions,
        /// <summary>
        ///
        /// </summary>
        SupportsCaptions,
        /// <summary>
        ///
        /// </summary>
        SupportsDarkInterface,
        /// <summary>
        ///
        /// </summary>
        SupportsDifferentiateWithoutColorAlone,
        /// <summary>
        ///
        /// </summary>
        SupportsLargerText,
        /// <summary>
        ///
        /// </summary>
        SupportsReducedMotion,
        /// <summary>
        ///
        /// </summary>
        SupportsSufficientContrast,
        /// <summary>
        ///
        /// </summary>
        SupportsVoiceControl,
        /// <summary>
        ///
        /// </summary>
        SupportsVoiceover,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclarationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration value)
        {
            return value switch
            {
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.DeviceFamily => "deviceFamily",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.State => "state",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsAudioDescriptions => "supportsAudioDescriptions",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsCaptions => "supportsCaptions",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsDarkInterface => "supportsDarkInterface",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsDifferentiateWithoutColorAlone => "supportsDifferentiateWithoutColorAlone",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsLargerText => "supportsLargerText",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsReducedMotion => "supportsReducedMotion",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsSufficientContrast => "supportsSufficientContrast",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsVoiceControl => "supportsVoiceControl",
                AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsVoiceover => "supportsVoiceover",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration? ToEnum(string value)
        {
            return value switch
            {
                "deviceFamily" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.DeviceFamily,
                "state" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.State,
                "supportsAudioDescriptions" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsAudioDescriptions,
                "supportsCaptions" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsCaptions,
                "supportsDarkInterface" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsDarkInterface,
                "supportsDifferentiateWithoutColorAlone" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsDifferentiateWithoutColorAlone,
                "supportsLargerText" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsLargerText,
                "supportsReducedMotion" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsReducedMotion,
                "supportsSufficientContrast" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsSufficientContrast,
                "supportsVoiceControl" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsVoiceControl,
                "supportsVoiceover" => AccessibilityDeclarationsGetInstanceFieldsAccessibilityDeclaration.SupportsVoiceover,
                _ => null,
            };
        }
    }
}