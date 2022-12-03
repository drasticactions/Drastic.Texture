using System;
using System.Runtime.InteropServices;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;
using Photos;
using UIKit;

namespace Drastic.Texture
{

    // @protocol ASAsyncTransactionContainer
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASAsyncTransactionContainer
    {
        // @required @property (getter = asyncdisplaykit_isAsyncTransactionContainer, assign, nonatomic, setter = asyncdisplaykit_setAsyncTransactionContainer:) BOOL asyncdisplaykit_asyncTransactionContainer;
        [Abstract]
        [Export("asyncdisplaykit_asyncTransactionContainer")]
        bool Asyncdisplaykit_asyncTransactionContainer { [Bind("asyncdisplaykit_isAsyncTransactionContainer")] get; [Bind("asyncdisplaykit_setAsyncTransactionContainer:")] set; }

        // @required @property (readonly, assign, nonatomic) ASAsyncTransactionContainerState asyncdisplaykit_asyncTransactionContainerState;
        [Abstract]
        [Export("asyncdisplaykit_asyncTransactionContainerState", ArgumentSemantic.Assign)]
        ASAsyncTransactionContainerState Asyncdisplaykit_asyncTransactionContainerState { get; }

        // @required -(void)asyncdisplaykit_cancelAsyncTransactions;
        [Abstract]
        [Export("asyncdisplaykit_cancelAsyncTransactions")]
        void Asyncdisplaykit_cancelAsyncTransactions();

        // @required @property (nonatomic, setter = asyncdisplaykit_setCurrentAsyncTransaction:, strong) _ASAsyncTransaction * _Nullable asyncdisplaykit_currentAsyncTransaction;
        [Abstract]
        [NullAllowed, Export("asyncdisplaykit_currentAsyncTransaction", ArgumentSemantic.Strong)]
        _ASAsyncTransaction Asyncdisplaykit_currentAsyncTransaction { get; [Bind("asyncdisplaykit_setCurrentAsyncTransaction:")] set; }
    }

    interface IASAsyncTransactionContainer { }

    // @protocol ASLayoutElementExtensibility <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASLayoutElementExtensibility
    {
        // @required -(void)setLayoutOptionExtensionBool:(BOOL)value atIndex:(int)idx;
        [Abstract]
        [Export("setLayoutOptionExtensionBool:atIndex:")]
        void SetLayoutOptionExtensionBool(bool value, int idx);

        // @required -(BOOL)layoutOptionExtensionBoolAtIndex:(int)idx;
        [Abstract]
        [Export("layoutOptionExtensionBoolAtIndex:")]
        bool LayoutOptionExtensionBoolAtIndex(int idx);

        // @required -(void)setLayoutOptionExtensionInteger:(NSInteger)value atIndex:(int)idx;
        [Abstract]
        [Export("setLayoutOptionExtensionInteger:atIndex:")]
        void SetLayoutOptionExtensionInteger(nint value, int idx);

        // @required -(NSInteger)layoutOptionExtensionIntegerAtIndex:(int)idx;
        [Abstract]
        [Export("layoutOptionExtensionIntegerAtIndex:")]
        nint LayoutOptionExtensionIntegerAtIndex(int idx);

        // @required -(void)setLayoutOptionExtensionEdgeInsets:(UIEdgeInsets)value atIndex:(int)idx;
        [Abstract]
        [Export("setLayoutOptionExtensionEdgeInsets:atIndex:")]
        void SetLayoutOptionExtensionEdgeInsets(UIEdgeInsets value, int idx);

        // @required -(UIEdgeInsets)layoutOptionExtensionEdgeInsetsAtIndex:(int)idx;
        [Abstract]
        [Export("layoutOptionExtensionEdgeInsetsAtIndex:")]
        UIEdgeInsets LayoutOptionExtensionEdgeInsetsAtIndex(int idx);
    }

    // @protocol ASStackLayoutElement <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASStackLayoutElement
    {
        // @required @property (readwrite, nonatomic) CGFloat spacingBefore;
        [Abstract]
        [Export("spacingBefore")]
        nfloat SpacingBefore { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat spacingAfter;
        [Abstract]
        [Export("spacingAfter")]
        nfloat SpacingAfter { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat flexGrow;
        [Abstract]
        [Export("flexGrow")]
        nfloat FlexGrow { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat flexShrink;
        [Abstract]
        [Export("flexShrink")]
        nfloat FlexShrink { get; set; }

        // @required @property (readwrite, nonatomic) ASDimension flexBasis;
        [Abstract]
        [Export("flexBasis", ArgumentSemantic.Assign)]
        ASDimension FlexBasis { get; set; }

        // @required @property (readwrite, nonatomic) ASStackLayoutAlignSelf alignSelf;
        [Abstract]
        [Export("alignSelf", ArgumentSemantic.Assign)]
        ASStackLayoutAlignSelf AlignSelf { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat ascender;
        [Abstract]
        [Export("ascender")]
        nfloat Ascender { get; set; }

        // @required @property (readwrite, nonatomic) CGFloat descender;
        [Abstract]
        [Export("descender")]
        nfloat Descender { get; set; }
    }

    // @protocol ASAbsoluteLayoutElement
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASAbsoluteLayoutElement
    {
        // @required @property (assign, nonatomic) CGPoint layoutPosition;
        [Abstract]
        [Export("layoutPosition", ArgumentSemantic.Assign)]
        CGPoint LayoutPosition { get; set; }
    }

    // @protocol ASTraitEnvironment <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTraitEnvironment
    {
        // @required -(ASPrimitiveTraitCollection)primitiveTraitCollection;
        // @required -(void)setPrimitiveTraitCollection:(ASPrimitiveTraitCollection)traitCollection;
        [Abstract]
        [Export("primitiveTraitCollection")]
        //[Verify (MethodToProperty)]
        ASPrimitiveTraitCollection PrimitiveTraitCollection { get; set; }

        // @required -(ASTraitCollection * _Nonnull)asyncTraitCollection;
        [Abstract]
        [Export("asyncTraitCollection")]
        ASTraitCollection AsyncTraitCollection();
    }

    interface IASTraitEnvironment { }

    // @interface ASTraitCollection : NSObject
    [BaseType(typeof(NSObject))]
    interface ASTraitCollection
    {
        // @property (readonly, assign, nonatomic) CGFloat displayScale;
        [Export("displayScale")]
        nfloat DisplayScale { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceSizeClass horizontalSizeClass;
        [Export("horizontalSizeClass", ArgumentSemantic.Assign)]
        UIUserInterfaceSizeClass HorizontalSizeClass { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceIdiom userInterfaceIdiom;
        [Export("userInterfaceIdiom", ArgumentSemantic.Assign)]
        UIUserInterfaceIdiom UserInterfaceIdiom { get; }

        // @property (readonly, assign, nonatomic) UIUserInterfaceSizeClass verticalSizeClass;
        [Export("verticalSizeClass", ArgumentSemantic.Assign)]
        UIUserInterfaceSizeClass VerticalSizeClass { get; }

        // @property (readonly, assign, nonatomic) UIForceTouchCapability forceTouchCapability;
        [Export("forceTouchCapability", ArgumentSemantic.Assign)]
        UIForceTouchCapability ForceTouchCapability { get; }

        // @property (readonly, assign, nonatomic) CGSize containerSize;
        [Export("containerSize", ArgumentSemantic.Assign)]
        CGSize ContainerSize { get; }

        // +(ASTraitCollection * _Nonnull)traitCollectionWithASPrimitiveTraitCollection:(ASPrimitiveTraitCollection)traits;
        [Static]
        [Export("traitCollectionWithASPrimitiveTraitCollection:")]
        ASTraitCollection TraitCollectionWithASPrimitiveTraitCollection(ASPrimitiveTraitCollection traits);

        // +(ASTraitCollection * _Nonnull)traitCollectionWithUITraitCollection:(UITraitCollection * _Nonnull)traitCollection containerSize:(CGSize)windowSize;
        [Static]
        [Export("traitCollectionWithUITraitCollection:containerSize:")]
        ASTraitCollection TraitCollectionWithUITraitCollection(UITraitCollection traitCollection, CGSize windowSize);

        // +(ASTraitCollection * _Nonnull)traitCollectionWithDisplayScale:(CGFloat)displayScale userInterfaceIdiom:(UIUserInterfaceIdiom)userInterfaceIdiom horizontalSizeClass:(UIUserInterfaceSizeClass)horizontalSizeClass verticalSizeClass:(UIUserInterfaceSizeClass)verticalSizeClass forceTouchCapability:(UIForceTouchCapability)forceTouchCapability containerSize:(CGSize)windowSize;
        [Static]
        [Export("traitCollectionWithDisplayScale:userInterfaceIdiom:horizontalSizeClass:verticalSizeClass:forceTouchCapability:containerSize:")]
        ASTraitCollection TraitCollectionWithDisplayScale(nfloat displayScale, UIUserInterfaceIdiom userInterfaceIdiom, UIUserInterfaceSizeClass horizontalSizeClass, UIUserInterfaceSizeClass verticalSizeClass, UIForceTouchCapability forceTouchCapability, CGSize windowSize);

        // -(ASPrimitiveTraitCollection)primitiveTraitCollection;
        [Export("primitiveTraitCollection")]
        //[Verify (MethodToProperty)]
        ASPrimitiveTraitCollection PrimitiveTraitCollection { get; }

        // -(BOOL)isEqualToTraitCollection:(ASTraitCollection * _Nonnull)traitCollection;
        [Export("isEqualToTraitCollection:")]
        bool IsEqualToTraitCollection(ASTraitCollection traitCollection);
    }

    // @protocol ASLayoutElement <ASLayoutElementExtensibility, ASTraitEnvironment, ASLayoutElementAsciiArtProtocol>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASLayoutElement
    {
        // @required @property (readonly, assign, nonatomic) ASLayoutElementType layoutElementType;
        [Abstract]
        [Export("layoutElementType", ArgumentSemantic.Assign)]
        ASLayoutElementType LayoutElementType { get; }

        // @required @property (readonly, nonatomic, strong) ASLayoutElementStyle * _Nonnull style;
        [Abstract]
        [Export("style", ArgumentSemantic.Strong)]
        ASLayoutElementStyle Style { get; }

        // @required -(NSArray<id<ASLayoutElement>> * _Nullable)sublayoutElements;
        [Abstract]
        [NullAllowed, Export("sublayoutElements")]
        //[Verify (MethodToProperty)]
        IASLayoutElement[] SublayoutElements { get; }

        // @required -(ASLayout * _Nonnull)layoutThatFits:(ASSizeRange)constrainedSize;
        [Abstract]
        [Export("layoutThatFits:")]
        ASLayout LayoutThatFits(ASSizeRange constrainedSize);

        // @required -(ASLayout * _Nonnull)layoutThatFits:(ASSizeRange)constrainedSize parentSize:(CGSize)parentSize;
        [Abstract]
        [Export("layoutThatFits:parentSize:")]
        ASLayout LayoutThatFits(ASSizeRange constrainedSize, CGSize parentSize);

        // @required -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize;
        [Abstract]
        [Export("calculateLayoutThatFits:")]
        ASLayout CalculateLayoutThatFits(ASSizeRange constrainedSize);

        // @required -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize restrictedToSize:(ASLayoutElementSize)size relativeToParentSize:(CGSize)parentSize;
        [Abstract]
        [Export("calculateLayoutThatFits:restrictedToSize:relativeToParentSize:")]
        ASLayout CalculateLayoutThatFits(ASSizeRange constrainedSize, ASLayoutElementSize size, CGSize parentSize);

        // @required -(BOOL)implementsLayoutMethod;
        [Abstract]
        [Export("implementsLayoutMethod")]
        //[Verify (MethodToProperty)]
        bool ImplementsLayoutMethod { get; }
    }

    interface IASLayoutElement { }

    // @protocol ASLayoutElementStyleDelegate <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASLayoutElementStyleDelegate
    {
        // @required -(void)style:(__kindof ASLayoutElementStyle * _Nonnull)style propertyDidChange:(NSString * _Nonnull)propertyName;
        [Abstract]
        [Export("style:propertyDidChange:")]
        void PropertyDidChange(ASLayoutElementStyle style, string propertyName);
    }

    // @interface ASLayoutElementStyle : NSObject <ASStackLayoutElement, ASAbsoluteLayoutElement, ASLayoutElementExtensibility>
    [BaseType(typeof(NSObject))]
    interface ASLayoutElementStyle : ASStackLayoutElement, ASAbsoluteLayoutElement, ASLayoutElementExtensibility
    {
        // -(instancetype _Nonnull)initWithDelegate:(id<ASLayoutElementStyleDelegate> _Nonnull)delegate;
        [Export("initWithDelegate:")]
        IntPtr Constructor(ASLayoutElementStyleDelegate @delegate);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ASLayoutElementStyleDelegate Delegate { get; }

        // @property (readonly, nonatomic, weak) id<ASLayoutElementStyleDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; }

        // @property (assign, readwrite, nonatomic) ASDimension width;
        [Export("width", ArgumentSemantic.Assign)]
        ASDimension Width { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension height;
        [Export("height", ArgumentSemantic.Assign)]
        ASDimension Height { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension minHeight;
        [Export("minHeight", ArgumentSemantic.Assign)]
        ASDimension MinHeight { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension maxHeight;
        [Export("maxHeight", ArgumentSemantic.Assign)]
        ASDimension MaxHeight { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension minWidth;
        [Export("minWidth", ArgumentSemantic.Assign)]
        ASDimension MinWidth { get; set; }

        // @property (assign, readwrite, nonatomic) ASDimension maxWidth;
        [Export("maxWidth", ArgumentSemantic.Assign)]
        ASDimension MaxWidth { get; set; }

        // @property (assign, nonatomic) CGSize preferredSize;
        [Export("preferredSize", ArgumentSemantic.Assign)]
        CGSize PreferredSize { get; set; }

        // @property (assign, nonatomic) CGSize minSize;
        [Export("minSize", ArgumentSemantic.Assign)]
        CGSize MinSize { get; set; }

        // @property (assign, nonatomic) CGSize maxSize;
        [Export("maxSize", ArgumentSemantic.Assign)]
        CGSize MaxSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize preferredLayoutSize;
        [Export("preferredLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize PreferredLayoutSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize minLayoutSize;
        [Export("minLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize MinLayoutSize { get; set; }

        // @property (assign, readwrite, nonatomic) ASLayoutSize maxLayoutSize;
        [Export("maxLayoutSize", ArgumentSemantic.Assign)]
        ASLayoutSize MaxLayoutSize { get; set; }
    }

    // @protocol ASLayoutElementStylability
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASLayoutElementStylability
    {
        // @required -(instancetype _Nonnull)styledWithBlock:(void (^ _Nonnull)(__kindof ASLayoutElementStyle * _Nonnull))styleBlock;
        [Abstract]
        [Export("styledWithBlock:")]
        IASLayoutElementStylability StyledWithBlock(Action<ASLayoutElementStyle> styleBlock);
    }

    interface IASLayoutElementStylability { }

    // typedef UIView * _Nonnull (^ASDisplayNodeViewBlock)();
    delegate UIView ASDisplayNodeViewBlock();

    // typedef UIViewController * _Nonnull (^ASDisplayNodeViewControllerBlock)();
    delegate UIViewController ASDisplayNodeViewControllerBlock();

    // typedef CALayer * _Nonnull (^ASDisplayNodeLayerBlock)();
    delegate CALayer ASDisplayNodeLayerBlock();

    // typedef void (^ASDisplayNodeDidLoadBlock)(__kindof ASDisplayNode * _Nonnull);
    delegate void ASDisplayNodeDidLoadBlock(ASDisplayNode arg0);

    //// typedef void (^ASDisplayNodeContextModifier)(CGContextRef _Nonnull, id _Nullable);
    //unsafe delegate void ASDisplayNodeContextModifier (CGContextRef* arg0, [NullAllowed] NSObject arg1);

    // typedef ASLayoutSpec * _Nonnull (^ASLayoutSpecBlock)(__kindof ASDisplayNode * _Nonnull, ASSizeRange);
    delegate ASLayoutSpec ASLayoutSpecBlock(ASDisplayNode arg0, ASSizeRange arg1);

    // typedef void (^ASDisplayNodeNonFatalErrorBlock)(__kindof NSError * _Nonnull);
    delegate void ASDisplayNodeNonFatalErrorBlock(NSError arg0);

    // @interface ASDisplayNode : NSObject
    [BaseType(typeof(NSObject))]
    partial interface ASDisplayNode : ASLayoutElement, ASLayoutElementStylability, ASAsyncTransactionContainer, ASInterfaceStateDelegate
    {
        // -(instancetype _Nonnull)initWithViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock;
        [Export("initWithViewBlock:")]
        IntPtr Constructor(ASDisplayNodeViewBlock viewBlock);

        // -(instancetype _Nonnull)initWithViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export("initWithViewBlock:didLoadBlock:")]
        IntPtr Constructor(ASDisplayNodeViewBlock viewBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(instancetype _Nonnull)initWithLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock;
        [Export("initWithLayerBlock:")]
        IntPtr Constructor(ASDisplayNodeLayerBlock layerBlock);

        // -(instancetype _Nonnull)initWithLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export("initWithLayerBlock:didLoadBlock:")]
        IntPtr Constructor(ASDisplayNodeLayerBlock layerBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(void)onDidLoad:(ASDisplayNodeDidLoadBlock _Nonnull)body;
        [Export("onDidLoad:")]
        void OnDidLoad(ASDisplayNodeDidLoadBlock body);

        // -(void)setViewBlock:(ASDisplayNodeViewBlock _Nonnull)viewBlock;
        [Export("setViewBlock:")]
        void SetViewBlock(ASDisplayNodeViewBlock viewBlock);

        // -(void)setLayerBlock:(ASDisplayNodeLayerBlock _Nonnull)layerBlock;
        [Export("setLayerBlock:")]
        void SetLayerBlock(ASDisplayNodeLayerBlock layerBlock);

        // @property (readonly, getter = isSynchronous, assign, atomic) BOOL synchronous;
        [Export("synchronous")]
        bool Synchronous { [Bind("isSynchronous")] get; }

        // @property (readonly, nonatomic, strong) UIView * _Nonnull view;
        [Export("view", ArgumentSemantic.Strong)]
        UIView View { get; }

        // @property (readonly, getter = isNodeLoaded, assign, nonatomic) BOOL nodeLoaded;
        [Export("nodeLoaded")]
        bool NodeLoaded { [Bind("isNodeLoaded")] get; }

        // @property (getter = isLayerBacked, assign, nonatomic) BOOL layerBacked;
        [Export("layerBacked")]
        bool LayerBacked { [Bind("isLayerBacked")] get; set; }

        // @property (readonly, nonatomic, strong) CALayer * _Nonnull layer;
        [Export("layer", ArgumentSemantic.Strong)]
        CALayer Layer { get; }

        // @property (readonly, getter = isVisible) BOOL visible;
        [Export("visible")]
        bool Visible { [Bind("isVisible")] get; }

        // @property (readonly, getter = isInPreloadState) BOOL inPreloadState;
        [Export("inPreloadState")]
        bool InPreloadState { [Bind("isInPreloadState")] get; }

        // @property (readonly, getter = isInDisplayState) BOOL inDisplayState;
        [Export("inDisplayState")]
        bool InDisplayState { [Bind("isInDisplayState")] get; }

        // @property (readonly) ASInterfaceState interfaceState;
        [Export("interfaceState")]
        ASInterfaceState InterfaceState { get; }

        // @property (copy, nonatomic, class) ASDisplayNodeNonFatalErrorBlock _Nonnull nonFatalErrorBlock;
        [Static]
        [Export("nonFatalErrorBlock", ArgumentSemantic.Copy)]
        ASDisplayNodeNonFatalErrorBlock NonFatalErrorBlock { get; set; }

        // -(void)addSubnode:(ASDisplayNode * _Nonnull)subnode;
        [Export("addSubnode:")]
        void AddSubnode(ASDisplayNode subnode);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode belowSubnode:(ASDisplayNode * _Nonnull)below;
        [Export("insertSubnode:belowSubnode:")]
        void InsertSubnode(ASDisplayNode subnode, ASDisplayNode below);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode aboveSubnode:(ASDisplayNode * _Nonnull)above;
        [Export("insertSubnode:aboveSubnode:")]
        void InsertSubnodeAboveSubnode(ASDisplayNode subnode, ASDisplayNode above);

        // -(void)insertSubnode:(ASDisplayNode * _Nonnull)subnode atIndex:(NSInteger)idx;
        [Export("insertSubnode:atIndex:")]
        void InsertSubnodeAtIndex(ASDisplayNode subnode, nint idx);

        // -(void)replaceSubnode:(ASDisplayNode * _Nonnull)subnode withSubnode:(ASDisplayNode * _Nonnull)replacementSubnode;
        [Export("replaceSubnode:withSubnode:")]
        void ReplaceSubnode(ASDisplayNode subnode, ASDisplayNode replacementSubnode);

        // -(void)removeFromSupernode;
        [Export("removeFromSupernode")]
        void RemoveFromSupernode();

        // @property (readonly, copy, nonatomic) NSArray<ASDisplayNode *> * _Nonnull subnodes;
        [Export("subnodes", ArgumentSemantic.Copy)]
        ASDisplayNode[] Subnodes { get; }

        // @property (readonly, nonatomic, weak) ASDisplayNode * _Nullable supernode;
        [NullAllowed, Export("supernode", ArgumentSemantic.Weak)]
        ASDisplayNode Supernode { get; }

        // @property (assign, nonatomic) BOOL displaysAsynchronously;
        [Export("displaysAsynchronously")]
        bool DisplaysAsynchronously { get; set; }

        // @property (assign, nonatomic) BOOL displaySuspended;
        [Export("displaySuspended")]
        bool DisplaySuspended { get; set; }

        // @property (assign, nonatomic) BOOL shouldAnimateSizeChanges;
        [Export("shouldAnimateSizeChanges")]
        bool ShouldAnimateSizeChanges { get; set; }

        // -(void)recursivelySetDisplaySuspended:(BOOL)flag;
        [Export("recursivelySetDisplaySuspended:")]
        void RecursivelySetDisplaySuspended(bool flag);

        // -(void)recursivelyClearContents;
        [Export("recursivelyClearContents")]
        void RecursivelyClearContents();

        // @property (assign, nonatomic) BOOL placeholderEnabled;
        [Export("placeholderEnabled")]
        bool PlaceholderEnabled { get; set; }

        // @property (assign, nonatomic) NSTimeInterval placeholderFadeDuration;
        [Export("placeholderFadeDuration")]
        double PlaceholderFadeDuration { get; set; }

        // @property (assign, atomic) NSInteger drawingPriority;
        [Export("drawingPriority")]
        nint DrawingPriority { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets hitTestSlop;
        [Export("hitTestSlop", ArgumentSemantic.Assign)]
        UIEdgeInsets HitTestSlop { get; set; }

        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("pointInside:withEvent:")]
        bool PointInside(CGPoint point, [NullAllowed] UIEvent @event);

        // -(CGPoint)convertPoint:(CGPoint)point toNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export("convertPoint:toNode:")]
        CGPoint ConvertPointToNode(CGPoint point, [NullAllowed] ASDisplayNode node);

        // -(CGPoint)convertPoint:(CGPoint)point fromNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export("convertPoint:fromNode:")]
        CGPoint ConvertPointFromNode(CGPoint point, [NullAllowed] ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect toNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export("convertRect:toNode:")]
        CGRect ConvertRectToNode(CGRect rect, [NullAllowed] ASDisplayNode node);

        // -(CGRect)convertRect:(CGRect)rect fromNode:(ASDisplayNode * _Nullable)node __attribute__((warn_unused_result));
        [Export("convertRect:fromNode:")]
        CGRect ConvertRectFromNode(CGRect rect, [NullAllowed] ASDisplayNode node);

        // @property (readonly, nonatomic) BOOL supportsLayerBacking;
        [Export("supportsLayerBacking")]
        bool SupportsLayerBacking { get; }
    }

    // @interface UIViewBridge (ASDisplayNode)
    //[Category()]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // -(void)setNeedsDisplay;
        [Export("setNeedsDisplay")]
        void SetNeedsDisplay();

        // -(void)setNeedsLayout;
        [Export("setNeedsLayout")]
        void SetNeedsLayout();

        // -(void)layoutIfNeeded;
        [Export("layoutIfNeeded")]
        void LayoutIfNeeded();

        // @property (assign, nonatomic) CGRect frame;
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // @property (assign, nonatomic) CGRect bounds;
        [Export("bounds", ArgumentSemantic.Assign)]
        CGRect Bounds { get; set; }

        // @property (assign, nonatomic) CGPoint position;
        [Export("position", ArgumentSemantic.Assign)]
        CGPoint Position { get; set; }

        // @property (assign, nonatomic) CGFloat alpha;
        [Export("alpha")]
        nfloat Alpha { get; set; }

        // @property (assign, nonatomic) ASCornerRoundingType cornerRoundingType;
        [Export("cornerRoundingType", ArgumentSemantic.Assign)]
        ASCornerRoundingType CornerRoundingType { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) BOOL clipsToBounds;
        [Export("clipsToBounds")]
        bool ClipsToBounds { get; set; }

        // @property (getter = isHidden, nonatomic) BOOL hidden;
        [Export("hidden")]
        bool Hidden { [Bind("isHidden")] get; set; }

        // @property (getter = isOpaque, nonatomic) BOOL opaque;
        [Export("opaque")]
        bool Opaque { [Bind("isOpaque")] get; set; }

        // @property (nonatomic, strong) id _Nullable contents;
        [NullAllowed, Export("contents", ArgumentSemantic.Strong)]
        NSObject Contents { get; set; }

        // @property (assign, nonatomic) CGRect contentsRect;
        [Export("contentsRect", ArgumentSemantic.Assign)]
        CGRect ContentsRect { get; set; }

        // @property (assign, nonatomic) CGRect contentsCenter;
        [Export("contentsCenter", ArgumentSemantic.Assign)]
        CGRect ContentsCenter { get; set; }

        // @property (assign, nonatomic) CGFloat contentsScale;
        [Export("contentsScale")]
        nfloat ContentsScale { get; set; }

        // @property (assign, nonatomic) CGFloat rasterizationScale;
        [Export("rasterizationScale")]
        nfloat RasterizationScale { get; set; }

        // @property (assign, nonatomic) CGPoint anchorPoint;
        [Export("anchorPoint", ArgumentSemantic.Assign)]
        CGPoint AnchorPoint { get; set; }

        // @property (assign, nonatomic) CGFloat zPosition;
        [Export("zPosition")]
        nfloat ZPosition { get; set; }

        // @property (assign, nonatomic) CATransform3D transform;
        [Export("transform", ArgumentSemantic.Assign)]
        CATransform3D Transform { get; set; }

        // @property (assign, nonatomic) CATransform3D subnodeTransform;
        [Export("subnodeTransform", ArgumentSemantic.Assign)]
        CATransform3D SubnodeTransform { get; set; }

        // @property (getter = isUserInteractionEnabled, assign, nonatomic) BOOL userInteractionEnabled;
        [Export("userInteractionEnabled")]
        bool UserInteractionEnabled { [Bind("isUserInteractionEnabled")] get; set; }

        // @property (getter = isExclusiveTouch, assign, nonatomic) BOOL exclusiveTouch;
        [Export("exclusiveTouch")]
        bool ExclusiveTouch { [Bind("isExclusiveTouch")] get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // -(void)tintColorDidChange;
        [Export("tintColorDidChange")]
        void TintColorDidChange();

        // @property (assign, nonatomic) UIViewContentMode contentMode;
        [Export("contentMode", ArgumentSemantic.Assign)]
        UIViewContentMode ContentMode { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull contentsGravity;
        [Export("contentsGravity")]
        string ContentsGravity { get; set; }

        // @property (assign, nonatomic) UISemanticContentAttribute semanticContentAttribute;
        [Export("semanticContentAttribute", ArgumentSemantic.Assign)]
        UISemanticContentAttribute SemanticContentAttribute { get; set; }

        // @property (assign, nonatomic) CGFloat shadowOpacity;
        [Export("shadowOpacity")]
        nfloat ShadowOpacity { get; set; }

        // @property (assign, nonatomic) CGSize shadowOffset;
        [Export("shadowOffset", ArgumentSemantic.Assign)]
        CGSize ShadowOffset { get; set; }

        // @property (assign, nonatomic) CGFloat shadowRadius;
        [Export("shadowRadius")]
        nfloat ShadowRadius { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) BOOL allowsGroupOpacity;
        [Export("allowsGroupOpacity")]
        bool AllowsGroupOpacity { get; set; }

        // @property (assign, nonatomic) BOOL allowsEdgeAntialiasing;
        [Export("allowsEdgeAntialiasing")]
        bool AllowsEdgeAntialiasing { get; set; }

        // @property (assign, nonatomic) unsigned int edgeAntialiasingMask;
        [Export("edgeAntialiasingMask")]
        uint EdgeAntialiasingMask { get; set; }

        // @property (assign, nonatomic) BOOL needsDisplayOnBoundsChange;
        [Export("needsDisplayOnBoundsChange")]
        bool NeedsDisplayOnBoundsChange { get; set; }

        // @property (assign, nonatomic) BOOL autoresizesSubviews;
        [Export("autoresizesSubviews")]
        bool AutoresizesSubviews { get; set; }

        // @property (assign, nonatomic) UIViewAutoresizing autoresizingMask;
        [Export("autoresizingMask", ArgumentSemantic.Assign)]
        UIViewAutoresizing AutoresizingMask { get; set; }

        // -(BOOL)canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        //[Verify (MethodToProperty)]
        bool CanBecomeFirstResponder { get; }

        // -(BOOL)becomeFirstResponder;
        [Export("becomeFirstResponder")]
        //[Verify (MethodToProperty)]
        bool BecomeFirstResponder { get; }

        // -(BOOL)canResignFirstResponder;
        [Export("canResignFirstResponder")]
        //[Verify (MethodToProperty)]
        bool CanResignFirstResponder { get; }

        // -(BOOL)resignFirstResponder;
        [Export("resignFirstResponder")]
        //[Verify (MethodToProperty)]
        bool ResignFirstResponder { get; }

        // -(BOOL)isFirstResponder;
        [Export("isFirstResponder")]
        //[Verify (MethodToProperty)]
        bool IsFirstResponder { get; }

        // -(BOOL)canPerformAction:(SEL _Nonnull)action withSender:(id _Nonnull)sender;
        [Export("canPerformAction:withSender:")]
        bool CanPerformAction(Selector action, NSObject sender);
    }

    // @interface UIViewBridgeAccessibility (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) BOOL isAccessibilityElement;
        [Export("isAccessibilityElement")]
        bool IsAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedLabel __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export("accessibilityAttributedLabel", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedLabel { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
        [NullAllowed, Export("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedHint __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export("accessibilityAttributedHint", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedHint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
        [NullAllowed, Export("accessibilityValue")]
        string AccessibilityValue { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable accessibilityAttributedValue __attribute__((availability(tvos, introduced=11.0))) __attribute__((availability(ios, introduced=11.0)));
        //[TV (11, 0), iOS (11, 0)]
        [NullAllowed, Export("accessibilityAttributedValue", ArgumentSemantic.Copy)]
        NSAttributedString AccessibilityAttributedValue { get; set; }

        // @property (assign, nonatomic) UIAccessibilityTraits accessibilityTraits;
        [Export("accessibilityTraits")]
        ulong AccessibilityTraits { get; set; }

        // @property (assign, nonatomic) CGRect accessibilityFrame;
        [Export("accessibilityFrame", ArgumentSemantic.Assign)]
        CGRect AccessibilityFrame { get; set; }

        // @property (copy, nonatomic) UIBezierPath * _Nullable accessibilityPath;
        [NullAllowed, Export("accessibilityPath", ArgumentSemantic.Copy)]
        UIBezierPath AccessibilityPath { get; set; }

        // @property (assign, nonatomic) CGPoint accessibilityActivationPoint;
        [Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
        CGPoint AccessibilityActivationPoint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLanguage;
        [NullAllowed, Export("accessibilityLanguage")]
        string AccessibilityLanguage { get; set; }

        // @property (assign, nonatomic) BOOL accessibilityElementsHidden;
        [Export("accessibilityElementsHidden")]
        bool AccessibilityElementsHidden { get; set; }

        // @property (assign, nonatomic) BOOL accessibilityViewIsModal;
        [Export("accessibilityViewIsModal")]
        bool AccessibilityViewIsModal { get; set; }

        // @property (assign, nonatomic) BOOL shouldGroupAccessibilityChildren;
        [Export("shouldGroupAccessibilityChildren")]
        bool ShouldGroupAccessibilityChildren { get; set; }

        // @property (assign, nonatomic) UIAccessibilityNavigationStyle accessibilityNavigationStyle;
        [Export("accessibilityNavigationStyle", ArgumentSemantic.Assign)]
        UIAccessibilityNavigationStyle AccessibilityNavigationStyle { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
        [NullAllowed, Export("accessibilityIdentifier")]
        string AccessibilityIdentifier { get; set; }
    }

    // @interface ASLayoutElementStylability (ASDisplayNode) <ASLayoutElementStylability>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
    }

    // @interface ASLayout (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readwrite, copy, nonatomic) ASLayoutSpecBlock _Nullable layoutSpecBlock;
        [NullAllowed, Export("layoutSpecBlock", ArgumentSemantic.Copy)]
        ASLayoutSpecBlock LayoutSpecBlock { get; set; }

        // @property (readonly, assign, nonatomic) CGSize calculatedSize;
        [Export("calculatedSize", ArgumentSemantic.Assign)]
        CGSize CalculatedSize { get; }

        // @property (readonly, assign, nonatomic) ASSizeRange constrainedSizeForCalculatedLayout;
        [Export("constrainedSizeForCalculatedLayout", ArgumentSemantic.Assign)]
        ASSizeRange ConstrainedSizeForCalculatedLayout { get; }
    }

    // @interface ASLayoutTransitioning (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) NSTimeInterval defaultLayoutTransitionDuration;
        [Export("defaultLayoutTransitionDuration")]
        double DefaultLayoutTransitionDuration { get; set; }

        // @property (assign, nonatomic) NSTimeInterval defaultLayoutTransitionDelay;
        [Export("defaultLayoutTransitionDelay")]
        double DefaultLayoutTransitionDelay { get; set; }

        // @property (assign, nonatomic) UIViewAnimationOptions defaultLayoutTransitionOptions;
        [Export("defaultLayoutTransitionOptions", ArgumentSemantic.Assign)]
        UIViewAnimationOptions DefaultLayoutTransitionOptions { get; set; }

        // -(void)animateLayoutTransition:(id<ASContextTransitioning> _Nonnull)context;
        [Export("animateLayoutTransition:")]
        void AnimateLayoutTransition(ASContextTransitioning context);

        // -(void)didCompleteLayoutTransition:(id<ASContextTransitioning> _Nonnull)context;
        [Export("didCompleteLayoutTransition:")]
        void DidCompleteLayoutTransition(ASContextTransitioning context);

        // -(void)transitionLayoutWithSizeRange:(ASSizeRange)constrainedSize animated:(BOOL)animated shouldMeasureAsync:(BOOL)shouldMeasureAsync measurementCompletion:(void (^ _Nullable)())completion;
        [Export("transitionLayoutWithSizeRange:animated:shouldMeasureAsync:measurementCompletion:")]
        void TransitionLayoutWithSizeRange(ASSizeRange constrainedSize, bool animated, bool shouldMeasureAsync, [NullAllowed] Action completion);

        // -(void)transitionLayoutWithAnimation:(BOOL)animated shouldMeasureAsync:(BOOL)shouldMeasureAsync measurementCompletion:(void (^ _Nullable)())completion;
        [Export("transitionLayoutWithAnimation:shouldMeasureAsync:measurementCompletion:")]
        void TransitionLayoutWithAnimation(bool animated, bool shouldMeasureAsync, [NullAllowed] Action completion);

        // -(void)cancelLayoutTransition;
        [Export("cancelLayoutTransition")]
        void CancelLayoutTransition();
    }

    // @interface ASAutomaticSubnodeManagement (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (assign, nonatomic) BOOL automaticallyManagesSubnodes;
        [Export("automaticallyManagesSubnodes")]
        bool AutomaticallyManagesSubnodes { get; set; }
    }

    // @interface Ancestry (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // -(__kindof ASDisplayNode * _Nullable)supernodeOfClass:(Class _Nonnull)supernodeClass includingSelf:(BOOL)includeSelf;
        [Export("supernodeOfClass:includingSelf:")]
        ASDisplayNode SupernodeOfClass(Class supernodeClass, bool includeSelf);

        // @property (readonly, copy, atomic) NSString * _Nonnull ancestryDescription;
        [Export("ancestryDescription")]
        string AncestryDescription { get; }
    }


    // @interface Convenience (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic) __kindof UIViewController * _Nullable closestViewController;
        [Export("closestViewController")]
        UIViewController ClosestViewController { get; }
    }

    // @interface ASControlNode : ASDisplayNode
    [BaseType(typeof(ASDisplayNode))]
    partial interface ASControlNode
    {
        // @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (getter = isHighlighted, assign, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { [Bind("isHighlighted")] get; set; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (readonly, getter = isTracking, assign, nonatomic) BOOL tracking;
        [Export("tracking")]
        bool Tracking { [Bind("isTracking")] get; }

        // @property (readonly, getter = isTouchInside, assign, nonatomic) BOOL touchInside;
        [Export("touchInside")]
        bool TouchInside { [Bind("isTouchInside")] get; }

        // -(void)addTarget:(id _Nullable)target action:(SEL _Nonnull)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export("addTarget:action:forControlEvents:")]
        void AddTarget([NullAllowed] NSObject target, Selector action, ASControlNodeEvent controlEvents);

        // -(NSArray<NSString *> * _Nullable)actionsForTarget:(id _Nonnull)target forControlEvent:(ASControlNodeEvent)controlEvent __attribute__((warn_unused_result));
        [Export("actionsForTarget:forControlEvent:")]
        [return: NullAllowed]
        string[] ActionsForTarget(NSObject target, ASControlNodeEvent controlEvent);

        // -(NSSet * _Nonnull)allTargets __attribute__((warn_unused_result));
        [Export("allTargets")]
        //[Verify (MethodToProperty)]
        NSSet AllTargets { get; }

        // -(void)removeTarget:(id _Nullable)target action:(SEL _Nullable)action forControlEvents:(ASControlNodeEvent)controlEvents;
        [Export("removeTarget:action:forControlEvents:")]
        void RemoveTarget([NullAllowed] NSObject target, [NullAllowed] Selector action, ASControlNodeEvent controlEvents);

        // -(void)sendActionsForControlEvents:(ASControlNodeEvent)controlEvents withEvent:(UIEvent * _Nullable)event;
        [Export("sendActionsForControlEvents:withEvent:")]
        void SendActionsForControlEvents(ASControlNodeEvent controlEvents, [NullAllowed] UIEvent @event);
    }

    // typedef UIImage * _Nullable (^asimagenode_modification_block_t)(UIImage * _Nonnull);
    delegate UIImage asimagenode_modification_block_t(UIImage arg0);

    // @interface ASImageNode : ASControlNode
    [BaseType(typeof(ASControlNode))]
    partial interface ASImageNode
    {
        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
        [NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (getter = isCropEnabled, assign, nonatomic) BOOL cropEnabled;
        [Export("cropEnabled")]
        bool CropEnabled { [Bind("isCropEnabled")] get; set; }

        // @property (assign, nonatomic) BOOL forceUpscaling;
        [Export("forceUpscaling")]
        bool ForceUpscaling { get; set; }

        // @property (assign, nonatomic) CGSize forcedSize;
        [Export("forcedSize", ArgumentSemantic.Assign)]
        CGSize ForcedSize { get; set; }

        // -(void)setCropEnabled:(BOOL)cropEnabled recropImmediately:(BOOL)recropImmediately inBounds:(CGRect)cropBounds;
        [Export("setCropEnabled:recropImmediately:inBounds:")]
        void SetCropEnabled(bool cropEnabled, bool recropImmediately, CGRect cropBounds);

        // @property (assign, readwrite, nonatomic) CGRect cropRect;
        [Export("cropRect", ArgumentSemantic.Assign)]
        CGRect CropRect { get; set; }

        // @property (readwrite, copy, nonatomic) asimagenode_modification_block_t _Nullable imageModificationBlock;
        [NullAllowed, Export("imageModificationBlock", ArgumentSemantic.Copy)]
        asimagenode_modification_block_t ImageModificationBlock { get; set; }

        // -(void)setNeedsDisplayWithCompletion:(void (^ _Nullable)(BOOL))displayCompletionBlock;
        [Export("setNeedsDisplayWithCompletion:")]
        void SetNeedsDisplayWithCompletion([NullAllowed] Action<bool> displayCompletionBlock);
    }

    // @interface AnimatedImage (ASImageNode)
    //[Category]
    //[BaseType (typeof(ASImageNode))]
    partial interface ASImageNode
    {
        // @property (nonatomic, strong) id<ASAnimatedImageProtocol> _Nullable animatedImage;
        [NullAllowed, Export("animatedImage", ArgumentSemantic.Strong)]
        ASAnimatedImageProtocol AnimatedImage { get; set; }

        // @property (assign, nonatomic) BOOL animatedImagePaused;
        [Export("animatedImagePaused")]
        bool AnimatedImagePaused { get; set; }

        // @property (nonatomic, strong) NSString * _Nonnull animatedImageRunLoopMode;
        [Export("animatedImageRunLoopMode", ArgumentSemantic.Strong)]
        string AnimatedImageRunLoopMode { get; set; }

        // -(void)animatedImageSet:(id<ASAnimatedImageProtocol> _Nonnull)newAnimatedImage previousAnimatedImage:(id<ASAnimatedImageProtocol> _Nonnull)previousAnimatedImage;
        [Export("animatedImageSet:previousAnimatedImage:")]
        void AnimatedImageSet(ASAnimatedImageProtocol newAnimatedImage, ASAnimatedImageProtocol previousAnimatedImage);
    }

    // @interface ASTextNode : ASControlNode
    [BaseType(typeof(ASControlNode))]
    interface ASTextNode : ASTextNodeDelegate
    {
        // @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
        [NullAllowed, Export("attributedText", ArgumentSemantic.Copy)]
        NSAttributedString AttributedText { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable truncationAttributedText;
        [NullAllowed, Export("truncationAttributedText", ArgumentSemantic.Copy)]
        NSAttributedString TruncationAttributedText { get; set; }

        // @property (copy, nonatomic) NSAttributedString * _Nullable additionalTruncationMessage;
        [NullAllowed, Export("additionalTruncationMessage", ArgumentSemantic.Copy)]
        NSAttributedString AdditionalTruncationMessage { get; set; }

        // @property (assign, nonatomic) NSLineBreakMode truncationMode;
        [Export("truncationMode", ArgumentSemantic.Assign)]
        UILineBreakMode TruncationMode { get; set; }

        // @property (readonly, getter = isTruncated, assign, nonatomic) BOOL truncated;
        [Export("truncated")]
        bool Truncated { [Bind("isTruncated")] get; }

        // @property (assign, nonatomic) NSUInteger maximumNumberOfLines;
        [Export("maximumNumberOfLines")]
        nuint MaximumNumberOfLines { get; set; }

        // @property (readonly, assign, nonatomic) NSUInteger lineCount;
        [Export("lineCount")]
        nuint LineCount { get; }

        // @property (nonatomic, strong) NSArray<UIBezierPath *> * _Nullable exclusionPaths;
        [NullAllowed, Export("exclusionPaths", ArgumentSemantic.Strong)]
        UIBezierPath[] ExclusionPaths { get; set; }

        // @property (assign, nonatomic) BOOL placeholderEnabled;
        [Export("placeholderEnabled")]
        bool PlaceholderEnabled { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable placeholderColor;
        [NullAllowed, Export("placeholderColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderColor { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets placeholderInsets;
        [Export("placeholderInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets PlaceholderInsets { get; set; }

        // @property (readonly, assign, nonatomic) UIEdgeInsets shadowPadding;
        [Export("shadowPadding", ArgumentSemantic.Assign)]
        UIEdgeInsets ShadowPadding { get; }

        // -(NSArray<NSValue *> * _Nonnull)rectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export("rectsForTextRange:")]
        NSValue[] RectsForTextRange(NSRange textRange);

        // -(NSArray<NSValue *> * _Nonnull)highlightRectsForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export("highlightRectsForTextRange:")]
        NSValue[] HighlightRectsForTextRange(NSRange textRange);

        // -(CGRect)frameForTextRange:(NSRange)textRange __attribute__((warn_unused_result));
        [Export("frameForTextRange:")]
        CGRect FrameForTextRange(NSRange textRange);

        // -(CGRect)trailingRect __attribute__((warn_unused_result));
        [Export("trailingRect")]
        //[Verify (MethodToProperty)]
        CGRect TrailingRect { get; }

        // @property (copy, nonatomic) NSArray<NSString *> * _Nonnull linkAttributeNames;
        [Export("linkAttributeNames", ArgumentSemantic.Copy)]
        string[] LinkAttributeNames { get; set; }

        // @property (assign, nonatomic) ASTextNodeHighlightStyle highlightStyle;
        [Export("highlightStyle", ArgumentSemantic.Assign)]
        ASTextNodeHighlightStyle HighlightStyle { get; set; }

        // @property (assign, nonatomic) NSRange highlightRange;
        [Export("highlightRange", ArgumentSemantic.Assign)]
        NSRange HighlightRange { get; set; }

        // -(void)setHighlightRange:(NSRange)highlightRange animated:(BOOL)animated;
        [Export("setHighlightRange:animated:")]
        void SetHighlightRange(NSRange highlightRange, bool animated);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ASTextNodeDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ASTextNodeDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (assign, nonatomic) BOOL longPressCancelsTouches;
        [Export("longPressCancelsTouches")]
        bool LongPressCancelsTouches { get; set; }

        // @property (assign, nonatomic) BOOL passthroughNonlinkTouches;
        [Export("passthroughNonlinkTouches")]
        bool PassthroughNonlinkTouches { get; set; }
    }

    // @protocol ASTextNodeDelegate <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTextNodeDelegate
    {
        // @optional -(void)textNode:(ASTextNode * _Nonnull)textNode tappedLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export("textNode:tappedLinkAttribute:value:atPoint:textRange:")]
        void TappedLinkAttribute(ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNode:(ASTextNode * _Nonnull)textNode longPressedLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point textRange:(NSRange)textRange;
        [Export("textNode:longPressedLinkAttribute:value:atPoint:textRange:")]
        void LongPressedLinkAttribute(ASTextNode textNode, string attribute, NSObject value, CGPoint point, NSRange textRange);

        // @optional -(void)textNodeTappedTruncationToken:(ASTextNode * _Nonnull)textNode;
        [Export("textNodeTappedTruncationToken:")]
        void TextNodeTappedTruncationToken(ASTextNode textNode);

        // @optional -(BOOL)textNode:(ASTextNode * _Nonnull)textNode shouldHighlightLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point;
        [Export("textNode:shouldHighlightLinkAttribute:value:atPoint:")]
        bool ShouldHighlightLinkAttribute(ASTextNode textNode, string attribute, NSObject value, CGPoint point);

        // @optional -(BOOL)textNode:(ASTextNode * _Nonnull)textNode shouldLongPressLinkAttribute:(NSString * _Nonnull)attribute value:(id _Nonnull)value atPoint:(CGPoint)point;
        [Export("textNode:shouldLongPressLinkAttribute:value:atPoint:")]
        bool ShouldLongPressLinkAttribute(ASTextNode textNode, string attribute, NSObject value, CGPoint point);
    }

    // @interface ASButtonNode : ASControlNode
    [BaseType(typeof(ASControlNode))]
    interface ASButtonNode
    {
        // @property (readonly, nonatomic) ASTextNode * _Nonnull titleNode;
        [Export("titleNode")]
        ASTextNode TitleNode { get; }

        // @property (readonly, nonatomic) ASImageNode * _Nonnull imageNode;
        [Export("imageNode")]
        ASImageNode ImageNode { get; }

        // @property (readonly, nonatomic) ASImageNode * _Nonnull backgroundImageNode;
        [Export("backgroundImageNode")]
        ASImageNode BackgroundImageNode { get; }

        // @property (assign, nonatomic) CGFloat contentSpacing;
        [Export("contentSpacing")]
        nfloat ContentSpacing { get; set; }

        // @property (assign, nonatomic) BOOL laysOutHorizontally;
        [Export("laysOutHorizontally")]
        bool LaysOutHorizontally { get; set; }

        // @property (assign, nonatomic) ASHorizontalAlignment contentHorizontalAlignment;
        [Export("contentHorizontalAlignment", ArgumentSemantic.Assign)]
        ASHorizontalAlignment ContentHorizontalAlignment { get; set; }

        // @property (assign, nonatomic) ASVerticalAlignment contentVerticalAlignment;
        [Export("contentVerticalAlignment", ArgumentSemantic.Assign)]
        ASVerticalAlignment ContentVerticalAlignment { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
        [Export("contentEdgeInsets", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentEdgeInsets { get; set; }

        // @property (assign, nonatomic) ASButtonNodeImageAlignment imageAlignment;
        [Export("imageAlignment", ArgumentSemantic.Assign)]
        ASButtonNodeImageAlignment ImageAlignment { get; set; }

        // -(NSAttributedString * _Nullable)attributedTitleForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export("attributedTitleForState:")]
        [return: NullAllowed]
        NSAttributedString AttributedTitleForState(UIControlState state);

        // -(void)setAttributedTitle:(NSAttributedString * _Nullable)title forState:(UIControlState)state;
        [Export("setAttributedTitle:forState:")]
        void SetAttributedTitle([NullAllowed] NSAttributedString title, UIControlState state);

        // -(void)setTitle:(NSString * _Nonnull)title withFont:(UIFont * _Nullable)font withColor:(UIColor * _Nullable)color forState:(UIControlState)state;
        [Export("setTitle:withFont:withColor:forState:")]
        void SetTitle(string title, [NullAllowed] UIFont font, [NullAllowed] UIColor color, UIControlState state);

        // -(UIImage * _Nullable)imageForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export("imageForState:")]
        [return: NullAllowed]
        UIImage ImageForState(UIControlState state);

        // -(void)setImage:(UIImage * _Nullable)image forState:(UIControlState)state;
        [Export("setImage:forState:")]
        void SetImage([NullAllowed] UIImage image, UIControlState state);

        // -(void)setBackgroundImage:(UIImage * _Nullable)image forState:(UIControlState)state;
        [Export("setBackgroundImage:forState:")]
        void SetBackgroundImage([NullAllowed] UIImage image, UIControlState state);

        // -(UIImage * _Nullable)backgroundImageForState:(UIControlState)state __attribute__((warn_unused_result));
        [Export("backgroundImageForState:")]
        [return: NullAllowed]
        UIImage BackgroundImageForState(UIControlState state);
    }

    // @interface ASNetworkImageNode : ASImageNode
    [BaseType(typeof(ASImageNode))]
    interface ASNetworkImageNode
    {
        // -(instancetype _Nonnull)initWithCache:(id<ASImageCacheProtocol> _Nullable)cache downloader:(id<ASImageDownloaderProtocol> _Nonnull)downloader __attribute__((objc_designated_initializer));
        [Export("initWithCache:downloader:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] ASImageCacheProtocol cache, ASImageDownloaderProtocol downloader);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ASNetworkImageNodeDelegate Delegate { get; set; }

        // @property (readwrite, nonatomic, weak) id<ASNetworkImageNodeDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (readwrite, nonatomic, strong) UIImage * _Nullable defaultImage;
        [NullAllowed, Export("defaultImage", ArgumentSemantic.Strong)]
        UIImage DefaultImage { get; set; }

        // @property (readwrite, nonatomic, strong) NSURL * _Nullable URL;
        [NullAllowed, Export("URL", ArgumentSemantic.Strong)]
        NSUrl URL { get; set; }

        // @property (readwrite, nonatomic, strong) NSArray<NSURL *> * _Nullable URLs;
        [NullAllowed, Export("URLs", ArgumentSemantic.Strong)]
        NSUrl[] URLs { get; set; }

        // -(void)setURL:(NSURL * _Nullable)URL resetToDefault:(BOOL)reset;
        [Export("setURL:resetToDefault:")]
        void SetURL([NullAllowed] NSUrl URL, bool reset);

        // @property (assign, readwrite, nonatomic) BOOL shouldCacheImage;
        [Export("shouldCacheImage")]
        bool ShouldCacheImage { get; set; }

        // @property (assign, readwrite, nonatomic) BOOL shouldRenderProgressImages;
        [Export("shouldRenderProgressImages")]
        bool ShouldRenderProgressImages { get; set; }

        // @property (readonly, assign, nonatomic) CGFloat currentImageQuality;
        [Export("currentImageQuality")]
        nfloat CurrentImageQuality { get; }

        // @property (readonly, assign, nonatomic) CGFloat renderedImageQuality;
        [Export("renderedImageQuality")]
        nfloat RenderedImageQuality { get; }
    }

    // @protocol ASNetworkImageNodeDelegate <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASNetworkImageNodeDelegate
    {
        // @optional -(void)imageNode:(ASNetworkImageNode * _Nonnull)imageNode didLoadImage:(UIImage * _Nonnull)image;
        [Export("imageNode:didLoadImage:")]
        void ImageNode(ASNetworkImageNode imageNode, UIImage image);

        // @optional -(void)imageNodeDidStartFetchingData:(ASNetworkImageNode * _Nonnull)imageNode;
        [Export("imageNodeDidStartFetchingData:")]
        void ImageNodeDidStartFetchingData(ASNetworkImageNode imageNode);

        // @optional -(void)imageNode:(ASNetworkImageNode * _Nonnull)imageNode didFailWithError:(NSError * _Nonnull)error;
        [Export("imageNode:didFailWithError:")]
        void ImageNode(ASNetworkImageNode imageNode, NSError error);

        // @optional -(void)imageNodeDidFinishDecoding:(ASNetworkImageNode * _Nonnull)imageNode;
        [Export("imageNodeDidFinishDecoding:")]
        void ImageNodeDidFinishDecoding(ASNetworkImageNode imageNode);
    }

    // typedef ASCellNode * _Nonnull (^ASCellNodeBlock)();
    delegate ASCellNode ASCellNodeBlock();

    // typedef BOOL (^asdisplaynode_iscancelled_block_t)();
    delegate bool asdisplaynode_iscancelled_block_t();

    // @protocol ASInterfaceStateDelegate <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASInterfaceStateDelegate
    {
        // @required -(void)interfaceStateDidChange:(ASInterfaceState)newState fromState:(ASInterfaceState)oldState;
        [Abstract]
        [Export("interfaceStateDidChange:fromState:")]
        void InterfaceStateDidChange(ASInterfaceState newState, ASInterfaceState oldState);

        // @required -(void)didEnterVisibleState;
        [Abstract]
        [Export("didEnterVisibleState")]
        void DidEnterVisibleState();

        // @required -(void)didExitVisibleState;
        [Abstract]
        [Export("didExitVisibleState")]
        void DidExitVisibleState();

        // @required -(void)didEnterDisplayState;
        [Abstract]
        [Export("didEnterDisplayState")]
        void DidEnterDisplayState();

        // @required -(void)didExitDisplayState;
        [Abstract]
        [Export("didExitDisplayState")]
        void DidExitDisplayState();

        // @required -(void)didEnterPreloadState;
        [Abstract]
        [Export("didEnterPreloadState")]
        void DidEnterPreloadState();

        // @required -(void)didExitPreloadState;
        [Abstract]
        [Export("didExitPreloadState")]
        void DidExitPreloadState();

        // @required -(void)nodeDidLayout;
        [Abstract]
        [Export("nodeDidLayout")]
        void NodeDidLayout();
    }

    interface IASInterfaceStateDelegate { }

    // @interface Subclassing (ASDisplayNode) <ASInterfaceStateDelegate>
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic, strong) ASLayout * _Nullable calculatedLayout;
        [NullAllowed, Export("calculatedLayout", ArgumentSemantic.Strong)]
        ASLayout CalculatedLayout { get; }

        // -(void)didLoad __attribute__((objc_requires_super));
        [Export("didLoad")]
        //[RequiresSuper]
        void DidLoad();

        // -(void)layout __attribute__((objc_requires_super));
        [Export("layout")]
        //[RequiresSuper]
        void Layout();

        // -(void)layoutDidFinish __attribute__((objc_requires_super));
        [Export("layoutDidFinish")]
        //[RequiresSuper]
        void LayoutDidFinish();

        // -(void)calculatedLayoutDidChange __attribute__((objc_requires_super));
        [Export("calculatedLayoutDidChange")]
        //[RequiresSuper]
        void CalculatedLayoutDidChange();

        //// -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize;
        //[Export ("calculateLayoutThatFits:")]
        //ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize);

        //// -(ASLayout * _Nonnull)calculateLayoutThatFits:(ASSizeRange)constrainedSize restrictedToSize:(ASLayoutElementSize)size relativeToParentSize:(CGSize)parentSize;
        //[Export ("calculateLayoutThatFits:restrictedToSize:relativeToParentSize:")]
        //ASLayout CalculateLayoutThatFits (ASSizeRange constrainedSize, ASLayoutElementSize size, CGSize parentSize);

        // -(CGSize)calculateSizeThatFits:(CGSize)constrainedSize;
        [Export("calculateSizeThatFits:")]
        CGSize CalculateSizeThatFits(CGSize constrainedSize);

        // -(ASLayoutSpec * _Nonnull)layoutSpecThatFits:(ASSizeRange)constrainedSize;
        [Export("layoutSpecThatFits:")]
        ASLayoutSpec LayoutSpecThatFits(ASSizeRange constrainedSize);

        // -(void)invalidateCalculatedLayout;
        [Export("invalidateCalculatedLayout")]
        void InvalidateCalculatedLayout();

        // -(void)asyncTraitCollectionDidChange;
        [Export("asyncTraitCollectionDidChange")]
        void AsyncTraitCollectionDidChange();

        // +(void)drawRect:(CGRect)bounds withParameters:(id _Nullable)parameters isCancelled:(asdisplaynode_iscancelled_block_t _Nonnull)isCancelledBlock isRasterizing:(BOOL)isRasterizing;
        [Static]
        [Export("drawRect:withParameters:isCancelled:isRasterizing:")]
        void DrawRect(CGRect bounds, [NullAllowed] NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock, bool isRasterizing);

        // +(UIImage * _Nullable)displayWithParameters:(id _Nullable)parameters isCancelled:(asdisplaynode_iscancelled_block_t _Nonnull)isCancelledBlock;
        [Static]
        [Export("displayWithParameters:isCancelled:")]
        [return: NullAllowed]
        UIImage DisplayWithParameters([NullAllowed] NSObject parameters, asdisplaynode_iscancelled_block_t isCancelledBlock);

        // -(id<NSObject> _Nullable)drawParametersForAsyncLayer:(_ASDisplayLayer * _Nonnull)layer;
        [Export("drawParametersForAsyncLayer:")]
        [return: NullAllowed]
        NSObject DrawParametersForAsyncLayer(_ASDisplayLayer layer);

        // -(void)displayWillStart __attribute__((deprecated("Use displayWillStartAsynchronously: instead."))) __attribute__((objc_requires_super));
        [Export("displayWillStart")]
        //[RequiresSuper]
        void DisplayWillStart();

        // -(void)displayWillStartAsynchronously:(BOOL)asynchronously __attribute__((objc_requires_super));
        [Export("displayWillStartAsynchronously:")]
        //[RequiresSuper]
        void DisplayWillStartAsynchronously(bool asynchronously);

        // -(void)displayDidFinish __attribute__((objc_requires_super));
        [Export("displayDidFinish")]
        //[RequiresSuper]
        void DisplayDidFinish();

        // -(void)willEnterHierarchy __attribute__((objc_requires_super));
        [Export("willEnterHierarchy")]
        //[RequiresSuper]
        void WillEnterHierarchy();

        // -(void)didExitHierarchy __attribute__((objc_requires_super));
        [Export("didExitHierarchy")]
        //[RequiresSuper]
        void DidExitHierarchy();

        // @property (readonly, getter = isInHierarchy, assign, nonatomic) BOOL inHierarchy;
        [Export("inHierarchy")]
        bool InHierarchy { [Bind("isInHierarchy")] get; }

        // -(void)clearContents __attribute__((objc_requires_super));
        [Export("clearContents")]
        //[RequiresSuper]
        void ClearContents();

        // -(void)subnodeDisplayWillStart:(ASDisplayNode * _Nonnull)subnode __attribute__((objc_requires_super));
        [Export("subnodeDisplayWillStart:")]
        //[RequiresSuper]
        void SubnodeDisplayWillStart(ASDisplayNode subnode);

        // -(void)subnodeDisplayDidFinish:(ASDisplayNode * _Nonnull)subnode __attribute__((objc_requires_super));
        [Export("subnodeDisplayDidFinish:")]
        //[RequiresSuper]
        void SubnodeDisplayDidFinish(ASDisplayNode subnode);

        // -(void)setNeedsDisplayAtScale:(CGFloat)contentsScale;
        [Export("setNeedsDisplayAtScale:")]
        void SetNeedsDisplayAtScale(nfloat contentsScale);

        // -(void)recursivelySetNeedsDisplayAtScale:(CGFloat)contentsScale;
        [Export("recursivelySetNeedsDisplayAtScale:")]
        void RecursivelySetNeedsDisplayAtScale(nfloat contentsScale);

        // @property (readonly, assign, nonatomic) CGFloat contentsScaleForDisplay;
        [Export("contentsScaleForDisplay")]
        nfloat ContentsScaleForDisplay { get; }

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesBegan:withEvent:")]
        //[RequiresSuper]
        void TouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesMoved:withEvent:")]
        //[RequiresSuper]
        void TouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesEnded:withEvent:")]
        //[RequiresSuper]
        void TouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesCancelled:withEvent:")]
        //[RequiresSuper]
        void TouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(BOOL)gestureRecognizerShouldBegin:(UIGestureRecognizer * _Nonnull)gestureRecognizer;
        [Export("gestureRecognizerShouldBegin:")]
        bool GestureRecognizerShouldBegin(UIGestureRecognizer gestureRecognizer);

        // -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event;
        [Export("hitTest:withEvent:")]
        [return: NullAllowed]
        UIView HitTest(CGPoint point, [NullAllowed] UIEvent @event);

        // -(UIImage * _Nullable)placeholderImage;
        [NullAllowed, Export("placeholderImage")]
        //[Verify (MethodToProperty)]
        UIImage PlaceholderImage { get; }

        // -(NSString * _Nonnull)descriptionForRecursiveDescription;
        [Export("descriptionForRecursiveDescription")]
        //[Verify (MethodToProperty)]
        string DescriptionForRecursiveDescription { get; }
    }

    // @protocol ASImageContainerProtocol <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASImageContainerProtocol
    {
        // @required -(UIImage * _Nullable)asdk_image;
        [Abstract]
        [NullAllowed, Export("asdk_image")]
        //[Verify (MethodToProperty)]
        UIImage Asdk_image { get; }

        // @required -(NSData * _Nullable)asdk_animatedImageData;
        [Abstract]
        [NullAllowed, Export("asdk_animatedImageData")]
        //[Verify (MethodToProperty)]
        NSData Asdk_animatedImageData { get; }
    }

    // typedef void (^ASImageCacherCompletion)(id<ASImageContainerProtocol> _Nullable);
    delegate void ASImageCacherCompletion([NullAllowed] ASImageContainerProtocol arg0);

    // @protocol ASImageCacheProtocol <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASImageCacheProtocol
    {
        // @required -(void)cachedImageWithURL:(NSURL * _Nonnull)URL callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue completion:(ASImageCacherCompletion _Nonnull)completion;
        [Abstract]
        [Export("cachedImageWithURL:callbackQueue:completion:")]
        void CachedImageWithURL(NSUrl URL, DispatchQueue callbackQueue, ASImageCacherCompletion completion);

        // @optional -(id<ASImageContainerProtocol> _Nullable)synchronouslyFetchedCachedImageWithURL:(NSURL * _Nonnull)URL;
        [Export("synchronouslyFetchedCachedImageWithURL:")]
        [return: NullAllowed]
        ASImageContainerProtocol SynchronouslyFetchedCachedImageWithURL(NSUrl URL);

        // @optional -(void)clearFetchedImageFromCacheWithURL:(NSURL * _Nonnull)URL;
        [Export("clearFetchedImageFromCacheWithURL:")]
        void ClearFetchedImageFromCacheWithURL(NSUrl URL);

        // @optional -(void)cachedImageWithURLs:(NSArray<NSURL *> * _Nonnull)URLs callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue completion:(ASImageCacherCompletion _Nonnull)completion;
        [Export("cachedImageWithURLs:callbackQueue:completion:")]
        void CachedImageWithURLs(NSUrl[] URLs, DispatchQueue callbackQueue, ASImageCacherCompletion completion);
    }

    // typedef void (^ASImageDownloaderCompletion)(id<ASImageContainerProtocol> _Nullable, NSError * _Nullable, id _Nullable);
    delegate void ASImageDownloaderCompletion([NullAllowed] ASImageContainerProtocol arg0, [NullAllowed] NSError arg1, [NullAllowed] NSObject arg2);

    // typedef void (^ASImageDownloaderProgress)(CGFloat);
    delegate void ASImageDownloaderProgress(nfloat arg0);

    // typedef void (^ASImageDownloaderProgressImage)(UIImage * _Nonnull, CGFloat, id _Nullable);
    delegate void ASImageDownloaderProgressImage(UIImage arg0, nfloat arg1, [NullAllowed] NSObject arg2);

    // @protocol ASImageDownloaderProtocol <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASImageDownloaderProtocol
    {
        // @required -(id _Nullable)downloadImageWithURL:(NSURL * _Nonnull)URL callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue downloadProgress:(ASImageDownloaderProgress _Nullable)downloadProgress completion:(ASImageDownloaderCompletion _Nonnull)completion;
        [Abstract]
        [Export("downloadImageWithURL:callbackQueue:downloadProgress:completion:")]
        [return: NullAllowed]
        NSObject DownloadImageWithURL(NSUrl URL, DispatchQueue callbackQueue, [NullAllowed] ASImageDownloaderProgress downloadProgress, ASImageDownloaderCompletion completion);

        // @required -(void)cancelImageDownloadForIdentifier:(id _Nonnull)downloadIdentifier;
        [Abstract]
        [Export("cancelImageDownloadForIdentifier:")]
        void CancelImageDownloadForIdentifier(NSObject downloadIdentifier);

        // @optional -(void)cancelImageDownloadWithResumePossibilityForIdentifier:(id _Nonnull)downloadIdentifier;
        [Export("cancelImageDownloadWithResumePossibilityForIdentifier:")]
        void CancelImageDownloadWithResumePossibilityForIdentifier(NSObject downloadIdentifier);

        // @optional -(id<ASAnimatedImageProtocol> _Nullable)animatedImageWithData:(NSData * _Nonnull)animatedImageData;
        [Export("animatedImageWithData:")]
        [return: NullAllowed]
        ASAnimatedImageProtocol AnimatedImageWithData(NSData animatedImageData);

        // @optional -(void)setProgressImageBlock:(ASImageDownloaderProgressImage _Nullable)progressBlock callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue withDownloadIdentifier:(id _Nonnull)downloadIdentifier;
        [Export("setProgressImageBlock:callbackQueue:withDownloadIdentifier:")]
        void SetProgressImageBlock([NullAllowed] ASImageDownloaderProgressImage progressBlock, DispatchQueue callbackQueue, NSObject downloadIdentifier);

        // @optional -(void)setPriority:(ASImageDownloaderPriority)priority withDownloadIdentifier:(id _Nonnull)downloadIdentifier;
        [Export("setPriority:withDownloadIdentifier:")]
        void SetPriority(ASImageDownloaderPriority priority, NSObject downloadIdentifier);

        // @optional -(id _Nullable)downloadImageWithURLs:(NSArray<NSURL *> * _Nonnull)URLs callbackQueue:(dispatch_queue_t _Nonnull)callbackQueue downloadProgress:(ASImageDownloaderProgress _Nullable)downloadProgress completion:(ASImageDownloaderCompletion _Nonnull)completion;
        [Export("downloadImageWithURLs:callbackQueue:downloadProgress:completion:")]
        [return: NullAllowed]
        NSObject DownloadImageWithURLs(NSUrl[] URLs, DispatchQueue callbackQueue, [NullAllowed] ASImageDownloaderProgress downloadProgress, ASImageDownloaderCompletion completion);
    }

    // @protocol ASAnimatedImageProtocol <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASAnimatedImageProtocol
    {
        // @optional @property (readwrite, nonatomic) void (^ _Nonnull)(UIImage * _Nonnull) coverImageReadyCallback;
        [Export("coverImageReadyCallback", ArgumentSemantic.Assign)]
        Action<UIImage> CoverImageReadyCallback { get; set; }

        // @optional -(BOOL)isDataSupported:(NSData * _Nonnull)data;
        [Export("isDataSupported:")]
        bool IsDataSupported(NSData data);

        // @required @property (readonly, nonatomic) UIImage * _Nonnull coverImage;
        [Abstract]
        [Export("coverImage")]
        UIImage CoverImage { get; }

        // @required @property (readonly, nonatomic) BOOL coverImageReady;
        [Abstract]
        [Export("coverImageReady")]
        bool CoverImageReady { get; }

        // @required @property (readonly, nonatomic) CFTimeInterval totalDuration;
        [Abstract]
        [Export("totalDuration")]
        double TotalDuration { get; }

        // @required @property (readonly, nonatomic) NSUInteger frameInterval;
        [Abstract]
        [Export("frameInterval")]
        nuint FrameInterval { get; }

        // @required @property (readonly, nonatomic) size_t loopCount;
        [Abstract]
        [Export("loopCount")]
        nuint LoopCount { get; }

        // @required @property (readonly, nonatomic) size_t frameCount;
        [Abstract]
        [Export("frameCount")]
        nuint FrameCount { get; }

        // @required @property (readonly, nonatomic) BOOL playbackReady;
        [Abstract]
        [Export("playbackReady")]
        bool PlaybackReady { get; }

        // @required @property (readonly, nonatomic) NSError * _Nonnull error;
        [Abstract]
        [Export("error")]
        NSError Error { get; }

        // @required -(CFTimeInterval)durationAtIndex:(NSUInteger)index;
        [Abstract]
        [Export("durationAtIndex:")]
        double DurationAtIndex(nuint index);

        // @required -(void)clearAnimatedImageCache;
        [Abstract]
        [Export("clearAnimatedImageCache")]
        void ClearAnimatedImageCache();
    }

    // @interface ASBasicImageDownloader : NSObject <ASImageDownloaderProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface ASBasicImageDownloader : ASImageDownloaderProtocol
    {
        // +(instancetype _Nonnull)sharedImageDownloader;
        [Static]
        [Export("sharedImageDownloader")]
        ASBasicImageDownloader SharedImageDownloader();
    }

    // @protocol ASCommonTableDataSource <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASCommonTableDataSource
    {
        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((deprecated("Implement -tableNode:numberOfRowsInSection: instead.")));
        [Export("tableView:numberOfRowsInSection:")]
        nint NumberOfRowsInSection(UITableView tableView, nint section);

        // @optional -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((deprecated("Implement numberOfSectionsInTableNode: instead.")));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForHeaderInSection:(NSInteger)section;
        [Export("tableView:titleForHeaderInSection:")]
        [return: NullAllowed]
        string TitleForHeaderInSection(UITableView tableView, nint section);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForFooterInSection:(NSInteger)section;
        [Export("tableView:titleForFooterInSection:")]
        [return: NullAllowed]
        string TitleForFooterInSection(UITableView tableView, nint section);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canEditRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:canEditRowAtIndexPath:")]
        bool CanEditRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canMoveRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:canMoveRowAtIndexPath:")]
        bool CanMoveRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray<NSString *> * _Nullable)sectionIndexTitlesForTableView:(UITableView * _Nonnull)tableView;
        [Export("sectionIndexTitlesForTableView:")]
        [return: NullAllowed]
        string[] SectionIndexTitlesForTableView(UITableView tableView);

        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView sectionForSectionIndexTitle:(NSString * _Nonnull)title atIndex:(NSInteger)index;
        [Export("tableView:sectionForSectionIndexTitle:atIndex:")]
        nint SectionForSectionIndexTitle(UITableView tableView, string title, nint index);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView commitEditingStyle:(UITableViewCellEditingStyle)editingStyle forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:commitEditingStyle:forRowAtIndexPath:")]
        void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView moveRowAtIndexPath:(NSIndexPath * _Nonnull)sourceIndexPath toIndexPath:(NSIndexPath * _Nonnull)destinationIndexPath;
        [Export("tableView:moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath(UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath);
    }

    interface IASCommonTableDataSource { }

    // @protocol ASCommonTableViewDelegate <NSObject, UIScrollViewDelegate>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASCommonTableViewDelegate : IUIScrollViewDelegate
    {
        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willDisplayHeaderView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export("tableView:willDisplayHeaderView:forSection:")]
        void WillDisplayHeaderView(UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willDisplayFooterView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export("tableView:willDisplayFooterView:forSection:")]
        void WillDisplayFooterView(UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndDisplayingHeaderView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export("tableView:didEndDisplayingHeaderView:forSection:")]
        void DidEndDisplayingHeaderView(UITableView tableView, UIView view, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndDisplayingFooterView:(UIView * _Nonnull)view forSection:(NSInteger)section;
        [Export("tableView:didEndDisplayingFooterView:forSection:")]
        void DidEndDisplayingFooterView(UITableView tableView, UIView view, nint section);

        // @optional -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section;
        [Export("tableView:heightForHeaderInSection:")]
        nfloat HeightForHeaderInSection(UITableView tableView, nint section);

        // @optional -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section;
        [Export("tableView:heightForFooterInSection:")]
        nfloat HeightForFooterInSection(UITableView tableView, nint section);

        // @optional -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section;
        [Export("tableView:viewForHeaderInSection:")]
        [return: NullAllowed]
        UIView ViewForHeaderInSection(UITableView tableView, nint section);

        // @optional -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section;
        [Export("tableView:viewForFooterInSection:")]
        [return: NullAllowed]
        UIView ViewForFooterInSection(UITableView tableView, nint section);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView accessoryButtonTappedForRowWithIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:accessoryButtonTappedForRowWithIndexPath:")]
        void TableView(UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:shouldHighlightRowAtIndexPath: instead.")));
        [Export("tableView:shouldHighlightRowAtIndexPath:")]
        bool ShouldHighlightRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didHighlightRowAtIndexPath: instead.")));
        [Export("tableView:didHighlightRowAtIndexPath:")]
        void DidHighlightRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didUnhighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didUnhighlightRowAtIndexPath: instead.")));
        [Export("tableView:didUnhighlightRowAtIndexPath:")]
        void DidUnhighlightRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableView:(UITableView * _Nonnull)tableView willSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:willSelectRowAtIndexPath: instead.")));
        [Export("tableView:willSelectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillSelectRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableView:(UITableView * _Nonnull)tableView willDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:willDeselectRowAtIndexPath: instead.")));
        [Export("tableView:willDeselectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillDeselectRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didSelectRowAtIndexPath: instead.")));
        [Export("tableView:didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:didDeselectRowAtIndexPath: instead.")));
        [Export("tableView:didDeselectRowAtIndexPath:")]
        void DidDeselectRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(UITableViewCellEditingStyle)tableView:(UITableView * _Nonnull)tableView editingStyleForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:editingStyleForRowAtIndexPath:")]
        UITableViewCellEditingStyle EditingStyleForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSString * _Nullable)tableView:(UITableView * _Nonnull)tableView titleForDeleteConfirmationButtonForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:titleForDeleteConfirmationButtonForRowAtIndexPath:")]
        [return: NullAllowed]
        string TitleForDeleteConfirmationButtonForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSArray<UITableViewRowAction *> * _Nullable)tableView:(UITableView * _Nonnull)tableView editActionsForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:editActionsForRowAtIndexPath:")]
        [return: NullAllowed]
        UITableViewRowAction[] EditActionsForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldIndentWhileEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:shouldIndentWhileEditingRowAtIndexPath:")]
        bool ShouldIndentWhileEditingRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView willBeginEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:willBeginEditingRowAtIndexPath:")]
        void WillBeginEditingRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView didEndEditingRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:didEndEditingRowAtIndexPath:")]
        void DidEndEditingRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nonnull)tableView:(UITableView * _Nonnull)tableView targetIndexPathForMoveFromRowAtIndexPath:(NSIndexPath * _Nonnull)sourceIndexPath toProposedIndexPath:(NSIndexPath * _Nonnull)proposedDestinationIndexPath;
        [Export("tableView:targetIndexPathForMoveFromRowAtIndexPath:toProposedIndexPath:")]
        NSIndexPath TargetIndexPathForMoveFromRowAtIndexPath(UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath proposedDestinationIndexPath);

        // @optional -(NSInteger)tableView:(UITableView * _Nonnull)tableView indentationLevelForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:indentationLevelForRowAtIndexPath:")]
        nint IndentationLevelForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldShowMenuForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Implement -tableNode:shouldShowMenuForRowAtIndexPath: instead.")));
        [Export("tableView:shouldShowMenuForRowAtIndexPath:")]
        bool ShouldShowMenuForRowAtIndexPath(UITableView tableView, NSIndexPath indexPath);

        // @optional -(BOOL)tableView:(UITableView * _Nonnull)tableView canPerformAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement -tableNode:canPerformAction:forRowAtIndexPath:withSender: instead.")));
        [Export("tableView:canPerformAction:forRowAtIndexPath:withSender:")]
        bool CanPerformAction(UITableView tableView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(void)tableView:(UITableView * _Nonnull)tableView performAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender __attribute__((deprecated("Implement -tableNode:performAction:forRowAtIndexPath:withSender: instead.")));
        [Export("tableView:performAction:forRowAtIndexPath:withSender:")]
        void PerformAction(UITableView tableView, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);
    }

    interface IASCommonTableViewDelegate { }

    // @interface ASTableView : UITableView
    [BaseType(typeof(UITableView))]
    interface ASTableView
    {
        // @property (readonly, nonatomic, weak) ASTableNode * _Nullable tableNode;
        [NullAllowed, Export("tableNode", ArgumentSemantic.Weak)]
        ASTableNode TableNode { get; }

        // -(ASCellNode * _Nullable)nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("nodeForRowAtIndexPath:")]
        [return: NullAllowed]
        ASCellNode NodeForRowAtIndexPath(NSIndexPath indexPath);
    }

    // @protocol ASTableViewDataSource <ASTableDataSource>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTableViewDataSource
    {
    }

    // @protocol ASTableViewDelegate <ASTableDelegate>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTableViewDelegate
    {
    }

    // @protocol ASRangeControllerUpdateRangeProtocol <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASRangeControllerUpdateRangeProtocol
    {
        // @required -(void)updateCurrentRangeWithMode:(ASLayoutRangeMode)rangeMode;
        [Abstract]
        [Export("updateCurrentRangeWithMode:")]
        void UpdateCurrentRangeWithMode(ASLayoutRangeMode rangeMode);
    }

    interface IASRangeControllerUpdateRangeProtocol { }

    // @protocol ASRangeManagingNode <NSObject, ASTraitEnvironment>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASRangeManagingNode : ASTraitEnvironment
    {
        // @required -(NSIndexPath * _Nullable)indexPathForNode:(ASCellNode * _Nonnull)node;
        [Abstract]
        [Export("indexPathForNode:")]
        [return: NullAllowed]
        NSIndexPath IndexPathForNode(ASCellNode node);
    }

    interface IASRangeManagingNode { }

    // @interface ASTableNode : ASDisplayNode <ASRangeControllerUpdateRangeProtocol, ASRangeManagingNode>
    [BaseType(typeof(ASDisplayNode))]
    interface ASTableNode : ASRangeControllerUpdateRangeProtocol, ASRangeManagingNode
    {
        // -(instancetype _Nonnull)initWithStyle:(UITableViewStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewStyle style);

        // @property (readonly, nonatomic, strong) ASTableView * _Nonnull view;
        [Export("view", ArgumentSemantic.Strong)]
        ASTableView View { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        ASTableDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<ASTableDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) id<ASTableDataSource> _Nullable dataSource;
        [NullAllowed, Export("dataSource", ArgumentSemantic.Weak)]
        ASTableDataSource DataSource { get; set; }

        // @property (assign, nonatomic) CGFloat leadingScreensForBatching;
        [Export("leadingScreensForBatching")]
        nfloat LeadingScreensForBatching { get; set; }

        // @property (assign, nonatomic) BOOL inverted;
        [Export("inverted")]
        bool Inverted { get; set; }

        // @property (assign, nonatomic) UIEdgeInsets contentInset;
        [Export("contentInset", ArgumentSemantic.Assign)]
        UIEdgeInsets ContentInset { get; set; }

        // @property (assign, nonatomic) CGPoint contentOffset;
        [Export("contentOffset", ArgumentSemantic.Assign)]
        CGPoint ContentOffset { get; set; }

        // -(void)setContentOffset:(CGPoint)contentOffset animated:(BOOL)animated;
        [Export("setContentOffset:animated:")]
        void SetContentOffset(CGPoint contentOffset, bool animated);

        // @property (assign, nonatomic) BOOL automaticallyAdjustsContentOffset;
        [Export("automaticallyAdjustsContentOffset")]
        bool AutomaticallyAdjustsContentOffset { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelection;
        [Export("allowsSelection")]
        bool AllowsSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsSelectionDuringEditing;
        [Export("allowsSelectionDuringEditing")]
        bool AllowsSelectionDuringEditing { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelection;
        [Export("allowsMultipleSelection")]
        bool AllowsMultipleSelection { get; set; }

        // @property (assign, nonatomic) BOOL allowsMultipleSelectionDuringEditing;
        [Export("allowsMultipleSelectionDuringEditing")]
        bool AllowsMultipleSelectionDuringEditing { get; set; }

        // -(ASRangeTuningParameters)tuningParametersForRangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
        [Export("tuningParametersForRangeType:")]
        ASRangeTuningParameters TuningParametersForRangeType(ASLayoutRangeType rangeType);

        // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeType:(ASLayoutRangeType)rangeType;
        [Export("setTuningParameters:forRangeType:")]
        void SetTuningParameters(ASRangeTuningParameters tuningParameters, ASLayoutRangeType rangeType);

        // -(ASRangeTuningParameters)tuningParametersForRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType __attribute__((warn_unused_result));
        [Export("tuningParametersForRangeMode:rangeType:")]
        ASRangeTuningParameters TuningParametersForRangeMode(ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

        // -(void)setTuningParameters:(ASRangeTuningParameters)tuningParameters forRangeMode:(ASLayoutRangeMode)rangeMode rangeType:(ASLayoutRangeType)rangeType;
        [Export("setTuningParameters:forRangeMode:rangeType:")]
        void SetTuningParameters(ASRangeTuningParameters tuningParameters, ASLayoutRangeMode rangeMode, ASLayoutRangeType rangeType);

        // -(void)scrollToRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath atScrollPosition:(UITableViewScrollPosition)scrollPosition animated:(BOOL)animated;
        [Export("scrollToRowAtIndexPath:atScrollPosition:animated:")]
        void ScrollToRowAtIndexPath(NSIndexPath indexPath, UITableViewScrollPosition scrollPosition, bool animated);

        // -(void)reloadDataWithCompletion:(void (^ _Nullable)())completion;
        [Export("reloadDataWithCompletion:")]
        void ReloadDataWithCompletion([NullAllowed] Action completion);

        // -(void)reloadData;
        [Export("reloadData")]
        void ReloadData();

        // -(void)relayoutItems;
        [Export("relayoutItems")]
        void RelayoutItems();

        // -(void)performBatchAnimated:(BOOL)animated updates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
        [Export("performBatchAnimated:updates:completion:")]
        void PerformBatchAnimated(bool animated, [NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

        // -(void)performBatchUpdates:(void (^ _Nullable)())updates completion:(void (^ _Nullable)(BOOL))completion;
        [Export("performBatchUpdates:completion:")]
        void PerformBatchUpdates([NullAllowed] Action updates, [NullAllowed] Action<bool> completion);

        // @property (readonly, nonatomic) BOOL isProcessingUpdates;
        [Export("isProcessingUpdates")]
        bool IsProcessingUpdates { get; }

        // -(void)onDidFinishProcessingUpdates:(void (^ _Nullable)())didFinishProcessingUpdates;
        [Export("onDidFinishProcessingUpdates:")]
        void OnDidFinishProcessingUpdates([NullAllowed] Action didFinishProcessingUpdates);

        // -(void)waitUntilAllUpdatesAreProcessed;
        [Export("waitUntilAllUpdatesAreProcessed")]
        void WaitUntilAllUpdatesAreProcessed();

        // -(void)insertSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("insertSections:withRowAnimation:")]
        void InsertSections(NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)deleteSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("deleteSections:withRowAnimation:")]
        void DeleteSections(NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)reloadSections:(NSIndexSet * _Nonnull)sections withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("reloadSections:withRowAnimation:")]
        void ReloadSections(NSIndexSet sections, UITableViewRowAnimation animation);

        // -(void)moveSection:(NSInteger)section toSection:(NSInteger)newSection;
        [Export("moveSection:toSection:")]
        void MoveSection(nint section, nint newSection);

        // -(void)insertRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("insertRowsAtIndexPaths:withRowAnimation:")]
        void InsertRowsAtIndexPaths(NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)deleteRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("deleteRowsAtIndexPaths:withRowAnimation:")]
        void DeleteRowsAtIndexPaths(NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)reloadRowsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths withRowAnimation:(UITableViewRowAnimation)animation;
        [Export("reloadRowsAtIndexPaths:withRowAnimation:")]
        void ReloadRowsAtIndexPaths(NSIndexPath[] indexPaths, UITableViewRowAnimation animation);

        // -(void)moveRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
        [Export("moveRowAtIndexPath:toIndexPath:")]
        void MoveRowAtIndexPath(NSIndexPath indexPath, NSIndexPath newIndexPath);

        // -(void)selectRowAtIndexPath:(NSIndexPath * _Nullable)indexPath animated:(BOOL)animated scrollPosition:(UITableViewScrollPosition)scrollPosition;
        [Export("selectRowAtIndexPath:animated:scrollPosition:")]
        void SelectRowAtIndexPath([NullAllowed] NSIndexPath indexPath, bool animated, UITableViewScrollPosition scrollPosition);

        // -(void)deselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
        [Export("deselectRowAtIndexPath:animated:")]
        void DeselectRowAtIndexPath(NSIndexPath indexPath, bool animated);

        // -(NSInteger)numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result));
        [Export("numberOfRowsInSection:")]
        nint NumberOfRowsInSection(nint section);

        // @property (readonly, nonatomic) NSInteger numberOfSections;
        [Export("numberOfSections")]
        nint NumberOfSections { get; }

        // @property (readonly, nonatomic) NSArray<__kindof ASCellNode *> * _Nonnull visibleNodes;
        [Export("visibleNodes")]
        ASCellNode[] VisibleNodes { get; }

        // -(__kindof ASCellNode * _Nullable)nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath(NSIndexPath indexPath);

        // -(CGRect)rectForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("rectForRowAtIndexPath:")]
        CGRect RectForRowAtIndexPath(NSIndexPath indexPath);

        // -(__kindof UITableViewCell * _Nullable)cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result));
        [Export("cellForRowAtIndexPath:")]
        UITableViewCell CellForRowAtIndexPath(NSIndexPath indexPath);

        // @property (readonly, nonatomic) NSIndexPath * _Nullable indexPathForSelectedRow;
        [NullAllowed, Export("indexPathForSelectedRow")]
        NSIndexPath IndexPathForSelectedRow { get; }

        // @property (readonly, nonatomic) NSArray<NSIndexPath *> * _Nullable indexPathsForSelectedRows;
        [NullAllowed, Export("indexPathsForSelectedRows")]
        NSIndexPath[] IndexPathsForSelectedRows { get; }

        // -(NSIndexPath * _Nullable)indexPathForRowAtPoint:(CGPoint)point __attribute__((warn_unused_result));
        [Export("indexPathForRowAtPoint:")]
        [return: NullAllowed]
        NSIndexPath IndexPathForRowAtPoint(CGPoint point);

        // -(NSArray<NSIndexPath *> * _Nullable)indexPathsForRowsInRect:(CGRect)rect __attribute__((warn_unused_result));
        [Export("indexPathsForRowsInRect:")]
        [return: NullAllowed]
        NSIndexPath[] IndexPathsForRowsInRect(CGRect rect);

        // -(NSArray<NSIndexPath *> * _Nonnull)indexPathsForVisibleRows __attribute__((warn_unused_result));
        [Export("indexPathsForVisibleRows")]
        //[Verify (MethodToProperty)]
        NSIndexPath[] IndexPathsForVisibleRows { get; }
    }

    // @protocol ASTableDataSource <ASCommonTableDataSource, NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTableDataSource : ASCommonTableDataSource
    {
        // @optional -(NSInteger)numberOfSectionsInTableNode:(ASTableNode * _Nonnull)tableNode;
        [Export("numberOfSectionsInTableNode:")]
        nint NumberOfSectionsInTableNode(ASTableNode tableNode);

        // @optional -(NSInteger)tableNode:(ASTableNode * _Nonnull)tableNode numberOfRowsInSection:(NSInteger)section;
        [Export("tableNode:numberOfRowsInSection:")]
        nint NumberOfRowsInSection(ASTableNode tableNode, nint section);

        // @optional -(ASCellNodeBlock _Nonnull)tableNode:(ASTableNode * _Nonnull)tableNode nodeBlockForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:nodeBlockForRowAtIndexPath:")]
        ASCellNodeBlock NodeBlockForRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(ASCellNode * _Nonnull)tableNode:(ASTableNode * _Nonnull)tableNode nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(ASCellNode * _Nonnull)tableView:(ASTableView * _Nonnull)tableView nodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export("tableView:nodeForRowAtIndexPath:")]
        ASCellNode NodeForRowAtIndexPath(ASTableView tableView, NSIndexPath indexPath);

        // @optional -(ASCellNodeBlock _Nonnull)tableView:(ASTableView * _Nonnull)tableView nodeBlockForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export("tableView:nodeBlockForRowAtIndexPath:")]
        ASCellNodeBlock NodeBlockForRowAtIndexPath(ASTableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableViewLockDataSource:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
        [Export("tableViewLockDataSource:")]
        void TableViewLockDataSource(ASTableView tableView);

        // @optional -(void)tableViewUnlockDataSource:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Data source accesses are on the main thread. Method will not be called.")));
        [Export("tableViewUnlockDataSource:")]
        void TableViewUnlockDataSource(ASTableView tableView);
    }

    // @protocol ASTableDelegate <ASCommonTableViewDelegate, NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASTableDelegate : ASCommonTableViewDelegate
    {
        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode willDisplayRowWithNode:(ASCellNode * _Nonnull)node;
        [Export("tableNode:willDisplayRowWithNode:")]
        void WillDisplayRowWithNode(ASTableNode tableNode, ASCellNode node);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didEndDisplayingRowWithNode:(ASCellNode * _Nonnull)node;
        [Export("tableNode:didEndDisplayingRowWithNode:")]
        void DidEndDisplayingRowWithNode(ASTableNode tableNode, ASCellNode node);

        // @optional -(NSIndexPath * _Nullable)tableNode:(ASTableNode * _Nonnull)tableNode willSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:willSelectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillSelectRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:didSelectRowAtIndexPath:")]
        void DidSelectRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(NSIndexPath * _Nullable)tableNode:(ASTableNode * _Nonnull)tableNode willDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:willDeselectRowAtIndexPath:")]
        [return: NullAllowed]
        NSIndexPath WillDeselectRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didDeselectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:didDeselectRowAtIndexPath:")]
        void DidDeselectRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:shouldHighlightRowAtIndexPath:")]
        bool ShouldHighlightRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:didHighlightRowAtIndexPath:")]
        void DidHighlightRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode didUnhighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:didUnhighlightRowAtIndexPath:")]
        void DidUnhighlightRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode shouldShowMenuForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:shouldShowMenuForRowAtIndexPath:")]
        bool ShouldShowMenuForRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(BOOL)tableNode:(ASTableNode * _Nonnull)tableNode canPerformAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender;
        [Export("tableNode:canPerformAction:forRowAtIndexPath:withSender:")]
        bool CanPerformAction(ASTableNode tableNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode performAction:(SEL _Nonnull)action forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath withSender:(id _Nullable)sender;
        [Export("tableNode:performAction:forRowAtIndexPath:withSender:")]
        void PerformAction(ASTableNode tableNode, Selector action, NSIndexPath indexPath, [NullAllowed] NSObject sender);

        // @optional -(ASSizeRange)tableNode:(ASTableNode * _Nonnull)tableNode constrainedSizeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableNode:constrainedSizeForRowAtIndexPath:")]
        ASSizeRange ConstrainedSizeForRowAtIndexPath(ASTableNode tableNode, NSIndexPath indexPath);

        // @optional -(void)tableNode:(ASTableNode * _Nonnull)tableNode willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context;
        [Export("tableNode:willBeginBatchFetchWithContext:")]
        void WillBeginBatchFetchWithContext(ASTableNode tableNode, ASBatchContext context);

        // @optional -(BOOL)shouldBatchFetchForTableNode:(ASTableNode * _Nonnull)tableNode;
        [Export("shouldBatchFetchForTableNode:")]
        bool ShouldBatchFetchForTableNode(ASTableNode tableNode);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willDisplayNode:(ASCellNode * _Nonnull)node forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export("tableView:willDisplayNode:forRowAtIndexPath:")]
        void WillDisplayNode(ASTableView tableView, ASCellNode node, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView didEndDisplayingNode:(ASCellNode * _Nonnull)node forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export("tableView:didEndDisplayingNode:forRowAtIndexPath:")]
        void DidEndDisplayingNode(ASTableView tableView, ASCellNode node, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willBeginBatchFetchWithContext:(ASBatchContext * _Nonnull)context __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export("tableView:willBeginBatchFetchWithContext:")]
        void WillBeginBatchFetchWithContext(ASTableView tableView, ASBatchContext context);

        // @optional -(BOOL)shouldBatchFetchForTableView:(ASTableView * _Nonnull)tableView __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export("shouldBatchFetchForTableView:")]
        bool ShouldBatchFetchForTableView(ASTableView tableView);

        // @optional -(ASSizeRange)tableView:(ASTableView * _Nonnull)tableView constrainedSizeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead."))) __attribute__((warn_unused_result));
        [Export("tableView:constrainedSizeForRowAtIndexPath:")]
        ASSizeRange ConstrainedSizeForRowAtIndexPath(ASTableView tableView, NSIndexPath indexPath);

        // @optional -(void)tableView:(ASTableView * _Nonnull)tableView willDisplayNodeForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((deprecated("Use ASTableNode's method instead.")));
        [Export("tableView:willDisplayNodeForRowAtIndexPath:")]
        void WillDisplayNodeForRowAtIndexPath(ASTableView tableView, NSIndexPath indexPath);
    }

    interface IASTableDelegate { }

    // @interface ASBatchContext : NSObject
    [BaseType(typeof(NSObject))]
    interface ASBatchContext
    {
        // -(BOOL)isFetching;
        [Export("isFetching")]
        //[Verify (MethodToProperty)]
        bool IsFetching { get; }

        // -(void)completeBatchFetching:(BOOL)didComplete;
        [Export("completeBatchFetching:")]
        void CompleteBatchFetching(bool didComplete);

        // -(BOOL)batchFetchingWasCancelled;
        [Export("batchFetchingWasCancelled")]
        //[Verify (MethodToProperty)]
        bool BatchFetchingWasCancelled { get; }

        // -(void)cancelBatchFetching;
        [Export("cancelBatchFetching")]
        void CancelBatchFetching();

        // -(void)beginBatchFetching;
        [Export("beginBatchFetching")]
        void BeginBatchFetching();
    }

    // @interface ASCellNode : ASDisplayNode
    [BaseType(typeof(ASDisplayNode))]
    interface ASCellNode
    {
        // @property (assign, nonatomic) BOOL neverShowPlaceholders;
        [Export("neverShowPlaceholders")]
        bool NeverShowPlaceholders { get; set; }

        // @property (readonly, copy, atomic) NSString * _Nullable supplementaryElementKind;
        [NullAllowed, Export("supplementaryElementKind")]
        string SupplementaryElementKind { get; }

        // @property (readonly, nonatomic, strong) UICollectionViewLayoutAttributes * _Nullable layoutAttributes;
        [NullAllowed, Export("layoutAttributes", ArgumentSemantic.Strong)]
        UICollectionViewLayoutAttributes LayoutAttributes { get; }

        // @property (getter = isSelected, assign, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected { [Bind("isSelected")] get; set; }

        // @property (getter = isHighlighted, assign, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted { [Bind("isHighlighted")] get; set; }

        // @property (readonly, atomic) NSIndexPath * _Nullable indexPath;
        [NullAllowed, Export("indexPath")]
        NSIndexPath IndexPath { get; }

        // @property (atomic) id _Nullable nodeModel;
        [NullAllowed, Export("nodeModel", ArgumentSemantic.Assign)]
        NSObject NodeModel { get; set; }

        // -(BOOL)canUpdateToNodeModel:(id _Nonnull)nodeModel;
        [Export("canUpdateToNodeModel:")]
        bool CanUpdateToNodeModel(NSObject nodeModel);

        // @property (readonly, nonatomic) UIViewController * _Nullable viewController;
        [NullAllowed, Export("viewController")]
        UIViewController ViewController { get; }

        // @property (readonly, atomic, weak) id<ASRangeManagingNode> _Nullable owningNode;
        [NullAllowed, Export("owningNode", ArgumentSemantic.Weak)]
        ASRangeManagingNode OwningNode { get; }

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesBegan:withEvent:")]
        //[RequiresSuper]
        void TouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesMoved:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesMoved:withEvent:")]
        //[RequiresSuper]
        void TouchesMoved(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesEnded:withEvent:")]
        //[RequiresSuper]
        void TouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nullable)touches withEvent:(UIEvent * _Nullable)event __attribute__((objc_requires_super));
        [Export("touchesCancelled:withEvent:")]
        //[RequiresSuper]
        void TouchesCancelled([NullAllowed] NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)applyLayoutAttributes:(UICollectionViewLayoutAttributes * _Nonnull)layoutAttributes;
        [Export("applyLayoutAttributes:")]
        void ApplyLayoutAttributes(UICollectionViewLayoutAttributes layoutAttributes);

        // -(instancetype _Nonnull)initWithViewControllerBlock:(ASDisplayNodeViewControllerBlock _Nonnull)viewControllerBlock didLoadBlock:(ASDisplayNodeDidLoadBlock _Nullable)didLoadBlock;
        [Export("initWithViewControllerBlock:didLoadBlock:")]
        IntPtr Constructor(ASDisplayNodeViewControllerBlock viewControllerBlock, [NullAllowed] ASDisplayNodeDidLoadBlock didLoadBlock);

        // -(void)cellNodeVisibilityEvent:(ASCellNodeVisibilityEvent)event inScrollView:(UIScrollView * _Nullable)scrollView withCellFrame:(CGRect)cellFrame;
        [Export("cellNodeVisibilityEvent:inScrollView:withCellFrame:")]
        void CellNodeVisibilityEvent(ASCellNodeVisibilityEvent @event, [NullAllowed] UIScrollView scrollView, CGRect cellFrame);

        // @property (nonatomic) UITableViewCellSelectionStyle selectionStyle;
        [Export("selectionStyle", ArgumentSemantic.Assign)]
        UITableViewCellSelectionStyle SelectionStyle { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable selectedBackgroundView;
        [NullAllowed, Export("selectedBackgroundView", ArgumentSemantic.Strong)]
        UIView SelectedBackgroundView { get; set; }

        //// @property (nonatomic) UITableViewCellAccessoryType accessoryType;
        //[Export ("accessoryType", ArgumentSemantic.Assign)]
        //UITableViewCellAccessoryType AccessoryType { get; set; }

        // @property (nonatomic) UIEdgeInsets separatorInset;
        [Export("separatorInset", ArgumentSemantic.Assign)]
        UIEdgeInsets SeparatorInset { get; set; }
    }

    // audit-objc-generics: @interface ASNodeController<__covariant DisplayNodeType : ASDisplayNode *> : NSObject <ASInterfaceStateDelegate>
    [BaseType(typeof(NSObject))]
    interface ASNodeController : ASInterfaceStateDelegate
    {
        // @property (nonatomic, strong) DisplayNodeType node;
        [Export("node", ArgumentSemantic.Strong)]
        ASDisplayNode Node { get; set; }

        // @property (assign, nonatomic) BOOL shouldInvertStrongReference;
        [Export("shouldInvertStrongReference")]
        bool ShouldInvertStrongReference { get; set; }

        // -(void)loadNode;
        [Export("loadNode")]
        void LoadNode();
    }

    // @interface ASNodeController (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (readonly, nonatomic) ASNodeController * nodeController;
        [Export("nodeController")]
        ASNodeController NodeController { get; }
    }

    // @interface ASLayout : NSObject
    [BaseType(typeof(NSObject))]
    interface ASLayout
    {
        // @property (readonly, nonatomic, weak) id<ASLayoutElement> _Nullable layoutElement;
        [NullAllowed, Export("layoutElement", ArgumentSemantic.Weak)]
        IASLayoutElement LayoutElement { get; }

        // @property (readonly, assign, nonatomic) ASLayoutElementType type;
        [Export("type", ArgumentSemantic.Assign)]
        ASLayoutElementType Type { get; }

        // @property (readonly, assign, nonatomic) CGSize size;
        [Export("size", ArgumentSemantic.Assign)]
        CGSize Size { get; }

        // @property (readonly, assign, nonatomic) CGPoint position;
        [Export("position", ArgumentSemantic.Assign)]
        CGPoint Position { get; }

        // @property (readonly, copy, nonatomic) NSArray<ASLayout *> * _Nonnull sublayouts;
        [Export("sublayouts", ArgumentSemantic.Copy)]
        ASLayout[] Sublayouts { get; }

        // -(CGRect)frameForElement:(id<ASLayoutElement> _Nonnull)layoutElement;
        [Export("frameForElement:")]
        CGRect FrameForElement(IASLayoutElement layoutElement);

        // @property (readonly, assign, nonatomic) CGRect frame;
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; }

        // -(instancetype _Nonnull)initWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size position:(CGPoint)position sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((objc_designated_initializer));
        [Export("initWithLayoutElement:size:position:sublayouts:")]
        [DesignatedInitializer]
        IntPtr Constructor(IASLayoutElement layoutElement, CGSize size, CGPoint position, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size position:(CGPoint)position sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((warn_unused_result));
        [Static]
        [Export("layoutWithLayoutElement:size:position:sublayouts:")]
        ASLayout LayoutWithLayoutElement(IASLayoutElement layoutElement, CGSize size, CGPoint position, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size sublayouts:(NSArray<ASLayout *> * _Nullable)sublayouts __attribute__((warn_unused_result));
        [Static]
        [Export("layoutWithLayoutElement:size:sublayouts:")]
        ASLayout LayoutWithLayoutElement(IASLayoutElement layoutElement, CGSize size, [NullAllowed] ASLayout[] sublayouts);

        // +(instancetype _Nonnull)layoutWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement size:(CGSize)size __attribute__((warn_unused_result));
        [Static]
        [Export("layoutWithLayoutElement:size:")]
        ASLayout LayoutWithLayoutElement(IASLayoutElement layoutElement, CGSize size);

        // -(ASLayout * _Nonnull)filteredNodeLayoutTree __attribute__((warn_unused_result));
        [Export("filteredNodeLayoutTree")]
        ASLayout FilteredNodeLayoutTree { get; }
    }

    // @interface ASLayoutSpec : NSObject <ASLayoutElement, ASLayoutElementStylability, NSFastEnumeration, ASDescriptionProvider>
    [BaseType(typeof(NSObject))]
    interface ASLayoutSpec : ASLayoutElement, ASLayoutElementStylability
    //, INSFastEnumeration, IASDescriptionProvider
    {
        // @property (assign, nonatomic) BOOL isMutable;
        [Export("isMutable")]
        bool IsMutable { get; set; }

        // @property (nonatomic, strong) id<ASLayoutElement> _Nullable child;
        [NullAllowed, Export("child", ArgumentSemantic.Strong)]
        IASLayoutElement Child { get; set; }

        // @property (nonatomic, strong) NSArray<id<ASLayoutElement>> * _Nullable children;
        [NullAllowed, Export("children", ArgumentSemantic.Strong)]
        IASLayoutElement[] Children { get; set; }
    }

    // @interface ASWrapperLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    [DisableDefaultCtor]
    interface ASWrapperLayoutSpec
    {
        // +(instancetype _Nonnull)wrapperWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement __attribute__((warn_unused_result));
        [Static]
        [Export("wrapperWithLayoutElement:")]
        ASWrapperLayoutSpec WrapperWithLayoutElement(IASLayoutElement layoutElement);

        // +(instancetype _Nonnull)wrapperWithLayoutElements:(NSArray<id<ASLayoutElement>> * _Nonnull)layoutElements __attribute__((warn_unused_result));
        [Static]
        [Export("wrapperWithLayoutElements:")]
        ASWrapperLayoutSpec WrapperWithLayoutElements(IASLayoutElement[] layoutElements);

        // -(instancetype _Nonnull)initWithLayoutElement:(id<ASLayoutElement> _Nonnull)layoutElement __attribute__((warn_unused_result));
        [Export("initWithLayoutElement:")]
        IntPtr Constructor(IASLayoutElement layoutElement);

        // -(instancetype _Nonnull)initWithLayoutElements:(NSArray<id<ASLayoutElement>> * _Nonnull)layoutElements __attribute__((warn_unused_result));
        [Export("initWithLayoutElements:")]
        IntPtr Constructor(IASLayoutElement[] layoutElements);
    }

    // @interface ASBackgroundLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASBackgroundLayoutSpec
    {
        // @property (nonatomic, strong) id<ASLayoutElement> _Nonnull background;
        [Export("background", ArgumentSemantic.Strong)]
        IASLayoutElement Background { get; set; }

        // +(instancetype _Nonnull)backgroundLayoutSpecWithChild:(id<ASLayoutElement> _Nonnull)child background:(id<ASLayoutElement> _Nonnull)background __attribute__((warn_unused_result));
        [Static]
        [Export("backgroundLayoutSpecWithChild:background:")]
        ASBackgroundLayoutSpec BackgroundLayoutSpecWithChild(IASLayoutElement child, IASLayoutElement background);
    }

    // @interface ASRelativeLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASRelativeLayoutSpec
    {
        // @property (assign, nonatomic) ASRelativeLayoutSpecPosition horizontalPosition;
        [Export("horizontalPosition", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecPosition HorizontalPosition { get; set; }

        // @property (assign, nonatomic) ASRelativeLayoutSpecPosition verticalPosition;
        [Export("verticalPosition", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecPosition VerticalPosition { get; set; }

        // @property (assign, nonatomic) ASRelativeLayoutSpecSizingOption sizingOption;
        [Export("sizingOption", ArgumentSemantic.Assign)]
        ASRelativeLayoutSpecSizingOption SizingOption { get; set; }

        // +(instancetype _Nonnull)relativePositionLayoutSpecWithHorizontalPosition:(ASRelativeLayoutSpecPosition)horizontalPosition verticalPosition:(ASRelativeLayoutSpecPosition)verticalPosition sizingOption:(ASRelativeLayoutSpecSizingOption)sizingOption child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export("relativePositionLayoutSpecWithHorizontalPosition:verticalPosition:sizingOption:child:")]
        ASRelativeLayoutSpec RelativePositionLayoutSpecWithHorizontalPosition(ASRelativeLayoutSpecPosition horizontalPosition, ASRelativeLayoutSpecPosition verticalPosition, ASRelativeLayoutSpecSizingOption sizingOption, IASLayoutElement child);

        // -(instancetype _Nonnull)initWithHorizontalPosition:(ASRelativeLayoutSpecPosition)horizontalPosition verticalPosition:(ASRelativeLayoutSpecPosition)verticalPosition sizingOption:(ASRelativeLayoutSpecSizingOption)sizingOption child:(id<ASLayoutElement> _Nonnull)child;
        [Export("initWithHorizontalPosition:verticalPosition:sizingOption:child:")]
        IntPtr Constructor(ASRelativeLayoutSpecPosition horizontalPosition, ASRelativeLayoutSpecPosition verticalPosition, ASRelativeLayoutSpecSizingOption sizingOption, IASLayoutElement child);
    }

    // @interface ASCenterLayoutSpec : ASRelativeLayoutSpec
    [BaseType(typeof(ASRelativeLayoutSpec))]
    interface ASCenterLayoutSpec
    {
        // @property (assign, nonatomic) ASCenterLayoutSpecCenteringOptions centeringOptions;
        [Export("centeringOptions", ArgumentSemantic.Assign)]
        ASCenterLayoutSpecCenteringOptions CenteringOptions { get; set; }

        // @property (assign, nonatomic) ASCenterLayoutSpecSizingOptions sizingOptions;
        [Export("sizingOptions", ArgumentSemantic.Assign)]
        ASCenterLayoutSpecSizingOptions SizingOptions { get; set; }

        // +(instancetype _Nonnull)centerLayoutSpecWithCenteringOptions:(ASCenterLayoutSpecCenteringOptions)centeringOptions sizingOptions:(ASCenterLayoutSpecSizingOptions)sizingOptions child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export("centerLayoutSpecWithCenteringOptions:sizingOptions:child:")]
        ASCenterLayoutSpec CenterLayoutSpecWithCenteringOptions(ASCenterLayoutSpecCenteringOptions centeringOptions, ASCenterLayoutSpecSizingOptions sizingOptions, IASLayoutElement child);
    }

    // @interface ASInsetLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASInsetLayoutSpec
    {
        // @property (assign, nonatomic) UIEdgeInsets insets;
        [Export("insets", ArgumentSemantic.Assign)]
        UIEdgeInsets Insets { get; set; }

        // +(instancetype _Nonnull)insetLayoutSpecWithInsets:(UIEdgeInsets)insets child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export("insetLayoutSpecWithInsets:child:")]
        ASInsetLayoutSpec InsetLayoutSpecWithInsets(UIEdgeInsets insets, IASLayoutElement child);
    }

    interface IASInsetLayoutSpec { }

    // @interface ASOverlayLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASOverlayLayoutSpec
    {
        // @property (nonatomic, strong) id<ASLayoutElement> _Nonnull overlay;
        [Export("overlay", ArgumentSemantic.Strong)]
        IASLayoutElement Overlay { get; set; }

        // +(instancetype _Nonnull)overlayLayoutSpecWithChild:(id<ASLayoutElement> _Nonnull)child overlay:(id<ASLayoutElement> _Nonnull)overlay __attribute__((warn_unused_result));
        [Static]
        [Export("overlayLayoutSpecWithChild:overlay:")]
        ASOverlayLayoutSpec OverlayLayoutSpecWithChild(IASLayoutElement child, IASLayoutElement overlay);
    }

    // @interface ASRatioLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASRatioLayoutSpec
    {
        // @property (assign, nonatomic) CGFloat ratio;
        [Export("ratio")]
        nfloat Ratio { get; set; }

        // +(instancetype _Nonnull)ratioLayoutSpecWithRatio:(CGFloat)ratio child:(id<ASLayoutElement> _Nonnull)child __attribute__((warn_unused_result));
        [Static]
        [Export("ratioLayoutSpecWithRatio:child:")]
        ASRatioLayoutSpec RatioLayoutSpecWithRatio(nfloat ratio, IASLayoutElement child);
    }

    // @interface ASAbsoluteLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASAbsoluteLayoutSpec
    {
        // @property (assign, nonatomic) ASAbsoluteLayoutSpecSizing sizing;
        [Export("sizing", ArgumentSemantic.Assign)]
        ASAbsoluteLayoutSpecSizing Sizing { get; set; }

        // +(instancetype _Nonnull)absoluteLayoutSpecWithSizing:(ASAbsoluteLayoutSpecSizing)sizing children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export("absoluteLayoutSpecWithSizing:children:")]
        ASAbsoluteLayoutSpec AbsoluteLayoutSpecWithSizing(ASAbsoluteLayoutSpecSizing sizing, IASLayoutElement[] children);

        // +(instancetype _Nonnull)absoluteLayoutSpecWithChildren:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export("absoluteLayoutSpecWithChildren:")]
        ASAbsoluteLayoutSpec AbsoluteLayoutSpecWithChildren(IASLayoutElement[] children);
    }

    // @interface ASStackLayoutSpec : ASLayoutSpec
    [BaseType(typeof(ASLayoutSpec))]
    interface ASStackLayoutSpec
    {
        // @property (assign, nonatomic) ASStackLayoutDirection direction;
        [Export("direction", ArgumentSemantic.Assign)]
        ASStackLayoutDirection Direction { get; set; }

        // @property (assign, nonatomic) CGFloat spacing;
        [Export("spacing")]
        nfloat Spacing { get; set; }

        // @property (assign, nonatomic) ASHorizontalAlignment horizontalAlignment;
        [Export("horizontalAlignment", ArgumentSemantic.Assign)]
        ASHorizontalAlignment HorizontalAlignment { get; set; }

        // @property (assign, nonatomic) ASVerticalAlignment verticalAlignment;
        [Export("verticalAlignment", ArgumentSemantic.Assign)]
        ASVerticalAlignment VerticalAlignment { get; set; }

        // @property (assign, nonatomic) ASStackLayoutJustifyContent justifyContent;
        [Export("justifyContent", ArgumentSemantic.Assign)]
        ASStackLayoutJustifyContent JustifyContent { get; set; }

        // @property (assign, nonatomic) ASStackLayoutAlignItems alignItems;
        [Export("alignItems", ArgumentSemantic.Assign)]
        ASStackLayoutAlignItems AlignItems { get; set; }

        // @property (assign, nonatomic) ASStackLayoutFlexWrap flexWrap;
        [Export("flexWrap", ArgumentSemantic.Assign)]
        ASStackLayoutFlexWrap FlexWrap { get; set; }

        // @property (assign, nonatomic) ASStackLayoutAlignContent alignContent;
        [Export("alignContent", ArgumentSemantic.Assign)]
        ASStackLayoutAlignContent AlignContent { get; set; }

        // @property (assign, nonatomic) CGFloat lineSpacing;
        [Export("lineSpacing")]
        nfloat LineSpacing { get; set; }

        // @property (getter = isConcurrent, assign, nonatomic) BOOL concurrent;
        [Export("concurrent")]
        bool Concurrent { [Bind("isConcurrent")] get; set; }

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection(ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, IASLayoutElement[] children);

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems flexWrap:(ASStackLayoutFlexWrap)flexWrap alignContent:(ASStackLayoutAlignContent)alignContent children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:flexWrap:alignContent:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection(ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, ASStackLayoutFlexWrap flexWrap, ASStackLayoutAlignContent alignContent, IASLayoutElement[] children);

        // +(instancetype _Nonnull)stackLayoutSpecWithDirection:(ASStackLayoutDirection)direction spacing:(CGFloat)spacing justifyContent:(ASStackLayoutJustifyContent)justifyContent alignItems:(ASStackLayoutAlignItems)alignItems flexWrap:(ASStackLayoutFlexWrap)flexWrap alignContent:(ASStackLayoutAlignContent)alignContent lineSpacing:(CGFloat)lineSpacing children:(NSArray<id<ASLayoutElement>> * _Nonnull)children __attribute__((warn_unused_result));
        [Static]
        [Export("stackLayoutSpecWithDirection:spacing:justifyContent:alignItems:flexWrap:alignContent:lineSpacing:children:")]
        ASStackLayoutSpec StackLayoutSpecWithDirection(ASStackLayoutDirection direction, nfloat spacing, ASStackLayoutJustifyContent justifyContent, ASStackLayoutAlignItems alignItems, ASStackLayoutFlexWrap flexWrap, ASStackLayoutAlignContent alignContent, nfloat lineSpacing, IASLayoutElement[] children);

        // +(instancetype _Nonnull)verticalStackLayoutSpec __attribute__((warn_unused_result));
        [Static]
        [Export("verticalStackLayoutSpec")]
        ASStackLayoutSpec VerticalStackLayoutSpec();

        // +(instancetype _Nonnull)horizontalStackLayoutSpec __attribute__((warn_unused_result));
        [Static]
        [Export("horizontalStackLayoutSpec")]
        ASStackLayoutSpec HorizontalStackLayoutSpec();
    }

    // typedef void (^asyncdisplaykit_async_transaction_completion_block_t)(_ASAsyncTransaction * _Nonnull, BOOL);
    delegate void asyncdisplaykit_async_transaction_completion_block_t(_ASAsyncTransaction arg0, bool arg1);

    // typedef id<NSObject> _Nullable (^asyncdisplaykit_async_transaction_operation_block_t)();
    delegate NSObject asyncdisplaykit_async_transaction_operation_block_t();

    // typedef void (^asyncdisplaykit_async_transaction_operation_completion_block_t)(id _Nullable, BOOL);
    delegate void asyncdisplaykit_async_transaction_operation_completion_block_t([NullAllowed] NSObject arg0, bool arg1);

    // typedef void (^asyncdisplaykit_async_transaction_complete_async_operation_block_t)(id _Nullable);
    delegate void asyncdisplaykit_async_transaction_complete_async_operation_block_t([NullAllowed] NSObject arg0);

    // typedef void (^asyncdisplaykit_async_transaction_async_operation_block_t)(asyncdisplaykit_async_transaction_complete_async_operation_block_t _Nonnull);
    delegate void asyncdisplaykit_async_transaction_async_operation_block_t(asyncdisplaykit_async_transaction_complete_async_operation_block_t arg0);

    // @interface _ASAsyncTransaction : NSObject
    [BaseType(typeof(NSObject))]
    interface _ASAsyncTransaction
    {
        // -(instancetype _Nonnull)initWithCompletionBlock:(asyncdisplaykit_async_transaction_completion_block_t _Nullable)completionBlock;
        [Export("initWithCompletionBlock:")]
        IntPtr Constructor([NullAllowed] asyncdisplaykit_async_transaction_completion_block_t completionBlock);

        // -(void)waitUntilComplete;
        [Export("waitUntilComplete")]
        void WaitUntilComplete();

        // @property (readonly, copy, nonatomic) asyncdisplaykit_async_transaction_completion_block_t _Nullable completionBlock;
        [NullAllowed, Export("completionBlock", ArgumentSemantic.Copy)]
        asyncdisplaykit_async_transaction_completion_block_t CompletionBlock { get; }

        // @property (readonly, assign) ASAsyncTransactionState state;
        [Export("state", ArgumentSemantic.Assign)]
        ASAsyncTransactionState State { get; }

        // -(void)addOperationWithBlock:(asyncdisplaykit_async_transaction_operation_block_t _Nonnull)block queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export("addOperationWithBlock:queue:completion:")]
        void AddOperationWithBlock(asyncdisplaykit_async_transaction_operation_block_t block, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addOperationWithBlock:(asyncdisplaykit_async_transaction_operation_block_t _Nonnull)block priority:(NSInteger)priority queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export("addOperationWithBlock:priority:queue:completion:")]
        void AddOperationWithBlock(asyncdisplaykit_async_transaction_operation_block_t block, nint priority, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addAsyncOperationWithBlock:(asyncdisplaykit_async_transaction_async_operation_block_t _Nonnull)block queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export("addAsyncOperationWithBlock:queue:completion:")]
        void AddAsyncOperationWithBlock(asyncdisplaykit_async_transaction_async_operation_block_t block, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addAsyncOperationWithBlock:(asyncdisplaykit_async_transaction_async_operation_block_t _Nonnull)block priority:(NSInteger)priority queue:(dispatch_queue_t _Nonnull)queue completion:(asyncdisplaykit_async_transaction_operation_completion_block_t _Nullable)completion;
        [Export("addAsyncOperationWithBlock:priority:queue:completion:")]
        void AddAsyncOperationWithBlock(asyncdisplaykit_async_transaction_async_operation_block_t block, nint priority, DispatchQueue queue, [NullAllowed] asyncdisplaykit_async_transaction_operation_completion_block_t completion);

        // -(void)addCompletionBlock:(asyncdisplaykit_async_transaction_completion_block_t _Nonnull)completion;
        [Export("addCompletionBlock:")]
        void AddCompletionBlock(asyncdisplaykit_async_transaction_completion_block_t completion);

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // -(void)commit;
        [Export("commit")]
        void Commit();
    }

    // @interface _ASDisplayLayer : CALayer
    [BaseType(typeof(CALayer))]
    interface _ASDisplayLayer
    {
        // @property (nonatomic, weak) ASDisplayNode * asyncdisplaykit_node;
        [Export("asyncdisplaykit_node", ArgumentSemantic.Weak)]
        ASDisplayNode Asyncdisplaykit_node { get; set; }

        // @property (assign, nonatomic) BOOL displaysAsynchronously;
        [Export("displaysAsynchronously")]
        bool DisplaysAsynchronously { get; set; }

        // -(void)cancelAsyncDisplay;
        [Export("cancelAsyncDisplay")]
        void CancelAsyncDisplay();

        // +(dispatch_queue_t)displayQueue;
        [Static]
        [Export("displayQueue")]
        //[Verify (MethodToProperty)]
        DispatchQueue DisplayQueue { get; }

        //[Wrap ("WeakAsyncDelegate")]
        //_ASDisplayLayerDelegate AsyncDelegate { get; set; }

        // @property (atomic, weak) id<_ASDisplayLayerDelegate> asyncDelegate;
        [NullAllowed, Export("asyncDelegate", ArgumentSemantic.Weak)]
        NSObject WeakAsyncDelegate { get; set; }

        // @property (getter = isDisplaySuspended, assign, nonatomic) BOOL displaySuspended;
        [Export("displaySuspended")]
        bool DisplaySuspended { [Bind("isDisplaySuspended")] get; set; }

        // -(void)displayImmediately;
        [Export("displayImmediately")]
        void DisplayImmediately();
    }

    // @protocol ASContextTransitioning <NSObject>
    [Protocol, Model, BaseType(typeof(NSObject))]
    interface ASContextTransitioning
    {
        // @required -(BOOL)isAnimated;
        [Abstract]
        [Export("isAnimated")]
        //[Verify (MethodToProperty)]
        bool IsAnimated { get; }

        // @required -(ASLayout * _Nullable)layoutForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export("layoutForKey:")]
        [return: NullAllowed]
        ASLayout LayoutForKey(string key);

        // @required -(ASSizeRange)constrainedSizeForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export("constrainedSizeForKey:")]
        ASSizeRange ConstrainedSizeForKey(string key);

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)subnodesForKey:(NSString * _Nonnull)key;
        [Abstract]
        [Export("subnodesForKey:")]
        ASDisplayNode[] SubnodesForKey(string key);

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)insertedSubnodes;
        [Abstract]
        [Export("insertedSubnodes")]
        //[Verify (MethodToProperty)]
        ASDisplayNode[] InsertedSubnodes { get; }

        // @required -(NSArray<ASDisplayNode *> * _Nonnull)removedSubnodes;
        [Abstract]
        [Export("removedSubnodes")]
        //[Verify (MethodToProperty)]
        ASDisplayNode[] RemovedSubnodes { get; }

        // @required -(CGRect)initialFrameForNode:(ASDisplayNode * _Nonnull)node;
        [Abstract]
        [Export("initialFrameForNode:")]
        CGRect InitialFrameForNode(ASDisplayNode node);

        // @required -(CGRect)finalFrameForNode:(ASDisplayNode * _Nonnull)node;
        [Abstract]
        [Export("finalFrameForNode:")]
        CGRect FinalFrameForNode(ASDisplayNode node);

        // @required -(void)completeTransition:(BOOL)didComplete;
        [Abstract]
        [Export("completeTransition:")]
        void CompleteTransition(bool didComplete);
    }

    //// @interface Subclassing (ASControlNode)
    //[Category]
    //[BaseType (typeof(ASControlNode))]
    partial interface ASControlNode
    {
        //// -(void)sendActionsForControlEvents:(ASControlNodeEvent)controlEvents withEvent:(UIEvent * _Nullable)touchEvent;
        //[Export ("sendActionsForControlEvents:withEvent:")]
        //void SendActionsForControlEvents (ASControlNodeEvent controlEvents, [NullAllowed] UIEvent touchEvent);

        // -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export("beginTrackingWithTouch:withEvent:")]
        bool BeginTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent touchEvent);

        // -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export("continueTrackingWithTouch:withEvent:")]
        bool ContinueTrackingWithTouch(UITouch touch, [NullAllowed] UIEvent touchEvent);

        // -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)touchEvent;
        [Export("cancelTrackingWithEvent:")]
        void CancelTrackingWithEvent([NullAllowed] UIEvent touchEvent);

        // -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)touchEvent;
        [Export("endTrackingWithTouch:withEvent:")]
        void EndTrackingWithTouch([NullAllowed] UITouch touch, [NullAllowed] UIEvent touchEvent);
    }

    // typedef void (^ASTipDisplayBlock)(ASDisplayNode * _Nonnull, NSString * _Nonnull);
    delegate void ASTipDisplayBlock(ASDisplayNode arg0, string arg1);

    // @interface Tips (ASDisplayNode)
    //[Category]
    //[BaseType (typeof(ASDisplayNode))]
    partial interface ASDisplayNode
    {
        // @property (class) BOOL enableTips;
        [Static]
        [Export("enableTips")]
        bool EnableTips { get; set; }

        // @property (copy, nonatomic, class) ASTipDisplayBlock _Null_unspecified tipDisplayBlock;
        [Static]
        [Export("tipDisplayBlock", ArgumentSemantic.Copy)]
        ASTipDisplayBlock TipDisplayBlock { get; set; }
    }
}
