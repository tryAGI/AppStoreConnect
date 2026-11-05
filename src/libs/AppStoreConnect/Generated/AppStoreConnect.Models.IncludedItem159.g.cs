#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem159 : global::System.IEquatable<IncludedItem159>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionMessageResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.RetentionMessageVersion? RetentionMessageVersions { get; init; }
#else
        public global::AppStoreConnect.RetentionMessageVersion? RetentionMessageVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RetentionMessageVersions))]
#endif
        public bool IsRetentionMessageVersions => RetentionMessageVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRetentionMessageVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.RetentionMessageVersion? value)
        {
            value = RetentionMessageVersions;
            return IsRetentionMessageVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.RetentionMessageVersion PickRetentionMessageVersions() => RetentionMessageVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RetentionMessageVersions' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem159(global::AppStoreConnect.RetentionMessageVersion value) => new IncludedItem159((global::AppStoreConnect.RetentionMessageVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.RetentionMessageVersion?(IncludedItem159 @this) => @this.RetentionMessageVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem159(global::AppStoreConnect.RetentionMessageVersion? value)
        {
            RetentionMessageVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem159 FromRetentionMessageVersions(global::AppStoreConnect.RetentionMessageVersion? value) => new IncludedItem159(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem159(global::AppStoreConnect.Subscription value) => new IncludedItem159((global::AppStoreConnect.Subscription?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Subscription?(IncludedItem159 @this) => @this.Subscriptions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem159(global::AppStoreConnect.Subscription? value)
        {
            Subscriptions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem159 FromSubscriptions(global::AppStoreConnect.Subscription? value) => new IncludedItem159(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem159(
            global::AppStoreConnect.RetentionMessageResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.RetentionMessageVersion? retentionMessageVersions,
            global::AppStoreConnect.Subscription? subscriptions
            )
        {
            Type = type;

            RetentionMessageVersions = retentionMessageVersions;
            Subscriptions = subscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Subscriptions as object ??
            RetentionMessageVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RetentionMessageVersions?.ToString() ??
            Subscriptions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRetentionMessageVersions && !IsSubscriptions || !IsRetentionMessageVersions && IsSubscriptions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.RetentionMessageVersion, TResult>? retentionMessageVersions = null,
            global::System.Func<global::AppStoreConnect.Subscription, TResult>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionMessageVersions is { } __value0 && retentionMessageVersions != null)
            {
                return retentionMessageVersions(__value0);
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
            global::System.Action<global::AppStoreConnect.RetentionMessageVersion>? retentionMessageVersions = null,

            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionMessageVersions is { } __value0)
            {
                retentionMessageVersions?.Invoke(__value0);
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
            global::System.Action<global::AppStoreConnect.RetentionMessageVersion>? retentionMessageVersions = null,
            global::System.Action<global::AppStoreConnect.Subscription>? subscriptions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RetentionMessageVersions is { } __value0)
            {
                retentionMessageVersions?.Invoke(__value0);
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
                RetentionMessageVersions,
                typeof(global::AppStoreConnect.RetentionMessageVersion),
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
        public bool Equals(IncludedItem159 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.RetentionMessageVersion?>.Default.Equals(RetentionMessageVersions, other.RetentionMessageVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Subscription?>.Default.Equals(Subscriptions, other.Subscriptions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem159 obj1, IncludedItem159 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem159>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem159 obj1, IncludedItem159 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem159 o && Equals(o);
        }
    }
}
