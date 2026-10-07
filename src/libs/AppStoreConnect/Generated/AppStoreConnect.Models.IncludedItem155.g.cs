#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem155 : global::System.IEquatable<IncludedItem155>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.InAppPurchaseV2? InAppPurchases { get; init; }
#else
        public global::AppStoreConnect.InAppPurchaseV2? InAppPurchases { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InAppPurchases))]
#endif
        public bool IsInAppPurchases => InAppPurchases != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInAppPurchases(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.InAppPurchaseV2? value)
        {
            value = InAppPurchases;
            return IsInAppPurchases;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.InAppPurchaseV2 PickInAppPurchases() => InAppPurchases is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InAppPurchases' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem155(global::AppStoreConnect.InAppPurchaseV2 value) => new IncludedItem155((global::AppStoreConnect.InAppPurchaseV2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseV2?(IncludedItem155 @this) => @this.InAppPurchases;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem155(global::AppStoreConnect.InAppPurchaseV2? value)
        {
            InAppPurchases = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem155 FromInAppPurchases(global::AppStoreConnect.InAppPurchaseV2? value) => new IncludedItem155(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem155(global::AppStoreConnect.Subscription value) => new IncludedItem155((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem155 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem155(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem155 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem155(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem155(
            global::AppStoreConnect.PromotedPurchaseResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.InAppPurchaseV2? inAppPurchases,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            InAppPurchases = inAppPurchases;
            Subscriptions = subscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            InAppPurchases as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InAppPurchases?.ToString() ??
            Subscriptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInAppPurchases && !IsSubscriptions || !IsInAppPurchases && IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.InAppPurchaseV2, TResult>? inAppPurchases = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchases is { } __value0 && inAppPurchases != null)
            {
                return inAppPurchases(__value0);
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
            global::System.Action<global::AppStoreConnect.InAppPurchaseV2>? inAppPurchases = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchases is { } __value0)
            {
                inAppPurchases?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.InAppPurchaseV2>? inAppPurchases = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InAppPurchases is { } __value0)
            {
                inAppPurchases?.Invoke(__value0);
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
                InAppPurchases,
                typeof(global::AppStoreConnect.InAppPurchaseV2),
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
        public bool Equals(IncludedItem155 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseV2?>.Default.Equals(InAppPurchases, other.InAppPurchases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem155 obj1, IncludedItem155 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem155>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem155 obj1, IncludedItem155 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem155 o && Equals(o);
        }
    }
}
