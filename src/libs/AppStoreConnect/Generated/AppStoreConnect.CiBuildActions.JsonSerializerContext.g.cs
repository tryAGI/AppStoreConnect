
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiArtifactsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiIssuesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiTestResultsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildActionArtifactsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseData))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType), TypeInfoPropertyName = "CiBuildActionBuildRunLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildActionIssuesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType), TypeInfoPropertyName = "CiBuildActionTestResultsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction), TypeInfoPropertyName = "CiBuildActionsGetInstanceFieldsCiBuildAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun), TypeInfoPropertyName = "CiBuildActionsGetInstanceFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem), TypeInfoPropertyName = "CiBuildActionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact), TypeInfoPropertyName = "CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem), TypeInfoPropertyName = "CiBuildActionsBuildRunGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue), TypeInfoPropertyName = "CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult), TypeInfoPropertyName = "CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildActionArtifactsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType?), TypeInfoPropertyName = "NullableCiBuildActionBuildRunLinkageResponseDataType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildActionIssuesLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType?), TypeInfoPropertyName = "NullableCiBuildActionTestResultsLinkagesResponseDataItemType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?), TypeInfoPropertyName = "NullableCiBuildActionsGetInstanceFieldsCiBuildAction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiBuildActionsGetInstanceFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?), TypeInfoPropertyName = "NullableCiBuildActionsGetInstanceIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact?), TypeInfoPropertyName = "NullableCiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsBuild2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?), TypeInfoPropertyName = "NullableCiBuildActionsBuildRunGetToOneRelatedIncludeItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue?), TypeInfoPropertyName = "NullableCiBuildActionsIssuesGetToManyRelatedFieldsCiIssue2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult?), TypeInfoPropertyName = "NullableCiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult>))]
    internal sealed partial class CiBuildActionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CiBuildActionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static CiBuildActionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private CiBuildActionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.PartitionCoreSourceGenerationContext.AddConverters(options);
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
                    typeToConvert == typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue?)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult)

                    || typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionArtifactsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionArtifactsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionArtifactsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionBuildRunLinkageResponseDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionBuildRunLinkageResponseDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionBuildRunLinkageResponseDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionIssuesLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionIssuesLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionIssuesLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTestResultsLinkagesResponseDataItemTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionTestResultsLinkagesResponseDataItemType?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionTestResultsLinkagesResponseDataItemTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildActionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildActionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsGetInstanceIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifactJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifact?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsArtifactsGetToManyRelatedFieldsCiArtifactNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRunJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRun?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiBuildRunNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflowJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflow?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiWorkflowNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequestJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequest?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedFieldsScmPullRequestNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsBuildRunGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsBuildRunGetToOneRelatedIncludeItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssueJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssue?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsIssuesGetToManyRelatedFieldsCiIssueNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResultJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResult?))
                {
                    return new global::AppStoreConnect.JsonConverters.CiBuildActionsTestResultsGetToManyRelatedFieldsCiTestResultNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new CiBuildActionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::AppStoreConnect.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}