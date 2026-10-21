
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_67AE9A0F24B888C9
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_18E0F6E466F53185.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_26ADF7E57ACDCF1B.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_2D43CB3279862914.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_31828961C30C6DFF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_360DA3EB30E365B9.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_40A09A193D8A34CB.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_453FC7C6833F7944.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_4971DA78B3C40991.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_56F9F838A560A41A.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_6059A4A274E57CCE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_711A2152D34E8067.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_8B6E86A818FFE0D4.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9233CB920F59DEDF.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9B57E71A405CE9F5.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_9EFA24104A775350.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_A8745C8615AC57F1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_CE03C660AD186033.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_E270EFE13C2BCAFE.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F0988770A4A72861.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F104894686A94220.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F1D89578314C4CD1.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_F5D3498388DA4563.MetadataScope,
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
                if (type == typeof(global::AppStoreConnect.GameCenterDetailRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0Factory_GameCenterDetailRelationships.Create_GameCenterDetailRelationships(options);
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