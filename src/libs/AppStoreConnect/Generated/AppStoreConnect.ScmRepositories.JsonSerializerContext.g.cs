
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ScmRepositoriesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A93A3D6A5DA030AE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2AAD7C7C59CAE344.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D288F1BFDE73CC9C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFF661D66F8C2B1C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E95D5BF6C1BB6E35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24C5225D1DBD7D02.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30D8C1185B3DFC48.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6C89E524EDC223C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2B1914A0A10A637A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EDFC87BD89B994E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_70E75DC8020C773E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_820A08FF052A888C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA0B1E540BF86C90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_33CA4F84605FCD8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CAE96020C7F63FC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A79B2B419F7148A6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F99EE9CCF7D52433.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C511BC4A23D7CEAA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_57E90D8FE0981FD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8520CA3CA53906EC.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ScmRepositoriesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ScmRepositoriesSourceGenerationContext Default => DefaultHolder.Instance;
        private ScmRepositoriesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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