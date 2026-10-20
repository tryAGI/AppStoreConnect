
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_42E61AD696899D01 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_42E61AD696899D01 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_42E61AD696899D01(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile?)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreReleaseJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreReleaseNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFileJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFileNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.BackgroundAssetVersionsGetInstanceIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_BackgroundAssetVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_FA6341D9B348633B(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E6E2168E9B959F32(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_61EED8480C1748CA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_E13B1EEEEF244261(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_C9E08083D90FD1EA(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_693A4D2D66B5EE91(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata4.Create_SourceGenerationContextMetadataType_A29AECCD263A422E(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAsset2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease2(options);
                }
                if (type == typeof(global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata7.Create_NullableBackgroundAssetVersionsGetInstanceIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAsset>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_AD7626FB26674EE2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetUploadFile>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_6217E95BD9820F23(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersion>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_CC9E97D36F4F376F(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionAppStoreRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_76C83411D2CF6A16(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionExternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_256B0C185CFDB45A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceFieldsBackgroundAssetVersionInternalBetaRelease>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_ACEC9E6A0E62E484(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.BackgroundAssetVersionsGetInstanceIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata9.Create_SourceGenerationContextMetadataType_17EC11E4961D74CF(options);
                }
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