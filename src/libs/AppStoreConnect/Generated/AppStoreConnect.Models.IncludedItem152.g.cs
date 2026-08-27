#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem152 : global::System.IEquatable<IncludedItem152>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.PromotedPurchasesResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.InAppPurchaseV2 PickInAppPurchases() => IsInAppPurchases
            ? InAppPurchases!
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
        public global::AppStoreConnect.Subscription PickSubscriptions() => IsSubscriptions
            ? Subscriptions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subscriptions' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem152(global::AppStoreConnect.InAppPurchaseV2 value) => new IncludedItem152((global::AppStoreConnect.InAppPurchaseV2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.InAppPurchaseV2?(IncludedItem152 @this) => @this.InAppPurchases;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem152(global::AppStoreConnect.InAppPurchaseV2? value)
        {
            InAppPurchases = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem152 FromInAppPurchases(global::AppStoreConnect.InAppPurchaseV2? value) => new IncludedItem152(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem152(global::AppStoreConnect.Subscription value) => new IncludedItem152((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem152 @this) => @this.Subscriptions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem152(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem152 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem152(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem152(
            global::AppStoreConnect.PromotedPurchasesResponseIncludedItemDiscriminatorType? type,
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

            if (IsInAppPurchases && inAppPurchases != null)
            {
                return inAppPurchases(InAppPurchases!);
            }
            else if (IsSubscriptions && subscriptions != null)
            {
                return subscriptions(Subscriptions!);
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

            if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
            else if (IsSubscriptions)
            {
                subscriptions?.Invoke(Subscriptions!);
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

            if (IsInAppPurchases)
            {
                inAppPurchases?.Invoke(InAppPurchases!);
            }
            else if (IsSubscriptions)
            {
                subscriptions?.Invoke(Subscriptions!);
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
        public bool Equals(IncludedItem152 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.InAppPurchaseV2?>.Default.Equals(InAppPurchases, other.InAppPurchases) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem152 obj1, IncludedItem152 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem152>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem152 obj1, IncludedItem152 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem152 o && Equals(o);
        }
    }
}
