
#nullable enable

namespace AppStoreConnect
{    /// <summary>
    ///
    /// </summary>
    public sealed partial class AppsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AppsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AppsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::AppStoreConnect.SourceGenerationContextGraph_F4487A25FFFBFFC2.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8BB033D224809AED.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_95FADB56B5142E3D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3628789B1143FBA9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8CC5A6FDD8A55155.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CEACB3568C4DD6AB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7A2658FCE828BEC7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_43691DF69D784C72.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C3F7469F050561C0.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_03BFA7762B684D38.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_58EBB619C968EE9C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5217AB0B342C172B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F6C4CFC0588ACF76.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_813C33222330242F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B6D55DEE7C008E86.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_170B7F3D4AFF0A0E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D9BEF2B937943E36.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_91157B61C393956C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3F059F2EDF1203FA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_34A60FBB389130B7.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3CAC9193CF3B1454.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_38F32E7FF02C3932.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0B7986CA4F45CBDB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DE43EC728FD4A9DB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A73AF79073002EAC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_29B4C3814D5276D5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C9B427885CB8EF46.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_130A0FD60073A648.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CDE27E38402B5E2C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FB96EBF00B17F948.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9B1C16FA5CD45827.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C67793CC2A7608FC.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FA1D5FBED1A1261C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F22D0B344E69897D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_4B85EE7CF5FA78D5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_DD135D628AE093E9.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9AAF82A638794348.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_830AD4F0A9310F1A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0BB63FBD004EF933.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_98D4B5F0240EDCD6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E039436152387811.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_45E16B39C0D15E6F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_70303E6F91154B9B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_00600DFD25DF06D6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_48F87105AF0EF6EF.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_416EEE2068E6FE74.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FA46644D3D59C58E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_652672890F1B4B2C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B36C7349FBC01BED.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_BCE3D72CB56B2D5F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C7CC30D1217A4D49.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5FEA215A09242356.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D64D9FE231FEC805.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_48C26C501F64FB81.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_845522CBF0AA0337.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0AE22EE6856D2E1F.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_09D663F2A99F6786.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_8AEDF1BEAA9225B6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_64544EECAE17A240.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_726561F71F2CA118.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A4592334458E587E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_06DCADA88DD4F36B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D8A5D4FF54A7CF4D.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D361D127A3AE74CA.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B21360ED4FCA1636.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_0FBB4A6AFB41978B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7387803977FD8B85.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_60305C428966BBC3.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_84B28F561072E974.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_FAAAA4A9EF045807.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_70F922C57DA266CB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6884BC14795757DE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_CE521FD1324FD1DD.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_801C778727E16E30.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_5E86A349D60E6852.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C5390AA41DB0BF10.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_475E579030451C62.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_690D4D87FFC88729.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E8C8B7EFBA45A85C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_1CBAC600BCEB7C79.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_82DDF9E15068A943.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D9545B2DD86F73C1.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_3956BB14FED1536C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_F933E650902D5EA5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7123C5E808F77F00.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A581FF09830B74D6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_EC41BD76F3469B5E.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_EBB124F836A7F5CE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_71ED7407BAB3CE5C.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_A115ADEBC9844094.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_180AC032CD40B51A.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_EF8E17C1873F2213.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_C44C019762170826.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_51BBB04954A79B05.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_75CECA2EC079C0BB.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_D0D341D43A102A46.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_E25C3419BB5EC3B5.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_9DAB8FE686DA0256.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_017905C22BF23D2B.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_978AF2E32F7AA1E6.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_6BC34C71234431DE.AddConverters(options);
            global::AppStoreConnect.SourceGenerationContextGraph_7CA0F65A822BE811.AddConverters(options);
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
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[107];

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
                    0 => global::AppStoreConnect.SourceGenerationContextGraph_F4487A25FFFBFFC2.TypeInfoResolver,

                    1 => global::AppStoreConnect.SourceGenerationContextGraph_B13FE678A1B36769.TypeInfoResolver,

                    2 => global::AppStoreConnect.SourceGenerationContextGraph_6DA88C34BA124C41.TypeInfoResolver,

                    3 => global::AppStoreConnect.SourceGenerationContextGraph_8BB033D224809AED.TypeInfoResolver,

                    4 => global::AppStoreConnect.SourceGenerationContextGraph_95FADB56B5142E3D.TypeInfoResolver,

                    5 => global::AppStoreConnect.SourceGenerationContextGraph_3628789B1143FBA9.TypeInfoResolver,

                    6 => global::AppStoreConnect.SourceGenerationContextGraph_8CC5A6FDD8A55155.TypeInfoResolver,

                    7 => global::AppStoreConnect.SourceGenerationContextGraph_CEACB3568C4DD6AB.TypeInfoResolver,

                    8 => global::AppStoreConnect.SourceGenerationContextGraph_7A2658FCE828BEC7.TypeInfoResolver,

                    9 => global::AppStoreConnect.SourceGenerationContextGraph_43691DF69D784C72.TypeInfoResolver,

                    10 => global::AppStoreConnect.SourceGenerationContextGraph_C3F7469F050561C0.TypeInfoResolver,

                    11 => global::AppStoreConnect.SourceGenerationContextGraph_03BFA7762B684D38.TypeInfoResolver,

                    12 => global::AppStoreConnect.SourceGenerationContextGraph_58EBB619C968EE9C.TypeInfoResolver,

                    13 => global::AppStoreConnect.SourceGenerationContextGraph_5217AB0B342C172B.TypeInfoResolver,

                    14 => global::AppStoreConnect.SourceGenerationContextGraph_F6C4CFC0588ACF76.TypeInfoResolver,

                    15 => global::AppStoreConnect.SourceGenerationContextGraph_01286B345C7FB528.TypeInfoResolver,

                    16 => global::AppStoreConnect.SourceGenerationContextGraph_813C33222330242F.TypeInfoResolver,

                    17 => global::AppStoreConnect.SourceGenerationContextGraph_B6D55DEE7C008E86.TypeInfoResolver,

                    18 => global::AppStoreConnect.SourceGenerationContextGraph_170B7F3D4AFF0A0E.TypeInfoResolver,

                    19 => global::AppStoreConnect.SourceGenerationContextGraph_D9BEF2B937943E36.TypeInfoResolver,

                    20 => global::AppStoreConnect.SourceGenerationContextGraph_91157B61C393956C.TypeInfoResolver,

                    21 => global::AppStoreConnect.SourceGenerationContextGraph_3F059F2EDF1203FA.TypeInfoResolver,

                    22 => global::AppStoreConnect.SourceGenerationContextGraph_34A60FBB389130B7.TypeInfoResolver,

                    23 => global::AppStoreConnect.SourceGenerationContextGraph_3CAC9193CF3B1454.TypeInfoResolver,

                    24 => global::AppStoreConnect.SourceGenerationContextGraph_38F32E7FF02C3932.TypeInfoResolver,

                    25 => global::AppStoreConnect.SourceGenerationContextGraph_0B7986CA4F45CBDB.TypeInfoResolver,

                    26 => global::AppStoreConnect.SourceGenerationContextGraph_DE43EC728FD4A9DB.TypeInfoResolver,

                    27 => global::AppStoreConnect.SourceGenerationContextGraph_A73AF79073002EAC.TypeInfoResolver,

                    28 => global::AppStoreConnect.SourceGenerationContextGraph_29B4C3814D5276D5.TypeInfoResolver,

                    29 => global::AppStoreConnect.SourceGenerationContextGraph_C9B427885CB8EF46.TypeInfoResolver,

                    30 => global::AppStoreConnect.SourceGenerationContextGraph_130A0FD60073A648.TypeInfoResolver,

                    31 => global::AppStoreConnect.SourceGenerationContextGraph_CDE27E38402B5E2C.TypeInfoResolver,

                    32 => global::AppStoreConnect.SourceGenerationContextGraph_FB96EBF00B17F948.TypeInfoResolver,

                    33 => global::AppStoreConnect.SourceGenerationContextGraph_9B1C16FA5CD45827.TypeInfoResolver,

                    34 => global::AppStoreConnect.SourceGenerationContextGraph_C67793CC2A7608FC.TypeInfoResolver,

                    35 => global::AppStoreConnect.SourceGenerationContextGraph_FA1D5FBED1A1261C.TypeInfoResolver,

                    36 => global::AppStoreConnect.SourceGenerationContextGraph_F22D0B344E69897D.TypeInfoResolver,

                    37 => global::AppStoreConnect.SourceGenerationContextGraph_4B85EE7CF5FA78D5.TypeInfoResolver,

                    38 => global::AppStoreConnect.SourceGenerationContextGraph_DD135D628AE093E9.TypeInfoResolver,

                    39 => global::AppStoreConnect.SourceGenerationContextGraph_9AAF82A638794348.TypeInfoResolver,

                    40 => global::AppStoreConnect.SourceGenerationContextGraph_830AD4F0A9310F1A.TypeInfoResolver,

                    41 => global::AppStoreConnect.SourceGenerationContextGraph_0BB63FBD004EF933.TypeInfoResolver,

                    42 => global::AppStoreConnect.SourceGenerationContextGraph_98D4B5F0240EDCD6.TypeInfoResolver,

                    43 => global::AppStoreConnect.SourceGenerationContextGraph_E039436152387811.TypeInfoResolver,

                    44 => global::AppStoreConnect.SourceGenerationContextGraph_45E16B39C0D15E6F.TypeInfoResolver,

                    45 => global::AppStoreConnect.SourceGenerationContextGraph_70303E6F91154B9B.TypeInfoResolver,

                    46 => global::AppStoreConnect.SourceGenerationContextGraph_00600DFD25DF06D6.TypeInfoResolver,

                    47 => global::AppStoreConnect.SourceGenerationContextGraph_48F87105AF0EF6EF.TypeInfoResolver,

                    48 => global::AppStoreConnect.SourceGenerationContextGraph_416EEE2068E6FE74.TypeInfoResolver,

                    49 => global::AppStoreConnect.SourceGenerationContextGraph_FA46644D3D59C58E.TypeInfoResolver,

                    50 => global::AppStoreConnect.SourceGenerationContextGraph_652672890F1B4B2C.TypeInfoResolver,

                    51 => global::AppStoreConnect.SourceGenerationContextGraph_B36C7349FBC01BED.TypeInfoResolver,

                    52 => global::AppStoreConnect.SourceGenerationContextGraph_BCE3D72CB56B2D5F.TypeInfoResolver,

                    53 => global::AppStoreConnect.SourceGenerationContextGraph_C7CC30D1217A4D49.TypeInfoResolver,

                    54 => global::AppStoreConnect.SourceGenerationContextGraph_5FEA215A09242356.TypeInfoResolver,

                    55 => global::AppStoreConnect.SourceGenerationContextGraph_D64D9FE231FEC805.TypeInfoResolver,

                    56 => global::AppStoreConnect.SourceGenerationContextGraph_48C26C501F64FB81.TypeInfoResolver,

                    57 => global::AppStoreConnect.SourceGenerationContextGraph_845522CBF0AA0337.TypeInfoResolver,

                    58 => global::AppStoreConnect.SourceGenerationContextGraph_0AE22EE6856D2E1F.TypeInfoResolver,

                    59 => global::AppStoreConnect.SourceGenerationContextGraph_09D663F2A99F6786.TypeInfoResolver,

                    60 => global::AppStoreConnect.SourceGenerationContextGraph_8AEDF1BEAA9225B6.TypeInfoResolver,

                    61 => global::AppStoreConnect.SourceGenerationContextGraph_64544EECAE17A240.TypeInfoResolver,

                    62 => global::AppStoreConnect.SourceGenerationContextGraph_726561F71F2CA118.TypeInfoResolver,

                    63 => global::AppStoreConnect.SourceGenerationContextGraph_A4592334458E587E.TypeInfoResolver,

                    64 => global::AppStoreConnect.SourceGenerationContextGraph_06DCADA88DD4F36B.TypeInfoResolver,

                    65 => global::AppStoreConnect.SourceGenerationContextGraph_D8A5D4FF54A7CF4D.TypeInfoResolver,

                    66 => global::AppStoreConnect.SourceGenerationContextGraph_D361D127A3AE74CA.TypeInfoResolver,

                    67 => global::AppStoreConnect.SourceGenerationContextGraph_B21360ED4FCA1636.TypeInfoResolver,

                    68 => global::AppStoreConnect.SourceGenerationContextGraph_0FBB4A6AFB41978B.TypeInfoResolver,

                    69 => global::AppStoreConnect.SourceGenerationContextGraph_7387803977FD8B85.TypeInfoResolver,

                    70 => global::AppStoreConnect.SourceGenerationContextGraph_60305C428966BBC3.TypeInfoResolver,

                    71 => global::AppStoreConnect.SourceGenerationContextGraph_B760F44FA5965C24.TypeInfoResolver,

                    72 => global::AppStoreConnect.SourceGenerationContextGraph_84B28F561072E974.TypeInfoResolver,

                    73 => global::AppStoreConnect.SourceGenerationContextGraph_FAAAA4A9EF045807.TypeInfoResolver,

                    74 => global::AppStoreConnect.SourceGenerationContextGraph_70F922C57DA266CB.TypeInfoResolver,

                    75 => global::AppStoreConnect.SourceGenerationContextGraph_6884BC14795757DE.TypeInfoResolver,

                    76 => global::AppStoreConnect.SourceGenerationContextGraph_CE521FD1324FD1DD.TypeInfoResolver,

                    77 => global::AppStoreConnect.SourceGenerationContextGraph_801C778727E16E30.TypeInfoResolver,

                    78 => global::AppStoreConnect.SourceGenerationContextGraph_5E86A349D60E6852.TypeInfoResolver,

                    79 => global::AppStoreConnect.SourceGenerationContextGraph_C5390AA41DB0BF10.TypeInfoResolver,

                    80 => global::AppStoreConnect.SourceGenerationContextGraph_475E579030451C62.TypeInfoResolver,

                    81 => global::AppStoreConnect.SourceGenerationContextGraph_690D4D87FFC88729.TypeInfoResolver,

                    82 => global::AppStoreConnect.SourceGenerationContextGraph_E8C8B7EFBA45A85C.TypeInfoResolver,

                    83 => global::AppStoreConnect.SourceGenerationContextGraph_1CBAC600BCEB7C79.TypeInfoResolver,

                    84 => global::AppStoreConnect.SourceGenerationContextGraph_82DDF9E15068A943.TypeInfoResolver,

                    85 => global::AppStoreConnect.SourceGenerationContextGraph_D9545B2DD86F73C1.TypeInfoResolver,

                    86 => global::AppStoreConnect.SourceGenerationContextGraph_3956BB14FED1536C.TypeInfoResolver,

                    87 => global::AppStoreConnect.SourceGenerationContextGraph_F933E650902D5EA5.TypeInfoResolver,

                    88 => global::AppStoreConnect.SourceGenerationContextGraph_7123C5E808F77F00.TypeInfoResolver,

                    89 => global::AppStoreConnect.SourceGenerationContextGraph_A581FF09830B74D6.TypeInfoResolver,

                    90 => global::AppStoreConnect.SourceGenerationContextGraph_EC41BD76F3469B5E.TypeInfoResolver,

                    91 => global::AppStoreConnect.SourceGenerationContextGraph_EBB124F836A7F5CE.TypeInfoResolver,

                    92 => global::AppStoreConnect.SourceGenerationContextGraph_71ED7407BAB3CE5C.TypeInfoResolver,

                    93 => global::AppStoreConnect.SourceGenerationContextGraph_A115ADEBC9844094.TypeInfoResolver,

                    94 => global::AppStoreConnect.SourceGenerationContextGraph_180AC032CD40B51A.TypeInfoResolver,

                    95 => global::AppStoreConnect.SourceGenerationContextGraph_EF8E17C1873F2213.TypeInfoResolver,

                    96 => global::AppStoreConnect.SourceGenerationContextGraph_C44C019762170826.TypeInfoResolver,

                    97 => global::AppStoreConnect.SourceGenerationContextGraph_6426A0703B85F664.TypeInfoResolver,

                    98 => global::AppStoreConnect.SourceGenerationContextGraph_51BBB04954A79B05.TypeInfoResolver,

                    99 => global::AppStoreConnect.SourceGenerationContextGraph_75CECA2EC079C0BB.TypeInfoResolver,

                    100 => global::AppStoreConnect.SourceGenerationContextGraph_D0D341D43A102A46.TypeInfoResolver,

                    101 => global::AppStoreConnect.SourceGenerationContextGraph_E25C3419BB5EC3B5.TypeInfoResolver,

                    102 => global::AppStoreConnect.SourceGenerationContextGraph_9DAB8FE686DA0256.TypeInfoResolver,

                    103 => global::AppStoreConnect.SourceGenerationContextGraph_017905C22BF23D2B.TypeInfoResolver,

                    104 => global::AppStoreConnect.SourceGenerationContextGraph_978AF2E32F7AA1E6.TypeInfoResolver,

                    105 => global::AppStoreConnect.SourceGenerationContextGraph_6BC34C71234431DE.TypeInfoResolver,

                    106 => global::AppStoreConnect.SourceGenerationContextGraph_7CA0F65A822BE811.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}