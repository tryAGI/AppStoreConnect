
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_43C612EF712FF9B0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_43C612EF712FF9B0 Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_43C612EF712FF9B0(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference?)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReferenceJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReferenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.ScmProvidersRepositoriesGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_ScmProvidersRepositoriesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_C7199810E28CBC10(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_CDE19ACE4FF15890(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_8DA7F10841159B78(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_SourceGenerationContextMetadataType_4FD10A2784C48A6A(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableScmProvidersRepositoriesGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_BEB2AF41AE5DFAA2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_0BC6598800874B5C(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_494CC4BDBEC6D5E2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2C8FB1AAAEF44866(options);
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