#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem149 : global::System.IEquatable<IncludedItem149>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.Actor PickActors() => Actors is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Actors' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEvent? AppEvents { get; init; }
#else
        public global::AppStoreConnect.AppEvent? AppEvents { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEvents))]
#endif
        public bool IsAppEvents => AppEvents != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEvents(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEvent? value)
        {
            value = AppEvents;
            return IsAppEvents;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEvent PickAppEvents() => AppEvents is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents' but the value was {ToString()}.");

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
        public global::AppStoreConnect.App PickApps() => Apps is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Apps' but the value was {ToString()}.");

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
        public global::AppStoreConnect.Territory PickTerritories() => Territories is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Territories' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem149(global::AppStoreConnect.Actor value) => new IncludedItem149((global::AppStoreConnect.Actor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Actor?(IncludedItem149 @this) => @this.Actors;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem149(global::AppStoreConnect.Actor? value)
        {
            Actors = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem149 FromActors(global::AppStoreConnect.Actor? value) => new IncludedItem149(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem149(global::AppStoreConnect.AppEvent value) => new IncludedItem149((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem149 @this) => @this.AppEvents;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem149(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem149 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem149(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem149(global::AppStoreConnect.App value) => new IncludedItem149((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem149 @this) => @this.Apps;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem149(global::AppStoreConnect.App? value)
        {
            Apps = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem149 FromApps(global::AppStoreConnect.App? value) => new IncludedItem149(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem149(global::AppStoreConnect.Territory value) => new IncludedItem149((global::AppStoreConnect.Territory?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.Territory?(IncludedItem149 @this) => @this.Territories;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem149(global::AppStoreConnect.Territory? value)
        {
            Territories = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem149 FromTerritories(global::AppStoreConnect.Territory? value) => new IncludedItem149(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem149(
            global::AppStoreConnect.NominationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.Actor? actors,
            global::AppStoreConnect.AppEvent? appEvents,
            global::AppStoreConnect.App? apps,
            global::AppStoreConnect.Territory? territories
            )
        {
            Type = type;

            Actors = actors;
            AppEvents = appEvents;
            Apps = apps;
            Territories = territories;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Territories as object ??
            Apps as object ??
            AppEvents as object ??
            Actors as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Actors?.ToString() ??
            AppEvents?.ToString() ??
            Apps?.ToString() ??
            Territories?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsActors && !IsAppEvents && !IsApps && !IsTerritories || !IsActors && IsAppEvents && !IsApps && !IsTerritories || !IsActors && !IsAppEvents && IsApps && !IsTerritories || !IsActors && !IsAppEvents && !IsApps && IsTerritories;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.Actor, TResult>? actors = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? apps = null,
            global::System.Func<global::AppStoreConnect.Territory, TResult>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0 && actors != null)
            {
                return actors(__value0);
            }
            else if (AppEvents is { } __value1 && appEvents != null)
            {
                return appEvents(__value1);
            }
            else if (Apps is { } __value2 && apps != null)
            {
                return apps(__value2);
            }
            else if (Territories is { } __value3 && territories != null)
            {
                return territories(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,

            global::System.Action<global::AppStoreConnect.App>? apps = null,

            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0)
            {
                actors?.Invoke(__value0);
            }
            else if (AppEvents is { } __value1)
            {
                appEvents?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
            else if (Territories is { } __value3)
            {
                territories?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.Actor>? actors = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            global::System.Action<global::AppStoreConnect.App>? apps = null,
            global::System.Action<global::AppStoreConnect.Territory>? territories = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Actors is { } __value0)
            {
                actors?.Invoke(__value0);
            }
            else if (AppEvents is { } __value1)
            {
                appEvents?.Invoke(__value1);
            }
            else if (Apps is { } __value2)
            {
                apps?.Invoke(__value2);
            }
            else if (Territories is { } __value3)
            {
                territories?.Invoke(__value3);
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
                AppEvents,
                typeof(global::AppStoreConnect.AppEvent),
                Apps,
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
        public bool Equals(IncludedItem149 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Actor?>.Default.Equals(Actors, other.Actors) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents, other.AppEvents) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(Apps, other.Apps) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.Territory?>.Default.Equals(Territories, other.Territories)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem149 obj1, IncludedItem149 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem149>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem149 obj1, IncludedItem149 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem149 o && Equals(o);
        }
    }
}
