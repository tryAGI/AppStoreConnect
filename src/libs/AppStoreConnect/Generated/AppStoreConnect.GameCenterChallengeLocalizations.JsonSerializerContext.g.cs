
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterChallengeLocalizationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_175AC13A2993E77E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3F804B4216DAFDFE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EDF0595B9D8D63ED.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_887B9E48ECD14265.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0EBAE7C57E288AF3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34327983F387C1D3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27B71F4C87BA0C19.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A15E2725E3393A0C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1C132137CAE1EE3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C38DA20FA29BD54E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A2321B072E0293E4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1B44E72A06692EED.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterChallengeLocalizationsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterChallengeLocalizationsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterChallengeLocalizationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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