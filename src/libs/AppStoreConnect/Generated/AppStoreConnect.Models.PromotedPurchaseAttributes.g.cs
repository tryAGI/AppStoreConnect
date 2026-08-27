
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotedPurchaseAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleForAllUsers")]
        public bool? VisibleForAllUsers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PromotedPurchaseAttributesStateJsonConverter))]
        public global::AppStoreConnect.PromotedPurchaseAttributesState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseAttributes" /> class.
        /// </summary>
        /// <param name="visibleForAllUsers"></param>
        /// <param name="enabled"></param>
        /// <param name="state"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotedPurchaseAttributes(
            bool? visibleForAllUsers,
            bool? enabled,
            global::AppStoreConnect.PromotedPurchaseAttributesState? state)
        {
            this.VisibleForAllUsers = visibleForAllUsers;
            this.Enabled = enabled;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseAttributes" /> class.
        /// </summary>
        public PromotedPurchaseAttributes()
        {
        }

    }
}