
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class InAppPurchasePriceSchedulesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7609AB5E8E05FB65.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CC143B8B731622DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D4B6D3D26A55716.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_32B5DDAC18A5F7D5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51243B1FBD0644EB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_29DFC395E7E142DF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C58ECB5578FA203D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_446D05F503469BB9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1A9D3C7FE07EB02A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_82D8639FAA8BC67C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CFA0A22D94748358.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_48A241AF090705B3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C2A0560F7B478A96.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_89B748B4BB71715C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_EB1A4E5650A531DA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A5DAC71CE25B3F9D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_926C44191CB1A01C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C54E352B1EE01C54.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_49F7E6E142756314.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E2E1646BE98A1012.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC1C11884EBAD390.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C478524FB4FD7AAE.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly InAppPurchasePriceSchedulesSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static InAppPurchasePriceSchedulesSourceGenerationContext Default => DefaultHolder.Instance;
        private InAppPurchasePriceSchedulesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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