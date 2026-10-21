
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CiBuildActionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_105017BA76D19E94.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_35C32CC1996CA26E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_ED1A81FF8090ADB8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B54194AC614B9DBE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D6FDE38D4580341F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9BE64F665DD58BBC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3768F99D4E95AF41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CA0A0E319F6EEECA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_493A69CBA993A70C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6BAF0D3664D6EC5D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EA0666A9CBB378E0.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_63A9E7ACF78CA6B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34B6702D1C92D79E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_89AACB7D54500D16.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18C339B83B899FCC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B25E036603A7A287.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FD5B048809770DD9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_912E3071EBEB7D8A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C176D1CA38CF963C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FB518877E2908609.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3BF4CE69F600ACDF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_23DC250B026F57D8.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CiBuildActionsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CiBuildActionsSourceGenerationContext Default => DefaultHolder.Instance;
        private CiBuildActionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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