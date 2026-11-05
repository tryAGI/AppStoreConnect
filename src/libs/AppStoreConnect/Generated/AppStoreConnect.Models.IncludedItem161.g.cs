#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem161 : global::System.IEquatable<IncludedItem161>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.RetentionOfferPrice? RetentionOfferPrices { get; init; }
#else
        public global::AppStoreConnect.RetentionOfferPrice? RetentionOfferPrices { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetentionOfferPrices))]
#endif
        public bool IsRetentionOfferPrices => RetentionOfferPrices != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetentionOfferPrices(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.RetentionOfferPrice? value)
        {
            value = RetentionOfferPrices;
            return IsRetentionOfferPrices;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionOfferPrice PickRetentionOfferPrices() => RetentionOfferPrices is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetentionOfferPrices' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem161(global::AppStoreConnect.RetentionOfferPrice value) => new IncludedItem161((global::AppStoreConnect.RetentionOfferPrice?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.RetentionOfferPrice?(IncludedItem161 @this) => @this.RetentionOfferPrices;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem161(global::AppStoreConnect.RetentionOfferPrice? value)
        {
            RetentionOfferPrices = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem161 FromRetentionOfferPrices(global::AppStoreConnect.RetentionOfferPrice? value) => new IncludedItem161(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem161(global::AppStoreConnect.Subscription value) => new IncludedItem161((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem161 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem161(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem161 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem161(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem161(
            global::AppStoreConnect.RetentionOffersResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.RetentionOfferPrice? retentionOfferPrices,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            RetentionOfferPrices = retentionOfferPrices;
            Subscriptions = subscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            RetentionOfferPrices as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RetentionOfferPrices?.ToString() ??
            Subscriptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRetentionOfferPrices && !IsSubscriptions || !IsRetentionOfferPrices && IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.RetentionOfferPrice, TResult>? retentionOfferPrices = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionOfferPrices is { } __value0 && retentionOfferPrices != null)
            {
                return retentionOfferPrices(__value0);
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
            global::System.Action<global::AppStoreConnect.RetentionOfferPrice>? retentionOfferPrices = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionOfferPrices is { } __value0)
            {
                retentionOfferPrices?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.RetentionOfferPrice>? retentionOfferPrices = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionOfferPrices is { } __value0)
            {
                retentionOfferPrices?.Invoke(__value0);
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
                RetentionOfferPrices,
                typeof(global::AppStoreConnect.RetentionOfferPrice),
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
        public bool Equals(IncludedItem161 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.RetentionOfferPrice?>.Default.Equals(RetentionOfferPrices, other.RetentionOfferPrices) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem161 obj1, IncludedItem161 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem161>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem161 obj1, IncludedItem161 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem161 o && Equals(o);
        }
    }
}
