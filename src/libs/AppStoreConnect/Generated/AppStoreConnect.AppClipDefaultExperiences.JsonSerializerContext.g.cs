
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class AppClipDefaultExperiencesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F827A08AD4897315.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4865C92F476CBBE0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4229E6B522468BB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ADA151EA806F73B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A915DF0EDEBF158B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E06E8403D575CCD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BE89FCC4C03C79EB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6AA191FD12C7B52.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9F854B8B074493CA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_61BBC7846921CE28.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C6B9ABA618DFB62C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FCE66E998D6A5D19.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AE6194C80C7F12AF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED9A14300364269A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9E2F345933E32A0A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2E08BC4474F2859F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3DC626B9C9A525FA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE14E13CEE5FB451.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_589BB56883005C07.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB5F84BF85EC76A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ECFEF16776C89FB6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B554BDE9DB38738B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB1262BC673C1A4A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D2DBAC60F1C2DC4E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_703255E6E689ECD1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0501176EFDAB9B49.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1AB6BB734B4E9231.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_93E5D4606116D6EF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_99133EBD2256FD09.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_62EDAB5E02C06C6E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_254A477D46386E67.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CB89E7BD613CACB0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C5A3C052679CFBFC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7A9C6C299926E917.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_66E7CEB972821B76.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3702BAF606A0520C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_00EA1C2E62DDE357.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8DBE613F3DDFA735.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3048FB05B8D77AA6.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly AppClipDefaultExperiencesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static AppClipDefaultExperiencesSourceGenerationContext Default => DefaultHolder.Instance;
        private AppClipDefaultExperiencesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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