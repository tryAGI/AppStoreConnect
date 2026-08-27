#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem103 : global::System.IEquatable<IncludedItem103>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? Apps { get; init; }
#else
        public global::AppStoreConnect.App? Apps { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Apps))]
#endif
        public bool IsApps => Apps != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = Apps;
            return IsApps;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickApps() => IsApps
            ? Apps!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterEnabledVersion? GameCenterEnabledVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterEnabledVersion? GameCenterEnabledVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterEnabledVersions))]
#endif
        public bool IsGameCenterEnabledVersions => GameCenterEnabledVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterEnabledVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterEnabledVersion? value)
        {
            value = GameCenterEnabledVersions;
            return IsGameCenterEnabledVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterEnabledVersion PickGameCenterEnabledVersions() => IsGameCenterEnabledVersions
            ? GameCenterEnabledVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterEnabledVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem103(global::AppStoreConnect.App value) => new IncludedItem103((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem103 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem103(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem103 FromApps(global::AppStoreConnect.App? value) => new IncludedItem103(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem103(global::AppStoreConnect.GameCenterEnabledVersion value) => new IncludedItem103((global::AppStoreConnect.GameCenterEnabledVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterEnabledVersion?(IncludedItem103 @this) => @this.GameCenterEnabledVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem103(global::AppStoreConnect.GameCenterEnabledVersion? value)
        {
            GameCenterEnabledVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem103 FromGameCenterEnabledVersions(global::AppStoreConnect.GameCenterEnabledVersion? value) => new IncludedItem103(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem103(
            global::AppStoreConnect.GameCenterEnabledVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.GameCenterEnabledVersion? gameCenterEnabledVersions
            )
        {
            Type = type;

            Apps = apps;
            GameCenterEnabledVersions = gameCenterEnabledVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterEnabledVersions as object ??
            Apps as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Apps?.ToString() ??
            GameCenterEnabledVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsApps && !IsGameCenterEnabledVersions || !IsApps && IsGameCenterEnabledVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.GameCenterEnabledVersion, TResult>? gameCenterEnabledVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps && apps != null)
            {
                return apps(Apps!);
            }
            else if (IsGameCenterEnabledVersions && gameCenterEnabledVersions != null)
            {
                return gameCenterEnabledVersions(GameCenterEnabledVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.GameCenterEnabledVersion>? gameCenterEnabledVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsGameCenterEnabledVersions)
            {
                gameCenterEnabledVersions?.Invoke(GameCenterEnabledVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.GameCenterEnabledVersion>? gameCenterEnabledVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApps)
            {
                apps?.Invoke(Apps!);
            }
            else if (IsGameCenterEnabledVersions)
            {
                gameCenterEnabledVersions?.Invoke(GameCenterEnabledVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Apps,
                typeof(global::AppStoreConnect.App),
                GameCenterEnabledVersions,
                typeof(global::AppStoreConnect.GameCenterEnabledVersion),
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
        public bool Equals(IncludedItem103 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterEnabledVersion?>.Default.Equals(GameCenterEnabledVersions, other.GameCenterEnabledVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem103 obj1, IncludedItem103 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem103>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem103 obj1, IncludedItem103 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem103 o && Equals(o);
        }
    }
}
