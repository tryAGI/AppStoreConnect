
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AccessibilityDeclarationCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deviceFamily")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.DeviceFamilyJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::AppStoreConnect.DeviceFamily DeviceFamily { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsAudioDescriptions")]
        public bool? SupportsAudioDescriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsCaptions")]
        public bool? SupportsCaptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsDarkInterface")]
        public bool? SupportsDarkInterface { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsDifferentiateWithoutColorAlone")]
        public bool? SupportsDifferentiateWithoutColorAlone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsLargerText")]
        public bool? SupportsLargerText { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsReducedMotion")]
        public bool? SupportsReducedMotion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsSufficientContrast")]
        public bool? SupportsSufficientContrast { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsVoiceControl")]
        public bool? SupportsVoiceControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supportsVoiceover")]
        public bool? SupportsVoiceover { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessibilityDeclarationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="deviceFamily"></param>
        /// <param name="supportsAudioDescriptions"></param>
        /// <param name="supportsCaptions"></param>
        /// <param name="supportsDarkInterface"></param>
        /// <param name="supportsDifferentiateWithoutColorAlone"></param>
        /// <param name="supportsLargerText"></param>
        /// <param name="supportsReducedMotion"></param>
        /// <param name="supportsSufficientContrast"></param>
        /// <param name="supportsVoiceControl"></param>
        /// <param name="supportsVoiceover"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessibilityDeclarationCreateRequestDataAttributes(
            global::AppStoreConnect.DeviceFamily deviceFamily,
            bool? supportsAudioDescriptions,
            bool? supportsCaptions,
            bool? supportsDarkInterface,
            bool? supportsDifferentiateWithoutColorAlone,
            bool? supportsLargerText,
            bool? supportsReducedMotion,
            bool? supportsSufficientContrast,
            bool? supportsVoiceControl,
            bool? supportsVoiceover)
        {
            this.DeviceFamily = deviceFamily;
            this.SupportsAudioDescriptions = supportsAudioDescriptions;
            this.SupportsCaptions = supportsCaptions;
            this.SupportsDarkInterface = supportsDarkInterface;
            this.SupportsDifferentiateWithoutColorAlone = supportsDifferentiateWithoutColorAlone;
            this.SupportsLargerText = supportsLargerText;
            this.SupportsReducedMotion = supportsReducedMotion;
            this.SupportsSufficientContrast = supportsSufficientContrast;
            this.SupportsVoiceControl = supportsVoiceControl;
            this.SupportsVoiceover = supportsVoiceover;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessibilityDeclarationCreateRequestDataAttributes" /> class.
        /// </summary>
        public AccessibilityDeclarationCreateRequestDataAttributes()
        {
        }

    }
}