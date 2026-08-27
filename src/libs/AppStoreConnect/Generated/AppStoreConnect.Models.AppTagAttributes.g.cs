
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppTagAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        /// Initializes a new instance of the <see cref="AppTagAttributes" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="visibleInAppStore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppTagAttributes(
            string? name,
            bool? visibleInAppStore)
        {
            this.Name = name;
            this.VisibleInAppStore = visibleInAppStore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppTagAttributes" /> class.
        /// </summary>
        public AppTagAttributes()
        {
        }

    }
}