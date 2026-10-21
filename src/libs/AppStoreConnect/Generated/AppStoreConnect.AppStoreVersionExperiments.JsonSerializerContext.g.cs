
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppStoreVersionExperimentsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0CACE9B6689F19F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F3394EC934987078.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_283F5A05E512DDE5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5A0EEA9C811AE93.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EAC549B5AE6D7BF4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_13CF7205D80F35AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BFD695AD80E00B4F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F3A14DFA18D0FB4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D25E173B8D75032.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_393EF50F6BEA9AED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6FAC80BD005361DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_000C812FE876E28D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_132CD72D5A461149.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BADC95A15433D9E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7B38AE153B486EF4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_21E6FFA294711ED3.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppStoreVersionExperimentsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppStoreVersionExperimentsSourceGenerationContext Default => DefaultHolder.Instance;
        private AppStoreVersionExperimentsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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