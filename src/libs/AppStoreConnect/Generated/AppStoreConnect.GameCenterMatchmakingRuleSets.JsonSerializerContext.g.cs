
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class GameCenterMatchmakingRuleSetsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static GameCenterMatchmakingRuleSetsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private GameCenterMatchmakingRuleSetsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_FF7A5CBBA865596B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3DBE80021E3CD75F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D098B77F00014EBC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_49BE38D1AD45E5D4.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F06C0F5997F33B32.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1BC64CE55019D7EC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DF9744F191456A45.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5BFBF488EB03B6CF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9EC0C8F20CF7431E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_12B3D2BDF505286B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CC397D9DBB84BF02.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CF6E546EF32CF5E8.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[14];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_FF7A5CBBA865596B.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_3DBE80021E3CD75F.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_D098B77F00014EBC.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_49BE38D1AD45E5D4.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_F06C0F5997F33B32.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_1BC64CE55019D7EC.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_DF9744F191456A45.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_5BFBF488EB03B6CF.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_9EC0C8F20CF7431E.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_12B3D2BDF505286B.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_CC397D9DBB84BF02.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_CF6E546EF32CF5E8.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}