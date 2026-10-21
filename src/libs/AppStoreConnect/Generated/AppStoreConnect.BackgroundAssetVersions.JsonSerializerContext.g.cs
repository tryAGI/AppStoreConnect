
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BackgroundAssetVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_783FA5BBFACD997E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8CBB6794B740FC21.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_686477A194BC2EA9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_324917820764378C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_54FB18E3B16263B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A4FB1F476BA8C1B1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_61EED8480C1748CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FA6341D9B348633B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_693A4D2D66B5EE91.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C9E08083D90FD1EA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E13B1EEEEF244261.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6E2168E9B959F32.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A29AECCD263A422E.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BackgroundAssetVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BackgroundAssetVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private BackgroundAssetVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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