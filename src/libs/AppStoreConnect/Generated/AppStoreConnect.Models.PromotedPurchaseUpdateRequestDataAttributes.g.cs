
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PromotedPurchaseUpdateRequestDataAttributes
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="visibleForAllUsers"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotedPurchaseUpdateRequestDataAttributes(
            bool? visibleForAllUsers,
            bool? enabled)
        {
            this.VisibleForAllUsers = visibleForAllUsers;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotedPurchaseUpdateRequestDataAttributes" /> class.
        /// </summary>
        public PromotedPurchaseUpdateRequestDataAttributes()
        {
        }

    }
}