#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem95 : global::System.IEquatable<IncludedItem95>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersion? AppStoreVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersions))]
#endif
        public bool IsAppStoreVersions => AppStoreVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersion? value)
        {
            value = AppStoreVersions;
            return IsAppStoreVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => AppStoreVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; init; }
#else
        public global::AppStoreConnect.GameCenterAppVersion? GameCenterAppVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GameCenterAppVersions))]
#endif
        public bool IsGameCenterAppVersions => GameCenterAppVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGameCenterAppVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.GameCenterAppVersion? value)
        {
            value = GameCenterAppVersions;
            return IsGameCenterAppVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.GameCenterAppVersion PickGameCenterAppVersions() => GameCenterAppVersions is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'GameCenterAppVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem95(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem95((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem95 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem95(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem95 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem95(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem95(global::AppStoreConnect.GameCenterAppVersion value) => new IncludedItem95((global::AppStoreConnect.GameCenterAppVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.GameCenterAppVersion?(IncludedItem95 @this) => @this.GameCenterAppVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem95(global::AppStoreConnect.GameCenterAppVersion? value)
        {
            GameCenterAppVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem95 FromGameCenterAppVersions(global::AppStoreConnect.GameCenterAppVersion? value) => new IncludedItem95(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem95(
            global::AppStoreConnect.GameCenterAppVersionsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions,
            global::AppStoreConnect.GameCenterAppVersion? gameCenterAppVersions
            )
        {
            Type = type;

            AppStoreVersions = appStoreVersions;
            GameCenterAppVersions = gameCenterAppVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            GameCenterAppVersions as object ??
            AppStoreVersions as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppStoreVersions?.ToString() ??
            GameCenterAppVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppStoreVersions && !IsGameCenterAppVersions || !IsAppStoreVersions && IsGameCenterAppVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            global::System.Func<global::AppStoreConnect.GameCenterAppVersion, TResult>? gameCenterAppVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0 && appStoreVersions != null)
            {
                return appStoreVersions(__value0);
            }
            else if (GameCenterAppVersions is { } __value1 && gameCenterAppVersions != null)
            {
                return gameCenterAppVersions(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,

            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0)
            {
                appStoreVersions?.Invoke(__value0);
            }
            else if (GameCenterAppVersions is { } __value1)
            {
                gameCenterAppVersions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            global::System.Action<global::AppStoreConnect.GameCenterAppVersion>? gameCenterAppVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppStoreVersions is { } __value0)
            {
                appStoreVersions?.Invoke(__value0);
            }
            else if (GameCenterAppVersions is { } __value1)
            {
                gameCenterAppVersions?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
                GameCenterAppVersions,
                typeof(global::AppStoreConnect.GameCenterAppVersion),
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
        public bool Equals(IncludedItem95 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.GameCenterAppVersion?>.Default.Equals(GameCenterAppVersions, other.GameCenterAppVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem95 obj1, IncludedItem95 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem95>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem95 obj1, IncludedItem95 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem95 o && Equals(o);
        }
    }
}
