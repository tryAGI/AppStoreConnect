
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterDetailsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterDetailsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterDetailsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_11EAC3E6977CD18C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D767A1BCDB1FA2E8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4CD51FC48B8A34C0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C79FEAEC11053F45.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2A9B33613816076D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A468354D0DEBE92F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6884BC14795757DE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B9FE8C28D5B947CA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5455BA404415CDC8.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C6563D39043F8532.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AA69C6B32549C949.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_89340C3837562B70.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_13DC4EBFC5FB4BEC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7751458373B8DE0C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_43A325C0502BE26B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2C338BC7A4B7AE39.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5BEB401B8ADF9D66.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6E5BC7AD5A17253D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4EF80EE5AD16228D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BECC06B4C96DBF31.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_08F1F20E76368772.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0E70E4A83F8CA3A0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_258C1DDFD5BC2D3A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CD54524082003684.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_044D72FDAC05DE34.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_62C348D726977A6E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CC7A0496731D9E17.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_2E0C5DC3061DD274.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8B23A325C3AD3CB5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F5D25FA15581B36C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DE2D8570D7BB0F7D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E88CA4965C73E311.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B6DAE7B06E88F927.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_AEBD4C39DF90E07E.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[37];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_11EAC3E6977CD18C.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_D767A1BCDB1FA2E8.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_4CD51FC48B8A34C0.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_C79FEAEC11053F45.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_2A9B33613816076D.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_A468354D0DEBE92F.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_6884BC14795757DE.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_B9FE8C28D5B947CA.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_5455BA404415CDC8.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_C6563D39043F8532.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_AA69C6B32549C949.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_89340C3837562B70.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_13DC4EBFC5FB4BEC.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_7751458373B8DE0C.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_43A325C0502BE26B.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_2C338BC7A4B7AE39.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_5BEB401B8ADF9D66.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_6E5BC7AD5A17253D.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_4EF80EE5AD16228D.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_BECC06B4C96DBF31.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_08F1F20E76368772.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_0E70E4A83F8CA3A0.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_258C1DDFD5BC2D3A.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_CD54524082003684.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_044D72FDAC05DE34.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_62C348D726977A6E.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_CC7A0496731D9E17.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_2E0C5DC3061DD274.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_8B23A325C3AD3CB5.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_F5D25FA15581B36C.TypeInfoResolver,

                    33 => global::AppStoreConnect.SourceGenerationContextGraph_DE2D8570D7BB0F7D.TypeInfoResolver,

                    34 => global::AppStoreConnect.SourceGenerationContextGraph_E88CA4965C73E311.TypeInfoResolver,

                    35 => global::AppStoreConnect.SourceGenerationContextGraph_B6DAE7B06E88F927.TypeInfoResolver,

                    36 => global::AppStoreConnect.SourceGenerationContextGraph_AEBD4C39DF90E07E.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}