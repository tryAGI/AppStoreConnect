
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PreReleaseVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45DDF6A6D83E4FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_335691B84393EE07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26D9BC4ED7DEFCB2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_488A5D737E196788.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_90611FC9E1D86B8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C0DE089DA76BB7B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F6E4B0006D3D4402.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7DC0784D318AC953.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8936C58694741C8D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1D442113277FF16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B03B8288EBB2E6AC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_46B7F8A81432DFCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8A30B3B42896958C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A4646F67AEECFD6D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_496D71A668409818.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9AE7DB53CA4DE492.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A4CB3DECCB46E240.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5F9CAC1790E671CF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_971CCF95D232F604.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7528CBBC06CE7FF4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PreReleaseVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PreReleaseVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private PreReleaseVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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