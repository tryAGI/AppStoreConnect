#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem23 : global::System.IEquatable<IncludedItem23>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEventLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryPlacement? AppAssetLibraryPlacements { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryPlacements))]
#endif
        public bool IsAppAssetLibraryPlacements => AppAssetLibraryPlacements != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryPlacements(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            value = AppAssetLibraryPlacements;
            return IsAppAssetLibraryPlacements;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacement PickAppAssetLibraryPlacements() => AppAssetLibraryPlacements is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryPlacements' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEventScreenshot? AppEventScreenshots { get; init; }
#else
        public global::AppStoreConnect.AppEventScreenshot? AppEventScreenshots { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEventScreenshots))]
#endif
        public bool IsAppEventScreenshots => AppEventScreenshots != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEventScreenshots(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEventScreenshot? value)
        {
            value = AppEventScreenshots;
            return IsAppEventScreenshots;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEventScreenshot PickAppEventScreenshots() => AppEventScreenshots is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEventScreenshots' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEventVideoClip? AppEventVideoClips { get; init; }
#else
        public global::AppStoreConnect.AppEventVideoClip? AppEventVideoClips { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEventVideoClips))]
#endif
        public bool IsAppEventVideoClips => AppEventVideoClips != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEventVideoClips(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEventVideoClip? value)
        {
            value = AppEventVideoClips;
            return IsAppEventVideoClips;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEventVideoClip PickAppEventVideoClips() => AppEventVideoClips is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEventVideoClips' but the value was {ToString()}.");

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
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppAssetLibraryPlacement value) => new IncludedItem23((global::AppStoreConnect.AppAssetLibraryPlacement?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryPlacement?(IncludedItem23 @this) => @this.AppAssetLibraryPlacements;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppAssetLibraryPlacement? value)
        {
            AppAssetLibraryPlacements = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem23 FromAppAssetLibraryPlacements(global::AppStoreConnect.AppAssetLibraryPlacement? value) => new IncludedItem23(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppEventScreenshot value) => new IncludedItem23((global::AppStoreConnect.AppEventScreenshot?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEventScreenshot?(IncludedItem23 @this) => @this.AppEventScreenshots;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppEventScreenshot? value)
        {
            AppEventScreenshots = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem23 FromAppEventScreenshots(global::AppStoreConnect.AppEventScreenshot? value) => new IncludedItem23(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppEventVideoClip value) => new IncludedItem23((global::AppStoreConnect.AppEventVideoClip?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEventVideoClip?(IncludedItem23 @this) => @this.AppEventVideoClips;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppEventVideoClip? value)
        {
            AppEventVideoClips = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem23 FromAppEventVideoClips(global::AppStoreConnect.AppEventVideoClip? value) => new IncludedItem23(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem23(global::AppStoreConnect.AppEvent value) => new IncludedItem23((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem23 @this) => @this.AppEvents;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem23(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem23 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem23(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem23(
            global::AppStoreConnect.AppEventLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryPlacement? appAssetLibraryPlacements,
            global::AppStoreConnect.AppEventScreenshot? appEventScreenshots,
            global::AppStoreConnect.AppEventVideoClip? appEventVideoClips,
            global::AppStoreConnect.AppEvent? appEvents
            )
        {
            Type = type;

            AppAssetLibraryPlacements = appAssetLibraryPlacements;
            AppEventScreenshots = appEventScreenshots;
            AppEventVideoClips = appEventVideoClips;
            AppEvents = appEvents;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppEvents as object ??
            AppEventVideoClips as object ??
            AppEventScreenshots as object ??
            AppAssetLibraryPlacements as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryPlacements?.ToString() ??
            AppEventScreenshots?.ToString() ??
            AppEventVideoClips?.ToString() ??
            AppEvents?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryPlacements && !IsAppEventScreenshots && !IsAppEventVideoClips && !IsAppEvents || !IsAppAssetLibraryPlacements && IsAppEventScreenshots && !IsAppEventVideoClips && !IsAppEvents || !IsAppAssetLibraryPlacements && !IsAppEventScreenshots && IsAppEventVideoClips && !IsAppEvents || !IsAppAssetLibraryPlacements && !IsAppEventScreenshots && !IsAppEventVideoClips && IsAppEvents;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryPlacement, TResult>? appAssetLibraryPlacements = null,
            global::System.Func<global::AppStoreConnect.AppEventScreenshot, TResult>? appEventScreenshots = null,
            global::System.Func<global::AppStoreConnect.AppEventVideoClip, TResult>? appEventVideoClips = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0 && appAssetLibraryPlacements != null)
            {
                return appAssetLibraryPlacements(__value0);
            }
            else if (AppEventScreenshots is { } __value1 && appEventScreenshots != null)
            {
                return appEventScreenshots(__value1);
            }
            else if (AppEventVideoClips is { } __value2 && appEventVideoClips != null)
            {
                return appEventVideoClips(__value2);
            }
            else if (AppEvents is { } __value3 && appEvents != null)
            {
                return appEvents(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,

            global::System.Action<global::AppStoreConnect.AppEventScreenshot>? appEventScreenshots = null,

            global::System.Action<global::AppStoreConnect.AppEventVideoClip>? appEventVideoClips = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (AppEventScreenshots is { } __value1)
            {
                appEventScreenshots?.Invoke(__value1);
            }
            else if (AppEventVideoClips is { } __value2)
            {
                appEventVideoClips?.Invoke(__value2);
            }
            else if (AppEvents is { } __value3)
            {
                appEvents?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryPlacement>? appAssetLibraryPlacements = null,
            global::System.Action<global::AppStoreConnect.AppEventScreenshot>? appEventScreenshots = null,
            global::System.Action<global::AppStoreConnect.AppEventVideoClip>? appEventVideoClips = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryPlacements is { } __value0)
            {
                appAssetLibraryPlacements?.Invoke(__value0);
            }
            else if (AppEventScreenshots is { } __value1)
            {
                appEventScreenshots?.Invoke(__value1);
            }
            else if (AppEventVideoClips is { } __value2)
            {
                appEventVideoClips?.Invoke(__value2);
            }
            else if (AppEvents is { } __value3)
            {
                appEvents?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryPlacements,
                typeof(global::AppStoreConnect.AppAssetLibraryPlacement),
                AppEventScreenshots,
                typeof(global::AppStoreConnect.AppEventScreenshot),
                AppEventVideoClips,
                typeof(global::AppStoreConnect.AppEventVideoClip),
                AppEvents,
                typeof(global::AppStoreConnect.AppEvent),
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
        public bool Equals(IncludedItem23 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryPlacement?>.Default.Equals(AppAssetLibraryPlacements, other.AppAssetLibraryPlacements) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEventScreenshot?>.Default.Equals(AppEventScreenshots, other.AppEventScreenshots) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEventVideoClip?>.Default.Equals(AppEventVideoClips, other.AppEventVideoClips) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents, other.AppEvents)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem23 obj1, IncludedItem23 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem23>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem23 obj1, IncludedItem23 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem23 o && Equals(o);
        }
    }
}
