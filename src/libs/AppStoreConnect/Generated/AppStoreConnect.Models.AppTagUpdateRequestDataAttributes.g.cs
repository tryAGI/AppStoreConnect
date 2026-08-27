
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppTagUpdateRequestDataAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibleInAppStore")]
        public bool? VisibleInAppStore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTagUpdateRequestDataAttributes" /> class.
        /// </summary>
        /// <param name="visibleInAppStore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppTagUpdateRequestDataAttributes(
            bool? visibleInAppStore)
        {
            this.VisibleInAppStore = visibleInAppStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTagUpdateRequestDataAttributes" /> class.
        /// </summary>
        public AppTagUpdateRequestDataAttributes()
        {
        }

    }
}