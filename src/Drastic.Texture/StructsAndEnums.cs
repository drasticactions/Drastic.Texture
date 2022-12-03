using System;
using System.Runtime.InteropServices;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Drastic.Texture
{
    [Native]
    public enum ASAsyncTransactionContainerState : long
    {
        NoTransactions = 0,
        PendingTransactions
    }

    [Native]
    public enum ASDimensionUnit : long
    {
        Auto,
        Points,
        Fraction
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASDimension
    {
        public ASDimensionUnit unit;

        public nfloat value;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASLayoutSize
    {
        public ASDimension width;

        public ASDimension height;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASSizeRange
    {
        public CGSize min;

        public CGSize max;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASLayoutElementStyleExtensions
    {
        public bool[] boolExtensions;

        public nint[] integerExtensions;

        public UIEdgeInsets[] edgeInsetsExtensions;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASLayoutElementSize
    {
        public ASDimension width;

        public ASDimension height;

        public ASDimension minWidth;

        public ASDimension maxWidth;

        public ASDimension minHeight;

        public ASDimension maxHeight;
    }

    [Native]
    public enum ASStackLayoutDirection : long
    {
        Vertical,
        Horizontal
    }

    [Native]
    public enum ASStackLayoutJustifyContent : long
    {
        Start,
        Center,
        End,
        SpaceBetween,
        SpaceAround
    }

    [Native]
    public enum ASStackLayoutAlignItems : long
    {
        Start,
        End,
        Center,
        Stretch,
        BaselineFirst,
        BaselineLast,
        NotSet
    }

    [Native]
    public enum ASStackLayoutAlignSelf : long
    {
        Auto,
        Start,
        End,
        Center,
        Stretch
    }

    [Native]
    public enum ASStackLayoutFlexWrap : long
    {
        NoWrap,
        Wrap
    }

    [Native]
    public enum ASStackLayoutAlignContent : long
    {
        Start,
        Center,
        End,
        SpaceBetween,
        SpaceAround,
        Stretch
    }

    [Native]
    public enum ASHorizontalAlignment : long
    {
        HorizontalAlignmentNone,
        HorizontalAlignmentLeft,
        HorizontalAlignmentMiddle,
        HorizontalAlignmentRight,
        AlignmentLeft = HorizontalAlignmentLeft,
        AlignmentMiddle = HorizontalAlignmentMiddle,
        AlignmentRight = HorizontalAlignmentRight
    }

    [Native]
    public enum ASVerticalAlignment : long
    {
        VerticalAlignmentNone,
        VerticalAlignmentTop,
        VerticalAlignmentCenter,
        VerticalAlignmentBottom,
        AlignmentTop = VerticalAlignmentTop,
        AlignmentCenter = VerticalAlignmentCenter,
        AlignmentBottom = VerticalAlignmentBottom
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASPrimitiveTraitCollection
    {
        public nfloat displayScale;

        public UIUserInterfaceSizeClass horizontalSizeClass;

        public UIUserInterfaceIdiom userInterfaceIdiom;

        public UIUserInterfaceSizeClass verticalSizeClass;

        public UIForceTouchCapability forceTouchCapability;

        public CGSize containerSize;
    }

    [Native]
    public enum ASLayoutElementType : long
    {
        LayoutSpec,
        DisplayNode
    }

    [Native]
    public enum ASInterfaceState : long
    {
        None = 0,
        MeasureLayout = 1 << 0,
        Preload = 1 << 1,
        Display = 1 << 2,
        Visible = 1 << 3,
        InHierarchy = MeasureLayout | Preload | Display | Visible
    }

    [Native]
    public enum ASCornerRoundingType : long
    {
        DefaultSlowCALayer,
        Precomposited,
        Clipping
    }

    [Native]
    public enum ASControlNodeEvent : long
    {
        TouchDown = 1 << 0,
        TouchDownRepeat = 1 << 1,
        TouchDragInside = 1 << 2,
        TouchDragOutside = 1 << 3,
        TouchUpInside = 1 << 4,
        TouchUpOutside = 1 << 5,
        TouchCancel = 1 << 6,
        ValueChanged = 1 << 12,
        PrimaryActionTriggered = 1 << 13,
        AllEvents = 4294967295L
    }

    [Native]
    public enum ASTextNodeHighlightStyle : long
    {
        Light,
        Dark
    }

    [Native]
    public enum ASButtonNodeImageAlignment : long
    {
        Beginning,
        End
    }

    [Native]
    public enum ASMapNodeShowAnnotationsOptions : long
    {
        Ignored = 0,
        Zoomed = 1 << 0,
        Animated = 1 << 1
    }

    [Native]
    public enum ASVideoNodePlayerState : long
    {
        Unknown,
        InitialLoading,
        ReadyToPlay,
        PlaybackLikelyToKeepUpButNotPlaying,
        Playing,
        Loading,
        Paused,
        Finished
    }

    [Native]
    public enum ASVideoPlayerNodeControlType : long
    {
        PlaybackButton,
        ElapsedText,
        DurationText,
        Scrubber,
        FullScreenButton,
        FlexGrowSpacer
    }

    [Native]
    public enum ASImageDownloaderPriority : long
    {
        Preload = 0,
        Imminent,
        Visible
    }

    [Native]
    public enum ASMultiplexImageNodeErrorCode : long
    {
        NoSourceForImage = 0,
        BestImageIdentifierChanged,
        PhotosImageManagerFailedWithoutError,
        PHAssetIsUnavailable
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASRangeTuningParameters
    {
        public nfloat leadingBufferScreenfuls;

        public nfloat trailingBufferScreenfuls;
    }

    [Native]
    public enum ASLayoutRangeMode : long
    {
        Unspecified = -1,
        Minimum = 0,
        Full,
        VisibleOnly,
        LowMemory
    }

    [Native]
    public enum ASLayoutRangeType : long
    {
        Display,
        Preload
    }

    [Native]
    public enum ASScrollDirection : long
    {
        None = 0,
        Right = 1 << 0,
        Left = 1 << 1,
        Up = 1 << 2,
        Down = 1 << 3
    }

    [Native]
    public enum ASCellNodeVisibilityEvent : long
    {
        Visible,
        VisibleRectChanged,
        Invisible,
        WillBeginDragging,
        DidEndDragging
    }

    [Native]
    public enum ASRelativeLayoutSpecPosition : long
    {
        None = 0,
        Start = 1,
        Center = 2,
        End = 3
    }

    [Native]
    public enum ASRelativeLayoutSpecSizingOption : long
    {
        Default,
        MinimumWidth = 1 << 0,
        MinimumHeight = 1 << 1,
        MinimumSize = MinimumWidth | MinimumHeight
    }

    [Native]
    public enum ASCenterLayoutSpecCenteringOptions : long
    {
        None = 0,
        X = 1 << 0,
        Y = 1 << 1,
        Xy = X | Y
    }

    [Native]
    public enum ASCenterLayoutSpecSizingOptions : long
    {
        Default = 0,
        MinimumX = 1 << 0,
        MinimumY = 1 << 1,
        MinimumXY = ASCenterLayoutSpecSizingOptions.MinimumX | ASCenterLayoutSpecSizingOptions.MinimumY
    }

    [Native]
    public enum ASAbsoluteLayoutSpecSizing : long
    {
        Default,
        SizeToFit
    }

    [Native]
    public enum ASAsyncTransactionState : long
    {
        Open = 0,
        Committed,
        Canceled,
        Complete
    }

    [Native]
    public enum ASDisplayNodePerformanceMeasurementOptions : long
    {
        Spec = 1 << 0,
        Computation = 1 << 1
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct ASDisplayNodePerformanceMeasurements
    {
        public double layoutSpecTotalTime;

        public nint layoutSpecNumberOfPasses;

        public double layoutComputationTotalTime;

        public nint layoutComputationNumberOfPasses;
    }

    [Native]
    public enum ASTextNodeExperimentOptions : long
    {
        Subclasses = 1 << 0,
        RandomInstances = 1 << 1,
        AllInstances = 1 << 2,
        Debugging = 1 << 3
    }
}
