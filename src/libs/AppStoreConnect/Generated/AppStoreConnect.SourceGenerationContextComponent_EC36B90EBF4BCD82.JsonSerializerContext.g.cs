
#nullable enable
namespace AppStoreConnect
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EC36B90EBF4BCD82
    {

        internal static readonly global::AppStoreConnect.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::AppStoreConnect.SourceGenerationContextMetadataScope>[] {
                    static () => global::AppStoreConnect.SourceGenerationContextComponent_058BE0E6AA2F0A90.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_69C591C5A6056B38.MetadataScope,                    static () => global::AppStoreConnect.SourceGenerationContextComponent_DD04B2363FA9BF43.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::AppStoreConnect.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>>(static () => new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>());
            collector.AddEager<global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter>(static () => new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch1165.Create_SourceGenerationContextMetadataType_EC36B90EBF4BCD82(options);
                }
                if (type == typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.SubscriptionPromotionalOfferInlineCreate, global::AppStoreConnect.SubscriptionPriceInlineCreate, global::AppStoreConnect.SubscriptionIntroductoryOfferInlineCreate>?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0FactoryBatch1091.Create_SourceGenerationContextMetadataType_BEF3DF735ADC7399(options);
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