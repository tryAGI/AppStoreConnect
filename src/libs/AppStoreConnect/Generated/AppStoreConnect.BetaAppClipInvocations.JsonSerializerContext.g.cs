
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType), TypeInfoPropertyName = "BetaAppClipInvocationLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType), TypeInfoPropertyName = "BetaAppClipInvocationLocalizationInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType), TypeInfoPropertyName = "BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationType), TypeInfoPropertyName = "BetaAppClipInvocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType), TypeInfoPropertyName = "BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType), TypeInfoPropertyName = "BetaAppClipInvocationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundle))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType), TypeInfoPropertyName = "BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType), TypeInfoPropertyName = "BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType), TypeInfoPropertyName = "BetaAppClipInvocationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorResponseError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>), TypeInfoPropertyName = "OneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourcePointer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorSourceParameter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>), TypeInfoPropertyName = "OneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociated))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ErrorLinksAssociatedMeta))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformationPaging))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation), TypeInfoPropertyName = "BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization), TypeInfoPropertyName = "BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem), TypeInfoPropertyName = "BetaAppClipInvocationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationLocalizationInlineCreateType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationCreateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationUpdateRequestDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation?), TypeInfoPropertyName = "NullableBetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization?), TypeInfoPropertyName = "NullableBetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableBetaAppClipInvocationsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreate>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem>))]
    internal sealed partial class BetaAppClipInvocationsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaAppClipInvocationsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BetaAppClipInvocationsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BetaAppClipInvocationsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>());
            options.Converters.Add(new global::AppStoreConnect.JsonConverters.OneOfJsonConverter<string, global::AppStoreConnect.ErrorLinksAssociated>());
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
                    typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationInlineCreateRelationshipsBetaAppClipInvocationDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBuildBundleDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationCreateRequestDataRelationshipsBetaAppClipInvocationLocalizationsDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationUpdateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationUpdateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationUpdateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationsGetInstanceIncludeItemNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
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
                    0 => new BetaAppClipInvocationsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}