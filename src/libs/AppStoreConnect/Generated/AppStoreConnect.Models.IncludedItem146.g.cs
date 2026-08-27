#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem146 : global::System.IEquatable<IncludedItem146>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.Actor? Actors { get; init; }
#else
        public global::AppStoreConnect.Actor? Actors { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Actors))]
#endif
        public bool IsActors => Actors != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickActors(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.Actor? value)
        {
            value = Actors;
            return IsActors;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.Actor PickActors() => IsActors
            ? Actors!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Actors' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEvent? AppEvents1 { get; init; }
#else
        public global::AppStoreConnect.AppEvent? AppEvents1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEvents1))]
#endif
        public bool IsAppEvents1 => AppEvents1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEvents1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEvent? value)
        {
            value = AppEvents1;
            return IsAppEvents1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEvent PickAppEvents1() => IsAppEvents1
            ? AppEvents1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppEvents2 { get; init; }
#else
        public global::AppStoreConnect.App? AppEvents2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEvents2))]
#endif
        public bool IsAppEvents2 => AppEvents2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEvents2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppEvents2;
            return IsAppEvents2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickAppEvents2() => IsAppEvents2
            ? AppEvents2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents2' but the value was {ToString()}.");

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
        public global::AppStoreConnect.Territory PickTerritories() => IsTerritories
            ? Territories!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem146(global::AppStoreConnect.Actor value) => new IncludedItem146((global::AppStoreConnect.Actor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Actor?(IncludedItem146 @this) => @this.Actors;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem146(global::AppStoreConnect.Actor? value)
        {
            Actors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem146 FromActors(global::AppStoreConnect.Actor? value) => new IncludedItem146(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem146(global::AppStoreConnect.AppEvent value) => new IncludedItem146((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem146 @this) => @this.AppEvents1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem146(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem146 FromAppEvents1(global::AppStoreConnect.AppEvent? value) => new IncludedItem146(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem146(global::AppStoreConnect.App value) => new IncludedItem146((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem146 @this) => @this.AppEvents2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem146(global::AppStoreConnect.App? value)
        {
            AppEvents2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem146 FromAppEvents2(global::AppStoreConnect.App? value) => new IncludedItem146(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem146(global::AppStoreConnect.Territory value) => new IncludedItem146((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem146 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem146(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem146 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem146(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem146(
            global::AppStoreConnect.NominationsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.Actor? actors,
            global::AppStoreConnect.AppEvent? appEvents1,
            global::AppStoreConnect.App? appEvents2,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            Actors = actors;
            AppEvents1 = appEvents1;
            AppEvents2 = appEvents2;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            AppEvents2 as object ??
            AppEvents1 as object ??
            Actors as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Actors?.ToString() ??
            AppEvents1?.ToString() ??
            AppEvents2?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActors && !IsAppEvents1 && !IsAppEvents2 && !IsTerritories || !IsActors && IsAppEvents1 && !IsAppEvents2 && !IsTerritories || !IsActors && !IsAppEvents1 && IsAppEvents2 && !IsTerritories || !IsActors && !IsAppEvents1 && !IsAppEvents2 && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.Actor, TResult>? actors = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents1 = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appEvents2 = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors && actors != null)
            {
                return actors(Actors!);
            }
            else if (IsAppEvents1 && appEvents1 != null)
            {
                return appEvents1(AppEvents1!);
            }
            else if (IsAppEvents2 && appEvents2 != null)
            {
                return appEvents2(AppEvents2!);
            }
            else if (IsTerritories && territories != null)
            {
                return territories(Territories!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents1 = null,

            global::System.Action<global::AppStoreConnect.App>? appEvents2 = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors)
            {
                actors?.Invoke(Actors!);
            }
            else if (IsAppEvents1)
            {
                appEvents1?.Invoke(AppEvents1!);
            }
            else if (IsAppEvents2)
            {
                appEvents2?.Invoke(AppEvents2!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents1 = null,
            global::System.Action<global::AppStoreConnect.App>? appEvents2 = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsActors)
            {
                actors?.Invoke(Actors!);
            }
            else if (IsAppEvents1)
            {
                appEvents1?.Invoke(AppEvents1!);
            }
            else if (IsAppEvents2)
            {
                appEvents2?.Invoke(AppEvents2!);
            }
            else if (IsTerritories)
            {
                territories?.Invoke(Territories!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Actors,
                typeof(global::AppStoreConnect.Actor),
                AppEvents1,
                typeof(global::AppStoreConnect.AppEvent),
                AppEvents2,
                typeof(global::AppStoreConnect.App),
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
        public bool Equals(IncludedItem146 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Actor?>.Default.Equals(Actors, other.Actors) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents1, other.AppEvents1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppEvents2, other.AppEvents2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem146 obj1, IncludedItem146 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem146>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem146 obj1, IncludedItem146 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem146 o && Equals(o);
        }
    }
}
