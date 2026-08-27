
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BuildUploadAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfBundleShortVersionString")]
        public string? CfBundleShortVersionString { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfBundleVersion")]
        public string? CfBundleVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdDate")]
        public global::System.DateTime? CreatedDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public global::AppStoreConnect.BuildUploadAttributesState? State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("platform")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::AppStoreConnect.JsonConverters.PlatformJsonConverter))]
        public global::AppStoreConnect.Platform? Platform { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploadedDate")]
        public global::System.DateTime? UploadedDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadAttributes" /> class.
        /// </summary>
        /// <param name="cfBundleShortVersionString"></param>
        /// <param name="cfBundleVersion"></param>
        /// <param name="createdDate"></param>
        /// <param name="state"></param>
        /// <param name="platform"></param>
        /// <param name="uploadedDate"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BuildUploadAttributes(
            string? cfBundleShortVersionString,
            string? cfBundleVersion,
            global::System.DateTime? createdDate,
            global::AppStoreConnect.BuildUploadAttributesState? state,
            global::AppStoreConnect.Platform? platform,
            global::System.DateTime? uploadedDate)
        {
            this.CfBundleShortVersionString = cfBundleShortVersionString;
            this.CfBundleVersion = cfBundleVersion;
            this.CreatedDate = createdDate;
            this.State = state;
            this.Platform = platform;
            this.UploadedDate = uploadedDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildUploadAttributes" /> class.
        /// </summary>
        public BuildUploadAttributes()
        {
        }

    }
}