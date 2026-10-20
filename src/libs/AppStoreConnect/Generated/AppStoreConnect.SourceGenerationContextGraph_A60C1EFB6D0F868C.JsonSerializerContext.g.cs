
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    internal sealed partial class SourceGenerationContextGraph_A60C1EFB6D0F868C : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SourceGenerationContextGraph_A60C1EFB6D0F868C Default { get; } = new(DefaultOptions);

        private SourceGenerationContextGraph_A60C1EFB6D0F868C(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType)

                    || typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return new global::AppStoreConnect.JsonConverters.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataTypeNullableJsonConverter();
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
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequest))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequest(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataAttributes))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataAttributes(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationships))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationships(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperiment(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentData))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentData(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2Data))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2Data(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata0.Create_AppStoreVersionExperimentTreatmentCreateRequestDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentV2DataType2(options);
                }
                #pragma warning restore CS0618
                #pragma warning disable CS0618 // Metadata references a deprecated API model.
                if (type == typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentCreateRequestDataType?))
                {
                    return global::AppStoreConnect.SourceGenerationContextMetadata6.Create_NullableAppStoreVersionExperimentTreatmentCreateRequestDataType2(options);
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