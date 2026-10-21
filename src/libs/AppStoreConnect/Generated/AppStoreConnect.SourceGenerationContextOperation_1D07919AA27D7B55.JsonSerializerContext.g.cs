
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_1D07919AA27D7B55 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76C9EEA5457EA0C1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F7D463680307A6D9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_401089F046426E7A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7299D6BE4319484D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_959FA0C35DEFFAB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_405224328DD2AAA7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3142F60115BA1BC5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1BFB684EF57CF15A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D77200E67E4EC7B8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB457D971AE6B2DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_09660857ECDE51C3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99312C6FAA30BBE1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_56954AC6E33E3CC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F368EACF67B347A5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5B541003A3E9B3FD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F9A5AB1E79195FDA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_48973EFA259648B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_17025D2D79DEA41C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7C7C2FF008556A48.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0A4AE305F080FA32.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_1D07919AA27D7B55 Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_1D07919AA27D7B55 Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_1D07919AA27D7B55(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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