
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_787CB4F93DD38B87
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_032E510C3F0A33D8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0A88F54A0909FCE4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_0F4EF83D1F7937A9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_12009D3D8881D10A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26BE00CE4A857F4B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3CD9DD37C9B3E1B5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_3D0EE15ECFB329BC.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_41DC91C55625E451.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_51F4B71BB8B3A54D.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6B0A39A13717A718.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_73F2E834BD582330.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_7DD73C2DD6B2A171.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_996C090B5A44F7E9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9E1053123794494C.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A8305AF84D516B44.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DAE6F2AC557274A8.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E81C60EE7D421797.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.AgeRatingDeclarationAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_AgeRatingDeclarationAttributes.Create_AgeRatingDeclarationAttributes(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}