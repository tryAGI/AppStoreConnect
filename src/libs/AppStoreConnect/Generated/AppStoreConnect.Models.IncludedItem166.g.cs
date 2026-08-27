#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem166 : global::System.IEquatable<IncludedItem166>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPricePoint? SubscriptionPricePoints { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPricePoint? SubscriptionPricePoints { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPricePoints))]
#endif
        public bool IsSubscriptionPricePoints => SubscriptionPricePoints != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubscriptionPricePoints(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPricePoint? value)
        {
            value = SubscriptionPricePoints;
            return IsSubscriptionPricePoints;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.SubscriptionPricePoint PickSubscriptionPricePoints() => IsSubscriptionPricePoints
            ? SubscriptionPricePoints!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPricePoints' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem166(global::AppStoreConnect.SubscriptionPricePoint value) => new IncludedItem166((global::AppStoreConnect.SubscriptionPricePoint?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPricePoint?(IncludedItem166 @this) => @this.SubscriptionPricePoints;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem166(global::AppStoreConnect.SubscriptionPricePoint? value)
        {
            SubscriptionPricePoints = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem166 FromSubscriptionPricePoints(global::AppStoreConnect.SubscriptionPricePoint? value) => new IncludedItem166(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem166(global::AppStoreConnect.Territory value) => new IncludedItem166((global::AppStoreConnect.Territory?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem166 @this) => @this.Territories;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem166(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem166 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem166(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem166(
            global::AppStoreConnect.SubscriptionOfferCodePricesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionPricePoint? subscriptionPricePoints,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            SubscriptionPricePoints = subscriptionPricePoints;
            Territories = territories;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Territories as object ??
            SubscriptionPricePoints as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SubscriptionPricePoints?.ToString() ??
            Territories?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionPricePoints && !IsTerritories || !IsSubscriptionPricePoints && IsTerritories;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionPricePoint, TResult>? subscriptionPricePoints = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionPricePoints && subscriptionPricePoints != null)
            {
                return subscriptionPricePoints(SubscriptionPricePoints!);
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
            global::System.Action<global::AppStoreConnect.SubscriptionPricePoint>? subscriptionPricePoints = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionPricePoints)
            {
                subscriptionPricePoints?.Invoke(SubscriptionPricePoints!);
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
            global::System.Action<global::AppStoreConnect.SubscriptionPricePoint>? subscriptionPricePoints = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionPricePoints)
            {
                subscriptionPricePoints?.Invoke(SubscriptionPricePoints!);
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
                SubscriptionPricePoints,
                typeof(global::AppStoreConnect.SubscriptionPricePoint),
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
        public bool Equals(IncludedItem166 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPricePoint?>.Default.Equals(SubscriptionPricePoints, other.SubscriptionPricePoints) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem166 obj1, IncludedItem166 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem166>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem166 obj1, IncludedItem166 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem166 o && Equals(o);
        }
    }
}
