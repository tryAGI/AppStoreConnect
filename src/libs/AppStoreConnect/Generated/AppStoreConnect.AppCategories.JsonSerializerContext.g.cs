
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppCategoriesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5682835E516E0D00.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_937B79180D6C849C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA2E0A604176BB2C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_87AD27192CF19EA4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2447673CDEEB92E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_53E3027D8A2B8A43.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A115CCA3B96E607B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B610CD1A7959AF86.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_057EC7DB2B83A8D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C8E9135E30AA32E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3776264BD0220662.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6E8E54FFED12A1D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DE945CADFC32A28.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppCategoriesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppCategoriesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppCategoriesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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