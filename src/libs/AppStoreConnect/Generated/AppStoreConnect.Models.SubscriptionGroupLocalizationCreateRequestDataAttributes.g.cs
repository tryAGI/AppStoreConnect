
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionGroupLocalizationCreateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customAppName")]
        public string? CustomAppName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("locale")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Locale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="locale"></param>
        /// <param name="customAppName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionGroupLocalizationCreateRequestDataAttributes(
            string name,
            string locale,
            string? customAppName)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CustomAppName = customAppName;
            this.Locale = locale ?? throw new global::System.ArgumentNullException(nameof(locale));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionGroupLocalizationCreateRequestDataAttributes" /> class.
        /// </summary>
        public SubscriptionGroupLocalizationCreateRequestDataAttributes()
        {
        }

    }
}