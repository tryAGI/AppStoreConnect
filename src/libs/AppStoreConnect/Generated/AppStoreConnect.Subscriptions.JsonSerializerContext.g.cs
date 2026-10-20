
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class SubscriptionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SubscriptionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SubscriptionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_99BD2162DFC2212D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_870C4C8FCDA79ED3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2F2F9727FBCCAAEE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_161941331C357731.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_74EF7686E3D80706.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2AC3BEC6F9F89754.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_43D6E2A2FE824495.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D0CAEE13E7B9E6FD.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5EAA45249387549C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BB415F796A7DAB53.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B1655239DE6473BF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_72925F76BE6EB50F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E4B4B1B67DFA542A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F2BBF85D2A7FAE0E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_22E99D3E4C4E2730.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5034AAD1DB64115A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7082304780EDC414.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8390FCE1DDB2D314.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8C547A8FB2FF3DB7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_932E404C63293626.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AB3A5B9C42D569B5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_38B0B4629CA0A4FA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DEC3D91362CCBD31.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_086EB0CF6C15128E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B1CE91CFF169DE56.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_826E42D34D9E55CF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_376793999C1E086E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_597517EE7B55E936.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_38EC63C44ED96649.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9557B8E58EDF35C7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0AF047E604AC6A6E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F3E933F386B86A80.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2A1467C674031982.AddConverters(options);
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

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[36];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_99BD2162DFC2212D.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_870C4C8FCDA79ED3.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_2F2F9727FBCCAAEE.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_161941331C357731.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_74EF7686E3D80706.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_2AC3BEC6F9F89754.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_43D6E2A2FE824495.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_D0CAEE13E7B9E6FD.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_5EAA45249387549C.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_BB415F796A7DAB53.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_B1655239DE6473BF.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_72925F76BE6EB50F.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_E4B4B1B67DFA542A.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_F2BBF85D2A7FAE0E.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_22E99D3E4C4E2730.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_5034AAD1DB64115A.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_7082304780EDC414.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_8390FCE1DDB2D314.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_8C547A8FB2FF3DB7.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_932E404C63293626.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_AB3A5B9C42D569B5.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_38B0B4629CA0A4FA.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_DEC3D91362CCBD31.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_086EB0CF6C15128E.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_B1CE91CFF169DE56.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_826E42D34D9E55CF.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_376793999C1E086E.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_597517EE7B55E936.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_38EC63C44ED96649.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_9557B8E58EDF35C7.TypeInfoResolver,

                    33 => global::AppStoreConnect.SourceGenerationContextGraph_0AF047E604AC6A6E.TypeInfoResolver,

                    34 => global::AppStoreConnect.SourceGenerationContextGraph_F3E933F386B86A80.TypeInfoResolver,

                    35 => global::AppStoreConnect.SourceGenerationContextGraph_2A1467C674031982.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}