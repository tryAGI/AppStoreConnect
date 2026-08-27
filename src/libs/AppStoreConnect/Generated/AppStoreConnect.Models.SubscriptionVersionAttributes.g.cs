
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SubscriptionVersionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public int? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.SubscriptionVersionAttributesStateJsonConverter))]
        public global::AppStoreConnect.SubscriptionVersionAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersionAttributes" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SubscriptionVersionAttributes(
            int? version,
            global::AppStoreConnect.SubscriptionVersionAttributesState? state)
        {
            this.Version = version;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionVersionAttributes" /> class.
        /// </summary>
        public SubscriptionVersionAttributes()
        {
        }

    }
}