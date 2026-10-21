
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class WebhooksSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AF7A09446AF6D43E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CACDA80B323B4AC6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5458C828BFD579D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D459292E90CEE3BA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3C442FFB89A0F7F2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC93A7B959FA011E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9BD9EA534CC0D43C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_083157F614E87F73.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C4DDEF2828CDE828.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C324BF12251E355.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC1E2A4DC2E83FB8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1C605E120B8DC1B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_240A0A43FDF017EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_43B7C893C1B55AFC.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly WebhooksSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static WebhooksSourceGenerationContext Default => DefaultHolder.Instance;
        private WebhooksSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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