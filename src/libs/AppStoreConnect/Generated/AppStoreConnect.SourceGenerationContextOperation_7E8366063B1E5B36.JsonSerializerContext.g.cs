
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_7E8366063B1E5B36 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B687C790DC2BD060.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_694C59D97F7062D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C34B9DF8DB77E11.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CF2746DFA95A8DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F19602CA30D7990.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2E812394A4B0D25.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6DBD30BCB66DD08.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3906F9613BF45A82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_145BCB7F3FF825A6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4F6FE52EC7371429.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_417C361EC6B96080.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_439D76D35F5CE444.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B356F6F88AF8BA3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_7E8366063B1E5B36 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_7E8366063B1E5B36 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_7E8366063B1E5B36(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);
        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}