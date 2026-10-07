#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem3 : global::System.IEquatable<IncludedItem3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryImage? AppAssetLibraryImages { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryImage? AppAssetLibraryImages { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryImages))]
#endif
        public bool IsAppAssetLibraryImages => AppAssetLibraryImages != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryImages(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryImage? value)
        {
            value = AppAssetLibraryImages;
            return IsAppAssetLibraryImages;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryImage PickAppAssetLibraryImages() => AppAssetLibraryImages is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryImages' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppAssetLibraryVideo? AppAssetLibraryVideos { get; init; }
#else
        public global::AppStoreConnect.AppAssetLibraryVideo? AppAssetLibraryVideos { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppAssetLibraryVideos))]
#endif
        public bool IsAppAssetLibraryVideos => AppAssetLibraryVideos != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppAssetLibraryVideos(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppAssetLibraryVideo? value)
        {
            value = AppAssetLibraryVideos;
            return IsAppAssetLibraryVideos;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppAssetLibraryVideo PickAppAssetLibraryVideos() => AppAssetLibraryVideos is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppAssetLibraryVideos' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppCustomProductPageLocalization? AppCustomProductPageLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppCustomProductPageLocalizations))]
#endif
        public bool IsAppCustomProductPageLocalizations => AppCustomProductPageLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppCustomProductPageLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            value = AppCustomProductPageLocalizations;
            return IsAppCustomProductPageLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppCustomProductPageLocalization PickAppCustomProductPageLocalizations() => AppCustomProductPageLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppCustomProductPageLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEventLocalization? AppEventLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppEventLocalization? AppEventLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEventLocalizations))]
#endif
        public bool IsAppEventLocalizations => AppEventLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEventLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEventLocalization? value)
        {
            value = AppEventLocalizations;
            return IsAppEventLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEventLocalization PickAppEventLocalizations() => AppEventLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEventLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? AppStoreVersionExperimentTreatmentLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionExperimentTreatmentLocalizations))]
#endif
        public bool IsAppStoreVersionExperimentTreatmentLocalizations => AppStoreVersionExperimentTreatmentLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionExperimentTreatmentLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            value = AppStoreVersionExperimentTreatmentLocalizations;
            return IsAppStoreVersionExperimentTreatmentLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization PickAppStoreVersionExperimentTreatmentLocalizations() => AppStoreVersionExperimentTreatmentLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionExperimentTreatmentLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; init; }
#else
        public global::AppStoreConnect.AppStoreVersionLocalization? AppStoreVersionLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppStoreVersionLocalizations))]
#endif
        public bool IsAppStoreVersionLocalizations => AppStoreVersionLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppStoreVersionLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            value = AppStoreVersionLocalizations;
            return IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppStoreVersionLocalization PickAppStoreVersionLocalizations() => AppStoreVersionLocalizations is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersionLocalizations' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppAssetLibraryImage value) => new IncludedItem3((global::AppStoreConnect.AppAssetLibraryImage?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryImage?(IncludedItem3 @this) => @this.AppAssetLibraryImages;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppAssetLibraryImage? value)
        {
            AppAssetLibraryImages = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppAssetLibraryImages(global::AppStoreConnect.AppAssetLibraryImage? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppAssetLibraryVideo value) => new IncludedItem3((global::AppStoreConnect.AppAssetLibraryVideo?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppAssetLibraryVideo?(IncludedItem3 @this) => @this.AppAssetLibraryVideos;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppAssetLibraryVideo? value)
        {
            AppAssetLibraryVideos = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppAssetLibraryVideos(global::AppStoreConnect.AppAssetLibraryVideo? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppCustomProductPageLocalization value) => new IncludedItem3((global::AppStoreConnect.AppCustomProductPageLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppCustomProductPageLocalization?(IncludedItem3 @this) => @this.AppCustomProductPageLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppCustomProductPageLocalization? value)
        {
            AppCustomProductPageLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppCustomProductPageLocalizations(global::AppStoreConnect.AppCustomProductPageLocalization? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppEventLocalization value) => new IncludedItem3((global::AppStoreConnect.AppEventLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEventLocalization?(IncludedItem3 @this) => @this.AppEventLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppEventLocalization? value)
        {
            AppEventLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppEventLocalizations(global::AppStoreConnect.AppEventLocalization? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization value) => new IncludedItem3((global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?(IncludedItem3 @this) => @this.AppStoreVersionExperimentTreatmentLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value)
        {
            AppStoreVersionExperimentTreatmentLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppStoreVersionExperimentTreatmentLocalizations(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem3(global::AppStoreConnect.AppStoreVersionLocalization value) => new IncludedItem3((global::AppStoreConnect.AppStoreVersionLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersionLocalization?(IncludedItem3 @this) => @this.AppStoreVersionLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(global::AppStoreConnect.AppStoreVersionLocalization? value)
        {
            AppStoreVersionLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem3 FromAppStoreVersionLocalizations(global::AppStoreConnect.AppStoreVersionLocalization? value) => new IncludedItem3(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem3(
            global::AppStoreConnect.AppAssetLibraryPlacementsResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppAssetLibraryImage? appAssetLibraryImages,
            global::AppStoreConnect.AppAssetLibraryVideo? appAssetLibraryVideos,
            global::AppStoreConnect.AppCustomProductPageLocalization? appCustomProductPageLocalizations,
            global::AppStoreConnect.AppEventLocalization? appEventLocalizations,
            global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization? appStoreVersionExperimentTreatmentLocalizations,
            global::AppStoreConnect.AppStoreVersionLocalization? appStoreVersionLocalizations
            )
        {
            Type = type;

            AppAssetLibraryImages = appAssetLibraryImages;
            AppAssetLibraryVideos = appAssetLibraryVideos;
            AppCustomProductPageLocalizations = appCustomProductPageLocalizations;
            AppEventLocalizations = appEventLocalizations;
            AppStoreVersionExperimentTreatmentLocalizations = appStoreVersionExperimentTreatmentLocalizations;
            AppStoreVersionLocalizations = appStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AppStoreVersionLocalizations as object ??
            AppStoreVersionExperimentTreatmentLocalizations as object ??
            AppEventLocalizations as object ??
            AppCustomProductPageLocalizations as object ??
            AppAssetLibraryVideos as object ??
            AppAssetLibraryImages as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppAssetLibraryImages?.ToString() ??
            AppAssetLibraryVideos?.ToString() ??
            AppCustomProductPageLocalizations?.ToString() ??
            AppEventLocalizations?.ToString() ??
            AppStoreVersionExperimentTreatmentLocalizations?.ToString() ??
            AppStoreVersionLocalizations?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageLocalizations && !IsAppEventLocalizations && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppAssetLibraryImages && IsAppAssetLibraryVideos && !IsAppCustomProductPageLocalizations && !IsAppEventLocalizations && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && IsAppCustomProductPageLocalizations && !IsAppEventLocalizations && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageLocalizations && IsAppEventLocalizations && !IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageLocalizations && !IsAppEventLocalizations && IsAppStoreVersionExperimentTreatmentLocalizations && !IsAppStoreVersionLocalizations || !IsAppAssetLibraryImages && !IsAppAssetLibraryVideos && !IsAppCustomProductPageLocalizations && !IsAppEventLocalizations && !IsAppStoreVersionExperimentTreatmentLocalizations && IsAppStoreVersionLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppAssetLibraryImage, TResult>? appAssetLibraryImages = null,
            global::System.Func<global::AppStoreConnect.AppAssetLibraryVideo, TResult>? appAssetLibraryVideos = null,
            global::System.Func<global::AppStoreConnect.AppCustomProductPageLocalization, TResult>? appCustomProductPageLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppEventLocalization, TResult>? appEventLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization, TResult>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersionLocalization, TResult>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0 && appAssetLibraryImages != null)
            {
                return appAssetLibraryImages(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1 && appAssetLibraryVideos != null)
            {
                return appAssetLibraryVideos(__value1);
            }
            else if (AppCustomProductPageLocalizations is { } __value2 && appCustomProductPageLocalizations != null)
            {
                return appCustomProductPageLocalizations(__value2);
            }
            else if (AppEventLocalizations is { } __value3 && appEventLocalizations != null)
            {
                return appEventLocalizations(__value3);
            }
            else if (AppStoreVersionExperimentTreatmentLocalizations is { } __value4 && appStoreVersionExperimentTreatmentLocalizations != null)
            {
                return appStoreVersionExperimentTreatmentLocalizations(__value4);
            }
            else if (AppStoreVersionLocalizations is { } __value5 && appStoreVersionLocalizations != null)
            {
                return appStoreVersionLocalizations(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImage>? appAssetLibraryImages = null,

            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideo>? appAssetLibraryVideos = null,

            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppEventLocalization>? appEventLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0)
            {
                appAssetLibraryImages?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1)
            {
                appAssetLibraryVideos?.Invoke(__value1);
            }
            else if (AppCustomProductPageLocalizations is { } __value2)
            {
                appCustomProductPageLocalizations?.Invoke(__value2);
            }
            else if (AppEventLocalizations is { } __value3)
            {
                appEventLocalizations?.Invoke(__value3);
            }
            else if (AppStoreVersionExperimentTreatmentLocalizations is { } __value4)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(__value4);
            }
            else if (AppStoreVersionLocalizations is { } __value5)
            {
                appStoreVersionLocalizations?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppAssetLibraryImage>? appAssetLibraryImages = null,
            global::System.Action<global::AppStoreConnect.AppAssetLibraryVideo>? appAssetLibraryVideos = null,
            global::System.Action<global::AppStoreConnect.AppCustomProductPageLocalization>? appCustomProductPageLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppEventLocalization>? appEventLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization>? appStoreVersionExperimentTreatmentLocalizations = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersionLocalization>? appStoreVersionLocalizations = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AppAssetLibraryImages is { } __value0)
            {
                appAssetLibraryImages?.Invoke(__value0);
            }
            else if (AppAssetLibraryVideos is { } __value1)
            {
                appAssetLibraryVideos?.Invoke(__value1);
            }
            else if (AppCustomProductPageLocalizations is { } __value2)
            {
                appCustomProductPageLocalizations?.Invoke(__value2);
            }
            else if (AppEventLocalizations is { } __value3)
            {
                appEventLocalizations?.Invoke(__value3);
            }
            else if (AppStoreVersionExperimentTreatmentLocalizations is { } __value4)
            {
                appStoreVersionExperimentTreatmentLocalizations?.Invoke(__value4);
            }
            else if (AppStoreVersionLocalizations is { } __value5)
            {
                appStoreVersionLocalizations?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppAssetLibraryImages,
                typeof(global::AppStoreConnect.AppAssetLibraryImage),
                AppAssetLibraryVideos,
                typeof(global::AppStoreConnect.AppAssetLibraryVideo),
                AppCustomProductPageLocalizations,
                typeof(global::AppStoreConnect.AppCustomProductPageLocalization),
                AppEventLocalizations,
                typeof(global::AppStoreConnect.AppEventLocalization),
                AppStoreVersionExperimentTreatmentLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization),
                AppStoreVersionLocalizations,
                typeof(global::AppStoreConnect.AppStoreVersionLocalization),
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
        public bool Equals(IncludedItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryImage?>.Default.Equals(AppAssetLibraryImages, other.AppAssetLibraryImages) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppAssetLibraryVideo?>.Default.Equals(AppAssetLibraryVideos, other.AppAssetLibraryVideos) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppCustomProductPageLocalization?>.Default.Equals(AppCustomProductPageLocalizations, other.AppCustomProductPageLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEventLocalization?>.Default.Equals(AppEventLocalizations, other.AppEventLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionExperimentTreatmentLocalization?>.Default.Equals(AppStoreVersionExperimentTreatmentLocalizations, other.AppStoreVersionExperimentTreatmentLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersionLocalization?>.Default.Equals(AppStoreVersionLocalizations, other.AppStoreVersionLocalizations)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem3 obj1, IncludedItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem3 obj1, IncludedItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem3 o && Equals(o);
        }
    }
}
