#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem174 : global::System.IEquatable<IncludedItem174>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionPromotionalOfferPrice? SubscriptionPromotionalOfferPrices { get; init; }
#else
        public global::AppStoreConnect.SubscriptionPromotionalOfferPrice? SubscriptionPromotionalOfferPrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionPromotionalOfferPrices))]
#endif
        public bool IsSubscriptionPromotionalOfferPrices => SubscriptionPromotionalOfferPrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptionPromotionalOfferPrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionPromotionalOfferPrice? value)
        {
            value = SubscriptionPromotionalOfferPrices;
            return IsSubscriptionPromotionalOfferPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.SubscriptionPromotionalOfferPrice PickSubscriptionPromotionalOfferPrices() => SubscriptionPromotionalOfferPrices is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionPromotionalOfferPrices' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Subscription? Subscriptions { get; init; }
#else
        public global::AppStoreConnect.Subscription? Subscriptions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Subscriptions))]
#endif
        public bool IsSubscriptions => Subscriptions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscriptions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Subscription? value)
        {
            value = Subscriptions;
            return IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Subscription PickSubscriptions() => Subscriptions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subscriptions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem174(global::AppStoreConnect.SubscriptionPromotionalOfferPrice value) => new IncludedItem174((global::AppStoreConnect.SubscriptionPromotionalOfferPrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionPromotionalOfferPrice?(IncludedItem174 @this) => @this.SubscriptionPromotionalOfferPrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem174(global::AppStoreConnect.SubscriptionPromotionalOfferPrice? value)
        {
            SubscriptionPromotionalOfferPrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem174 FromSubscriptionPromotionalOfferPrices(global::AppStoreConnect.SubscriptionPromotionalOfferPrice? value) => new IncludedItem174(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem174(global::AppStoreConnect.Subscription value) => new IncludedItem174((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem174 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem174(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem174 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem174(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem174(
            global::AppStoreConnect.SubscriptionPromotionalOffersResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionPromotionalOfferPrice? subscriptionPromotionalOfferPrices,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            SubscriptionPromotionalOfferPrices = subscriptionPromotionalOfferPrices;
            Subscriptions = subscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            SubscriptionPromotionalOfferPrices as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SubscriptionPromotionalOfferPrices?.ToString() ??
            Subscriptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionPromotionalOfferPrices && !IsSubscriptions || !IsSubscriptionPromotionalOfferPrices && IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionPromotionalOfferPrice, TResult>? subscriptionPromotionalOfferPrices = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPromotionalOfferPrices is { } __value0 && subscriptionPromotionalOfferPrices != null)
            {
                return subscriptionPromotionalOfferPrices(__value0);
            }
            else if (Subscriptions is { } __value1 && subscriptions != null)
            {
                return subscriptions(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.SubscriptionPromotionalOfferPrice>? subscriptionPromotionalOfferPrices = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPromotionalOfferPrices is { } __value0)
            {
                subscriptionPromotionalOfferPrices?.Invoke(__value0);
            }
            else if (Subscriptions is { } __value1)
            {
                subscriptions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.SubscriptionPromotionalOfferPrice>? subscriptionPromotionalOfferPrices = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SubscriptionPromotionalOfferPrices is { } __value0)
            {
                subscriptionPromotionalOfferPrices?.Invoke(__value0);
            }
            else if (Subscriptions is { } __value1)
            {
                subscriptions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SubscriptionPromotionalOfferPrices,
                typeof(global::AppStoreConnect.SubscriptionPromotionalOfferPrice),
                Subscriptions,
                typeof(global::AppStoreConnect.Subscription),
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
        public bool Equals(IncludedItem174 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionPromotionalOfferPrice?>.Default.Equals(SubscriptionPromotionalOfferPrices, other.SubscriptionPromotionalOfferPrices) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem174 obj1, IncludedItem174 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem174>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem174 obj1, IncludedItem174 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem174 o && Equals(o);
        }
    }
}
