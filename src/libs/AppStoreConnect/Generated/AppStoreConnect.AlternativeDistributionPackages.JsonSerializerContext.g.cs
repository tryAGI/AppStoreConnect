
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AlternativeDistributionPackagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3AA2A0489F9238F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1A614E9503DA911A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D874C3F3AC530975.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_314770DAF5225743.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B76653D3DE23BD87.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B90351829C00BC89.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8CA277524E505331.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_791E46A848502439.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_732E178B10D16F3F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EBFED2DBA575C597.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8E34E2A948ECE4E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9C129CB1832AEB28.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_09C78BDDE66CF396.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C321A87C5C594E91.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AlternativeDistributionPackagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AlternativeDistributionPackagesSourceGenerationContext Default => DefaultHolder.Instance;
        private AlternativeDistributionPackagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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