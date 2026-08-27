
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InAppPurchaseLocalizationAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.InAppPurchaseLocalizationAttributesStateJsonConverter))]
        public global::AppStoreConnect.InAppPurchaseLocalizationAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseLocalizationAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="locale"></param>
        /// <param name="description"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InAppPurchaseLocalizationAttributes(
            string? name,
            string? locale,
            string? description,
            global::AppStoreConnect.InAppPurchaseLocalizationAttributesState? state)
        {
            this.Name = name;
            this.Locale = locale;
            this.Description = description;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InAppPurchaseLocalizationAttributes" /> class.
        /// </summary>
        public InAppPurchaseLocalizationAttributes()
        {
        }

    }
}