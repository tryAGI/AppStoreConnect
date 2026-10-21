
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterAppVersionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_778730213D69B439.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C55CA43BAA2FC04.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F7DA7F071E1931C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B36A0483A26E5842.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4D09BC5233C35268.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E239563AD90D793C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA8758ACA3FACBCB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26CF9490AD7030E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_455F023C61709D2A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E67BA72574BC3F07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5F87189D710B1714.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF3F97356BB54163.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9AE4332779D9EE33.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5DAEF8AA433629F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4CAB1C4A548E839B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C56F9151B035D551.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0456030433AF329C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DFD221408B686295.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_380BE98E33E5295F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17B920FFFC2A951C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC9C4B935228546B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BCE0D680E3FD6088.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3E509BFE8420C994.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5EC6ACA694E8EBDD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0EACDB21B97FF357.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C943FD8842018BE3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED203C8F9D3ACF64.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE92E4F416585E7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF622FF133523E25.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterAppVersionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterAppVersionsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterAppVersionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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