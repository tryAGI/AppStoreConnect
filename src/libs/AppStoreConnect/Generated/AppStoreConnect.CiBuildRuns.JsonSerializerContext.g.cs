
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CiBuildRunsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_84E7945BFD5FB864.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_45BAD099C7E7D07D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED23FA2F6D3E9196.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_643A52A306DB5926.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_718CCB145432FC86.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_76C9EEA5457EA0C1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_85101A3D6483CECE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BC3F6A7F445A280.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B33485954D19CBFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_289370B56FBC4D95.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DC40205279A8436B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_451F999DDE69B3BB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7754CE19832BF62D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5BB9C84B97573C3F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_442EDE3993E4DB0F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37B817AB98AE0330.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_11590775787E6845.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_04601AAC4B50E785.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0FA27D3843C255B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_062725E42A7995AA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D5A2C79937674133.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9D8AA83C552E0DB9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BDDB7EAFBC5182B6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FAC69ACA4C9846CF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B37D206910DF3E92.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_20B90DA7D54E8605.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC3F6DD3A9409E2D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B54194AC614B9DBE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2713681330B446DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40979919C43B6156.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8C82F76CE0552928.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_92DA357F04FB9885.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC41CEDCB20D06A2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6FC56ACEB6FBD7CF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5F2D205D7A7A6DAB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51C8803F694557D3.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CiBuildRunsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CiBuildRunsSourceGenerationContext Default => DefaultHolder.Instance;
        private CiBuildRunsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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