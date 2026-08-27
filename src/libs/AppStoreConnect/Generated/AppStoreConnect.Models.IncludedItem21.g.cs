#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct IncludedItem21 : global::System.IEquatable<IncludedItem21>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::AppStoreConnect.AppEventLocalizationResponseIncludedItemDiscriminatorType? Type { get; }

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
        public global::AppStoreConnect.AppEventScreenshot PickAppEventScreenshots() => IsAppEventScreenshots
            ? AppEventScreenshots!
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
        public global::AppStoreConnect.AppEventVideoClip PickAppEventVideoClips() => IsAppEventVideoClips
            ? AppEventVideoClips!
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
        public global::AppStoreConnect.AppEvent PickAppEvents() => IsAppEvents
            ? AppEvents!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEvents' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.AppEventScreenshot value) => new IncludedItem21((global::AppStoreConnect.AppEventScreenshot?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEventScreenshot?(IncludedItem21 @this) => @this.AppEventScreenshots;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.AppEventScreenshot? value)
        {
            AppEventScreenshots = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem21 FromAppEventScreenshots(global::AppStoreConnect.AppEventScreenshot? value) => new IncludedItem21(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.AppEventVideoClip value) => new IncludedItem21((global::AppStoreConnect.AppEventVideoClip?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEventVideoClip?(IncludedItem21 @this) => @this.AppEventVideoClips;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.AppEventVideoClip? value)
        {
            AppEventVideoClips = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem21 FromAppEventVideoClips(global::AppStoreConnect.AppEventVideoClip? value) => new IncludedItem21(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator IncludedItem21(global::AppStoreConnect.AppEvent value) => new IncludedItem21((global::AppStoreConnect.AppEvent?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEvent?(IncludedItem21 @this) => @this.AppEvents;

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem21(global::AppStoreConnect.AppEvent? value)
        {
            AppEvents = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static IncludedItem21 FromAppEvents(global::AppStoreConnect.AppEvent? value) => new IncludedItem21(value);

        /// <summary>
        /// 
        /// </summary>
        public IncludedItem21(
            global::AppStoreConnect.AppEventLocalizationResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppEventScreenshot? appEventScreenshots,
            global::AppStoreConnect.AppEventVideoClip? appEventVideoClips,
            global::AppStoreConnect.AppEvent? appEvents
            )
        {
            Type = type;

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
            AppEventScreenshots as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AppEventScreenshots?.ToString() ??
            AppEventVideoClips?.ToString() ??
            AppEvents?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAppEventScreenshots && !IsAppEventVideoClips && !IsAppEvents || !IsAppEventScreenshots && IsAppEventVideoClips && !IsAppEvents || !IsAppEventScreenshots && !IsAppEventVideoClips && IsAppEvents;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppEventScreenshot, TResult>? appEventScreenshots = null,
            global::System.Func<global::AppStoreConnect.AppEventVideoClip, TResult>? appEventVideoClips = null,
            global::System.Func<global::AppStoreConnect.AppEvent, TResult>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEventScreenshots && appEventScreenshots != null)
            {
                return appEventScreenshots(AppEventScreenshots!);
            }
            else if (IsAppEventVideoClips && appEventVideoClips != null)
            {
                return appEventVideoClips(AppEventVideoClips!);
            }
            else if (IsAppEvents && appEvents != null)
            {
                return appEvents(AppEvents!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppEventScreenshot>? appEventScreenshots = null,

            global::System.Action<global::AppStoreConnect.AppEventVideoClip>? appEventVideoClips = null,

            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEventScreenshots)
            {
                appEventScreenshots?.Invoke(AppEventScreenshots!);
            }
            else if (IsAppEventVideoClips)
            {
                appEventVideoClips?.Invoke(AppEventVideoClips!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppEventScreenshot>? appEventScreenshots = null,
            global::System.Action<global::AppStoreConnect.AppEventVideoClip>? appEventVideoClips = null,
            global::System.Action<global::AppStoreConnect.AppEvent>? appEvents = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEventScreenshots)
            {
                appEventScreenshots?.Invoke(AppEventScreenshots!);
            }
            else if (IsAppEventVideoClips)
            {
                appEventVideoClips?.Invoke(AppEventVideoClips!);
            }
            else if (IsAppEvents)
            {
                appEvents?.Invoke(AppEvents!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
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
        public bool Equals(IncludedItem21 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEventScreenshot?>.Default.Equals(AppEventScreenshots, other.AppEventScreenshots) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEventVideoClip?>.Default.Equals(AppEventVideoClips, other.AppEventVideoClips) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEvent?>.Default.Equals(AppEvents, other.AppEvents) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(IncludedItem21 obj1, IncludedItem21 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem21>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(IncludedItem21 obj1, IncludedItem21 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem21 o && Equals(o);
        }
    }
}
