
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InAppPurchaseLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F93230331BB60CBC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D746BBCDBF1F81E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1A5CE4DCBC7108AC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3AF17B7C7CF5FBE9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3741FEE71D28A723.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85E616654CDE5FA3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5203C6FD07AD08F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_84936A7F12F5888E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCD70DB0336111CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D0249F09D8F3C3E1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8BAA234DC3B82C79.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5EC11575F3686AF0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EA5E689938C2D31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C326AB7C9FF9917.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6D7F4DCBF45649B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8713D82B1D8F0E4.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InAppPurchaseLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InAppPurchaseLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private InAppPurchaseLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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