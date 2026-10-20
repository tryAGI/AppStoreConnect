
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_D361D127A3AE74CA : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_D361D127A3AE74CA Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_D361D127A3AE74CA(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem)

                    || typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsCiProductJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsCiProductNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsAppJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsAppNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsBundleIdJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsBundleIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsScmRepositorieJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedFieldsScmRepositorieNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedIncludeItemJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppsCiProductGetToOneRelatedIncludeItemNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCiProductGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCiProductGetToOneRelatedFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCiProductGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCiProductGetToOneRelatedFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_AppsCiProductGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_061C1815C6C577DB(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_BC8AA001323B37DD(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_B261E19E3244B384(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_6FAA5CB8C7C8FD51(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata5.Create_SourceGenerationContextMetadataType_97564661FE6649F9(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCiProductGetToOneRelatedFieldsApp2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCiProductGetToOneRelatedFieldsBundleId2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCiProductGetToOneRelatedFieldsCiProduct2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCiProductGetToOneRelatedFieldsScmRepositorie2(options);
                }
                if (type == typeof(global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata8.Create_NullableAppsCiProductGetToOneRelatedIncludeItem2(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_1EE89A4CA2C4ABF5(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_C148E6D6A1407F94(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_86FC8E73DCB6913D(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_07586957601DC2AE(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem>))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata10.Create_SourceGenerationContextMetadataType_862D9D37EE02BE03(options);
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