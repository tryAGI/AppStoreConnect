#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem30 : global::System.IEquatable<IncludedItem30>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppPricePointV3? AppPricePoints { get; init; }
#else
        public global::AppStoreConnect.AppPricePointV3? AppPricePoints { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppPricePoints))]
#endif
        public bool IsAppPricePoints => AppPricePoints != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppPricePoints(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppPricePointV3? value)
        {
            value = AppPricePoints;
            return IsAppPricePoints;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppPricePointV3 PickAppPricePoints() => IsAppPricePoints
            ? AppPricePoints!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppPricePoints' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Territory? Territories { get; init; }
#else
        public global::AppStoreConnect.Territory? Territories { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Territories))]
#endif
        public bool IsTerritories => Territories != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTerritories(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Territory? value)
        {
            value = Territories;
            return IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Territory PickTerritories() => IsTerritories
            ? Territories!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem30(global::AppStoreConnect.AppPricePointV3 value) => new IncludedItem30((global::AppStoreConnect.AppPricePointV3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppPricePointV3?(IncludedItem30 @this) => @this.AppPricePoints;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(global::AppStoreConnect.AppPricePointV3? value)
        {
            AppPricePoints = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem30 FromAppPricePoints(global::AppStoreConnect.AppPricePointV3? value) => new IncludedItem30(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem30(global::AppStoreConnect.Territory value) => new IncludedItem30((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem30 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem30 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem30(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem30(
            global::AppStoreConnect.AppPricesV2ResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppPricePointV3? appPricePoints,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            AppPricePoints = appPricePoints;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            AppPricePoints as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppPricePoints?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppPricePoints && !IsTerritories || !IsAppPricePoints && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppPricePointV3, TResult>? appPricePoints = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPricePoints && appPricePoints != null)
            {
                return appPricePoints(AppPricePoints!);
            }
            else if (IsTerritories && territories != null)
            {
                return territories(Territories!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppPricePointV3>? appPricePoints = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPricePoints)
            {
                appPricePoints?.Invoke(AppPricePoints!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppPricePointV3>? appPricePoints = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppPricePoints)
            {
                appPricePoints?.Invoke(AppPricePoints!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppPricePoints,
                typeof(global::AppStoreConnect.AppPricePointV3),
                Territories,
                typeof(global::AppStoreConnect.Territory),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(IncludedItem30 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppPricePointV3?>.Default.Equals(AppPricePoints, other.AppPricePoints) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem30 obj1, IncludedItem30 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem30>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem30 obj1, IncludedItem30 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem30 o && Equals(o);
        }
    }
}
