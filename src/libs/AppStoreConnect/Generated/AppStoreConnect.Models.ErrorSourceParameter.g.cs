
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ErrorSourceParameter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parameter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSourceParameter" /> class.
        /// </summary>
        /// <param name="parameter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorSourceParameter(
            string parameter)
        {
            this.Parameter = parameter ?? throw new global::System.ArgumentNullException(nameof(parameter));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorSourceParameter" /> class.
        /// </summary>
        public ErrorSourceParameter()
        {
        }

    }
}