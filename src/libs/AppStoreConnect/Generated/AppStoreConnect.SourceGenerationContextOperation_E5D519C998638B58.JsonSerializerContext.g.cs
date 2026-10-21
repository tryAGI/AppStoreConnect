
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_E5D519C998638B58 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC4837D7F2491B37.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F217C4633094A382.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C47BE6A7C67EF31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_71F5CC447DD80E69.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3885C9BEC616FA35.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C540EEB27B72E82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F595AB876C6142CD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9FAB5FE10520A4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CECAD99B1A68F5D5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ABE00945DDA1FE5E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DFBCAD1056129008.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B2944F87D637D7FE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01A0AC9EBAE19043.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3AB9CC4461F4DDBC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFA9396552AA6EE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_E5D519C998638B58 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_E5D519C998638B58 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_E5D519C998638B58(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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