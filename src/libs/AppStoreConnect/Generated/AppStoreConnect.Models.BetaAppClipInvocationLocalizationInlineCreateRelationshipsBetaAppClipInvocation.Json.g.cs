#nullable enable

namespace AppStoreConnect
{
    public sealed partial class BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation
    {
        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerContext.Options.GetTypeInfo(this.GetType()));
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public string ToJson()
        {
            return ToJson(global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return ToJson(global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
            }

            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                jsonSerializerContext.Options.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation))) as global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation;
        }

        /// <summary>
        /// Deserializes a JSON string using the generated default JsonSerializerContext.
        /// </summary>
        public static global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation? FromJson(
            string json)
        {
            return FromJson(
                json,
                global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJson(
                    json,
                    global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
            }

            return global::System.Text.Json.JsonSerializer.Deserialize<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                jsonSerializerContext.Options.GetTypeInfo(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation))).ConfigureAwait(false)) as global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation;
        }

        /// <summary>
        /// Deserializes a JSON stream using the generated default JsonSerializerContext.
        /// </summary>
        public static global::System.Threading.Tasks.ValueTask<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream)
        {
            return FromJsonStreamAsync(
                jsonStream,
                global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            if (jsonSerializerOptions is null)
            {
                return FromJsonStreamAsync(
                    jsonStream,
                    global::AppStoreConnect.SourceGenerationContextComponent_C18E6648D0AB743A.Default);
            }

            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation?>(
                jsonStream,
                jsonSerializerOptions);
        }
    }
}
