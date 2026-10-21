
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3789E14C749068A6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B23EEB43D80C763C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_87E03A36CB9EB272.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_00EEEA95CA18ADC6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_32E20424E3419DC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DA74FE41E89FE5E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5AB70B123A6B916B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_167DF33FD2F1CDF3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A14972375C0AE5E7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D79202D3CCBABB27.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6C5D144DE6C5C38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_72F9B1CCA1A67A02.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_747D9ABF290D8EEA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DCEBF32C286C518.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7DC500AA45FA7F28.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_727771CE763C190A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8EE20859C540D15D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_02D5D2419CFF6C72.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85BCCE439C0B2574.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5322620595795DCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_15A6DD1558FB1D8F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_333DA0E9CCF429F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCB2C5D7874D09D6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8D43BB9CDD65F3E3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0340A6B8CDE8553C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1D8A3AFF6E795CB9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6ACC1A90EE7FA38A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1233440BF71CDCD0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ADCA27A572F7A412.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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