
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_91157B61C393956C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_91157B61C393956C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_91157B61C393956C(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuildJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuildNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocumentJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocumentNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_28138AFE106C22F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_CBD4B1A320B5ACD0(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_26787F6AAD0D0498(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_DCE072DCBF3E4B93(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_8D54211203F70B09(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_10D6183A394421D0(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_8E39B2CE233E74D7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_2E987167057E65C5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_932DD3D71069F8F2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C6AFB2009BC46470(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_81E157B30146AC1A(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_A98B82CCE86697BC(options);
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