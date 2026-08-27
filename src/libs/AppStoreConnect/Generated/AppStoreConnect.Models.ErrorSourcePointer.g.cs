
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorSourcePointer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pointer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Pointer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSourcePointer" /> class.
        /// </summary>
        /// <param name="pointer"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorSourcePointer(
            string pointer)
        {
            this.Pointer = pointer ?? throw new global::System.ArgumentNullException(nameof(pointer));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSourcePointer" /> class.
        /// </summary>
        public ErrorSourcePointer()
        {
        }

    }
}