
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_7CA5B5A810F35388 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_7CA5B5A810F35388 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_7CA5B5A810F35388(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePointJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePointNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshotJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshotNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsPromotedPurchaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsPromotedPurchaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceScheduleJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceScheduleNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImageJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImageNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.InAppPurchasesV2GetInstanceIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }
        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
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
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchase2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceFieldsPromotedPurchase2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_InAppPurchasesV2GetInstanceIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_AF7911A006954DC8(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_22CE966D272DB2D7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1D5C7A849D58B27B(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_3776D092CF9F3C57(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4589261A65D18BB7(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_E847F9FFA0869504(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_FDDEFFDE2BE66F7D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_21DE3703F0C0106A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_C8B495F98291661F(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DD05FAF7E1865A06(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_1EBC908110D8C39D(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_4BB7E71CD98358DA(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchase2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseContent2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseImage2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceFieldsPromotedPurchase2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableInAppPurchasesV2GetInstanceIncludeItem2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_3F34869992937FC0(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_03D528C447161FF9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_E373DE1A3B15F6AF(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9577C2F4E9941965(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_742FBEE037E0F858(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_FB9A79218BBE817A(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_4FD13A93300F412E(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_BD6555B0540F57A9(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_97D5815ECC33D43C(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_1ADC9C43A0C3F8A5(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_ACAE2574BF648952(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_9A16046F50AF6C61(options);
                }
                #pragma warning restore CS0618
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
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