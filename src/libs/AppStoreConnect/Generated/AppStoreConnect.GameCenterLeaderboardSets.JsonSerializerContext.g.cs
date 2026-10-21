
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class GameCenterLeaderboardSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CF456AC3FDDC6489.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5EECAE56F77BDA31.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A6AB2D5915732D85.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80D3CEA70AE5485B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_402F2BFC54C3C983.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_01650FBEBF827A61.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A6747590D5D62DE5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36FB24D43F1EA242.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9FB76F28EB219F3F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B3B67CB70C5D4AF8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2DFCB886003B87D0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2DDF814CB855C587.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_56EBDCC4FB1BAAB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D8231CFD790ADAEB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_546DF7E4CBCFB434.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8AFFC24DE92FF892.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5E7A080218695F8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D6186A5201C539F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D9C934B544019E5B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_36F900F56B0A33E0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34B850C108F7AF80.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BFFBB8E0E201E26D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FFAA93C326A35F4C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85DFC531778590B4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_30DFCDE182A14E2F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA5502CA65F3B90E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FD755E20B202D660.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C9D5DF8C38A9561B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_19CDDDC8804B2070.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1E4D952B9A0FE9AE.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly GameCenterLeaderboardSetsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static GameCenterLeaderboardSetsSourceGenerationContext Default => DefaultHolder.Instance;
        private GameCenterLeaderboardSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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