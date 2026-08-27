#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem162 : global::System.IEquatable<IncludedItem162>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroupLocalization? SubscriptionGroupLocalizations { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroupLocalization? SubscriptionGroupLocalizations { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroupLocalizations))]
#endif
        public bool IsSubscriptionGroupLocalizations => SubscriptionGroupLocalizations != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubscriptionGroupLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroupLocalization? value)
        {
            value = SubscriptionGroupLocalizations;
            return IsSubscriptionGroupLocalizations;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupLocalization PickSubscriptionGroupLocalizations() => IsSubscriptionGroupLocalizations
            ? SubscriptionGroupLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroupLocalizations' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.SubscriptionGroupVersion? SubscriptionGroupVersions { get; init; }
#else
        public global::AppStoreConnect.SubscriptionGroupVersion? SubscriptionGroupVersions { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscriptionGroupVersions))]
#endif
        public bool IsSubscriptionGroupVersions => SubscriptionGroupVersions != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubscriptionGroupVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            value = SubscriptionGroupVersions;
            return IsSubscriptionGroupVersions;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.SubscriptionGroupVersion PickSubscriptionGroupVersions() => IsSubscriptionGroupVersions
            ? SubscriptionGroupVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscriptionGroupVersions' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem162(global::AppStoreConnect.SubscriptionGroupLocalization value) => new IncludedItem162((global::AppStoreConnect.SubscriptionGroupLocalization?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupLocalization?(IncludedItem162 @this) => @this.SubscriptionGroupLocalizations;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem162(global::AppStoreConnect.SubscriptionGroupLocalization? value)
        {
            SubscriptionGroupLocalizations = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem162 FromSubscriptionGroupLocalizations(global::AppStoreConnect.SubscriptionGroupLocalization? value) => new IncludedItem162(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem162(global::AppStoreConnect.SubscriptionGroupVersion value) => new IncludedItem162((global::AppStoreConnect.SubscriptionGroupVersion?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupVersion?(IncludedItem162 @this) => @this.SubscriptionGroupVersions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem162(global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            SubscriptionGroupVersions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem162 FromSubscriptionGroupVersions(global::AppStoreConnect.SubscriptionGroupVersion? value) => new IncludedItem162(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem162(global::AppStoreConnect.Subscription value) => new IncludedItem162((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem162 @this) => @this.Subscriptions;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem162(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem162 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem162(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem162(
            global::AppStoreConnect.SubscriptionGroupsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.SubscriptionGroupLocalization? subscriptionGroupLocalizations,
            global::AppStoreConnect.SubscriptionGroupVersion? subscriptionGroupVersions,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            SubscriptionGroupLocalizations = subscriptionGroupLocalizations;
            SubscriptionGroupVersions = subscriptionGroupVersions;
            Subscriptions = subscriptions;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            SubscriptionGroupVersions as object ??
            SubscriptionGroupLocalizations as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SubscriptionGroupLocalizations?.ToString() ??
            SubscriptionGroupVersions?.ToString() ??
            Subscriptions?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSubscriptionGroupLocalizations && !IsSubscriptionGroupVersions && !IsSubscriptions || !IsSubscriptionGroupLocalizations && IsSubscriptionGroupVersions && !IsSubscriptions || !IsSubscriptionGroupLocalizations && !IsSubscriptionGroupVersions && IsSubscriptions;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.SubscriptionGroupLocalization, TResult>? subscriptionGroupLocalizations = null,
            global::System.Func<global::AppStoreConnect.SubscriptionGroupVersion, TResult>? subscriptionGroupVersions = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionGroupLocalizations && subscriptionGroupLocalizations != null)
            {
                return subscriptionGroupLocalizations(SubscriptionGroupLocalizations!);
            }
            else if (IsSubscriptionGroupVersions && subscriptionGroupVersions != null)
            {
                return subscriptionGroupVersions(SubscriptionGroupVersions!);
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
            global::System.Action<global::AppStoreConnect.SubscriptionGroupLocalization>? subscriptionGroupLocalizations = null,

            global::System.Action<global::AppStoreConnect.SubscriptionGroupVersion>? subscriptionGroupVersions = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionGroupLocalizations)
            {
                subscriptionGroupLocalizations?.Invoke(SubscriptionGroupLocalizations!);
            }
            else if (IsSubscriptionGroupVersions)
            {
                subscriptionGroupVersions?.Invoke(SubscriptionGroupVersions!);
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
            global::System.Action<global::AppStoreConnect.SubscriptionGroupLocalization>? subscriptionGroupLocalizations = null,
            global::System.Action<global::AppStoreConnect.SubscriptionGroupVersion>? subscriptionGroupVersions = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSubscriptionGroupLocalizations)
            {
                subscriptionGroupLocalizations?.Invoke(SubscriptionGroupLocalizations!);
            }
            else if (IsSubscriptionGroupVersions)
            {
                subscriptionGroupVersions?.Invoke(SubscriptionGroupVersions!);
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
                SubscriptionGroupLocalizations,
                typeof(global::AppStoreConnect.SubscriptionGroupLocalization),
                SubscriptionGroupVersions,
                typeof(global::AppStoreConnect.SubscriptionGroupVersion),
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
        public bool Equals(IncludedItem162 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroupLocalization?>.Default.Equals(SubscriptionGroupLocalizations, other.SubscriptionGroupLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.SubscriptionGroupVersion?>.Default.Equals(SubscriptionGroupVersions, other.SubscriptionGroupVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem162 obj1, IncludedItem162 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem162>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem162 obj1, IncludedItem162 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem162 o && Equals(o);
        }
    }
}
