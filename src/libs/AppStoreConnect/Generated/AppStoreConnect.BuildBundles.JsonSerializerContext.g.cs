
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BuildBundlesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C65CB70282A63CF3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C21BD627EFA6209.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CCB5BD167E75DDA2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2894D949BC2B239.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_22FB6030503AFB81.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BBD215D34EC165FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3EA0DC3F11BD66B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_50DDF48328337979.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_120A29A102EA4B11.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCF330107D7BFDF8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1F01AF6891942E0E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCFE9B05E7866A3A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B900159FBC0BE6AD.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BuildBundlesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BuildBundlesSourceGenerationContext Default => DefaultHolder.Instance;
        private BuildBundlesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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