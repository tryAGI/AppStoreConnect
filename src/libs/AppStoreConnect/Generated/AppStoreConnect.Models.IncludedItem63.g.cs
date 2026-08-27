#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct IncludedItem63 : global::System.IEquatable<IncludedItem63>
    {
        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.AppEncryptionDeclaration? AppEncryptionDeclarations1 { get; init; }
#else
        public global::AppStoreConnect.AppEncryptionDeclaration? AppEncryptionDeclarations1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarations1))]
#endif
        public bool IsAppEncryptionDeclarations1 => AppEncryptionDeclarations1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEncryptionDeclarations1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.AppEncryptionDeclaration? value)
        {
            value = AppEncryptionDeclarations1;
            return IsAppEncryptionDeclarations1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.AppEncryptionDeclaration PickAppEncryptionDeclarations1() => IsAppEncryptionDeclarations1
            ? AppEncryptionDeclarations1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarations1' but the value was {ToString()}.");

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
        public global::AppStoreConnect.AppStoreVersion PickAppStoreVersions() => IsAppStoreVersions
            ? AppStoreVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppStoreVersions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.App? AppEncryptionDeclarations2 { get; init; }
#else
        public global::AppStoreConnect.App? AppEncryptionDeclarations2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AppEncryptionDeclarations2))]
#endif
        public bool IsAppEncryptionDeclarations2 => AppEncryptionDeclarations2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAppEncryptionDeclarations2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.App? value)
        {
            value = AppEncryptionDeclarations2;
            return IsAppEncryptionDeclarations2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.App PickAppEncryptionDeclarations2() => IsAppEncryptionDeclarations2
            ? AppEncryptionDeclarations2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AppEncryptionDeclarations2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaAppReviewSubmission? BetaAppReviewSubmissions { get; init; }
#else
        public global::AppStoreConnect.BetaAppReviewSubmission? BetaAppReviewSubmissions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaAppReviewSubmissions))]
#endif
        public bool IsBetaAppReviewSubmissions => BetaAppReviewSubmissions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaAppReviewSubmissions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaAppReviewSubmission? value)
        {
            value = BetaAppReviewSubmissions;
            return IsBetaAppReviewSubmissions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaAppReviewSubmission PickBetaAppReviewSubmissions() => IsBetaAppReviewSubmissions
            ? BetaAppReviewSubmissions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaAppReviewSubmissions' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaBuildLocalization? BetaBuildLocalizations { get; init; }
#else
        public global::AppStoreConnect.BetaBuildLocalization? BetaBuildLocalizations { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaBuildLocalizations))]
#endif
        public bool IsBetaBuildLocalizations => BetaBuildLocalizations != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaBuildLocalizations(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaBuildLocalization? value)
        {
            value = BetaBuildLocalizations;
            return IsBetaBuildLocalizations;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaBuildLocalization PickBetaBuildLocalizations() => IsBetaBuildLocalizations
            ? BetaBuildLocalizations!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaBuildLocalizations' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; init; }
#else
        public global::AppStoreConnect.BetaGroup? BetaGroups { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaGroups))]
#endif
        public bool IsBetaGroups => BetaGroups != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaGroups(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaGroup? value)
        {
            value = BetaGroups;
            return IsBetaGroups;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaGroup PickBetaGroups() => IsBetaGroups
            ? BetaGroups!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaGroups' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BetaTester? BetaTesters { get; init; }
#else
        public global::AppStoreConnect.BetaTester? BetaTesters { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaTesters))]
#endif
        public bool IsBetaTesters => BetaTesters != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaTesters(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BetaTester? value)
        {
            value = BetaTesters;
            return IsBetaTesters;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BetaTester PickBetaTesters() => IsBetaTesters
            ? BetaTesters!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaTesters' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildBetaDetail? BuildBetaDetails { get; init; }
#else
        public global::AppStoreConnect.BuildBetaDetail? BuildBetaDetails { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildBetaDetails))]
#endif
        public bool IsBuildBetaDetails => BuildBetaDetails != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildBetaDetails(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildBetaDetail? value)
        {
            value = BuildBetaDetails;
            return IsBuildBetaDetails;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildBetaDetail PickBuildBetaDetails() => IsBuildBetaDetails
            ? BuildBetaDetails!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildBetaDetails' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildBundle? BuildBundles { get; init; }
#else
        public global::AppStoreConnect.BuildBundle? BuildBundles { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildBundles))]
#endif
        public bool IsBuildBundles => BuildBundles != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildBundles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildBundle? value)
        {
            value = BuildBundles;
            return IsBuildBundles;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildBundle PickBuildBundles() => IsBuildBundles
            ? BuildBundles!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildBundles' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildIcon? BuildIcons { get; init; }
#else
        public global::AppStoreConnect.BuildIcon? BuildIcons { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildIcons))]
#endif
        public bool IsBuildIcons => BuildIcons != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildIcons(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildIcon? value)
        {
            value = BuildIcons;
            return IsBuildIcons;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildIcon PickBuildIcons() => IsBuildIcons
            ? BuildIcons!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildIcons' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.BuildUpload? BuildUploads { get; init; }
#else
        public global::AppStoreConnect.BuildUpload? BuildUploads { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BuildUploads))]
#endif
        public bool IsBuildUploads => BuildUploads != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBuildUploads(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.BuildUpload? value)
        {
            value = BuildUploads;
            return IsBuildUploads;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.BuildUpload PickBuildUploads() => IsBuildUploads
            ? BuildUploads!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BuildUploads' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::AppStoreConnect.PrereleaseVersion? PreReleaseVersions { get; init; }
#else
        public global::AppStoreConnect.PrereleaseVersion? PreReleaseVersions { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreReleaseVersions))]
#endif
        public bool IsPreReleaseVersions => PreReleaseVersions != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreReleaseVersions(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::AppStoreConnect.PrereleaseVersion? value)
        {
            value = PreReleaseVersions;
            return IsPreReleaseVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public global::AppStoreConnect.PrereleaseVersion PickPreReleaseVersions() => IsPreReleaseVersions
            ? PreReleaseVersions!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreReleaseVersions' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.AppEncryptionDeclaration value) => new IncludedItem63((global::AppStoreConnect.AppEncryptionDeclaration?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppEncryptionDeclaration?(IncludedItem63 @this) => @this.AppEncryptionDeclarations1;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.AppEncryptionDeclaration? value)
        {
            AppEncryptionDeclarations1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromAppEncryptionDeclarations1(global::AppStoreConnect.AppEncryptionDeclaration? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.AppStoreVersion value) => new IncludedItem63((global::AppStoreConnect.AppStoreVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.AppStoreVersion?(IncludedItem63 @this) => @this.AppStoreVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.AppStoreVersion? value)
        {
            AppStoreVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromAppStoreVersions(global::AppStoreConnect.AppStoreVersion? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.App value) => new IncludedItem63((global::AppStoreConnect.App?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.App?(IncludedItem63 @this) => @this.AppEncryptionDeclarations2;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.App? value)
        {
            AppEncryptionDeclarations2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromAppEncryptionDeclarations2(global::AppStoreConnect.App? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BetaAppReviewSubmission value) => new IncludedItem63((global::AppStoreConnect.BetaAppReviewSubmission?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaAppReviewSubmission?(IncludedItem63 @this) => @this.BetaAppReviewSubmissions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BetaAppReviewSubmission? value)
        {
            BetaAppReviewSubmissions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBetaAppReviewSubmissions(global::AppStoreConnect.BetaAppReviewSubmission? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BetaBuildLocalization value) => new IncludedItem63((global::AppStoreConnect.BetaBuildLocalization?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaBuildLocalization?(IncludedItem63 @this) => @this.BetaBuildLocalizations;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BetaBuildLocalization? value)
        {
            BetaBuildLocalizations = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBetaBuildLocalizations(global::AppStoreConnect.BetaBuildLocalization? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BetaGroup value) => new IncludedItem63((global::AppStoreConnect.BetaGroup?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaGroup?(IncludedItem63 @this) => @this.BetaGroups;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BetaGroup? value)
        {
            BetaGroups = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBetaGroups(global::AppStoreConnect.BetaGroup? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BetaTester value) => new IncludedItem63((global::AppStoreConnect.BetaTester?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BetaTester?(IncludedItem63 @this) => @this.BetaTesters;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BetaTester? value)
        {
            BetaTesters = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBetaTesters(global::AppStoreConnect.BetaTester? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BuildBetaDetail value) => new IncludedItem63((global::AppStoreConnect.BuildBetaDetail?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildBetaDetail?(IncludedItem63 @this) => @this.BuildBetaDetails;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BuildBetaDetail? value)
        {
            BuildBetaDetails = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuildBetaDetails(global::AppStoreConnect.BuildBetaDetail? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BuildBundle value) => new IncludedItem63((global::AppStoreConnect.BuildBundle?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildBundle?(IncludedItem63 @this) => @this.BuildBundles;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BuildBundle? value)
        {
            BuildBundles = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuildBundles(global::AppStoreConnect.BuildBundle? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BuildIcon value) => new IncludedItem63((global::AppStoreConnect.BuildIcon?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildIcon?(IncludedItem63 @this) => @this.BuildIcons;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BuildIcon? value)
        {
            BuildIcons = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuildIcons(global::AppStoreConnect.BuildIcon? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.BuildUpload value) => new IncludedItem63((global::AppStoreConnect.BuildUpload?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.BuildUpload?(IncludedItem63 @this) => @this.BuildUploads;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.BuildUpload? value)
        {
            BuildUploads = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromBuildUploads(global::AppStoreConnect.BuildUpload? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator IncludedItem63(global::AppStoreConnect.PrereleaseVersion value) => new IncludedItem63((global::AppStoreConnect.PrereleaseVersion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::AppStoreConnect.PrereleaseVersion?(IncludedItem63 @this) => @this.PreReleaseVersions;

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(global::AppStoreConnect.PrereleaseVersion? value)
        {
            PreReleaseVersions = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static IncludedItem63 FromPreReleaseVersions(global::AppStoreConnect.PrereleaseVersion? value) => new IncludedItem63(value);

        /// <summary>
        ///
        /// </summary>
        public IncludedItem63(
            global::AppStoreConnect.BuildResponseIncludedItemDiscriminatorType? type,
            global::AppStoreConnect.AppEncryptionDeclaration? appEncryptionDeclarations1,
            global::AppStoreConnect.AppStoreVersion? appStoreVersions,
            global::AppStoreConnect.App? appEncryptionDeclarations2,
            global::AppStoreConnect.BetaAppReviewSubmission? betaAppReviewSubmissions,
            global::AppStoreConnect.BetaBuildLocalization? betaBuildLocalizations,
            global::AppStoreConnect.BetaGroup? betaGroups,
            global::AppStoreConnect.BetaTester? betaTesters,
            global::AppStoreConnect.BuildBetaDetail? buildBetaDetails,
            global::AppStoreConnect.BuildBundle? buildBundles,
            global::AppStoreConnect.BuildIcon? buildIcons,
            global::AppStoreConnect.BuildUpload? buildUploads,
            global::AppStoreConnect.PrereleaseVersion? preReleaseVersions
            )
        {
            Type = type;

            AppEncryptionDeclarations1 = appEncryptionDeclarations1;
            AppStoreVersions = appStoreVersions;
            AppEncryptionDeclarations2 = appEncryptionDeclarations2;
            BetaAppReviewSubmissions = betaAppReviewSubmissions;
            BetaBuildLocalizations = betaBuildLocalizations;
            BetaGroups = betaGroups;
            BetaTesters = betaTesters;
            BuildBetaDetails = buildBetaDetails;
            BuildBundles = buildBundles;
            BuildIcons = buildIcons;
            BuildUploads = buildUploads;
            PreReleaseVersions = preReleaseVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PreReleaseVersions as object ??
            BuildUploads as object ??
            BuildIcons as object ??
            BuildBundles as object ??
            BuildBetaDetails as object ??
            BetaTesters as object ??
            BetaGroups as object ??
            BetaBuildLocalizations as object ??
            BetaAppReviewSubmissions as object ??
            AppEncryptionDeclarations2 as object ??
            AppStoreVersions as object ??
            AppEncryptionDeclarations1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AppEncryptionDeclarations1?.ToString() ??
            AppStoreVersions?.ToString() ??
            AppEncryptionDeclarations2?.ToString() ??
            BetaAppReviewSubmissions?.ToString() ??
            BetaBuildLocalizations?.ToString() ??
            BetaGroups?.ToString() ??
            BetaTesters?.ToString() ??
            BuildBetaDetails?.ToString() ??
            BuildBundles?.ToString() ??
            BuildIcons?.ToString() ??
            BuildUploads?.ToString() ??
            PreReleaseVersions?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && IsBuildBundles && !IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && IsBuildIcons && !IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && IsBuildUploads && !IsPreReleaseVersions || !IsAppEncryptionDeclarations1 && !IsAppStoreVersions && !IsAppEncryptionDeclarations2 && !IsBetaAppReviewSubmissions && !IsBetaBuildLocalizations && !IsBetaGroups && !IsBetaTesters && !IsBuildBetaDetails && !IsBuildBundles && !IsBuildIcons && !IsBuildUploads && IsPreReleaseVersions;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::AppStoreConnect.AppEncryptionDeclaration, TResult>? appEncryptionDeclarations1 = null,
            global::System.Func<global::AppStoreConnect.AppStoreVersion, TResult>? appStoreVersions = null,
            global::System.Func<global::AppStoreConnect.App, TResult>? appEncryptionDeclarations2 = null,
            global::System.Func<global::AppStoreConnect.BetaAppReviewSubmission, TResult>? betaAppReviewSubmissions = null,
            global::System.Func<global::AppStoreConnect.BetaBuildLocalization, TResult>? betaBuildLocalizations = null,
            global::System.Func<global::AppStoreConnect.BetaGroup, TResult>? betaGroups = null,
            global::System.Func<global::AppStoreConnect.BetaTester, TResult>? betaTesters = null,
            global::System.Func<global::AppStoreConnect.BuildBetaDetail, TResult>? buildBetaDetails = null,
            global::System.Func<global::AppStoreConnect.BuildBundle, TResult>? buildBundles = null,
            global::System.Func<global::AppStoreConnect.BuildIcon, TResult>? buildIcons = null,
            global::System.Func<global::AppStoreConnect.BuildUpload, TResult>? buildUploads = null,
            global::System.Func<global::AppStoreConnect.PrereleaseVersion, TResult>? preReleaseVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarations1 && appEncryptionDeclarations1 != null)
            {
                return appEncryptionDeclarations1(AppEncryptionDeclarations1!);
            }
            else if (IsAppStoreVersions && appStoreVersions != null)
            {
                return appStoreVersions(AppStoreVersions!);
            }
            else if (IsAppEncryptionDeclarations2 && appEncryptionDeclarations2 != null)
            {
                return appEncryptionDeclarations2(AppEncryptionDeclarations2!);
            }
            else if (IsBetaAppReviewSubmissions && betaAppReviewSubmissions != null)
            {
                return betaAppReviewSubmissions(BetaAppReviewSubmissions!);
            }
            else if (IsBetaBuildLocalizations && betaBuildLocalizations != null)
            {
                return betaBuildLocalizations(BetaBuildLocalizations!);
            }
            else if (IsBetaGroups && betaGroups != null)
            {
                return betaGroups(BetaGroups!);
            }
            else if (IsBetaTesters && betaTesters != null)
            {
                return betaTesters(BetaTesters!);
            }
            else if (IsBuildBetaDetails && buildBetaDetails != null)
            {
                return buildBetaDetails(BuildBetaDetails!);
            }
            else if (IsBuildBundles && buildBundles != null)
            {
                return buildBundles(BuildBundles!);
            }
            else if (IsBuildIcons && buildIcons != null)
            {
                return buildIcons(BuildIcons!);
            }
            else if (IsBuildUploads && buildUploads != null)
            {
                return buildUploads(BuildUploads!);
            }
            else if (IsPreReleaseVersions && preReleaseVersions != null)
            {
                return preReleaseVersions(PreReleaseVersions!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclaration>? appEncryptionDeclarations1 = null,

            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,

            global::System.Action<global::AppStoreConnect.App>? appEncryptionDeclarations2 = null,

            global::System.Action<global::AppStoreConnect.BetaAppReviewSubmission>? betaAppReviewSubmissions = null,

            global::System.Action<global::AppStoreConnect.BetaBuildLocalization>? betaBuildLocalizations = null,

            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,

            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,

            global::System.Action<global::AppStoreConnect.BuildBetaDetail>? buildBetaDetails = null,

            global::System.Action<global::AppStoreConnect.BuildBundle>? buildBundles = null,

            global::System.Action<global::AppStoreConnect.BuildIcon>? buildIcons = null,

            global::System.Action<global::AppStoreConnect.BuildUpload>? buildUploads = null,

            global::System.Action<global::AppStoreConnect.PrereleaseVersion>? preReleaseVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarations1)
            {
                appEncryptionDeclarations1?.Invoke(AppEncryptionDeclarations1!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
            else if (IsAppEncryptionDeclarations2)
            {
                appEncryptionDeclarations2?.Invoke(AppEncryptionDeclarations2!);
            }
            else if (IsBetaAppReviewSubmissions)
            {
                betaAppReviewSubmissions?.Invoke(BetaAppReviewSubmissions!);
            }
            else if (IsBetaBuildLocalizations)
            {
                betaBuildLocalizations?.Invoke(BetaBuildLocalizations!);
            }
            else if (IsBetaGroups)
            {
                betaGroups?.Invoke(BetaGroups!);
            }
            else if (IsBetaTesters)
            {
                betaTesters?.Invoke(BetaTesters!);
            }
            else if (IsBuildBetaDetails)
            {
                buildBetaDetails?.Invoke(BuildBetaDetails!);
            }
            else if (IsBuildBundles)
            {
                buildBundles?.Invoke(BuildBundles!);
            }
            else if (IsBuildIcons)
            {
                buildIcons?.Invoke(BuildIcons!);
            }
            else if (IsBuildUploads)
            {
                buildUploads?.Invoke(BuildUploads!);
            }
            else if (IsPreReleaseVersions)
            {
                preReleaseVersions?.Invoke(PreReleaseVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::AppStoreConnect.AppEncryptionDeclaration>? appEncryptionDeclarations1 = null,
            global::System.Action<global::AppStoreConnect.AppStoreVersion>? appStoreVersions = null,
            global::System.Action<global::AppStoreConnect.App>? appEncryptionDeclarations2 = null,
            global::System.Action<global::AppStoreConnect.BetaAppReviewSubmission>? betaAppReviewSubmissions = null,
            global::System.Action<global::AppStoreConnect.BetaBuildLocalization>? betaBuildLocalizations = null,
            global::System.Action<global::AppStoreConnect.BetaGroup>? betaGroups = null,
            global::System.Action<global::AppStoreConnect.BetaTester>? betaTesters = null,
            global::System.Action<global::AppStoreConnect.BuildBetaDetail>? buildBetaDetails = null,
            global::System.Action<global::AppStoreConnect.BuildBundle>? buildBundles = null,
            global::System.Action<global::AppStoreConnect.BuildIcon>? buildIcons = null,
            global::System.Action<global::AppStoreConnect.BuildUpload>? buildUploads = null,
            global::System.Action<global::AppStoreConnect.PrereleaseVersion>? preReleaseVersions = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAppEncryptionDeclarations1)
            {
                appEncryptionDeclarations1?.Invoke(AppEncryptionDeclarations1!);
            }
            else if (IsAppStoreVersions)
            {
                appStoreVersions?.Invoke(AppStoreVersions!);
            }
            else if (IsAppEncryptionDeclarations2)
            {
                appEncryptionDeclarations2?.Invoke(AppEncryptionDeclarations2!);
            }
            else if (IsBetaAppReviewSubmissions)
            {
                betaAppReviewSubmissions?.Invoke(BetaAppReviewSubmissions!);
            }
            else if (IsBetaBuildLocalizations)
            {
                betaBuildLocalizations?.Invoke(BetaBuildLocalizations!);
            }
            else if (IsBetaGroups)
            {
                betaGroups?.Invoke(BetaGroups!);
            }
            else if (IsBetaTesters)
            {
                betaTesters?.Invoke(BetaTesters!);
            }
            else if (IsBuildBetaDetails)
            {
                buildBetaDetails?.Invoke(BuildBetaDetails!);
            }
            else if (IsBuildBundles)
            {
                buildBundles?.Invoke(BuildBundles!);
            }
            else if (IsBuildIcons)
            {
                buildIcons?.Invoke(BuildIcons!);
            }
            else if (IsBuildUploads)
            {
                buildUploads?.Invoke(BuildUploads!);
            }
            else if (IsPreReleaseVersions)
            {
                preReleaseVersions?.Invoke(PreReleaseVersions!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AppEncryptionDeclarations1,
                typeof(global::AppStoreConnect.AppEncryptionDeclaration),
                AppStoreVersions,
                typeof(global::AppStoreConnect.AppStoreVersion),
                AppEncryptionDeclarations2,
                typeof(global::AppStoreConnect.App),
                BetaAppReviewSubmissions,
                typeof(global::AppStoreConnect.BetaAppReviewSubmission),
                BetaBuildLocalizations,
                typeof(global::AppStoreConnect.BetaBuildLocalization),
                BetaGroups,
                typeof(global::AppStoreConnect.BetaGroup),
                BetaTesters,
                typeof(global::AppStoreConnect.BetaTester),
                BuildBetaDetails,
                typeof(global::AppStoreConnect.BuildBetaDetail),
                BuildBundles,
                typeof(global::AppStoreConnect.BuildBundle),
                BuildIcons,
                typeof(global::AppStoreConnect.BuildIcon),
                BuildUploads,
                typeof(global::AppStoreConnect.BuildUpload),
                PreReleaseVersions,
                typeof(global::AppStoreConnect.PrereleaseVersion),
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
        public bool Equals(IncludedItem63 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppEncryptionDeclaration?>.Default.Equals(AppEncryptionDeclarations1, other.AppEncryptionDeclarations1) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.AppStoreVersion?>.Default.Equals(AppStoreVersions, other.AppStoreVersions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.App?>.Default.Equals(AppEncryptionDeclarations2, other.AppEncryptionDeclarations2) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaAppReviewSubmission?>.Default.Equals(BetaAppReviewSubmissions, other.BetaAppReviewSubmissions) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaBuildLocalization?>.Default.Equals(BetaBuildLocalizations, other.BetaBuildLocalizations) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaGroup?>.Default.Equals(BetaGroups, other.BetaGroups) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BetaTester?>.Default.Equals(BetaTesters, other.BetaTesters) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildBetaDetail?>.Default.Equals(BuildBetaDetails, other.BuildBetaDetails) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildBundle?>.Default.Equals(BuildBundles, other.BuildBundles) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildIcon?>.Default.Equals(BuildIcons, other.BuildIcons) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.BuildUpload?>.Default.Equals(BuildUploads, other.BuildUploads) &&
                global::System.Collections.Generic.EqualityComparer<global::AppStoreConnect.PrereleaseVersion?>.Default.Equals(PreReleaseVersions, other.PreReleaseVersions)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(IncludedItem63 obj1, IncludedItem63 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<IncludedItem63>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(IncludedItem63 obj1, IncludedItem63 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is IncludedItem63 o && Equals(o);
        }
    }
}
