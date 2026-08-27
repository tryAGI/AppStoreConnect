
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeliveryFileUploadOperation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        public string? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("length")]
        public long? Length { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public long? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requestHeaders")]
        public global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>? RequestHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiration")]
        public global::System.DateTime? Expiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partNumber")]
        public long? PartNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entityTag")]
        public string? EntityTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryFileUploadOperation" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="url"></param>
        /// <param name="length"></param>
        /// <param name="offset"></param>
        /// <param name="requestHeaders"></param>
        /// <param name="expiration"></param>
        /// <param name="partNumber"></param>
        /// <param name="entityTag"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeliveryFileUploadOperation(
            string? method,
            string? url,
            long? length,
            long? offset,
            global::System.Collections.Generic.IList<global::AppStoreConnect.HttpHeader>? requestHeaders,
            global::System.DateTime? expiration,
            long? partNumber,
            string? entityTag)
        {
            this.Method = method;
            this.Url = url;
            this.Length = length;
            this.Offset = offset;
            this.RequestHeaders = requestHeaders;
            this.Expiration = expiration;
            this.PartNumber = partNumber;
            this.EntityTag = entityTag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryFileUploadOperation" /> class.
        /// </summary>
        public DeliveryFileUploadOperation()
        {
        }

    }
}