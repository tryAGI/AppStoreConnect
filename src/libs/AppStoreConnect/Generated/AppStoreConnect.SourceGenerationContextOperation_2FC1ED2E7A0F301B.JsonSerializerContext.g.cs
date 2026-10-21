
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal sealed partial class SourceGenerationContextOperation_2FC1ED2E7A0F301B : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        internal static global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E6FC395685898D2E.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A9FD73A68E8D704F.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E92A1107AEEA5F3C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_34CFEF437265FA56.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CD54950FE4B6FB23.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7EB9C352E1210EB3.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A1D233B458BF03E5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_BC92A2887453D099.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_67287147C6B23B26.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0AE57A44743CFACC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB9DE31AB0212639.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_5744794763E01D77.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_37715081B23BD10C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_C23547ADF4A36162.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4C1BD8F8872BC1DB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_090FE09093797277.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0CD986E2D4CC9F25.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DF47964D214725BF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_80F13FA4A16849E6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_AB4336F1FE3EB719.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B47482578473ACEB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1BD5F6961E3EDCCA.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0EF60FB0768A8DC2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6E9238735C0E43F4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_50194856AF8CD3D6.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8548A00352560B63.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_1477A1C43576A4D2.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_63C197062B1D667C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly SourceGenerationContextOperation_2FC1ED2E7A0F301B Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static SourceGenerationContextOperation_2FC1ED2E7A0F301B Default => DefaultHolder.Instance;
        private SourceGenerationContextOperation_2FC1ED2E7A0F301B(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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