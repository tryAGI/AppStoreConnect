
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class ReviewSubmissionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F257A43E37E5ADD3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DDA2976E0DF3C22E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A18BBA7A2CC686CC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA016E45FD565416.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C48DB22A35B32B23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AAEF88EED6A29792.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76AEE9D45001A795.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E78BEEA546CCDE09.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DCA172817EC115F7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26DB873E1F2CCE1B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_14E434C603B21E51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05C0D73169059656.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_49B65BFC4EDC5410.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C09016F0E729A0AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB4B95ACCADE7D2F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_52259E9CBF6D5686.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EDBE96ED2102835.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_79FBFFCBF7B8D12B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5D8E4C96CB27E123.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A58E4AC113377C6B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DFB70DC2C29CFFB1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BEA5A6AECE07AD26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3E2E121DA031A33C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_81AA951260879289.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E60A2C68B49D741C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_559E736D34191A01.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5C45E12CE8488876.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AC83A0C28F4178F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F8B19E0F70E83EF1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0ADCC38E5CCF9CBA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5BFBB943D4BF4411.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D80C2156EC29BEF5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3B5B2DF5A0E51294.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EF52918033640D02.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2BCBCAA82180EC3B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2719BBFE9B2FD5C7.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45CC2D522CF30D82.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2EC6F9006935364D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_781106FE0126F759.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly ReviewSubmissionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static ReviewSubmissionsSourceGenerationContext Default => DefaultHolder.Instance;
        private ReviewSubmissionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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