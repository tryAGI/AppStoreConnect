
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CiXcodeVersionAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("testDestinations")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>? TestDestinations { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributes" /> class.
        /// </summary>
        /// <param name="version"></param>
        /// <param name="name"></param>
        /// <param name="testDestinations"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CiXcodeVersionAttributes(
            string? version,
            string? name,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionAttributesTestDestination>? testDestinations)
        {
            this.Version = version;
            this.Name = name;
            this.TestDestinations = testDestinations;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CiXcodeVersionAttributes" /> class.
        /// </summary>
        public CiXcodeVersionAttributes()
        {
        }

    }
}