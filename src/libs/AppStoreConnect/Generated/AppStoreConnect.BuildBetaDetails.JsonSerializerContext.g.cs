
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BuildBetaDetailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC4837D7F2491B37.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F217C4633094A382.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C47BE6A7C67EF31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_71F5CC447DD80E69.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3885C9BEC616FA35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C540EEB27B72E82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F595AB876C6142CD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9FAB5FE10520A4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CECAD99B1A68F5D5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ABE00945DDA1FE5E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DFBCAD1056129008.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2944F87D637D7FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01A0AC9EBAE19043.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3AB9CC4461F4DDBC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFA9396552AA6EE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6031F31F7416566.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE76C6551BBA5333.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C25D86BD8E75612C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_738D88F80741204E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F7EB64F6C60943A0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA4EA1B5B545BACA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9636E7914ADDB071.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_91FEFE60D6FFAE07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BACBE24FAEEBA60B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_537E919B674E5333.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F8F9359C879EA7F.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BuildBetaDetailsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BuildBetaDetailsSourceGenerationContext Default => DefaultHolder.Instance;
        private BuildBetaDetailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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