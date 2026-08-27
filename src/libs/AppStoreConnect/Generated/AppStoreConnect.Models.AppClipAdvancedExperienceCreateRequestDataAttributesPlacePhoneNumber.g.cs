
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        public string? Number { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberTypeJsonConverter))]
        public global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intent")]
        public string? Intent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber" /> class.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="type"></param>
        /// <param name="intent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber(
            string? number,
            global::AppStoreConnect.AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumberType? type,
            string? intent)
        {
            this.Number = number;
            this.Type = type;
            this.Intent = intent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber" /> class.
        /// </summary>
        public AppClipAdvancedExperienceCreateRequestDataAttributesPlacePhoneNumber()
        {
        }

    }
}