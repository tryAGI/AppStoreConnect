
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class BetaBuildLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_901E9E1771803BA5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_919AF5D14CB8C338.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2C81C318F4E9746B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_983347591E122B2F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EC7F4424766B0E0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BAC364448173E4C5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_12AA21F1F31BE9C3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_786993976D7B648B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8BAD4D5C280B831.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_60175C4EA67B80BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4253F2CB55193536.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C1F527AB81838E0B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5036D24E94A8D555.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_31CEE75572E8A197.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76D2059373AE85A0.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly BetaBuildLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static BetaBuildLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private BetaBuildLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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