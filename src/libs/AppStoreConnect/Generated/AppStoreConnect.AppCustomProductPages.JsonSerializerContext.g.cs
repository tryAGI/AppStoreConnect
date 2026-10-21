
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppCustomProductPagesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D3F83C1764536368.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7BBE5D494506F8D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_95A091DE57FEB4AE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BF4CDC47AC36DC2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6CF10CE5A41F18BA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_35A8383E6F103A90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2AC3A14CF83B065.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_059AF82DC6E520A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BEBDC191B1634514.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_66A221D8A5C1BE6F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1B3845F0B2F658D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_615AAF68D3BE2342.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A23FA16197D7D5E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6572A9F1ADB09A1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC38E5E56BFB85F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27AC6BACB2067E13.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7AD6ADFEB8073080.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppCustomProductPagesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppCustomProductPagesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppCustomProductPagesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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