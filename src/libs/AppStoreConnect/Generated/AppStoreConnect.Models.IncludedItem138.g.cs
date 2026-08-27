#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem138 : global::System.IEquatable<IncludedItem138>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchasePricePoint? InAppPurchasePricePoints { get; init; }
#else
        public global::AppStoreConnect.InAppPurchasePricePoint? InAppPurchasePricePoints { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchasePricePoints))]
#endif
        public bool IsInAppPurchasePricePoints => InAppPurchasePricePoints != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchasePricePoints(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchasePricePoint? value)
        {
            value = InAppPurchasePricePoints;
            return IsInAppPurchasePricePoints;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchasePricePoint PickInAppPurchasePricePoints() => IsInAppPurchasePricePoints
            ? InAppPurchasePricePoints!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchasePricePoints' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem138(global::AppStoreConnect.InAppPurchasePricePoint value) => new IncludedItem138((global::AppStoreConnect.InAppPurchasePricePoint?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchasePricePoint?(IncludedItem138 @this) => @this.InAppPurchasePricePoints;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem138(global::AppStoreConnect.InAppPurchasePricePoint? value)
        {
            InAppPurchasePricePoints = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem138 FromInAppPurchasePricePoints(global::AppStoreConnect.InAppPurchasePricePoint? value) => new IncludedItem138(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem138(global::AppStoreConnect.Territory value) => new IncludedItem138((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem138 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem138(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem138 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem138(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem138(
            global::AppStoreConnect.InAppPurchaseOfferPricesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchasePricePoint? inAppPurchasePricePoints,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            InAppPurchasePricePoints = inAppPurchasePricePoints;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            InAppPurchasePricePoints as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InAppPurchasePricePoints?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchasePricePoints && !IsTerritories || !IsInAppPurchasePricePoints && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchasePricePoint, TResult>? inAppPurchasePricePoints = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchasePricePoints && inAppPurchasePricePoints != null)
            {
                return inAppPurchasePricePoints(InAppPurchasePricePoints!);
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
            global::System.Action<global::AppStoreConnect.InAppPurchasePricePoint>? inAppPurchasePricePoints = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchasePricePoints)
            {
                inAppPurchasePricePoints?.Invoke(InAppPurchasePricePoints!);
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
            global::System.Action<global::AppStoreConnect.InAppPurchasePricePoint>? inAppPurchasePricePoints = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInAppPurchasePricePoints)
            {
                inAppPurchasePricePoints?.Invoke(InAppPurchasePricePoints!);
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
                InAppPurchasePricePoints,
                typeof(global::AppStoreConnect.InAppPurchasePricePoint),
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
        public bool Equals(IncludedItem138 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchasePricePoint?>.Default.Equals(InAppPurchasePricePoints, other.InAppPurchasePricePoints) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem138 obj1, IncludedItem138 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem138>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem138 obj1, IncludedItem138 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem138 o && Equals(o);
        }
    }
}
