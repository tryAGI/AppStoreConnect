
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterMatchmakingQueuesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF17817A64449D7F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_882345061E8E6E43.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E9CC093E1C01962B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_137FA64CAE2D3379.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9ECFA4C5335C50F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1B35681DCF28CB70.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E92F47B0E2EC5F91.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EC534D66C233B88D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5740F1ED1213F7C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18613479020F2251.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4184A517E1BFF3DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_670E1797E9F94562.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E655CF8F7053C910.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FBC534D9B8859215.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDDF8A957F6400C0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_036D978C9BCB79A0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E918BD1DA152266.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_836BF4262F79B9E8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_308FB6705CFC9E6B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_25415516F57C5106.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A51661DD2AA96194.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4FCA632DA896FCA5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BC73AC298A334C4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0C69970326AAD23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8521270D0C46AAE5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6CB5D7B8593E4ADA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BED40F516EA0B52A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E0DDF0942A1DED0D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC0FBFE8F770F770.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterMatchmakingQueuesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterMatchmakingQueuesSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterMatchmakingQueuesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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