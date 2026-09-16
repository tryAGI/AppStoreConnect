
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.ResourceLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagedDocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.PagingInformation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.DocumentLinks))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusType), TypeInfoPropertyName = "AppClipDomainStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipDomainStatusAttributesDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomain))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode), TypeInfoPropertyName = "AppClipDomainStatusAttributesDomainErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalization))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType), TypeInfoPropertyName = "BetaAppClipInvocationLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationType), TypeInfoPropertyName = "BetaAppClipInvocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationships))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizations))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType), TypeInfoPropertyName = "BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleFileSize))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleFileSizeType), TypeInfoPropertyName = "BuildBundleFileSizeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleFileSizeAttributes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleFileSizesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundleFileSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType), TypeInfoPropertyName = "BuildBundleAppClipDomainCacheStatusLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType), TypeInfoPropertyName = "BuildBundleAppClipDomainDebugStatusLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType), TypeInfoPropertyName = "BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType2")]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse), TypeInfoPropertyName = "BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse), TypeInfoPropertyName = "BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation), TypeInfoPropertyName = "BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization), TypeInfoPropertyName = "BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem), TypeInfoPropertyName = "BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize), TypeInfoPropertyName = "BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusType?), TypeInfoPropertyName = "NullableAppClipDomainStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode?), TypeInfoPropertyName = "NullableAppClipDomainStatusAttributesDomainErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationLocalizationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType?), TypeInfoPropertyName = "NullableBetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleFileSizeType?), TypeInfoPropertyName = "NullableBuildBundleFileSizeType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildBundleAppClipDomainCacheStatusLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType?), TypeInfoPropertyName = "NullableBuildBundleAppClipDomainDebugStatusLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableBuildBundleBuildBundleFileSizesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<global::AppStoreConnect.ErrorSourcePointer, global::AppStoreConnect.ErrorSourceParameter>?), TypeInfoPropertyName = "NullableOneOfErrorSourcePointerErrorSourceParameter2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.OneOf<string, global::AppStoreConnect.ErrorLinksAssociated>?), TypeInfoPropertyName = "NullableOneOfStringErrorLinksAssociated2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse?), TypeInfoPropertyName = "NullableBuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse?), TypeInfoPropertyName = "NullableBuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation?), TypeInfoPropertyName = "NullableBuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization?), TypeInfoPropertyName = "NullableBuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem?), TypeInfoPropertyName = "NullableBuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize?), TypeInfoPropertyName = "NullableBuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppClipDomainStatusAttributesDomain>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleFileSize>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ErrorResponseError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize>))]
    internal sealed partial class BuildBundlesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BuildBundlesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BuildBundlesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BuildBundlesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode)

                    || typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationRelationshipsBetaAppClipInvocationLocalizationsDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleFileSizeType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleFileSizeType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize)

                    || typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDomainStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDomainStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDomainStatusAttributesDomainErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppClipDomainStatusAttributesDomainErrorCode?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppClipDomainStatusAttributesDomainErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BetaAppClipInvocationLocalizationType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BetaAppClipInvocationLocalizationTypeNullableJsonConverter();
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

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleFileSizeType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleFileSizeTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleFileSizeType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleFileSizeTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleAppClipDomainCacheStatusLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainCacheStatusLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleAppClipDomainCacheStatusLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleAppClipDomainDebugStatusLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleAppClipDomainDebugStatusLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleAppClipDomainDebugStatusLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleBetaAppClipInvocationsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundleBuildBundleFileSizesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocation?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalizationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalization?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedFieldsBetaAppClipInvocationLocalizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBetaAppClipInvocationsGetToManyRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSizeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSize?))
                {
                    return new global::AppStoreConnect.JsonConverters.BuildBundlesBuildBundleFileSizesGetToManyRelatedFieldsBuildBundleFileSizeNullableJsonConverter();
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
                    0 => new BuildBundlesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}