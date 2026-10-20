
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_2AC3BEC6F9F89754 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_2AC3BEC6F9F89754 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_2AC3BEC6F9F89754(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionGroupJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionGroupNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPriceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPriceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsWinBackOfferJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsWinBackOfferNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceFieldsSubscriptionVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.SubscriptionsGetInstanceIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, string>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_FC0ACBA26C044EC8(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_8219E7AD6AEFA4B4(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_92E1ACA86984772C(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_NullableJsonElement(options);
                }
                if (type == typeof(global::System.Collections.Generic.IDictionary<string, object>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_SourceGenerationContextMetadataType_7024F6984ED20EB8(options);
                }
                if (type == typeof(string))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_String(options);
                }
                if (type == typeof(object))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_Object(options);
                }
                if (type == typeof(global::System.Text.Json.JsonElement))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_JsonElement(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceFieldsWinBackOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SubscriptionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_03B320F93A91D454(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_626E5479AC5FB4BC(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DA39D34F7772D66F(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6C2D2DA5183643D4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FD50DF4E718DB3E7(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0AB54311F5DEA0ED(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_34B6F14A321492D0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_953B408CE0569A4C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_15F3D6CFDABEC448(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_02B5470B99D54CD4(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_9B26C592E661AC28(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E2B73F1CB9AB721C(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_28E1832D227CF19D(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4E7524C51E8702AF(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_0E983614E885980A(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsPromotedPurchase2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscription2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionGroup2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionImage2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionLocalization2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionOfferCode2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionPrice2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsSubscriptionVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceFieldsWinBackOffer2(options);
                }
                if (type == typeof(global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableSubscriptionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_325E9C47F04376F1(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscription>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_A3FB78E04092356D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_099C94BC790EDD70(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_8281949955C4D1FB(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionGroup>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4A290CBEA2C97E13(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1D88085BEF297864(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionIntroductoryOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_C211E50056195787(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_7B135DF5A166DBF2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_026F15B3BBA6758A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_251A235FC82DA91C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPrice>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_DECEFBF264CD9006(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionPromotionalOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E051B47DA58858D5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsSubscriptionVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_B711B6C3B601C32F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceFieldsWinBackOffer>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_29B423AFCD1C8663(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.SubscriptionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CF359FE90EA33189(options);
                }
                return null;
            }
        }


        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SharedMetadataResolver(),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}