
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionGroupLocalizationV2Attributes
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAppName")]
        public string? CustomAppName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        public string? Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationV2Attributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customAppName"></param>
        /// <param name="locale"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupLocalizationV2Attributes(
            string? name,
            string? customAppName,
            string? locale)
        {
            this.Name = name;
            this.CustomAppName = customAppName;
            this.Locale = locale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationV2Attributes" /> class.
        /// </summary>
        public SubscriptionGroupLocalizationV2Attributes()
        {
        }

    }
}