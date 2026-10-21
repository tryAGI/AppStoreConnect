
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class WinBackOffersSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F28D300948766017.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_791211493CB6812B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8689EB926095EC3D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BD8669A3C3A1378C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3E2FE21D08CECBEF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A19D90EBCAA9C1F9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_417858877439FDEC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0E126D71FEDDD42D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FBDAEF50AE54D1D8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B60A7C90390AFC2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_875B67972A42BC2C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FF6B67C68CF6A236.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AF59A70E47520845.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40BBE266E6B7CB82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B5C9D60AE6E7B1B8.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly WinBackOffersSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static WinBackOffersSourceGenerationContext Default => DefaultHolder.Instance;
        private WinBackOffersSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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