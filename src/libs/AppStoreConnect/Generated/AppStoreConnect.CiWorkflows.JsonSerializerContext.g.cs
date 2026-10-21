
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class CiWorkflowsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FEBF1DCC9488395B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3FE2F82F9FCFB408.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B3EBC5C2645D4D41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_060277662E875FE4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D94D1FC21FD8D26A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FDAA0572D59C2E9F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E07150600870F366.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_27FCD34DA43A7EFD.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7F7611F57B555F51.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0D16B74A54F4CAE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7CAB9E96FB33623D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BB148CD2ED8A5163.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D05CC82517A16139.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_06F194343F7D1D95.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_918109AC0A2C2C01.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DAABF3854F6CD22D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_FEFDB28397502520.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0BC00589BB29F298.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E314031BF52122B2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_24C5225D1DBD7D02.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6581B300F83A2AAB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE5D754CE146DFC1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_D1C4F506832C0536.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9A068F420FF5C3D8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_33F94EDFEBAE804C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EFA61F43664CCEFF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_61847EDC25CD1925.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly CiWorkflowsSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static CiWorkflowsSourceGenerationContext Default => DefaultHolder.Instance;
        private CiWorkflowsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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