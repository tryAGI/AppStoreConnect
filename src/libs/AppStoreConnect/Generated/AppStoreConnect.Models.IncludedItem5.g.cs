#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem5 : global::System.IEquatable<IncludedItem5>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipAdvancedExperienceImage? AppClipAdvancedExperienceImages { get; init; }
#else
        public global::AppStoreConnect.AppClipAdvancedExperienceImage? AppClipAdvancedExperienceImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAdvancedExperienceImages))]
#endif
        public bool IsAppClipAdvancedExperienceImages => AppClipAdvancedExperienceImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipAdvancedExperienceImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipAdvancedExperienceImage? value)
        {
            value = AppClipAdvancedExperienceImages;
            return IsAppClipAdvancedExperienceImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperienceImage PickAppClipAdvancedExperienceImages() => AppClipAdvancedExperienceImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAdvancedExperienceImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization? AppClipAdvancedExperienceLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization? AppClipAdvancedExperienceLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClipAdvancedExperienceLocalizations))]
#endif
        public bool IsAppClipAdvancedExperienceLocalizations => AppClipAdvancedExperienceLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClipAdvancedExperienceLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value)
        {
            value = AppClipAdvancedExperienceLocalizations;
            return IsAppClipAdvancedExperienceLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClipAdvancedExperienceLocalization PickAppClipAdvancedExperienceLocalizations() => AppClipAdvancedExperienceLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClipAdvancedExperienceLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppClip? AppClips { get; init; }
#else
        public global::AppStoreConnect.AppClip? AppClips { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppClips))]
#endif
        public bool IsAppClips => AppClips != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppClips(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppClip? value)
        {
            value = AppClips;
            return IsAppClips;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppClip PickAppClips() => AppClips is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppClips' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem5(global::AppStoreConnect.AppClipAdvancedExperienceImage value) => new IncludedItem5((global::AppStoreConnect.AppClipAdvancedExperienceImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipAdvancedExperienceImage?(IncludedItem5 @this) => @this.AppClipAdvancedExperienceImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem5(global::AppStoreConnect.AppClipAdvancedExperienceImage? value)
        {
            AppClipAdvancedExperienceImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem5 FromAppClipAdvancedExperienceImages(global::AppStoreConnect.AppClipAdvancedExperienceImage? value) => new IncludedItem5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem5(global::AppStoreConnect.AppClipAdvancedExperienceLocalization value) => new IncludedItem5((global::AppStoreConnect.AppClipAdvancedExperienceLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClipAdvancedExperienceLocalization?(IncludedItem5 @this) => @this.AppClipAdvancedExperienceLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem5(global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value)
        {
            AppClipAdvancedExperienceLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem5 FromAppClipAdvancedExperienceLocalizations(global::AppStoreConnect.AppClipAdvancedExperienceLocalization? value) => new IncludedItem5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem5(global::AppStoreConnect.AppClip value) => new IncludedItem5((global::AppStoreConnect.AppClip?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppClip?(IncludedItem5 @this) => @this.AppClips;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem5(global::AppStoreConnect.AppClip? value)
        {
            AppClips = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem5 FromAppClips(global::AppStoreConnect.AppClip? value) => new IncludedItem5(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem5(
            global::AppStoreConnect.AppClipAdvancedExperiencesResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppClipAdvancedExperienceImage? appClipAdvancedExperienceImages,
            global::AppStoreConnect.AppClipAdvancedExperienceLocalization? appClipAdvancedExperienceLocalizations,
            global::AppStoreConnect.AppClip? appClips
            )
        {
            Type = type;

            AppClipAdvancedExperienceImages = appClipAdvancedExperienceImages;
            AppClipAdvancedExperienceLocalizations = appClipAdvancedExperienceLocalizations;
            AppClips = appClips;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppClips as object ??
            AppClipAdvancedExperienceLocalizations as object ??
            AppClipAdvancedExperienceImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppClipAdvancedExperienceImages?.ToString() ??
            AppClipAdvancedExperienceLocalizations?.ToString() ??
            AppClips?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppClipAdvancedExperienceImages && !IsAppClipAdvancedExperienceLocalizations && !IsAppClips || !IsAppClipAdvancedExperienceImages && IsAppClipAdvancedExperienceLocalizations && !IsAppClips || !IsAppClipAdvancedExperienceImages && !IsAppClipAdvancedExperienceLocalizations && IsAppClips;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppClipAdvancedExperienceImage, TResult>? appClipAdvancedExperienceImages = null,
            global::System.Func<global::AppStoreConnect.AppClipAdvancedExperienceLocalization, TResult>? appClipAdvancedExperienceLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppClip, TResult>? appClips = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipAdvancedExperienceImages is { } __value0 && appClipAdvancedExperienceImages != null)
            {
                return appClipAdvancedExperienceImages(__value0);
            }
            else if (AppClipAdvancedExperienceLocalizations is { } __value1 && appClipAdvancedExperienceLocalizations != null)
            {
                return appClipAdvancedExperienceLocalizations(__value1);
            }
            else if (AppClips is { } __value2 && appClips != null)
            {
                return appClips(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceImage>? appClipAdvancedExperienceImages = null,

            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceLocalization>? appClipAdvancedExperienceLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppClip>? appClips = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipAdvancedExperienceImages is { } __value0)
            {
                appClipAdvancedExperienceImages?.Invoke(__value0);
            }
            else if (AppClipAdvancedExperienceLocalizations is { } __value1)
            {
                appClipAdvancedExperienceLocalizations?.Invoke(__value1);
            }
            else if (AppClips is { } __value2)
            {
                appClips?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceImage>? appClipAdvancedExperienceImages = null,
            global::System.Action<global::AppStoreConnect.AppClipAdvancedExperienceLocalization>? appClipAdvancedExperienceLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppClip>? appClips = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppClipAdvancedExperienceImages is { } __value0)
            {
                appClipAdvancedExperienceImages?.Invoke(__value0);
            }
            else if (AppClipAdvancedExperienceLocalizations is { } __value1)
            {
                appClipAdvancedExperienceLocalizations?.Invoke(__value1);
            }
            else if (AppClips is { } __value2)
            {
                appClips?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppClipAdvancedExperienceImages,
                typeof(global::AppStoreConnect.AppClipAdvancedExperienceImage),
                AppClipAdvancedExperienceLocalizations,
                typeof(global::AppStoreConnect.AppClipAdvancedExperienceLocalization),
                AppClips,
                typeof(global::AppStoreConnect.AppClip),
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
        public bool Equals(IncludedItem5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipAdvancedExperienceImage?>.Default.Equals(AppClipAdvancedExperienceImages, other.AppClipAdvancedExperienceImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClipAdvancedExperienceLocalization?>.Default.Equals(AppClipAdvancedExperienceLocalizations, other.AppClipAdvancedExperienceLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppClip?>.Default.Equals(AppClips, other.AppClips)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem5 obj1, IncludedItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem5 obj1, IncludedItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem5 o && Equals(o);
        }
    }
}
