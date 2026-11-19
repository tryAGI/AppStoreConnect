#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem61 : global::System.IEquatable<IncludedItem61>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPriceResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.SubscriptionPricePoint PickSubscriptionPricePoints() => SubscriptionPricePoints is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPricePoints' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPriceTier? SubscriptionPriceTiers { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPriceTier? SubscriptionPriceTiers { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPriceTiers))]
#endif
        public bool IsSubscriptionPriceTiers => SubscriptionPriceTiers != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionPriceTiers(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPriceTier? value)
        {
            value = SubscriptionPriceTiers;
            return IsSubscriptionPriceTiers;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPriceTier PickSubscriptionPriceTiers() => SubscriptionPriceTiers is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPriceTiers' but the value was {ToString()}.");

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
        public global::AppStoreConnect.Territory PickTerritories() => Territories is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.SubscriptionPricePoint value) => new IncludedItem61((global::AppStoreConnect.SubscriptionPricePoint?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPricePoint?(IncludedItem61 @this) => @this.SubscriptionPricePoints;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.SubscriptionPricePoint? value)
        {
            SubscriptionPricePoints = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromSubscriptionPricePoints(global::AppStoreConnect.SubscriptionPricePoint? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.SubscriptionPriceTier value) => new IncludedItem61((global::AppStoreConnect.SubscriptionPriceTier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPriceTier?(IncludedItem61 @this) => @this.SubscriptionPriceTiers;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.SubscriptionPriceTier? value)
        {
            SubscriptionPriceTiers = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromSubscriptionPriceTiers(global::AppStoreConnect.SubscriptionPriceTier? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem61(global::AppStoreConnect.Territory value) => new IncludedItem61((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem61 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem61 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem61(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem61(
            global::AppStoreConnect.SubscriptionPriceResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionPricePoint? subscriptionPricePoints,
            global::AppStoreConnect.SubscriptionPriceTier? subscriptionPriceTiers,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            SubscriptionPricePoints = subscriptionPricePoints;
            SubscriptionPriceTiers = subscriptionPriceTiers;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            SubscriptionPriceTiers as object ??
            SubscriptionPricePoints as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SubscriptionPricePoints?.ToString() ??
            SubscriptionPriceTiers?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionPricePoints && !IsSubscriptionPriceTiers && !IsTerritories || !IsSubscriptionPricePoints && IsSubscriptionPriceTiers && !IsTerritories || !IsSubscriptionPricePoints && !IsSubscriptionPriceTiers && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionPricePoint, TResult>? subscriptionPricePoints = null,
            global::System.Func<global::AppStoreConnect.SubscriptionPriceTier, TResult>? subscriptionPriceTiers = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPricePoints is { } __value0 && subscriptionPricePoints != null)
            {
                return subscriptionPricePoints(__value0);
            }
            else if (SubscriptionPriceTiers is { } __value1 && subscriptionPriceTiers != null)
            {
                return subscriptionPriceTiers(__value1);
            }
            else if (Territories is { } __value2 && territories != null)
            {
                return territories(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.SubscriptionPricePoint>? subscriptionPricePoints = null,

            global::System.Action<global::AppStoreConnect.SubscriptionPriceTier>? subscriptionPriceTiers = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPricePoints is { } __value0)
            {
                subscriptionPricePoints?.Invoke(__value0);
            }
            else if (SubscriptionPriceTiers is { } __value1)
            {
                subscriptionPriceTiers?.Invoke(__value1);
            }
            else if (Territories is { } __value2)
            {
                territories?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.SubscriptionPricePoint>? subscriptionPricePoints = null,
            global::System.Action<global::AppStoreConnect.SubscriptionPriceTier>? subscriptionPriceTiers = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPricePoints is { } __value0)
            {
                subscriptionPricePoints?.Invoke(__value0);
            }
            else if (SubscriptionPriceTiers is { } __value1)
            {
                subscriptionPriceTiers?.Invoke(__value1);
            }
            else if (Territories is { } __value2)
            {
                territories?.Invoke(__value2);
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
                SubscriptionPriceTiers,
                typeof(global::AppStoreConnect.SubscriptionPriceTier),
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
        public bool Equals(IncludedItem61 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPricePoint?>.Default.Equals(SubscriptionPricePoints, other.SubscriptionPricePoints) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPriceTier?>.Default.Equals(SubscriptionPriceTiers, other.SubscriptionPriceTiers) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem61>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem61 obj1, IncludedItem61 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem61 o && Equals(o);
        }
    }
}
