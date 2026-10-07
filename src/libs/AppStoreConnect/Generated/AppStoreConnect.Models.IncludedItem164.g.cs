#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem164 : global::System.IEquatable<IncludedItem164>
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
        public global::AppStoreConnect.SubscriptionGroupLocalization PickSubscriptionGroupLocalizations() => SubscriptionGroupLocalizations is { } value
            ? value
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
        public global::AppStoreConnect.SubscriptionGroupVersion PickSubscriptionGroupVersions() => SubscriptionGroupVersions is { } value
            ? value
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
        public global::AppStoreConnect.Subscription PickSubscriptions() => Subscriptions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subscriptions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem164(global::AppStoreConnect.SubscriptionGroupLocalization value) => new IncludedItem164((global::AppStoreConnect.SubscriptionGroupLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupLocalization?(IncludedItem164 @this) => @this.SubscriptionGroupLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem164(global::AppStoreConnect.SubscriptionGroupLocalization? value)
        {
            SubscriptionGroupLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem164 FromSubscriptionGroupLocalizations(global::AppStoreConnect.SubscriptionGroupLocalization? value) => new IncludedItem164(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem164(global::AppStoreConnect.SubscriptionGroupVersion value) => new IncludedItem164((global::AppStoreConnect.SubscriptionGroupVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.SubscriptionGroupVersion?(IncludedItem164 @this) => @this.SubscriptionGroupVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem164(global::AppStoreConnect.SubscriptionGroupVersion? value)
        {
            SubscriptionGroupVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem164 FromSubscriptionGroupVersions(global::AppStoreConnect.SubscriptionGroupVersion? value) => new IncludedItem164(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem164(global::AppStoreConnect.Subscription value) => new IncludedItem164((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem164 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem164(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem164 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem164(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem164(
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

            if (SubscriptionGroupLocalizations is { } __value0 && subscriptionGroupLocalizations != null)
            {
                return subscriptionGroupLocalizations(__value0);
            }
            else if (SubscriptionGroupVersions is { } __value1 && subscriptionGroupVersions != null)
            {
                return subscriptionGroupVersions(__value1);
            }
            else if (Subscriptions is { } __value2 && subscriptions != null)
            {
                return subscriptions(__value2);
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

            if (SubscriptionGroupLocalizations is { } __value0)
            {
                subscriptionGroupLocalizations?.Invoke(__value0);
            }
            else if (SubscriptionGroupVersions is { } __value1)
            {
                subscriptionGroupVersions?.Invoke(__value1);
            }
            else if (Subscriptions is { } __value2)
            {
                subscriptions?.Invoke(__value2);
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

            if (SubscriptionGroupLocalizations is { } __value0)
            {
                subscriptionGroupLocalizations?.Invoke(__value0);
            }
            else if (SubscriptionGroupVersions is { } __value1)
            {
                subscriptionGroupVersions?.Invoke(__value1);
            }
            else if (Subscriptions is { } __value2)
            {
                subscriptions?.Invoke(__value2);
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
        public bool Equals(IncludedItem164 other)
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
        public static bool operator ==(IncludedItem164 obj1, IncludedItem164 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem164>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem164 obj1, IncludedItem164 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem164 o && Equals(o);
        }
    }
}
