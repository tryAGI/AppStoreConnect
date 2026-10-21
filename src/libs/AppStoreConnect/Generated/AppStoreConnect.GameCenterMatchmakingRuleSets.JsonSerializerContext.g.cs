
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterMatchmakingRuleSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6983D1DADD3ACD69.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CD1FA08B3E0C8CD7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0B8A7A089B6CC8FC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B014D5183B74E289.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6C4DA856547D5CB4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C58227B4DE013C0A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_42E42C129AABEF0A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D43E766D4218C9A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E48B59134121978B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA32496C8008308D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_144D310A08F18199.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_893A659D42D1164E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B0436B4F91A887CE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D73A16B6A83B8B6A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_670E1797E9F94562.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A338613A0BC055FA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF5A5E6C748CC0DD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_68A872162416210C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A39C2707E13883F6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E075A99C037A82C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F960CCFDB3995127.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F71480B6862AACD4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_580FD88DFADBEA05.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CAD7DFDDBA8478A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_771E1CFA0CEBEA49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA2A336D228549D1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE63B94BA5A072F0.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterMatchmakingRuleSetsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterMatchmakingRuleSetsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterMatchmakingRuleSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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