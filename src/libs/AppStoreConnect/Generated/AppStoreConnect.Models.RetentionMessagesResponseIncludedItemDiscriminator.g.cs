
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetentionMessagesResponseIncludedItemDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.RetentionMessagesResponseIncludedItemDiscriminatorTypeJsonConverter))]
        public global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessagesResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetentionMessagesResponseIncludedItemDiscriminator(
            global::AppStoreConnect.RetentionMessagesResponseIncludedItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionMessagesResponseIncludedItemDiscriminator" /> class.
        /// </summary>
        public RetentionMessagesResponseIncludedItemDiscriminator()
        {
        }

    }
}