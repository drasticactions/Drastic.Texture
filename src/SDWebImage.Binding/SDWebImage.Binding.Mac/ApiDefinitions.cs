using System;
using AppKit;
using CoreAnimation;
using CoreFoundation;
using CoreGraphics;
using CoreImage;
using Foundation;
using ImageIO;
using ObjCRuntime;
using SDWebImage;

namespace Drastic.SDWebImage
{
	// @protocol SDWebImageOperation <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageOperation
	{
		// @required -(void)cancel;
		[Abstract]
		[Export ("cancel")]
		void Cancel ();

		// @optional @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }
	}

	// @interface SDWebImageOperation (NSOperation) <SDWebImageOperation>
	[Category]
	[BaseType (typeof(NSOperation))]
	interface NSOperation_SDWebImageOperation : ISDWebImageOperation
	{
	}

	// typedef void (^SDWebImageNoParamsBlock)();
	delegate void SDWebImageNoParamsBlock ();

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextSetImageOperationKey;
		[Field ("SDWebImageContextSetImageOperationKey")]
		NSString SDWebImageContextSetImageOperationKey { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextCustomManager __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use individual context option like .imageCache, .imageLoader and .imageTransformer instead")]
		[Field ("SDWebImageContextCustomManager")]
		NSString SDWebImageContextCustomManager { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageCache;
		[Field ("SDWebImageContextImageCache")]
		NSString SDWebImageContextImageCache { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageLoader;
		[Field ("SDWebImageContextImageLoader")]
		NSString SDWebImageContextImageLoader { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageCoder;
		[Field ("SDWebImageContextImageCoder")]
		NSString SDWebImageContextImageCoder { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageTransformer;
		[Field ("SDWebImageContextImageTransformer")]
		NSString SDWebImageContextImageTransformer { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageDecodeOptions;
		[Field ("SDWebImageContextImageDecodeOptions")]
		NSString SDWebImageContextImageDecodeOptions { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageScaleFactor;
		[Field ("SDWebImageContextImageScaleFactor")]
		NSString SDWebImageContextImageScaleFactor { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImagePreserveAspectRatio;
		[Field ("SDWebImageContextImagePreserveAspectRatio")]
		NSString SDWebImageContextImagePreserveAspectRatio { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageThumbnailPixelSize;
		[Field ("SDWebImageContextImageThumbnailPixelSize")]
		NSString SDWebImageContextImageThumbnailPixelSize { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextImageTypeIdentifierHint;
		[Field ("SDWebImageContextImageTypeIdentifierHint")]
		NSString SDWebImageContextImageTypeIdentifierHint { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextQueryCacheType;
		[Field ("SDWebImageContextQueryCacheType")]
		NSString SDWebImageContextQueryCacheType { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextStoreCacheType;
		[Field ("SDWebImageContextStoreCacheType")]
		NSString SDWebImageContextStoreCacheType { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextOriginalQueryCacheType;
		[Field ("SDWebImageContextOriginalQueryCacheType")]
		NSString SDWebImageContextOriginalQueryCacheType { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextOriginalStoreCacheType;
		[Field ("SDWebImageContextOriginalStoreCacheType")]
		NSString SDWebImageContextOriginalStoreCacheType { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextOriginalImageCache;
		[Field ("SDWebImageContextOriginalImageCache")]
		NSString SDWebImageContextOriginalImageCache { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextAnimatedImageClass;
		[Field ("SDWebImageContextAnimatedImageClass")]
		NSString SDWebImageContextAnimatedImageClass { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextDownloadRequestModifier;
		[Field ("SDWebImageContextDownloadRequestModifier")]
		NSString SDWebImageContextDownloadRequestModifier { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextDownloadResponseModifier;
		[Field ("SDWebImageContextDownloadResponseModifier")]
		NSString SDWebImageContextDownloadResponseModifier { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextDownloadDecryptor;
		[Field ("SDWebImageContextDownloadDecryptor")]
		NSString SDWebImageContextDownloadDecryptor { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextCacheKeyFilter;
		[Field ("SDWebImageContextCacheKeyFilter")]
		NSString SDWebImageContextCacheKeyFilter { get; }

		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextCacheSerializer;
		[Field ("SDWebImageContextCacheSerializer")]
		NSString SDWebImageContextCacheSerializer { get; }
	}

	// @interface ImageContentType (NSData)
	[Category]
	[BaseType (typeof(NSData))]
	interface NSData_ImageContentType
	{
		// +(SDImageFormat)sd_imageFormatForImageData:(NSData * _Nullable)data;
		[Static]
		[Export ("sd_imageFormatForImageData:")]
		nint Sd_imageFormatForImageData ([NullAllowed] NSData data);

		// +(CFStringRef _Nonnull)sd_UTTypeFromImageFormat:(SDImageFormat)format __attribute__((cf_returns_not_retained)) __attribute__((swift_name("sd_UTType(from:)")));
		[Static]
		[Export ("sd_UTTypeFromImageFormat:")]
		unsafe CFStringRef* Sd_UTTypeFromImageFormat (nint format);

		// +(SDImageFormat)sd_imageFormatFromUTType:(CFStringRef _Nonnull)uttype;
		[Static]
		[Export ("sd_imageFormatFromUTType:")]
		unsafe nint Sd_imageFormatFromUTType (CFStringRef* uttype);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeFirstFrameOnly;
		[Field ("SDImageCoderDecodeFirstFrameOnly")]
		NSString SDImageCoderDecodeFirstFrameOnly { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeScaleFactor;
		[Field ("SDImageCoderDecodeScaleFactor")]
		NSString SDImageCoderDecodeScaleFactor { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodePreserveAspectRatio;
		[Field ("SDImageCoderDecodePreserveAspectRatio")]
		NSString SDImageCoderDecodePreserveAspectRatio { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeThumbnailPixelSize;
		[Field ("SDImageCoderDecodeThumbnailPixelSize")]
		NSString SDImageCoderDecodeThumbnailPixelSize { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeFileExtensionHint;
		[Field ("SDImageCoderDecodeFileExtensionHint")]
		NSString SDImageCoderDecodeFileExtensionHint { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeTypeIdentifierHint;
		[Field ("SDImageCoderDecodeTypeIdentifierHint")]
		NSString SDImageCoderDecodeTypeIdentifierHint { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderDecodeUseLazyDecoding;
		[Field ("SDImageCoderDecodeUseLazyDecoding")]
		NSString SDImageCoderDecodeUseLazyDecoding { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeFirstFrameOnly;
		[Field ("SDImageCoderEncodeFirstFrameOnly")]
		NSString SDImageCoderEncodeFirstFrameOnly { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeCompressionQuality;
		[Field ("SDImageCoderEncodeCompressionQuality")]
		NSString SDImageCoderEncodeCompressionQuality { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeBackgroundColor;
		[Field ("SDImageCoderEncodeBackgroundColor")]
		NSString SDImageCoderEncodeBackgroundColor { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeMaxPixelSize;
		[Field ("SDImageCoderEncodeMaxPixelSize")]
		NSString SDImageCoderEncodeMaxPixelSize { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeMaxFileSize;
		[Field ("SDImageCoderEncodeMaxFileSize")]
		NSString SDImageCoderEncodeMaxFileSize { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderEncodeEmbedThumbnail;
		[Field ("SDImageCoderEncodeEmbedThumbnail")]
		NSString SDImageCoderEncodeEmbedThumbnail { get; }

		// extern SDImageCoderOption  _Nonnull const SDImageCoderWebImageContext __attribute__((availability(macos, introduced=10.10, deprecated=10.10))) __attribute__((availability(ios, introduced=8.0, deprecated=8.0))) __attribute__((availability(tvos, introduced=9.0, deprecated=9.0))) __attribute__((availability(watchos, introduced=2.0, deprecated=2.0)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Introduced (PlatformName.iOS, 8, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Deprecated (PlatformName.WatchOS, 2, 0, message: "No longer supported. Use SDWebImageContextDecodeOptions in loader API to provide options. Use SDImageCoderOptions in coder API to retrieve options.")]
		[Field ("SDImageCoderWebImageContext")]
		NSString SDImageCoderWebImageContext { get; }
	}

	// @protocol SDImageCoder <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDImageCoder
	{
		// @required -(BOOL)canDecodeFromData:(NSData * _Nullable)data;
		[Abstract]
		[Export ("canDecodeFromData:")]
		bool CanDecodeFromData ([NullAllowed] NSData data);

		// @required -(NSImage * _Nullable)decodedImageWithData:(NSData * _Nullable)data options:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("decodedImageWithData:options:")]
		[return: NullAllowed]
		NSImage DecodedImageWithData ([NullAllowed] NSData data, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// @required -(BOOL)canEncodeToFormat:(SDImageFormat)format __attribute__((swift_name("canEncode(to:)")));
		[Abstract]
		[Export ("canEncodeToFormat:")]
		bool CanEncodeToFormat (nint format);

		// @required -(NSData * _Nullable)encodedDataWithImage:(NSImage * _Nullable)image format:(SDImageFormat)format options:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("encodedDataWithImage:format:options:")]
		[return: NullAllowed]
		NSData EncodedDataWithImage ([NullAllowed] NSImage image, nint format, [NullAllowed] NSDictionary<NSString, NSObject> options);
	}

	// @protocol SDProgressiveImageCoder <SDImageCoder>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SDProgressiveImageCoder : ISDImageCoder
	{
		// @required -(BOOL)canIncrementalDecodeFromData:(NSData * _Nullable)data;
		[Abstract]
		[Export ("canIncrementalDecodeFromData:")]
		bool CanIncrementalDecodeFromData ([NullAllowed] NSData data);

		// @required -(instancetype _Nonnull)initIncrementalWithOptions:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("initIncrementalWithOptions:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSObject> options);

		// @required -(void)updateIncrementalData:(NSData * _Nullable)data finished:(BOOL)finished;
		[Abstract]
		[Export ("updateIncrementalData:finished:")]
		void UpdateIncrementalData ([NullAllowed] NSData data, bool finished);

		// @required -(NSImage * _Nullable)incrementalDecodedImageWithOptions:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("incrementalDecodedImageWithOptions:")]
		[return: NullAllowed]
		NSImage IncrementalDecodedImageWithOptions ([NullAllowed] NSDictionary<NSString, NSObject> options);
	}

	// @protocol SDAnimatedImageProvider <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDAnimatedImageProvider
	{
		// @required @property (readonly, copy, nonatomic) NSData * _Nullable animatedImageData;
		[Abstract]
		[NullAllowed, Export ("animatedImageData", ArgumentSemantic.Copy)]
		NSData AnimatedImageData { get; }

		// @required @property (readonly, assign, nonatomic) NSUInteger animatedImageFrameCount;
		[Abstract]
		[Export ("animatedImageFrameCount")]
		nuint AnimatedImageFrameCount { get; }

		// @required @property (readonly, assign, nonatomic) NSUInteger animatedImageLoopCount;
		[Abstract]
		[Export ("animatedImageLoopCount")]
		nuint AnimatedImageLoopCount { get; }

		// @required -(NSImage * _Nullable)animatedImageFrameAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("animatedImageFrameAtIndex:")]
		[return: NullAllowed]
		NSImage AnimatedImageFrameAtIndex (nuint index);

		// @required -(NSTimeInterval)animatedImageDurationAtIndex:(NSUInteger)index;
		[Abstract]
		[Export ("animatedImageDurationAtIndex:")]
		double AnimatedImageDurationAtIndex (nuint index);
	}

	// @protocol SDAnimatedImageCoder <SDImageCoder, SDAnimatedImageProvider>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SDAnimatedImageCoder : ISDImageCoder, ISDAnimatedImageProvider
	{
		// @required -(instancetype _Nullable)initWithAnimatedImageData:(NSData * _Nullable)data options:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("initWithAnimatedImageData:options:")]
		NativeHandle Options ([NullAllowed] NSData data, [NullAllowed] NSDictionary<NSString, NSObject> options);
	}

	// typedef void (^SDImageCacheCheckCompletionBlock)(BOOL);
	delegate void SDImageCacheCheckCompletionBlock (bool arg0);

	// typedef void (^SDImageCacheQueryDataCompletionBlock)(NSData * _Nullable);
	delegate void SDImageCacheQueryDataCompletionBlock ([NullAllowed] NSData arg0);

	// typedef void (^SDImageCacheCalculateSizeBlock)(NSUInteger, NSUInteger);
	delegate void SDImageCacheCalculateSizeBlock (nuint arg0, nuint arg1);

	// typedef NSString * _Nullable (^SDImageCacheAdditionalCachePathBlock)(NSString * _Nonnull);
	delegate string SDImageCacheAdditionalCachePathBlock (string arg0);

	// typedef void (^SDImageCacheQueryCompletionBlock)(NSImage * _Nullable, NSData * _Nullable, SDImageCacheType);
	delegate void SDImageCacheQueryCompletionBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSData arg1, SDImageCacheType arg2);

	// typedef void (^SDImageCacheContainsCompletionBlock)(SDImageCacheType);
	delegate void SDImageCacheContainsCompletionBlock (SDImageCacheType arg0);

	// @protocol SDImageCache <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDImageCache
	{
		// @required -(id<SDWebImageOperation> _Nullable)queryImageForKey:(NSString * _Nullable)key options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context completion:(SDImageCacheQueryCompletionBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("queryImageForKey:options:context:completion:")]
		[return: NullAllowed]
		SDWebImageOperation QueryImageForKey ([NullAllowed] string key, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageCacheQueryCompletionBlock completionBlock);

		// @required -(id<SDWebImageOperation> _Nullable)queryImageForKey:(NSString * _Nullable)key options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context cacheType:(SDImageCacheType)cacheType completion:(SDImageCacheQueryCompletionBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("queryImageForKey:options:context:cacheType:completion:")]
		[return: NullAllowed]
		SDWebImageOperation QueryImageForKey ([NullAllowed] string key, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, SDImageCacheType cacheType, [NullAllowed] SDImageCacheQueryCompletionBlock completionBlock);

		// @required -(void)storeImage:(NSImage * _Nullable)image imageData:(NSData * _Nullable)imageData forKey:(NSString * _Nullable)key cacheType:(SDImageCacheType)cacheType completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("storeImage:imageData:forKey:cacheType:completion:")]
		void StoreImage ([NullAllowed] NSImage image, [NullAllowed] NSData imageData, [NullAllowed] string key, SDImageCacheType cacheType, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// @required -(void)removeImageForKey:(NSString * _Nullable)key cacheType:(SDImageCacheType)cacheType completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("removeImageForKey:cacheType:completion:")]
		void RemoveImageForKey ([NullAllowed] string key, SDImageCacheType cacheType, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// @required -(void)containsImageForKey:(NSString * _Nullable)key cacheType:(SDImageCacheType)cacheType completion:(SDImageCacheContainsCompletionBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("containsImageForKey:cacheType:completion:")]
		void ContainsImageForKey ([NullAllowed] string key, SDImageCacheType cacheType, [NullAllowed] SDImageCacheContainsCompletionBlock completionBlock);

		// @required -(void)clearWithCacheType:(SDImageCacheType)cacheType completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Abstract]
		[Export ("clearWithCacheType:completion:")]
		void ClearWithCacheType (SDImageCacheType cacheType, [NullAllowed] SDWebImageNoParamsBlock completionBlock);
	}

	// typedef void (^SDImageLoaderProgressBlock)(NSInteger, NSInteger, NSURL * _Nullable);
	delegate void SDImageLoaderProgressBlock (nint arg0, nint arg1, [NullAllowed] NSUrl arg2);

	// typedef void (^SDImageLoaderCompletedBlock)(NSImage * _Nullable, NSData * _Nullable, NSError * _Nullable, BOOL);
	delegate void SDImageLoaderCompletedBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSData arg1, [NullAllowed] NSError arg2, bool arg3);

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern SDWebImageContextOption  _Nonnull const SDWebImageContextLoaderCachedImage;
		[Field ("SDWebImageContextLoaderCachedImage")]
		NSString SDWebImageContextLoaderCachedImage { get; }
	}

	// @protocol SDImageLoader <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDImageLoader
	{
		// @required -(BOOL)canRequestImageForURL:(NSURL * _Nullable)url __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use canRequestImageForURL:options:context: instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use canRequestImageForURL:options:context: instead")]
		[Abstract]
		[Export ("canRequestImageForURL:")]
		bool CanRequestImageForURL ([NullAllowed] NSUrl url);

		// @optional -(BOOL)canRequestImageForURL:(NSURL * _Nullable)url options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("canRequestImageForURL:options:context:")]
		bool CanRequestImageForURL ([NullAllowed] NSUrl url, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// @required -(id<SDWebImageOperation> _Nullable)requestImageWithURL:(NSURL * _Nullable)url options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDImageLoaderCompletedBlock _Nullable)completedBlock;
		[Abstract]
		[Export ("requestImageWithURL:options:context:progress:completed:")]
		[return: NullAllowed]
		SDWebImageOperation RequestImageWithURL ([NullAllowed] NSUrl url, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// @required -(BOOL)shouldBlockFailedURLWithURL:(NSURL * _Nonnull)url error:(NSError * _Nonnull)error __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Introduced (PlatformName.iOS, 8, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "Use shouldBlockFailedURLWithURL:error:options:context: instead")]
		[Abstract]
		[Export ("shouldBlockFailedURLWithURL:error:")]
		bool ShouldBlockFailedURLWithURL (NSUrl url, NSError error);

		// @optional -(BOOL)shouldBlockFailedURLWithURL:(NSURL * _Nonnull)url error:(NSError * _Nonnull)error options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("shouldBlockFailedURLWithURL:error:options:context:")]
		bool ShouldBlockFailedURLWithURL (NSUrl url, NSError error, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);
	}

	// @interface Transform (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_Transform
	{
		// -(NSImage * _Nullable)sd_resizedImageWithSize:(CGSize)size scaleMode:(SDImageScaleMode)scaleMode;
		[Export ("sd_resizedImageWithSize:scaleMode:")]
		[return: NullAllowed]
		NSImage Sd_resizedImageWithSize (CGSize size, SDImageScaleMode scaleMode);

		// -(NSImage * _Nullable)sd_croppedImageWithRect:(CGRect)rect;
		[Export ("sd_croppedImageWithRect:")]
		[return: NullAllowed]
		NSImage Sd_croppedImageWithRect (CGRect rect);

		// -(NSImage * _Nullable)sd_roundedCornerImageWithRadius:(CGFloat)cornerRadius corners:(SDRectCorner)corners borderWidth:(CGFloat)borderWidth borderColor:(NSColor * _Nullable)borderColor;
		[Export ("sd_roundedCornerImageWithRadius:corners:borderWidth:borderColor:")]
		[return: NullAllowed]
		NSImage Sd_roundedCornerImageWithRadius (nfloat cornerRadius, SDRectCorner corners, nfloat borderWidth, [NullAllowed] NSColor borderColor);

		// -(NSImage * _Nullable)sd_rotatedImageWithAngle:(CGFloat)angle fitSize:(BOOL)fitSize;
		[Export ("sd_rotatedImageWithAngle:fitSize:")]
		[return: NullAllowed]
		NSImage Sd_rotatedImageWithAngle (nfloat angle, bool fitSize);

		// -(NSImage * _Nullable)sd_flippedImageWithHorizontal:(BOOL)horizontal vertical:(BOOL)vertical;
		[Export ("sd_flippedImageWithHorizontal:vertical:")]
		[return: NullAllowed]
		NSImage Sd_flippedImageWithHorizontal (bool horizontal, bool vertical);

		// -(NSImage * _Nullable)sd_tintedImageWithColor:(NSColor * _Nonnull)tintColor;
		[Export ("sd_tintedImageWithColor:")]
		[return: NullAllowed]
		NSImage Sd_tintedImageWithColor (NSColor tintColor);

		// -(NSColor * _Nullable)sd_colorAtPoint:(CGPoint)point;
		[Export ("sd_colorAtPoint:")]
		[return: NullAllowed]
		NSColor Sd_colorAtPoint (CGPoint point);

		// -(NSArray<NSColor *> * _Nullable)sd_colorsWithRect:(CGRect)rect;
		[Export ("sd_colorsWithRect:")]
		[return: NullAllowed]
		NSColor[] Sd_colorsWithRect (CGRect rect);

		// -(NSImage * _Nullable)sd_blurredImageWithRadius:(CGFloat)blurRadius;
		[Export ("sd_blurredImageWithRadius:")]
		[return: NullAllowed]
		NSImage Sd_blurredImageWithRadius (nfloat blurRadius);

		// -(NSImage * _Nullable)sd_filteredImageWithFilter:(CIFilter * _Nonnull)filter;
		[Export ("sd_filteredImageWithFilter:")]
		[return: NullAllowed]
		NSImage Sd_filteredImageWithFilter (CIFilter filter);
	}

	// @protocol SDImageTransformer <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDImageTransformer
	{
		// @required @property (readonly, copy, nonatomic) NSString * _Nonnull transformerKey;
		[Abstract]
		[Export ("transformerKey")]
		string TransformerKey { get; }

		// @required -(NSImage * _Nullable)transformedImageWithImage:(NSImage * _Nonnull)image forKey:(NSString * _Nonnull)key __attribute__((availability(macos, introduced=10.10, deprecated=100000))) __attribute__((availability(ios, introduced=8.0, deprecated=100000))) __attribute__((availability(tvos, introduced=9.0, deprecated=100000))) __attribute__((availability(watchos, introduced=2.0, deprecated=100000)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Deprecated (PlatformName.MacOSX, 100000, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Introduced (PlatformName.iOS, 8, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Deprecated (PlatformName.iOS, 100000, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Introduced (PlatformName.TvOS, 9, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Deprecated (PlatformName.TvOS, 100000, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Introduced (PlatformName.WatchOS, 2, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Deprecated (PlatformName.WatchOS, 100000, 0, message: "The key arg will be removed in the future. Update your code and don't rely on that.")]
		[Abstract]
		[Export ("transformedImageWithImage:forKey:")]
		[return: NullAllowed]
		NSImage ForKey (NSImage image, string key);
	}

	// @interface SDImagePipelineTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImagePipelineTransformer : ISDImageTransformer
	{
		// @property (readonly, copy, nonatomic) NSArray<id<SDImageTransformer>> * _Nonnull transformers;
		[Export ("transformers", ArgumentSemantic.Copy)]
		SDImageTransformer[] Transformers { get; }

		// +(instancetype _Nonnull)transformerWithTransformers:(NSArray<id<SDImageTransformer>> * _Nonnull)transformers;
		[Static]
		[Export ("transformerWithTransformers:")]
		SDImagePipelineTransformer TransformerWithTransformers (SDImageTransformer[] transformers);
	}

	// @interface SDImageRoundCornerTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageRoundCornerTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; }

		// @property (readonly, assign, nonatomic) SDRectCorner corners;
		[Export ("corners", ArgumentSemantic.Assign)]
		SDRectCorner Corners { get; }

		// @property (readonly, assign, nonatomic) CGFloat borderWidth;
		[Export ("borderWidth")]
		nfloat BorderWidth { get; }

		// @property (readonly, nonatomic, strong) NSColor * _Nullable borderColor;
		[NullAllowed, Export ("borderColor", ArgumentSemantic.Strong)]
		NSColor BorderColor { get; }

		// +(instancetype _Nonnull)transformerWithRadius:(CGFloat)cornerRadius corners:(SDRectCorner)corners borderWidth:(CGFloat)borderWidth borderColor:(NSColor * _Nullable)borderColor;
		[Static]
		[Export ("transformerWithRadius:corners:borderWidth:borderColor:")]
		SDImageRoundCornerTransformer TransformerWithRadius (nfloat cornerRadius, SDRectCorner corners, nfloat borderWidth, [NullAllowed] NSColor borderColor);
	}

	// @interface SDImageResizingTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageResizingTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) CGSize size;
		[Export ("size", ArgumentSemantic.Assign)]
		CGSize Size { get; }

		// @property (readonly, assign, nonatomic) SDImageScaleMode scaleMode;
		[Export ("scaleMode", ArgumentSemantic.Assign)]
		SDImageScaleMode ScaleMode { get; }

		// +(instancetype _Nonnull)transformerWithSize:(CGSize)size scaleMode:(SDImageScaleMode)scaleMode;
		[Static]
		[Export ("transformerWithSize:scaleMode:")]
		SDImageResizingTransformer TransformerWithSize (CGSize size, SDImageScaleMode scaleMode);
	}

	// @interface SDImageCroppingTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageCroppingTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) CGRect rect;
		[Export ("rect", ArgumentSemantic.Assign)]
		CGRect Rect { get; }

		// +(instancetype _Nonnull)transformerWithRect:(CGRect)rect;
		[Static]
		[Export ("transformerWithRect:")]
		SDImageCroppingTransformer TransformerWithRect (CGRect rect);
	}

	// @interface SDImageFlippingTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageFlippingTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) BOOL horizontal;
		[Export ("horizontal")]
		bool Horizontal { get; }

		// @property (readonly, assign, nonatomic) BOOL vertical;
		[Export ("vertical")]
		bool Vertical { get; }

		// +(instancetype _Nonnull)transformerWithHorizontal:(BOOL)horizontal vertical:(BOOL)vertical;
		[Static]
		[Export ("transformerWithHorizontal:vertical:")]
		SDImageFlippingTransformer TransformerWithHorizontal (bool horizontal, bool vertical);
	}

	// @interface SDImageRotationTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageRotationTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) CGFloat angle;
		[Export ("angle")]
		nfloat Angle { get; }

		// @property (readonly, assign, nonatomic) BOOL fitSize;
		[Export ("fitSize")]
		bool FitSize { get; }

		// +(instancetype _Nonnull)transformerWithAngle:(CGFloat)angle fitSize:(BOOL)fitSize;
		[Static]
		[Export ("transformerWithAngle:fitSize:")]
		SDImageRotationTransformer TransformerWithAngle (nfloat angle, bool fitSize);
	}

	// @interface SDImageTintTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageTintTransformer : ISDImageTransformer
	{
		// @property (readonly, nonatomic, strong) NSColor * _Nonnull tintColor;
		[Export ("tintColor", ArgumentSemantic.Strong)]
		NSColor TintColor { get; }

		// +(instancetype _Nonnull)transformerWithColor:(NSColor * _Nonnull)tintColor;
		[Static]
		[Export ("transformerWithColor:")]
		SDImageTintTransformer TransformerWithColor (NSColor tintColor);
	}

	// @interface SDImageBlurTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageBlurTransformer : ISDImageTransformer
	{
		// @property (readonly, assign, nonatomic) CGFloat blurRadius;
		[Export ("blurRadius")]
		nfloat BlurRadius { get; }

		// +(instancetype _Nonnull)transformerWithRadius:(CGFloat)blurRadius;
		[Static]
		[Export ("transformerWithRadius:")]
		SDImageBlurTransformer TransformerWithRadius (nfloat blurRadius);
	}

	// @interface SDImageFilterTransformer : NSObject <SDImageTransformer>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDImageFilterTransformer : ISDImageTransformer
	{
		// @property (readonly, nonatomic, strong) CIFilter * _Nonnull filter;
		[Export ("filter", ArgumentSemantic.Strong)]
		CIFilter Filter { get; }

		// +(instancetype _Nonnull)transformerWithFilter:(CIFilter * _Nonnull)filter;
		[Static]
		[Export ("transformerWithFilter:")]
		SDImageFilterTransformer TransformerWithFilter (CIFilter filter);
	}

	// typedef NSString * _Nullable (^SDWebImageCacheKeyFilterBlock)(NSURL * _Nonnull);
	delegate string SDWebImageCacheKeyFilterBlock (NSUrl arg0);

	// @protocol SDWebImageCacheKeyFilter <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageCacheKeyFilter
	{
		// @required -(NSString * _Nullable)cacheKeyForURL:(NSURL * _Nonnull)url;
		[Abstract]
		[Export ("cacheKeyForURL:")]
		[return: NullAllowed]
		string CacheKeyForURL (NSUrl url);
	}

	// @interface SDWebImageCacheKeyFilter : NSObject <SDWebImageCacheKeyFilter>
	[BaseType (typeof(NSObject))]
	interface SDWebImageCacheKeyFilter : ISDWebImageCacheKeyFilter
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageCacheKeyFilterBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageCacheKeyFilterBlock block);

		// +(instancetype _Nonnull)cacheKeyFilterWithBlock:(SDWebImageCacheKeyFilterBlock _Nonnull)block;
		[Static]
		[Export ("cacheKeyFilterWithBlock:")]
		SDWebImageCacheKeyFilter CacheKeyFilterWithBlock (SDWebImageCacheKeyFilterBlock block);
	}

	// typedef NSData * _Nullable (^SDWebImageCacheSerializerBlock)(NSImage * _Nonnull, NSData * _Nullable, NSURL * _Nullable);
	delegate NSData SDWebImageCacheSerializerBlock (NSImage arg0, [NullAllowed] NSData arg1, [NullAllowed] NSUrl arg2);

	// @protocol SDWebImageCacheSerializer <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageCacheSerializer
	{
		// @required -(NSData * _Nullable)cacheDataWithImage:(NSImage * _Nonnull)image originalData:(NSData * _Nullable)data imageURL:(NSURL * _Nullable)imageURL;
		[Abstract]
		[Export ("cacheDataWithImage:originalData:imageURL:")]
		[return: NullAllowed]
		NSData OriginalData (NSImage image, [NullAllowed] NSData data, [NullAllowed] NSUrl imageURL);
	}

	// @interface SDWebImageCacheSerializer : NSObject <SDWebImageCacheSerializer>
	[BaseType (typeof(NSObject))]
	interface SDWebImageCacheSerializer : ISDWebImageCacheSerializer
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageCacheSerializerBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageCacheSerializerBlock block);

		// +(instancetype _Nonnull)cacheSerializerWithBlock:(SDWebImageCacheSerializerBlock _Nonnull)block;
		[Static]
		[Export ("cacheSerializerWithBlock:")]
		SDWebImageCacheSerializer CacheSerializerWithBlock (SDWebImageCacheSerializerBlock block);
	}

	// typedef SDWebImageOptionsResult * _Nullable (^SDWebImageOptionsProcessorBlock)(NSURL * _Nullable, SDWebImageOptions, SDWebImageContext * _Nullable);
	delegate SDWebImageOptionsResult SDWebImageOptionsProcessorBlock ([NullAllowed] NSUrl arg0, SDWebImageOptions arg1, [NullAllowed] NSDictionary<NSString, NSObject> arg2);

	// @interface SDWebImageOptionsResult : NSObject
	[BaseType (typeof(NSObject))]
	interface SDWebImageOptionsResult
	{
		// @property (readonly, assign, nonatomic) SDWebImageOptions options;
		[Export ("options", ArgumentSemantic.Assign)]
		SDWebImageOptions Options { get; }

		// @property (readonly, copy, nonatomic) SDWebImageContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Context { get; }

		// -(instancetype _Nonnull)initWithOptions:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("initWithOptions:context:")]
		NativeHandle Constructor (SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);
	}

	// @protocol SDWebImageOptionsProcessor <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageOptionsProcessor
	{
		// @required -(SDWebImageOptionsResult * _Nullable)processedResultForURL:(NSURL * _Nullable)url options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Abstract]
		[Export ("processedResultForURL:options:context:")]
		[return: NullAllowed]
		SDWebImageOptionsResult Options ([NullAllowed] NSUrl url, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);
	}

	// @interface SDWebImageOptionsProcessor : NSObject <SDWebImageOptionsProcessor>
	[BaseType (typeof(NSObject))]
	interface SDWebImageOptionsProcessor : ISDWebImageOptionsProcessor
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageOptionsProcessorBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageOptionsProcessorBlock block);

		// +(instancetype _Nonnull)optionsProcessorWithBlock:(SDWebImageOptionsProcessorBlock _Nonnull)block;
		[Static]
		[Export ("optionsProcessorWithBlock:")]
		SDWebImageOptionsProcessor OptionsProcessorWithBlock (SDWebImageOptionsProcessorBlock block);
	}

	// typedef void (^SDExternalCompletionBlock)(NSImage * _Nullable, NSError * _Nullable, SDImageCacheType, NSURL * _Nullable);
	delegate void SDExternalCompletionBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSError arg1, SDImageCacheType arg2, [NullAllowed] NSUrl arg3);

	// typedef void (^SDInternalCompletionBlock)(NSImage * _Nullable, NSData * _Nullable, NSError * _Nullable, SDImageCacheType, BOOL, NSURL * _Nullable);
	delegate void SDInternalCompletionBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSData arg1, [NullAllowed] NSError arg2, SDImageCacheType arg3, bool arg4, [NullAllowed] NSUrl arg5);

	// @interface SDWebImageCombinedOperation : NSObject <SDWebImageOperation>
	[BaseType (typeof(NSObject))]
	interface SDWebImageCombinedOperation : ISDWebImageOperation
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// @property (readonly, getter = isCancelled, assign, nonatomic) BOOL cancelled;
		[Export ("cancelled")]
		bool Cancelled { [Bind ("isCancelled")] get; }

		// @property (readonly, nonatomic, strong) id<SDWebImageOperation> _Nullable cacheOperation;
		[NullAllowed, Export ("cacheOperation", ArgumentSemantic.Strong)]
		SDWebImageOperation CacheOperation { get; }

		// @property (readonly, nonatomic, strong) id<SDWebImageOperation> _Nullable loaderOperation;
		[NullAllowed, Export ("loaderOperation", ArgumentSemantic.Strong)]
		SDWebImageOperation LoaderOperation { get; }
	}

	// @protocol SDWebImageManagerDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface SDWebImageManagerDelegate
	{
		// @optional -(BOOL)imageManager:(SDWebImageManager * _Nonnull)imageManager shouldDownloadImageForURL:(NSURL * _Nonnull)imageURL;
		[Export ("imageManager:shouldDownloadImageForURL:")]
		bool ShouldDownloadImageForURL (SDWebImageManager imageManager, NSUrl imageURL);

		// @optional -(BOOL)imageManager:(SDWebImageManager * _Nonnull)imageManager shouldBlockFailedURL:(NSURL * _Nonnull)imageURL withError:(NSError * _Nonnull)error;
		[Export ("imageManager:shouldBlockFailedURL:withError:")]
		bool ShouldBlockFailedURL (SDWebImageManager imageManager, NSUrl imageURL, NSError error);
	}

	// @interface SDWebImageManager : NSObject
	[BaseType (typeof(NSObject))]
	interface SDWebImageManager
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		SDWebImageManagerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SDWebImageManagerDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) id<SDImageCache> _Nonnull imageCache;
		[Export ("imageCache", ArgumentSemantic.Strong)]
		SDImageCache ImageCache { get; }

		// @property (readonly, nonatomic, strong) id<SDImageLoader> _Nonnull imageLoader;
		[Export ("imageLoader", ArgumentSemantic.Strong)]
		SDImageLoader ImageLoader { get; }

		// @property (nonatomic, strong) id<SDImageTransformer> _Nullable transformer;
		[NullAllowed, Export ("transformer", ArgumentSemantic.Strong)]
		SDImageTransformer Transformer { get; set; }

		// @property (nonatomic, strong) id<SDWebImageCacheKeyFilter> _Nullable cacheKeyFilter;
		[NullAllowed, Export ("cacheKeyFilter", ArgumentSemantic.Strong)]
		SDWebImageCacheKeyFilter CacheKeyFilter { get; set; }

		// @property (nonatomic, strong) id<SDWebImageCacheSerializer> _Nullable cacheSerializer;
		[NullAllowed, Export ("cacheSerializer", ArgumentSemantic.Strong)]
		SDWebImageCacheSerializer CacheSerializer { get; set; }

		// @property (nonatomic, strong) id<SDWebImageOptionsProcessor> _Nullable optionsProcessor;
		[NullAllowed, Export ("optionsProcessor", ArgumentSemantic.Strong)]
		SDWebImageOptionsProcessor OptionsProcessor { get; set; }

		// @property (readonly, getter = isRunning, assign, nonatomic) BOOL running;
		[Export ("running")]
		bool Running { [Bind ("isRunning")] get; }

		// @property (nonatomic, class) id<SDImageCache> _Nullable defaultImageCache;
		[Static]
		[NullAllowed, Export ("defaultImageCache", ArgumentSemantic.Assign)]
		SDImageCache DefaultImageCache { get; set; }

		// @property (nonatomic, class) id<SDImageLoader> _Nullable defaultImageLoader;
		[Static]
		[NullAllowed, Export ("defaultImageLoader", ArgumentSemantic.Assign)]
		SDImageLoader DefaultImageLoader { get; set; }

		// @property (readonly, nonatomic, class) SDWebImageManager * _Nonnull sharedManager;
		[Static]
		[Export ("sharedManager")]
		SDWebImageManager SharedManager { get; }

		// -(instancetype _Nonnull)initWithCache:(id<SDImageCache> _Nonnull)cache loader:(id<SDImageLoader> _Nonnull)loader __attribute__((objc_designated_initializer));
		[Export ("initWithCache:loader:")]
		[DesignatedInitializer]
		NativeHandle Constructor (SDImageCache cache, SDImageLoader loader);

		// -(SDWebImageCombinedOperation * _Nullable)loadImageWithURL:(NSURL * _Nullable)url options:(SDWebImageOptions)options progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDInternalCompletionBlock _Nonnull)completedBlock;
		[Export ("loadImageWithURL:options:progress:completed:")]
		[return: NullAllowed]
		SDWebImageCombinedOperation LoadImageWithURL ([NullAllowed] NSUrl url, SDWebImageOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, SDInternalCompletionBlock completedBlock);

		// -(SDWebImageCombinedOperation * _Nullable)loadImageWithURL:(NSURL * _Nullable)url options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDInternalCompletionBlock _Nonnull)completedBlock;
		[Export ("loadImageWithURL:options:context:progress:completed:")]
		[return: NullAllowed]
		SDWebImageCombinedOperation LoadImageWithURL ([NullAllowed] NSUrl url, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, SDInternalCompletionBlock completedBlock);

		// -(void)cancelAll;
		[Export ("cancelAll")]
		void CancelAll ();

		// -(void)removeFailedURL:(NSURL * _Nonnull)url;
		[Export ("removeFailedURL:")]
		void RemoveFailedURL (NSUrl url);

		// -(void)removeAllFailedURLs;
		[Export ("removeAllFailedURLs")]
		void RemoveAllFailedURLs ();

		// -(NSString * _Nullable)cacheKeyForURL:(NSURL * _Nullable)url;
		[Export ("cacheKeyForURL:")]
		[return: NullAllowed]
		string CacheKeyForURL ([NullAllowed] NSUrl url);

		// -(NSString * _Nullable)cacheKeyForURL:(NSURL * _Nullable)url context:(SDWebImageContext * _Nullable)context;
		[Export ("cacheKeyForURL:context:")]
		[return: NullAllowed]
		string CacheKeyForURL ([NullAllowed] NSUrl url, [NullAllowed] NSDictionary<NSString, NSObject> context);
	}

	// @interface WebCache (NSButton)
	[Category]
	[BaseType (typeof(NSButton))]
	interface NSButton_WebCache
	{
		// @property (readonly, nonatomic, strong) NSURL * _Nullable sd_currentImageURL;
		[NullAllowed, Export ("sd_currentImageURL", ArgumentSemantic.Strong)]
		NSUrl Sd_currentImageURL { get; }

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url __attribute__((swift_private));
		[Export ("sd_setImageWithURL:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:options:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder completed:(SDExternalCompletionBlock _Nullable)completedBlock __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// @property (readonly, nonatomic, strong) NSURL * _Nullable sd_currentAlternateImageURL;
		[NullAllowed, Export ("sd_currentAlternateImageURL", ArgumentSemantic.Strong)]
		NSUrl Sd_currentAlternateImageURL { get; }

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url __attribute__((swift_private));
		[Export ("sd_setAlternateImageWithURL:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder __attribute__((swift_private));
		[Export ("sd_setAlternateImageWithURL:placeholderImage:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options __attribute__((swift_private));
		[Export ("sd_setAlternateImageWithURL:placeholderImage:options:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("sd_setAlternateImageWithURL:placeholderImage:options:context:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setAlternateImageWithURL:completed:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder completed:(SDExternalCompletionBlock _Nullable)completedBlock __attribute__((swift_private));
		[Export ("sd_setAlternateImageWithURL:placeholderImage:completed:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setAlternateImageWithURL:placeholderImage:options:completed:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setAlternateImageWithURL:placeholderImage:options:progress:completed:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setAlternateImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setAlternateImageWithURL:placeholderImage:options:context:progress:completed:")]
		void Sd_setAlternateImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_cancelCurrentImageLoad;
		[Export ("sd_cancelCurrentImageLoad")]
		void Sd_cancelCurrentImageLoad ();

		// -(void)sd_cancelCurrentAlternateImageLoad;
		[Export ("sd_cancelCurrentAlternateImageLoad")]
		void Sd_cancelCurrentAlternateImageLoad ();
	}

	// @interface Compatibility (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_Compatibility
	{
		// @property (readonly, nonatomic) CGImageRef _Nullable CGImage;
		[NullAllowed, Export ("CGImage")]
		CGImage CGImage { get; }

		// @property (readonly, nonatomic) CIImage * _Nullable CIImage;
		[NullAllowed, Export ("CIImage")]
		CIImage CIImage { get; }

		// @property (readonly, nonatomic) CGFloat scale;
		[Export ("scale")]
		nfloat Scale { get; }

		// -(instancetype _Nonnull)initWithCGImage:(CGImageRef _Nonnull)cgImage scale:(CGFloat)scale orientation:(CGImagePropertyOrientation)orientation;
		[Export ("initWithCGImage:scale:orientation:")]
		NativeHandle Constructor (CGImage cgImage, nfloat scale, CGImagePropertyOrientation orientation);

		// -(instancetype _Nonnull)initWithCIImage:(CIImage * _Nonnull)ciImage scale:(CGFloat)scale orientation:(CGImagePropertyOrientation)orientation;
		[Export ("initWithCIImage:scale:orientation:")]
		NativeHandle Constructor (CIImage ciImage, nfloat scale, CGImagePropertyOrientation orientation);

		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)data scale:(CGFloat)scale;
		[Export ("initWithData:scale:")]
		NativeHandle Constructor (NSData data, nfloat scale);
	}

	// @protocol SDAnimatedImage <SDAnimatedImageProvider>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SDAnimatedImage : ISDAnimatedImageProvider
	{
		// @required -(instancetype _Nullable)initWithData:(NSData * _Nonnull)data scale:(CGFloat)scale options:(SDImageCoderOptions * _Nullable)options;
		[Abstract]
		[Export ("initWithData:scale:options:")]
		NativeHandle Constructor (NSData data, nfloat scale, [NullAllowed] NSDictionary<NSString, NSObject> options);

		// @required -(instancetype _Nullable)initWithAnimatedCoder:(id<SDAnimatedImageCoder> _Nonnull)animatedCoder scale:(CGFloat)scale;
		[Abstract]
		[Export ("initWithAnimatedCoder:scale:")]
		NativeHandle Constructor (SDAnimatedImageCoder animatedCoder, nfloat scale);

		// @optional -(void)preloadAllFrames;
		[Export ("preloadAllFrames")]
		void PreloadAllFrames ();

		// @optional -(void)unloadAllFrames;
		[Export ("unloadAllFrames")]
		void UnloadAllFrames ();

		// @optional @property (readonly, getter = isAllFramesLoaded, assign, nonatomic) BOOL allFramesLoaded;
		[Export ("allFramesLoaded")]
		bool AllFramesLoaded { [Bind ("isAllFramesLoaded")] get; }

		// @optional @property (readonly, nonatomic, strong) id<SDAnimatedImageCoder> _Nullable animatedCoder;
		[NullAllowed, Export ("animatedCoder", ArgumentSemantic.Strong)]
		SDAnimatedImageCoder AnimatedCoder { get; }
	}

	// @interface SDAnimatedImage : NSImage <SDAnimatedImage>
	[BaseType (typeof(NSImage))]
	interface SDAnimatedImage : ISDAnimatedImage
	{
		// +(instancetype _Nullable)imageNamed:(NSString * _Nonnull)name;
		[Static]
		[Export ("imageNamed:")]
		[return: NullAllowed]
		SDAnimatedImage ImageNamed (string name);

		// +(instancetype _Nullable)imageNamed:(NSString * _Nonnull)name inBundle:(NSBundle * _Nullable)bundle;
		[Static]
		[Export ("imageNamed:inBundle:")]
		[return: NullAllowed]
		SDAnimatedImage ImageNamed (string name, [NullAllowed] NSBundle bundle);

		// +(instancetype _Nullable)imageWithContentsOfFile:(NSString * _Nonnull)path;
		[Static]
		[Export ("imageWithContentsOfFile:")]
		[return: NullAllowed]
		SDAnimatedImage ImageWithContentsOfFile (string path);

		// +(instancetype _Nullable)imageWithData:(NSData * _Nonnull)data;
		[Static]
		[Export ("imageWithData:")]
		[return: NullAllowed]
		SDAnimatedImage ImageWithData (NSData data);

		// +(instancetype _Nullable)imageWithData:(NSData * _Nonnull)data scale:(CGFloat)scale;
		[Static]
		[Export ("imageWithData:scale:")]
		[return: NullAllowed]
		SDAnimatedImage ImageWithData (NSData data, nfloat scale);

		// -(instancetype _Nullable)initWithContentsOfFile:(NSString * _Nonnull)path;
		[Export ("initWithContentsOfFile:")]
		NativeHandle Constructor (string path);

		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nullable)initWithData:(NSData * _Nonnull)data scale:(CGFloat)scale;
		[Export ("initWithData:scale:")]
		NativeHandle Constructor (NSData data, nfloat scale);

		// @property (readonly, assign, nonatomic) SDImageFormat animatedImageFormat;
		[Export ("animatedImageFormat")]
		nint AnimatedImageFormat { get; }

		// @property (readonly, copy, nonatomic) NSData * _Nullable animatedImageData;
		[NullAllowed, Export ("animatedImageData", ArgumentSemantic.Copy)]
		NSData AnimatedImageData { get; }

		// @property (readonly, nonatomic) CGFloat scale;
		[Export ("scale")]
		nfloat Scale { get; }

		// -(void)preloadAllFrames;
		[Export ("preloadAllFrames")]
		void PreloadAllFrames ();

		// -(void)unloadAllFrames;
		[Export ("unloadAllFrames")]
		void UnloadAllFrames ();

		// @property (readonly, getter = isAllFramesLoaded, assign, nonatomic) BOOL allFramesLoaded;
		[Export ("allFramesLoaded")]
		bool AllFramesLoaded { [Bind ("isAllFramesLoaded")] get; }
	}

	// @interface SDAnimatedImagePlayer : NSObject
	[BaseType (typeof(NSObject))]
	interface SDAnimatedImagePlayer
	{
		// @property (readonly, nonatomic) NSImage * _Nullable currentFrame;
		[NullAllowed, Export ("currentFrame")]
		NSImage CurrentFrame { get; }

		// @property (readonly, nonatomic) NSUInteger currentFrameIndex;
		[Export ("currentFrameIndex")]
		nuint CurrentFrameIndex { get; }

		// @property (readonly, nonatomic) NSUInteger currentLoopCount;
		[Export ("currentLoopCount")]
		nuint CurrentLoopCount { get; }

		// @property (assign, nonatomic) NSUInteger totalFrameCount;
		[Export ("totalFrameCount")]
		nuint TotalFrameCount { get; set; }

		// @property (assign, nonatomic) NSUInteger totalLoopCount;
		[Export ("totalLoopCount")]
		nuint TotalLoopCount { get; set; }

		// @property (assign, nonatomic) double playbackRate;
		[Export ("playbackRate")]
		double PlaybackRate { get; set; }

		// @property (assign, nonatomic) SDAnimatedImagePlaybackMode playbackMode;
		[Export ("playbackMode", ArgumentSemantic.Assign)]
		SDAnimatedImagePlaybackMode PlaybackMode { get; set; }

		// @property (assign, nonatomic) NSUInteger maxBufferSize;
		[Export ("maxBufferSize")]
		nuint MaxBufferSize { get; set; }

		// @property (copy, nonatomic) NSRunLoopMode _Nonnull runLoopMode;
		[Export ("runLoopMode")]
		string RunLoopMode { get; set; }

		// -(instancetype _Nullable)initWithProvider:(id<SDAnimatedImageProvider> _Nonnull)provider;
		[Export ("initWithProvider:")]
		NativeHandle Constructor (SDAnimatedImageProvider provider);

		// +(instancetype _Nullable)playerWithProvider:(id<SDAnimatedImageProvider> _Nonnull)provider;
		[Static]
		[Export ("playerWithProvider:")]
		[return: NullAllowed]
		SDAnimatedImagePlayer PlayerWithProvider (SDAnimatedImageProvider provider);

		// @property (copy, nonatomic) void (^ _Nullable)(NSUInteger, NSImage * _Nonnull) animationFrameHandler;
		[NullAllowed, Export ("animationFrameHandler", ArgumentSemantic.Copy)]
		Action<nuint, NSImage> AnimationFrameHandler { get; set; }

		// @property (copy, nonatomic) void (^ _Nullable)(NSUInteger) animationLoopHandler;
		[NullAllowed, Export ("animationLoopHandler", ArgumentSemantic.Copy)]
		Action<nuint> AnimationLoopHandler { get; set; }

		// @property (readonly, nonatomic) BOOL isPlaying;
		[Export ("isPlaying")]
		bool IsPlaying { get; }

		// -(void)startPlaying;
		[Export ("startPlaying")]
		void StartPlaying ();

		// -(void)pausePlaying;
		[Export ("pausePlaying")]
		void PausePlaying ();

		// -(void)stopPlaying;
		[Export ("stopPlaying")]
		void StopPlaying ();

		// -(void)seekToFrameAtIndex:(NSUInteger)index loopCount:(NSUInteger)loopCount;
		[Export ("seekToFrameAtIndex:loopCount:")]
		void SeekToFrameAtIndex (nuint index, nuint loopCount);

		// -(void)clearFrameBuffer;
		[Export ("clearFrameBuffer")]
		void ClearFrameBuffer ();
	}

	// @interface SDAnimatedImageRep : NSBitmapImageRep
	[BaseType (typeof(NSBitmapImageRep))]
	interface SDAnimatedImageRep
	{
	}

	// @interface SDAnimatedImageView : NSImageView
	[BaseType (typeof(NSImageView))]
	interface SDAnimatedImageView
	{
		// @property (readonly, nonatomic, strong) SDAnimatedImagePlayer * _Nullable player;
		[NullAllowed, Export ("player", ArgumentSemantic.Strong)]
		SDAnimatedImagePlayer Player { get; }

		// @property (readonly, nonatomic, strong) NSImage * _Nullable currentFrame;
		[NullAllowed, Export ("currentFrame", ArgumentSemantic.Strong)]
		NSImage CurrentFrame { get; }

		// @property (readonly, assign, nonatomic) NSUInteger currentFrameIndex;
		[Export ("currentFrameIndex")]
		nuint CurrentFrameIndex { get; }

		// @property (readonly, assign, nonatomic) NSUInteger currentLoopCount;
		[Export ("currentLoopCount")]
		nuint CurrentLoopCount { get; }

		// @property (assign, nonatomic) BOOL shouldCustomLoopCount;
		[Export ("shouldCustomLoopCount")]
		bool ShouldCustomLoopCount { get; set; }

		// @property (assign, nonatomic) NSInteger animationRepeatCount;
		[Export ("animationRepeatCount")]
		nint AnimationRepeatCount { get; set; }

		// @property (assign, nonatomic) double playbackRate;
		[Export ("playbackRate")]
		double PlaybackRate { get; set; }

		// @property (assign, nonatomic) SDAnimatedImagePlaybackMode playbackMode;
		[Export ("playbackMode", ArgumentSemantic.Assign)]
		SDAnimatedImagePlaybackMode PlaybackMode { get; set; }

		// @property (assign, nonatomic) NSUInteger maxBufferSize;
		[Export ("maxBufferSize")]
		nuint MaxBufferSize { get; set; }

		// @property (assign, nonatomic) BOOL shouldIncrementalLoad;
		[Export ("shouldIncrementalLoad")]
		bool ShouldIncrementalLoad { get; set; }

		// @property (assign, nonatomic) BOOL clearBufferWhenStopped;
		[Export ("clearBufferWhenStopped")]
		bool ClearBufferWhenStopped { get; set; }

		// @property (assign, nonatomic) BOOL resetFrameIndexWhenStopped;
		[Export ("resetFrameIndexWhenStopped")]
		bool ResetFrameIndexWhenStopped { get; set; }

		// @property (assign, nonatomic) BOOL autoPlayAnimatedImage;
		[Export ("autoPlayAnimatedImage")]
		bool AutoPlayAnimatedImage { get; set; }

		// @property (copy, nonatomic) NSRunLoopMode _Nonnull runLoopMode;
		[Export ("runLoopMode")]
		string RunLoopMode { get; set; }
	}

	// @interface WebCache (SDAnimatedImageView)
	[Category]
	[BaseType (typeof(SDAnimatedImageView))]
	interface SDAnimatedImageView_WebCache
	{
		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url __attribute__((swift_private));
		[Export ("sd_setImageWithURL:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:options:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder completed:(SDExternalCompletionBlock _Nullable)completedBlock __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);
	}

	// @protocol SDDiskCache <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDDiskCache
	{
		// @required -(instancetype _Nullable)initWithCachePath:(NSString * _Nonnull)cachePath config:(SDImageCacheConfig * _Nonnull)config;
		[Abstract]
		[Export ("initWithCachePath:config:")]
		NativeHandle Constructor (string cachePath, SDImageCacheConfig config);

		// @required -(BOOL)containsDataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("containsDataForKey:")]
		bool ContainsDataForKey (string key);

		// @required -(NSData * _Nullable)dataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("dataForKey:")]
		[return: NullAllowed]
		NSData DataForKey (string key);

		// @required -(void)setData:(NSData * _Nullable)data forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setData:forKey:")]
		void SetData ([NullAllowed] NSData data, string key);

		// @required -(NSData * _Nullable)extendedDataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("extendedDataForKey:")]
		[return: NullAllowed]
		NSData ExtendedDataForKey (string key);

		// @required -(void)setExtendedData:(NSData * _Nullable)extendedData forKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("setExtendedData:forKey:")]
		void SetExtendedData ([NullAllowed] NSData extendedData, string key);

		// @required -(void)removeDataForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("removeDataForKey:")]
		void RemoveDataForKey (string key);

		// @required -(void)removeAllData;
		[Abstract]
		[Export ("removeAllData")]
		void RemoveAllData ();

		// @required -(void)removeExpiredData;
		[Abstract]
		[Export ("removeExpiredData")]
		void RemoveExpiredData ();

		// @required -(NSString * _Nullable)cachePathForKey:(NSString * _Nonnull)key;
		[Abstract]
		[Export ("cachePathForKey:")]
		[return: NullAllowed]
		string CachePathForKey (string key);

		// @required -(NSUInteger)totalCount;
		[Abstract]
		[Export ("totalCount")]
		[Verify (MethodToProperty)]
		nuint TotalCount { get; }

		// @required -(NSUInteger)totalSize;
		[Abstract]
		[Export ("totalSize")]
		[Verify (MethodToProperty)]
		nuint TotalSize { get; }
	}

	// @interface SDDiskCache : NSObject <SDDiskCache>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface SDDiskCache : ISDDiskCache
	{
		// @property (readonly, nonatomic, strong) SDImageCacheConfig * _Nonnull config;
		[Export ("config", ArgumentSemantic.Strong)]
		SDImageCacheConfig Config { get; }

		// -(void)moveCacheDirectoryFromPath:(NSString * _Nonnull)srcPath toPath:(NSString * _Nonnull)dstPath;
		[Export ("moveCacheDirectoryFromPath:toPath:")]
		void MoveCacheDirectoryFromPath (string srcPath, string dstPath);
	}

	// typedef void (^SDGraphicsImageDrawingActions)(CGContextRef _Nonnull);
	delegate void SDGraphicsImageDrawingActions (CGContext arg0);

	// @interface SDGraphicsImageRendererFormat : NSObject
	[BaseType (typeof(NSObject))]
	interface SDGraphicsImageRendererFormat
	{
		// @property (nonatomic) CGFloat scale;
		[Export ("scale")]
		nfloat Scale { get; set; }

		// @property (nonatomic) BOOL opaque;
		[Export ("opaque")]
		bool Opaque { get; set; }

		// @property (nonatomic) SDGraphicsImageRendererFormatRange preferredRange;
		[Export ("preferredRange", ArgumentSemantic.Assign)]
		SDGraphicsImageRendererFormatRange PreferredRange { get; set; }

		// +(instancetype _Nonnull)preferredFormat;
		[Static]
		[Export ("preferredFormat")]
		SDGraphicsImageRendererFormat PreferredFormat ();
	}

	// @interface SDGraphicsImageRenderer : NSObject
	[BaseType (typeof(NSObject))]
	interface SDGraphicsImageRenderer
	{
		// -(instancetype _Nonnull)initWithSize:(CGSize)size;
		[Export ("initWithSize:")]
		NativeHandle Constructor (CGSize size);

		// -(instancetype _Nonnull)initWithSize:(CGSize)size format:(SDGraphicsImageRendererFormat * _Nonnull)format;
		[Export ("initWithSize:format:")]
		NativeHandle Constructor (CGSize size, SDGraphicsImageRendererFormat format);

		// -(NSImage * _Nonnull)imageWithActions:(SDGraphicsImageDrawingActions _Nonnull)actions;
		[Export ("imageWithActions:")]
		NSImage ImageWithActions (SDGraphicsImageDrawingActions actions);
	}

	// @interface SDImageIOAnimatedCoder : NSObject <SDProgressiveImageCoder, SDAnimatedImageCoder>
	[BaseType (typeof(NSObject))]
	interface SDImageIOAnimatedCoder : ISDProgressiveImageCoder, ISDAnimatedImageCoder
	{
		// @property (readonly, class) SDImageFormat imageFormat;
		[Static]
		[Export ("imageFormat")]
		nint ImageFormat { get; }

		// @property (readonly, class) NSString * _Nonnull imageUTType;
		[Static]
		[Export ("imageUTType")]
		string ImageUTType { get; }

		// @property (readonly, class) NSString * _Nonnull dictionaryProperty;
		[Static]
		[Export ("dictionaryProperty")]
		string DictionaryProperty { get; }

		// @property (readonly, class) NSString * _Nonnull unclampedDelayTimeProperty;
		[Static]
		[Export ("unclampedDelayTimeProperty")]
		string UnclampedDelayTimeProperty { get; }

		// @property (readonly, class) NSString * _Nonnull delayTimeProperty;
		[Static]
		[Export ("delayTimeProperty")]
		string DelayTimeProperty { get; }

		// @property (readonly, class) NSString * _Nonnull loopCountProperty;
		[Static]
		[Export ("loopCountProperty")]
		string LoopCountProperty { get; }

		// @property (readonly, class) NSUInteger defaultLoopCount;
		[Static]
		[Export ("defaultLoopCount")]
		nuint DefaultLoopCount { get; }
	}

	// @interface SDImageAPNGCoder : SDImageIOAnimatedCoder <SDProgressiveImageCoder, SDAnimatedImageCoder>
	[BaseType (typeof(SDImageIOAnimatedCoder))]
	interface SDImageAPNGCoder : ISDProgressiveImageCoder, ISDAnimatedImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageAPNGCoder * _Nonnull sharedCoder;
		[Static]
		[Export ("sharedCoder")]
		SDImageAPNGCoder SharedCoder { get; }
	}

	// @interface SDImageAWebPCoder : SDImageIOAnimatedCoder <SDProgressiveImageCoder, SDAnimatedImageCoder>
	[Watch (7,0), TV (14,0), Mac (11,0), iOS (14,0)]
	[BaseType (typeof(SDImageIOAnimatedCoder))]
	interface SDImageAWebPCoder : ISDProgressiveImageCoder, ISDAnimatedImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageAWebPCoder * _Nonnull sharedCoder;
		[Static]
		[Export ("sharedCoder")]
		SDImageAWebPCoder SharedCoder { get; }
	}

	// @interface SDImageCacheConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface SDImageCacheConfig : INSCopying
	{
		// @property (readonly, nonatomic, class) SDImageCacheConfig * _Nonnull defaultCacheConfig;
		[Static]
		[Export ("defaultCacheConfig")]
		SDImageCacheConfig DefaultCacheConfig { get; }

		// @property (assign, nonatomic) BOOL shouldDisableiCloud;
		[Export ("shouldDisableiCloud")]
		bool ShouldDisableiCloud { get; set; }

		// @property (assign, nonatomic) BOOL shouldCacheImagesInMemory;
		[Export ("shouldCacheImagesInMemory")]
		bool ShouldCacheImagesInMemory { get; set; }

		// @property (assign, nonatomic) BOOL shouldUseWeakMemoryCache;
		[Export ("shouldUseWeakMemoryCache")]
		bool ShouldUseWeakMemoryCache { get; set; }

		// @property (assign, nonatomic) BOOL shouldRemoveExpiredDataWhenEnterBackground;
		[Export ("shouldRemoveExpiredDataWhenEnterBackground")]
		bool ShouldRemoveExpiredDataWhenEnterBackground { get; set; }

		// @property (assign, nonatomic) BOOL shouldRemoveExpiredDataWhenTerminate;
		[Export ("shouldRemoveExpiredDataWhenTerminate")]
		bool ShouldRemoveExpiredDataWhenTerminate { get; set; }

		// @property (assign, nonatomic) NSDataReadingOptions diskCacheReadingOptions;
		[Export ("diskCacheReadingOptions", ArgumentSemantic.Assign)]
		NSDataReadingOptions DiskCacheReadingOptions { get; set; }

		// @property (assign, nonatomic) NSDataWritingOptions diskCacheWritingOptions;
		[Export ("diskCacheWritingOptions", ArgumentSemantic.Assign)]
		NSDataWritingOptions DiskCacheWritingOptions { get; set; }

		// @property (assign, nonatomic) NSTimeInterval maxDiskAge;
		[Export ("maxDiskAge")]
		double MaxDiskAge { get; set; }

		// @property (assign, nonatomic) NSUInteger maxDiskSize;
		[Export ("maxDiskSize")]
		nuint MaxDiskSize { get; set; }

		// @property (assign, nonatomic) NSUInteger maxMemoryCost;
		[Export ("maxMemoryCost")]
		nuint MaxMemoryCost { get; set; }

		// @property (assign, nonatomic) NSUInteger maxMemoryCount;
		[Export ("maxMemoryCount")]
		nuint MaxMemoryCount { get; set; }

		// @property (assign, nonatomic) SDImageCacheConfigExpireType diskCacheExpireType;
		[Export ("diskCacheExpireType", ArgumentSemantic.Assign)]
		SDImageCacheConfigExpireType DiskCacheExpireType { get; set; }

		// @property (nonatomic, strong) NSFileManager * _Nullable fileManager;
		[NullAllowed, Export ("fileManager", ArgumentSemantic.Strong)]
		NSFileManager FileManager { get; set; }

		// @property (assign, nonatomic) Class _Nonnull memoryCacheClass;
		[Export ("memoryCacheClass", ArgumentSemantic.Assign)]
		Class MemoryCacheClass { get; set; }

		// @property (assign, nonatomic) Class _Nonnull diskCacheClass;
		[Export ("diskCacheClass", ArgumentSemantic.Assign)]
		Class DiskCacheClass { get; set; }
	}

	// @protocol SDMemoryCache <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDMemoryCache
	{
		// @required -(instancetype _Nonnull)initWithConfig:(SDImageCacheConfig * _Nonnull)config;
		[Abstract]
		[Export ("initWithConfig:")]
		NativeHandle Constructor (SDImageCacheConfig config);

		// @required -(id _Nullable)objectForKey:(id _Nonnull)key;
		[Abstract]
		[Export ("objectForKey:")]
		[return: NullAllowed]
		NSObject ObjectForKey (NSObject key);

		// @required -(void)setObject:(id _Nullable)object forKey:(id _Nonnull)key;
		[Abstract]
		[Export ("setObject:forKey:")]
		void SetObject ([NullAllowed] NSObject @object, NSObject key);

		// @required -(void)setObject:(id _Nullable)object forKey:(id _Nonnull)key cost:(NSUInteger)cost;
		[Abstract]
		[Export ("setObject:forKey:cost:")]
		void SetObject ([NullAllowed] NSObject @object, NSObject key, nuint cost);

		// @required -(void)removeObjectForKey:(id _Nonnull)key;
		[Abstract]
		[Export ("removeObjectForKey:")]
		void RemoveObjectForKey (NSObject key);

		// @required -(void)removeAllObjects;
		[Abstract]
		[Export ("removeAllObjects")]
		void RemoveAllObjects ();
	}

	// audit-objc-generics: @interface SDMemoryCache<KeyType, ObjectType> : NSCache <SDMemoryCache>
	[BaseType (typeof(NSCache))]
	interface SDMemoryCache : ISDMemoryCache
	{
		// @property (readonly, nonatomic, strong) SDImageCacheConfig * _Nonnull config;
		[Export ("config", ArgumentSemantic.Strong)]
		SDImageCacheConfig Config { get; }
	}

	// @interface SDImageCacheToken : NSObject <SDWebImageOperation>
	[BaseType (typeof(NSObject))]
	interface SDImageCacheToken : ISDWebImageOperation
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// @property (readonly, nonatomic, strong) NSString * _Nullable key;
		[NullAllowed, Export ("key", ArgumentSemantic.Strong)]
		string Key { get; }
	}

	// @interface SDImageCache : NSObject
	[BaseType (typeof(NSObject))]
	interface SDImageCache
	{
		// @property (readonly, copy, nonatomic) SDImageCacheConfig * _Nonnull config;
		[Export ("config", ArgumentSemantic.Copy)]
		SDImageCacheConfig Config { get; }

		// @property (readonly, nonatomic, strong) id<SDMemoryCache> _Nonnull memoryCache;
		[Export ("memoryCache", ArgumentSemantic.Strong)]
		SDMemoryCache MemoryCache { get; }

		// @property (readonly, nonatomic, strong) id<SDDiskCache> _Nonnull diskCache;
		[Export ("diskCache", ArgumentSemantic.Strong)]
		SDDiskCache DiskCache { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nonnull diskCachePath;
		[Export ("diskCachePath")]
		string DiskCachePath { get; }

		// @property (copy, nonatomic) SDImageCacheAdditionalCachePathBlock _Nullable additionalCachePathBlock;
		[NullAllowed, Export ("additionalCachePathBlock", ArgumentSemantic.Copy)]
		SDImageCacheAdditionalCachePathBlock AdditionalCachePathBlock { get; set; }

		// @property (readonly, nonatomic, class) SDImageCache * _Nonnull sharedImageCache;
		[Static]
		[Export ("sharedImageCache")]
		SDImageCache SharedImageCache { get; }

		// @property (readwrite, nonatomic, class, null_resettable) NSString * _Null_unspecified defaultDiskCacheDirectory;
		[Static]
		[NullAllowed, Export ("defaultDiskCacheDirectory")]
		string DefaultDiskCacheDirectory { get; set; }

		// -(instancetype _Nonnull)initWithNamespace:(NSString * _Nonnull)ns;
		[Export ("initWithNamespace:")]
		NativeHandle Constructor (string ns);

		// -(instancetype _Nonnull)initWithNamespace:(NSString * _Nonnull)ns diskCacheDirectory:(NSString * _Nullable)directory;
		[Export ("initWithNamespace:diskCacheDirectory:")]
		NativeHandle Constructor (string ns, [NullAllowed] string directory);

		// -(instancetype _Nonnull)initWithNamespace:(NSString * _Nonnull)ns diskCacheDirectory:(NSString * _Nullable)directory config:(SDImageCacheConfig * _Nullable)config __attribute__((objc_designated_initializer));
		[Export ("initWithNamespace:diskCacheDirectory:config:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string ns, [NullAllowed] string directory, [NullAllowed] SDImageCacheConfig config);

		// -(NSString * _Nullable)cachePathForKey:(NSString * _Nullable)key;
		[Export ("cachePathForKey:")]
		[return: NullAllowed]
		string CachePathForKey ([NullAllowed] string key);

		// -(void)storeImage:(NSImage * _Nullable)image forKey:(NSString * _Nullable)key completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Export ("storeImage:forKey:completion:")]
		void StoreImage ([NullAllowed] NSImage image, [NullAllowed] string key, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// -(void)storeImage:(NSImage * _Nullable)image forKey:(NSString * _Nullable)key toDisk:(BOOL)toDisk completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Export ("storeImage:forKey:toDisk:completion:")]
		void StoreImage ([NullAllowed] NSImage image, [NullAllowed] string key, bool toDisk, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// -(void)storeImageData:(NSData * _Nullable)imageData forKey:(NSString * _Nullable)key completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Export ("storeImageData:forKey:completion:")]
		void StoreImageData ([NullAllowed] NSData imageData, [NullAllowed] string key, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// -(void)storeImage:(NSImage * _Nullable)image imageData:(NSData * _Nullable)imageData forKey:(NSString * _Nullable)key toDisk:(BOOL)toDisk completion:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Export ("storeImage:imageData:forKey:toDisk:completion:")]
		void StoreImage ([NullAllowed] NSImage image, [NullAllowed] NSData imageData, [NullAllowed] string key, bool toDisk, [NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// -(void)storeImageToMemory:(NSImage * _Nullable)image forKey:(NSString * _Nullable)key;
		[Export ("storeImageToMemory:forKey:")]
		void StoreImageToMemory ([NullAllowed] NSImage image, [NullAllowed] string key);

		// -(void)storeImageDataToDisk:(NSData * _Nullable)imageData forKey:(NSString * _Nullable)key;
		[Export ("storeImageDataToDisk:forKey:")]
		void StoreImageDataToDisk ([NullAllowed] NSData imageData, [NullAllowed] string key);

		// -(void)diskImageExistsWithKey:(NSString * _Nullable)key completion:(SDImageCacheCheckCompletionBlock _Nullable)completionBlock;
		[Export ("diskImageExistsWithKey:completion:")]
		void DiskImageExistsWithKey ([NullAllowed] string key, [NullAllowed] SDImageCacheCheckCompletionBlock completionBlock);

		// -(BOOL)diskImageDataExistsWithKey:(NSString * _Nullable)key;
		[Export ("diskImageDataExistsWithKey:")]
		bool DiskImageDataExistsWithKey ([NullAllowed] string key);

		// -(NSData * _Nullable)diskImageDataForKey:(NSString * _Nullable)key;
		[Export ("diskImageDataForKey:")]
		[return: NullAllowed]
		NSData DiskImageDataForKey ([NullAllowed] string key);

		// -(void)diskImageDataQueryForKey:(NSString * _Nullable)key completion:(SDImageCacheQueryDataCompletionBlock _Nullable)completionBlock;
		[Export ("diskImageDataQueryForKey:completion:")]
		void DiskImageDataQueryForKey ([NullAllowed] string key, [NullAllowed] SDImageCacheQueryDataCompletionBlock completionBlock);

		// -(SDImageCacheToken * _Nullable)queryCacheOperationForKey:(NSString * _Nullable)key done:(SDImageCacheQueryCompletionBlock _Nullable)doneBlock;
		[Export ("queryCacheOperationForKey:done:")]
		[return: NullAllowed]
		SDImageCacheToken QueryCacheOperationForKey ([NullAllowed] string key, [NullAllowed] SDImageCacheQueryCompletionBlock doneBlock);

		// -(SDImageCacheToken * _Nullable)queryCacheOperationForKey:(NSString * _Nullable)key options:(SDImageCacheOptions)options done:(SDImageCacheQueryCompletionBlock _Nullable)doneBlock;
		[Export ("queryCacheOperationForKey:options:done:")]
		[return: NullAllowed]
		SDImageCacheToken QueryCacheOperationForKey ([NullAllowed] string key, SDImageCacheOptions options, [NullAllowed] SDImageCacheQueryCompletionBlock doneBlock);

		// -(SDImageCacheToken * _Nullable)queryCacheOperationForKey:(NSString * _Nullable)key options:(SDImageCacheOptions)options context:(SDWebImageContext * _Nullable)context done:(SDImageCacheQueryCompletionBlock _Nullable)doneBlock;
		[Export ("queryCacheOperationForKey:options:context:done:")]
		[return: NullAllowed]
		SDImageCacheToken QueryCacheOperationForKey ([NullAllowed] string key, SDImageCacheOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageCacheQueryCompletionBlock doneBlock);

		// -(SDImageCacheToken * _Nullable)queryCacheOperationForKey:(NSString * _Nullable)key options:(SDImageCacheOptions)options context:(SDWebImageContext * _Nullable)context cacheType:(SDImageCacheType)queryCacheType done:(SDImageCacheQueryCompletionBlock _Nullable)doneBlock;
		[Export ("queryCacheOperationForKey:options:context:cacheType:done:")]
		[return: NullAllowed]
		SDImageCacheToken QueryCacheOperationForKey ([NullAllowed] string key, SDImageCacheOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, SDImageCacheType queryCacheType, [NullAllowed] SDImageCacheQueryCompletionBlock doneBlock);

		// -(NSImage * _Nullable)imageFromMemoryCacheForKey:(NSString * _Nullable)key;
		[Export ("imageFromMemoryCacheForKey:")]
		[return: NullAllowed]
		NSImage ImageFromMemoryCacheForKey ([NullAllowed] string key);

		// -(NSImage * _Nullable)imageFromDiskCacheForKey:(NSString * _Nullable)key;
		[Export ("imageFromDiskCacheForKey:")]
		[return: NullAllowed]
		NSImage ImageFromDiskCacheForKey ([NullAllowed] string key);

		// -(NSImage * _Nullable)imageFromDiskCacheForKey:(NSString * _Nullable)key options:(SDImageCacheOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("imageFromDiskCacheForKey:options:context:")]
		[return: NullAllowed]
		NSImage ImageFromDiskCacheForKey ([NullAllowed] string key, SDImageCacheOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(NSImage * _Nullable)imageFromCacheForKey:(NSString * _Nullable)key;
		[Export ("imageFromCacheForKey:")]
		[return: NullAllowed]
		NSImage ImageFromCacheForKey ([NullAllowed] string key);

		// -(NSImage * _Nullable)imageFromCacheForKey:(NSString * _Nullable)key options:(SDImageCacheOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("imageFromCacheForKey:options:context:")]
		[return: NullAllowed]
		NSImage ImageFromCacheForKey ([NullAllowed] string key, SDImageCacheOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(void)removeImageForKey:(NSString * _Nullable)key withCompletion:(SDWebImageNoParamsBlock _Nullable)completion;
		[Export ("removeImageForKey:withCompletion:")]
		void RemoveImageForKey ([NullAllowed] string key, [NullAllowed] SDWebImageNoParamsBlock completion);

		// -(void)removeImageForKey:(NSString * _Nullable)key fromDisk:(BOOL)fromDisk withCompletion:(SDWebImageNoParamsBlock _Nullable)completion;
		[Export ("removeImageForKey:fromDisk:withCompletion:")]
		void RemoveImageForKey ([NullAllowed] string key, bool fromDisk, [NullAllowed] SDWebImageNoParamsBlock completion);

		// -(void)removeImageFromMemoryForKey:(NSString * _Nullable)key;
		[Export ("removeImageFromMemoryForKey:")]
		void RemoveImageFromMemoryForKey ([NullAllowed] string key);

		// -(void)removeImageFromDiskForKey:(NSString * _Nullable)key;
		[Export ("removeImageFromDiskForKey:")]
		void RemoveImageFromDiskForKey ([NullAllowed] string key);

		// -(void)clearMemory;
		[Export ("clearMemory")]
		void ClearMemory ();

		// -(void)clearDiskOnCompletion:(SDWebImageNoParamsBlock _Nullable)completion;
		[Export ("clearDiskOnCompletion:")]
		void ClearDiskOnCompletion ([NullAllowed] SDWebImageNoParamsBlock completion);

		// -(void)deleteOldFilesWithCompletionBlock:(SDWebImageNoParamsBlock _Nullable)completionBlock;
		[Export ("deleteOldFilesWithCompletionBlock:")]
		void DeleteOldFilesWithCompletionBlock ([NullAllowed] SDWebImageNoParamsBlock completionBlock);

		// -(NSUInteger)totalDiskSize;
		[Export ("totalDiskSize")]
		[Verify (MethodToProperty)]
		nuint TotalDiskSize { get; }

		// -(NSUInteger)totalDiskCount;
		[Export ("totalDiskCount")]
		[Verify (MethodToProperty)]
		nuint TotalDiskCount { get; }

		// -(void)calculateSizeWithCompletionBlock:(SDImageCacheCalculateSizeBlock _Nullable)completionBlock;
		[Export ("calculateSizeWithCompletionBlock:")]
		void CalculateSizeWithCompletionBlock ([NullAllowed] SDImageCacheCalculateSizeBlock completionBlock);
	}

	// @interface SDImageCache (SDImageCache) <SDImageCache>
	[Category]
	[BaseType (typeof(SDImageCache))]
	interface SDImageCache_SDImageCache : ISDImageCache
	{
	}

	// @interface SDImageCachesManager : NSObject <SDImageCache>
	[BaseType (typeof(NSObject))]
	interface SDImageCachesManager : ISDImageCache
	{
		// @property (readonly, nonatomic, class) SDImageCachesManager * _Nonnull sharedManager;
		[Static]
		[Export ("sharedManager")]
		SDImageCachesManager SharedManager { get; }

		// @property (assign, nonatomic) SDImageCachesManagerOperationPolicy queryOperationPolicy;
		[Export ("queryOperationPolicy", ArgumentSemantic.Assign)]
		SDImageCachesManagerOperationPolicy QueryOperationPolicy { get; set; }

		// @property (assign, nonatomic) SDImageCachesManagerOperationPolicy storeOperationPolicy;
		[Export ("storeOperationPolicy", ArgumentSemantic.Assign)]
		SDImageCachesManagerOperationPolicy StoreOperationPolicy { get; set; }

		// @property (assign, nonatomic) SDImageCachesManagerOperationPolicy removeOperationPolicy;
		[Export ("removeOperationPolicy", ArgumentSemantic.Assign)]
		SDImageCachesManagerOperationPolicy RemoveOperationPolicy { get; set; }

		// @property (assign, nonatomic) SDImageCachesManagerOperationPolicy containsOperationPolicy;
		[Export ("containsOperationPolicy", ArgumentSemantic.Assign)]
		SDImageCachesManagerOperationPolicy ContainsOperationPolicy { get; set; }

		// @property (assign, nonatomic) SDImageCachesManagerOperationPolicy clearOperationPolicy;
		[Export ("clearOperationPolicy", ArgumentSemantic.Assign)]
		SDImageCachesManagerOperationPolicy ClearOperationPolicy { get; set; }

		// @property (copy, nonatomic) NSArray<id<SDImageCache>> * _Nullable caches;
		[NullAllowed, Export ("caches", ArgumentSemantic.Copy)]
		SDImageCache[] Caches { get; set; }

		// -(void)addCache:(id<SDImageCache> _Nonnull)cache;
		[Export ("addCache:")]
		void AddCache (SDImageCache cache);

		// -(void)removeCache:(id<SDImageCache> _Nonnull)cache;
		[Export ("removeCache:")]
		void RemoveCache (SDImageCache cache);
	}

	// @interface SDImageFrame : NSObject
	[BaseType (typeof(NSObject))]
	interface SDImageFrame
	{
		// @property (readonly, nonatomic, strong) NSImage * _Nonnull image;
		[Export ("image", ArgumentSemantic.Strong)]
		NSImage Image { get; }

		// @property (readonly, assign, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; }

		// +(instancetype _Nonnull)frameWithImage:(NSImage * _Nonnull)image duration:(NSTimeInterval)duration;
		[Static]
		[Export ("frameWithImage:duration:")]
		SDImageFrame FrameWithImage (NSImage image, double duration);
	}

	// @interface SDImageCoderHelper : NSObject
	[BaseType (typeof(NSObject))]
	interface SDImageCoderHelper
	{
		// +(NSImage * _Nullable)animatedImageWithFrames:(NSArray<SDImageFrame *> * _Nullable)frames;
		[Static]
		[Export ("animatedImageWithFrames:")]
		[return: NullAllowed]
		NSImage AnimatedImageWithFrames ([NullAllowed] SDImageFrame[] frames);

		// +(NSArray<SDImageFrame *> * _Nullable)framesFromAnimatedImage:(NSImage * _Nullable)animatedImage __attribute__((swift_name("frames(from:)")));
		[Static]
		[Export ("framesFromAnimatedImage:")]
		[return: NullAllowed]
		SDImageFrame[] FramesFromAnimatedImage ([NullAllowed] NSImage animatedImage);

		// +(CGColorSpaceRef _Nonnull)colorSpaceGetDeviceRGB __attribute__((cf_returns_not_retained));
		[Static]
		[Export ("colorSpaceGetDeviceRGB")]
		[Verify (MethodToProperty)]
		CGColorSpace ColorSpaceGetDeviceRGB { get; }

		// +(BOOL)CGImageContainsAlpha:(CGImageRef _Nonnull)cgImage;
		[Static]
		[Export ("CGImageContainsAlpha:")]
		bool CGImageContainsAlpha (CGImage cgImage);

		// +(CGImageRef _Nullable)CGImageCreateDecoded:(CGImageRef _Nonnull)cgImage __attribute__((cf_returns_retained));
		[Static]
		[Export ("CGImageCreateDecoded:")]
		[return: NullAllowed]
		CGImage CGImageCreateDecoded (CGImage cgImage);

		// +(CGImageRef _Nullable)CGImageCreateDecoded:(CGImageRef _Nonnull)cgImage orientation:(CGImagePropertyOrientation)orientation __attribute__((cf_returns_retained));
		[Static]
		[Export ("CGImageCreateDecoded:orientation:")]
		[return: NullAllowed]
		CGImage CGImageCreateDecoded (CGImage cgImage, CGImagePropertyOrientation orientation);

		// +(CGImageRef _Nullable)CGImageCreateScaled:(CGImageRef _Nonnull)cgImage size:(CGSize)size __attribute__((cf_returns_retained));
		[Static]
		[Export ("CGImageCreateScaled:size:")]
		[return: NullAllowed]
		CGImage CGImageCreateScaled (CGImage cgImage, CGSize size);

		// +(CGSize)scaledSizeWithImageSize:(CGSize)imageSize scaleSize:(CGSize)scaleSize preserveAspectRatio:(BOOL)preserveAspectRatio shouldScaleUp:(BOOL)shouldScaleUp;
		[Static]
		[Export ("scaledSizeWithImageSize:scaleSize:preserveAspectRatio:shouldScaleUp:")]
		CGSize ScaledSizeWithImageSize (CGSize imageSize, CGSize scaleSize, bool preserveAspectRatio, bool shouldScaleUp);

		// +(NSImage * _Nullable)decodedImageWithImage:(NSImage * _Nullable)image;
		[Static]
		[Export ("decodedImageWithImage:")]
		[return: NullAllowed]
		NSImage DecodedImageWithImage ([NullAllowed] NSImage image);

		// +(NSImage * _Nullable)decodedAndScaledDownImageWithImage:(NSImage * _Nullable)image limitBytes:(NSUInteger)bytes;
		[Static]
		[Export ("decodedAndScaledDownImageWithImage:limitBytes:")]
		[return: NullAllowed]
		NSImage DecodedAndScaledDownImageWithImage ([NullAllowed] NSImage image, nuint bytes);

		// @property (readwrite, class) SDImageCoderDecodeSolution defaultDecodeSolution;
		[Static]
		[Export ("defaultDecodeSolution", ArgumentSemantic.Assign)]
		SDImageCoderDecodeSolution DefaultDecodeSolution { get; set; }

		// @property (readwrite, class) NSUInteger defaultScaleDownLimitBytes;
		[Static]
		[Export ("defaultScaleDownLimitBytes")]
		nuint DefaultScaleDownLimitBytes { get; set; }
	}

	// @interface SDImageCodersManager : NSObject <SDImageCoder>
	[BaseType (typeof(NSObject))]
	interface SDImageCodersManager : ISDImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageCodersManager * _Nonnull sharedManager;
		[Static]
		[Export ("sharedManager")]
		SDImageCodersManager SharedManager { get; }

		// @property (copy, nonatomic) NSArray<id<SDImageCoder>> * _Nullable coders;
		[NullAllowed, Export ("coders", ArgumentSemantic.Copy)]
		SDImageCoder[] Coders { get; set; }

		// -(void)addCoder:(id<SDImageCoder> _Nonnull)coder;
		[Export ("addCoder:")]
		void AddCoder (SDImageCoder coder);

		// -(void)removeCoder:(id<SDImageCoder> _Nonnull)coder;
		[Export ("removeCoder:")]
		void RemoveCoder (SDImageCoder coder);
	}

	// @interface SDImageGIFCoder : SDImageIOAnimatedCoder <SDProgressiveImageCoder, SDAnimatedImageCoder>
	[BaseType (typeof(SDImageIOAnimatedCoder))]
	interface SDImageGIFCoder : ISDProgressiveImageCoder, ISDAnimatedImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageGIFCoder * _Nonnull sharedCoder;
		[Static]
		[Export ("sharedCoder")]
		SDImageGIFCoder SharedCoder { get; }
	}

	// @interface SDImageHEICCoder : SDImageIOAnimatedCoder <SDProgressiveImageCoder, SDAnimatedImageCoder>
	[Watch (6,0), TV (13,0), Mac (10,15), iOS (13,0)]
	[BaseType (typeof(SDImageIOAnimatedCoder))]
	interface SDImageHEICCoder : ISDProgressiveImageCoder, ISDAnimatedImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageHEICCoder * _Nonnull sharedCoder;
		[Static]
		[Export ("sharedCoder")]
		SDImageHEICCoder SharedCoder { get; }
	}

	// @interface SDImageIOCoder : NSObject <SDProgressiveImageCoder>
	[BaseType (typeof(NSObject))]
	interface SDImageIOCoder : ISDProgressiveImageCoder
	{
		// @property (readonly, nonatomic, class) SDImageIOCoder * _Nonnull sharedCoder;
		[Static]
		[Export ("sharedCoder")]
		SDImageIOCoder SharedCoder { get; }
	}

	// @interface SDImageLoadersManager : NSObject <SDImageLoader>
	[BaseType (typeof(NSObject))]
	interface SDImageLoadersManager : ISDImageLoader
	{
		// @property (readonly, nonatomic, class) SDImageLoadersManager * _Nonnull sharedManager;
		[Static]
		[Export ("sharedManager")]
		SDImageLoadersManager SharedManager { get; }

		// @property (copy, nonatomic) NSArray<id<SDImageLoader>> * _Nullable loaders;
		[NullAllowed, Export ("loaders", ArgumentSemantic.Copy)]
		SDImageLoader[] Loaders { get; set; }

		// -(void)addLoader:(id<SDImageLoader> _Nonnull)loader;
		[Export ("addLoader:")]
		void AddLoader (SDImageLoader loader);

		// -(void)removeLoader:(id<SDImageLoader> _Nonnull)loader;
		[Export ("removeLoader:")]
		void RemoveLoader (SDImageLoader loader);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double SDWebImageVersionNumber;
		[Field ("SDWebImageVersionNumber")]
		double SDWebImageVersionNumber { get; }

		// extern const unsigned char[] SDWebImageVersionString;
		[Field ("SDWebImageVersionString")]
		byte[] SDWebImageVersionString { get; }
	}

	// @interface SDWebImageDownloaderConfig : NSObject <NSCopying>
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderConfig : INSCopying
	{
		// @property (readonly, nonatomic, class) SDWebImageDownloaderConfig * _Nonnull defaultDownloaderConfig;
		[Static]
		[Export ("defaultDownloaderConfig")]
		SDWebImageDownloaderConfig DefaultDownloaderConfig { get; }

		// @property (assign, nonatomic) NSInteger maxConcurrentDownloads;
		[Export ("maxConcurrentDownloads")]
		nint MaxConcurrentDownloads { get; set; }

		// @property (assign, nonatomic) NSTimeInterval downloadTimeout;
		[Export ("downloadTimeout")]
		double DownloadTimeout { get; set; }

		// @property (assign, nonatomic) double minimumProgressInterval;
		[Export ("minimumProgressInterval")]
		double MinimumProgressInterval { get; set; }

		// @property (nonatomic, strong) NSURLSessionConfiguration * _Nullable sessionConfiguration;
		[NullAllowed, Export ("sessionConfiguration", ArgumentSemantic.Strong)]
		NSUrlSessionConfiguration SessionConfiguration { get; set; }

		// @property (assign, nonatomic) Class _Nullable operationClass;
		[NullAllowed, Export ("operationClass", ArgumentSemantic.Assign)]
		Class OperationClass { get; set; }

		// @property (assign, nonatomic) SDWebImageDownloaderExecutionOrder executionOrder;
		[Export ("executionOrder", ArgumentSemantic.Assign)]
		SDWebImageDownloaderExecutionOrder ExecutionOrder { get; set; }

		// @property (copy, nonatomic) NSURLCredential * _Nullable urlCredential;
		[NullAllowed, Export ("urlCredential", ArgumentSemantic.Copy)]
		NSUrlCredential UrlCredential { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable username;
		[NullAllowed, Export ("username")]
		string Username { get; set; }

		// @property (copy, nonatomic) NSString * _Nullable password;
		[NullAllowed, Export ("password")]
		string Password { get; set; }

		// @property (copy, nonatomic) NSIndexSet * _Nullable acceptableStatusCodes;
		[NullAllowed, Export ("acceptableStatusCodes", ArgumentSemantic.Copy)]
		NSIndexSet AcceptableStatusCodes { get; set; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nullable acceptableContentTypes;
		[NullAllowed, Export ("acceptableContentTypes", ArgumentSemantic.Copy)]
		NSSet<NSString> AcceptableContentTypes { get; set; }
	}

	// typedef NSURLRequest * _Nullable (^SDWebImageDownloaderRequestModifierBlock)(NSURLRequest * _Nonnull);
	delegate NSUrlRequest SDWebImageDownloaderRequestModifierBlock (NSUrlRequest arg0);

	// @protocol SDWebImageDownloaderRequestModifier <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderRequestModifier
	{
		// @required -(NSURLRequest * _Nullable)modifiedRequestWithRequest:(NSURLRequest * _Nonnull)request;
		[Abstract]
		[Export ("modifiedRequestWithRequest:")]
		[return: NullAllowed]
		NSUrlRequest ModifiedRequestWithRequest (NSUrlRequest request);
	}

	// @interface SDWebImageDownloaderRequestModifier : NSObject <SDWebImageDownloaderRequestModifier>
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderRequestModifier : ISDWebImageDownloaderRequestModifier
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageDownloaderRequestModifierBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageDownloaderRequestModifierBlock block);

		// +(instancetype _Nonnull)requestModifierWithBlock:(SDWebImageDownloaderRequestModifierBlock _Nonnull)block;
		[Static]
		[Export ("requestModifierWithBlock:")]
		SDWebImageDownloaderRequestModifier RequestModifierWithBlock (SDWebImageDownloaderRequestModifierBlock block);
	}

	// @interface Conveniences (SDWebImageDownloaderRequestModifier)
	[Category]
	[BaseType (typeof(SDWebImageDownloaderRequestModifier))]
	interface SDWebImageDownloaderRequestModifier_Conveniences
	{
		// -(instancetype _Nonnull)initWithMethod:(NSString * _Nullable)method;
		[Export ("initWithMethod:")]
		NativeHandle Constructor ([NullAllowed] string method);

		// -(instancetype _Nonnull)initWithHeaders:(NSDictionary<NSString *,NSString *> * _Nullable)headers;
		[Export ("initWithHeaders:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSString> headers);

		// -(instancetype _Nonnull)initWithBody:(NSData * _Nullable)body;
		[Export ("initWithBody:")]
		NativeHandle Constructor ([NullAllowed] NSData body);

		// -(instancetype _Nonnull)initWithMethod:(NSString * _Nullable)method headers:(NSDictionary<NSString *,NSString *> * _Nullable)headers body:(NSData * _Nullable)body;
		[Export ("initWithMethod:headers:body:")]
		NativeHandle Constructor ([NullAllowed] string method, [NullAllowed] NSDictionary<NSString, NSString> headers, [NullAllowed] NSData body);
	}

	// typedef NSURLResponse * _Nullable (^SDWebImageDownloaderResponseModifierBlock)(NSURLResponse * _Nonnull);
	delegate NSUrlResponse SDWebImageDownloaderResponseModifierBlock (NSUrlResponse arg0);

	// @protocol SDWebImageDownloaderResponseModifier <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderResponseModifier
	{
		// @required -(NSURLResponse * _Nullable)modifiedResponseWithResponse:(NSURLResponse * _Nonnull)response;
		[Abstract]
		[Export ("modifiedResponseWithResponse:")]
		[return: NullAllowed]
		NSUrlResponse ModifiedResponseWithResponse (NSUrlResponse response);
	}

	// @interface SDWebImageDownloaderResponseModifier : NSObject <SDWebImageDownloaderResponseModifier>
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderResponseModifier : ISDWebImageDownloaderResponseModifier
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageDownloaderResponseModifierBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageDownloaderResponseModifierBlock block);

		// +(instancetype _Nonnull)responseModifierWithBlock:(SDWebImageDownloaderResponseModifierBlock _Nonnull)block;
		[Static]
		[Export ("responseModifierWithBlock:")]
		SDWebImageDownloaderResponseModifier ResponseModifierWithBlock (SDWebImageDownloaderResponseModifierBlock block);
	}

	// @interface Conveniences (SDWebImageDownloaderResponseModifier)
	[Category]
	[BaseType (typeof(SDWebImageDownloaderResponseModifier))]
	interface SDWebImageDownloaderResponseModifier_Conveniences
	{
		// -(instancetype _Nonnull)initWithStatusCode:(NSInteger)statusCode;
		[Export ("initWithStatusCode:")]
		NativeHandle Constructor (nint statusCode);

		// -(instancetype _Nonnull)initWithVersion:(NSString * _Nullable)version;
		[Export ("initWithVersion:")]
		NativeHandle Constructor ([NullAllowed] string version);

		// -(instancetype _Nonnull)initWithHeaders:(NSDictionary<NSString *,NSString *> * _Nullable)headers;
		[Export ("initWithHeaders:")]
		NativeHandle Constructor ([NullAllowed] NSDictionary<NSString, NSString> headers);

		// -(instancetype _Nonnull)initWithStatusCode:(NSInteger)statusCode version:(NSString * _Nullable)version headers:(NSDictionary<NSString *,NSString *> * _Nullable)headers;
		[Export ("initWithStatusCode:version:headers:")]
		NativeHandle Constructor (nint statusCode, [NullAllowed] string version, [NullAllowed] NSDictionary<NSString, NSString> headers);
	}

	// typedef NSData * _Nullable (^SDWebImageDownloaderDecryptorBlock)(NSData * _Nonnull, NSURLResponse * _Nullable);
	delegate NSData SDWebImageDownloaderDecryptorBlock (NSData arg0, [NullAllowed] NSUrlResponse arg1);

	// @protocol SDWebImageDownloaderDecryptor <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderDecryptor
	{
		// @required -(NSData * _Nullable)decryptedDataWithData:(NSData * _Nonnull)data response:(NSURLResponse * _Nullable)response;
		[Abstract]
		[Export ("decryptedDataWithData:response:")]
		[return: NullAllowed]
		NSData Response (NSData data, [NullAllowed] NSUrlResponse response);
	}

	// @interface SDWebImageDownloaderDecryptor : NSObject <SDWebImageDownloaderDecryptor>
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloaderDecryptor : ISDWebImageDownloaderDecryptor
	{
		// -(instancetype _Nonnull)initWithBlock:(SDWebImageDownloaderDecryptorBlock _Nonnull)block;
		[Export ("initWithBlock:")]
		NativeHandle Constructor (SDWebImageDownloaderDecryptorBlock block);

		// +(instancetype _Nonnull)decryptorWithBlock:(SDWebImageDownloaderDecryptorBlock _Nonnull)block;
		[Static]
		[Export ("decryptorWithBlock:")]
		SDWebImageDownloaderDecryptor DecryptorWithBlock (SDWebImageDownloaderDecryptorBlock block);
	}

	// @interface Conveniences (SDWebImageDownloaderDecryptor)
	[Category]
	[BaseType (typeof(SDWebImageDownloaderDecryptor))]
	interface SDWebImageDownloaderDecryptor_Conveniences
	{
		// @property (readonly, class) SDWebImageDownloaderDecryptor * _Nonnull base64Decryptor;
		[Static]
		[Export ("base64Decryptor")]
		SDWebImageDownloaderDecryptor Base64Decryptor { get; }
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSNotificationName  _Nonnull const SDWebImageDownloadStartNotification;
		[Field ("SDWebImageDownloadStartNotification")]
		NSString SDWebImageDownloadStartNotification { get; }

		// extern NSNotificationName  _Nonnull const SDWebImageDownloadReceiveResponseNotification;
		[Field ("SDWebImageDownloadReceiveResponseNotification")]
		NSString SDWebImageDownloadReceiveResponseNotification { get; }

		// extern NSNotificationName  _Nonnull const SDWebImageDownloadStopNotification;
		[Field ("SDWebImageDownloadStopNotification")]
		NSString SDWebImageDownloadStopNotification { get; }

		// extern NSNotificationName  _Nonnull const SDWebImageDownloadFinishNotification;
		[Field ("SDWebImageDownloadFinishNotification")]
		NSString SDWebImageDownloadFinishNotification { get; }
	}

	// typedef SDImageLoaderProgressBlock SDWebImageDownloaderProgressBlock;
	delegate void SDWebImageDownloaderProgressBlock (nint arg0, nint arg1, [NullAllowed] NSUrl arg2);

	// typedef SDImageLoaderCompletedBlock SDWebImageDownloaderCompletedBlock;
	delegate void SDWebImageDownloaderCompletedBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSData arg1, [NullAllowed] NSError arg2, bool arg3);

	// @interface SDWebImageDownloadToken : NSObject <SDWebImageOperation>
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloadToken : ISDWebImageOperation
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// @property (readonly, nonatomic, strong) NSURL * _Nullable url;
		[NullAllowed, Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		// @property (readonly, nonatomic, strong) NSURLRequest * _Nullable request;
		[NullAllowed, Export ("request", ArgumentSemantic.Strong)]
		NSUrlRequest Request { get; }

		// @property (readonly, nonatomic, strong) NSURLResponse * _Nullable response;
		[NullAllowed, Export ("response", ArgumentSemantic.Strong)]
		NSUrlResponse Response { get; }

		// @property (readonly, nonatomic, strong) NSURLSessionTaskMetrics * _Nullable metrics __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[NullAllowed, Export ("metrics", ArgumentSemantic.Strong)]
		NSUrlSessionTaskMetrics Metrics { get; }
	}

	// @interface SDWebImageDownloader : NSObject
	[BaseType (typeof(NSObject))]
	interface SDWebImageDownloader
	{
		// @property (readonly, copy, nonatomic) SDWebImageDownloaderConfig * _Nonnull config;
		[Export ("config", ArgumentSemantic.Copy)]
		SDWebImageDownloaderConfig Config { get; }

		// @property (nonatomic, strong) id<SDWebImageDownloaderRequestModifier> _Nullable requestModifier;
		[NullAllowed, Export ("requestModifier", ArgumentSemantic.Strong)]
		SDWebImageDownloaderRequestModifier RequestModifier { get; set; }

		// @property (nonatomic, strong) id<SDWebImageDownloaderResponseModifier> _Nullable responseModifier;
		[NullAllowed, Export ("responseModifier", ArgumentSemantic.Strong)]
		SDWebImageDownloaderResponseModifier ResponseModifier { get; set; }

		// @property (nonatomic, strong) id<SDWebImageDownloaderDecryptor> _Nullable decryptor;
		[NullAllowed, Export ("decryptor", ArgumentSemantic.Strong)]
		SDWebImageDownloaderDecryptor Decryptor { get; set; }

		// @property (readonly, nonatomic) NSURLSessionConfiguration * _Nonnull sessionConfiguration;
		[Export ("sessionConfiguration")]
		NSUrlSessionConfiguration SessionConfiguration { get; }

		// @property (getter = isSuspended, assign, nonatomic) BOOL suspended;
		[Export ("suspended")]
		bool Suspended { [Bind ("isSuspended")] get; set; }

		// @property (readonly, assign, nonatomic) NSUInteger currentDownloadCount;
		[Export ("currentDownloadCount")]
		nuint CurrentDownloadCount { get; }

		// @property (readonly, nonatomic, class) SDWebImageDownloader * _Nonnull sharedDownloader;
		[Static]
		[Export ("sharedDownloader")]
		SDWebImageDownloader SharedDownloader { get; }

		// -(instancetype _Nonnull)initWithConfig:(SDWebImageDownloaderConfig * _Nullable)config __attribute__((objc_designated_initializer));
		[Export ("initWithConfig:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] SDWebImageDownloaderConfig config);

		// -(void)setValue:(NSString * _Nullable)value forHTTPHeaderField:(NSString * _Nullable)field;
		[Export ("setValue:forHTTPHeaderField:")]
		void SetValue ([NullAllowed] string value, [NullAllowed] string field);

		// -(NSString * _Nullable)valueForHTTPHeaderField:(NSString * _Nullable)field;
		[Export ("valueForHTTPHeaderField:")]
		[return: NullAllowed]
		string ValueForHTTPHeaderField ([NullAllowed] string field);

		// -(SDWebImageDownloadToken * _Nullable)downloadImageWithURL:(NSURL * _Nullable)url completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock;
		[Export ("downloadImageWithURL:completed:")]
		[return: NullAllowed]
		SDWebImageDownloadToken DownloadImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// -(SDWebImageDownloadToken * _Nullable)downloadImageWithURL:(NSURL * _Nullable)url options:(SDWebImageDownloaderOptions)options progress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock;
		[Export ("downloadImageWithURL:options:progress:completed:")]
		[return: NullAllowed]
		SDWebImageDownloadToken DownloadImageWithURL ([NullAllowed] NSUrl url, SDWebImageDownloaderOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// -(SDWebImageDownloadToken * _Nullable)downloadImageWithURL:(NSURL * _Nullable)url options:(SDWebImageDownloaderOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock;
		[Export ("downloadImageWithURL:options:context:progress:completed:")]
		[return: NullAllowed]
		SDWebImageDownloadToken DownloadImageWithURL ([NullAllowed] NSUrl url, SDWebImageDownloaderOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// -(void)cancelAllDownloads;
		[Export ("cancelAllDownloads")]
		void CancelAllDownloads ();

		// -(void)invalidateSessionAndCancel:(BOOL)cancelPendingOperations;
		[Export ("invalidateSessionAndCancel:")]
		void InvalidateSessionAndCancel (bool cancelPendingOperations);
	}

	// @interface SDImageLoader (SDWebImageDownloader) <SDImageLoader>
	[Category]
	[BaseType (typeof(SDWebImageDownloader))]
	interface SDWebImageDownloader_SDImageLoader : ISDImageLoader
	{
	}

	// @protocol SDWebImageDownloaderOperation <NSURLSessionTaskDelegate, NSURLSessionDataDelegate>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	interface SDWebImageDownloaderOperation : INSUrlSessionTaskDelegate, INSUrlSessionDataDelegate
	{
		// @required -(instancetype _Nonnull)initWithRequest:(NSURLRequest * _Nullable)request inSession:(NSURLSession * _Nullable)session options:(SDWebImageDownloaderOptions)options;
		[Abstract]
		[Export ("initWithRequest:inSession:options:")]
		NativeHandle Constructor ([NullAllowed] NSUrlRequest request, [NullAllowed] NSUrlSession session, SDWebImageDownloaderOptions options);

		// @required -(instancetype _Nonnull)initWithRequest:(NSURLRequest * _Nullable)request inSession:(NSURLSession * _Nullable)session options:(SDWebImageDownloaderOptions)options context:(SDWebImageContext * _Nullable)context;
		[Abstract]
		[Export ("initWithRequest:inSession:options:context:")]
		NativeHandle Constructor ([NullAllowed] NSUrlRequest request, [NullAllowed] NSUrlSession session, SDWebImageDownloaderOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// @required -(id _Nullable)addHandlersForProgress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock;
		[Abstract]
		[Export ("addHandlersForProgress:completed:")]
		[return: NullAllowed]
		NSObject AddHandlersForProgress ([NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// @required -(id _Nullable)addHandlersForProgress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock decodeOptions:(SDImageCoderOptions * _Nullable)decodeOptions;
		[Abstract]
		[Export ("addHandlersForProgress:completed:decodeOptions:")]
		[return: NullAllowed]
		NSObject AddHandlersForProgress ([NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock, [NullAllowed] NSDictionary<NSString, NSObject> decodeOptions);

		// @required -(BOOL)cancel:(id _Nullable)token;
		[Abstract]
		[Export ("cancel:")]
		bool Cancel ([NullAllowed] NSObject token);

		// @required @property (readonly, nonatomic, strong) NSURLRequest * _Nullable request;
		[Abstract]
		[NullAllowed, Export ("request", ArgumentSemantic.Strong)]
		NSUrlRequest Request { get; }

		// @required @property (readonly, nonatomic, strong) NSURLResponse * _Nullable response;
		[Abstract]
		[NullAllowed, Export ("response", ArgumentSemantic.Strong)]
		NSUrlResponse Response { get; }

		// @optional @property (readonly, nonatomic, strong) NSURLSessionTask * _Nullable dataTask;
		[NullAllowed, Export ("dataTask", ArgumentSemantic.Strong)]
		NSUrlSessionTask DataTask { get; }

		// @optional @property (readonly, nonatomic, strong) NSURLSessionTaskMetrics * _Nullable metrics __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[NullAllowed, Export ("metrics", ArgumentSemantic.Strong)]
		NSUrlSessionTaskMetrics Metrics { get; }

		// @optional @property (nonatomic, strong) NSURLCredential * _Nullable credential;
		[NullAllowed, Export ("credential", ArgumentSemantic.Strong)]
		NSUrlCredential Credential { get; set; }

		// @optional @property (assign, nonatomic) double minimumProgressInterval;
		[Export ("minimumProgressInterval")]
		double MinimumProgressInterval { get; set; }

		// @optional @property (copy, nonatomic) NSIndexSet * _Nullable acceptableStatusCodes;
		[NullAllowed, Export ("acceptableStatusCodes", ArgumentSemantic.Copy)]
		NSIndexSet AcceptableStatusCodes { get; set; }

		// @optional @property (copy, nonatomic) NSSet<NSString *> * _Nullable acceptableContentTypes;
		[NullAllowed, Export ("acceptableContentTypes", ArgumentSemantic.Copy)]
		NSSet<NSString> AcceptableContentTypes { get; set; }
	}

	// @interface SDWebImageDownloaderOperation : NSOperation <SDWebImageDownloaderOperation>
	[BaseType (typeof(NSOperation))]
	interface SDWebImageDownloaderOperation : ISDWebImageDownloaderOperation
	{
		// @property (readonly, nonatomic, strong) NSURLRequest * _Nullable request;
		[NullAllowed, Export ("request", ArgumentSemantic.Strong)]
		NSUrlRequest Request { get; }

		// @property (readonly, nonatomic, strong) NSURLResponse * _Nullable response;
		[NullAllowed, Export ("response", ArgumentSemantic.Strong)]
		NSUrlResponse Response { get; }

		// @property (readonly, nonatomic, strong) NSURLSessionTask * _Nullable dataTask;
		[NullAllowed, Export ("dataTask", ArgumentSemantic.Strong)]
		NSUrlSessionTask DataTask { get; }

		// @property (readonly, nonatomic, strong) NSURLSessionTaskMetrics * _Nullable metrics __attribute__((availability(macos, introduced=10.12))) __attribute__((availability(ios, introduced=10.0))) __attribute__((availability(watchos, introduced=3.0))) __attribute__((availability(tvos, introduced=10.0)));
		[Watch (3, 0), TV (10, 0), Mac (10, 12), iOS (10, 0)]
		[NullAllowed, Export ("metrics", ArgumentSemantic.Strong)]
		NSUrlSessionTaskMetrics Metrics { get; }

		// @property (nonatomic, strong) NSURLCredential * _Nullable credential;
		[NullAllowed, Export ("credential", ArgumentSemantic.Strong)]
		NSUrlCredential Credential { get; set; }

		// @property (assign, nonatomic) double minimumProgressInterval;
		[Export ("minimumProgressInterval")]
		double MinimumProgressInterval { get; set; }

		// @property (copy, nonatomic) NSIndexSet * _Nullable acceptableStatusCodes;
		[NullAllowed, Export ("acceptableStatusCodes", ArgumentSemantic.Copy)]
		NSIndexSet AcceptableStatusCodes { get; set; }

		// @property (copy, nonatomic) NSSet<NSString *> * _Nullable acceptableContentTypes;
		[NullAllowed, Export ("acceptableContentTypes", ArgumentSemantic.Copy)]
		NSSet<NSString> AcceptableContentTypes { get; set; }

		// @property (readonly, assign, nonatomic) SDWebImageDownloaderOptions options;
		[Export ("options", ArgumentSemantic.Assign)]
		SDWebImageDownloaderOptions Options { get; }

		// @property (readonly, copy, nonatomic) SDWebImageContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Context { get; }

		// -(instancetype _Nonnull)initWithRequest:(NSURLRequest * _Nullable)request inSession:(NSURLSession * _Nullable)session options:(SDWebImageDownloaderOptions)options;
		[Export ("initWithRequest:inSession:options:")]
		NativeHandle Constructor ([NullAllowed] NSUrlRequest request, [NullAllowed] NSUrlSession session, SDWebImageDownloaderOptions options);

		// -(instancetype _Nonnull)initWithRequest:(NSURLRequest * _Nullable)request inSession:(NSURLSession * _Nullable)session options:(SDWebImageDownloaderOptions)options context:(SDWebImageContext * _Nullable)context __attribute__((objc_designated_initializer));
		[Export ("initWithRequest:inSession:options:context:")]
		[DesignatedInitializer]
		NativeHandle Constructor ([NullAllowed] NSUrlRequest request, [NullAllowed] NSUrlSession session, SDWebImageDownloaderOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(id _Nullable)addHandlersForProgress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock;
		[Export ("addHandlersForProgress:completed:")]
		[return: NullAllowed]
		NSObject AddHandlersForProgress ([NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock);

		// -(id _Nullable)addHandlersForProgress:(SDWebImageDownloaderProgressBlock _Nullable)progressBlock completed:(SDWebImageDownloaderCompletedBlock _Nullable)completedBlock decodeOptions:(SDImageCoderOptions * _Nullable)decodeOptions;
		[Export ("addHandlersForProgress:completed:decodeOptions:")]
		[return: NullAllowed]
		NSObject AddHandlersForProgress ([NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDImageLoaderCompletedBlock completedBlock, [NullAllowed] NSDictionary<NSString, NSObject> decodeOptions);

		// -(BOOL)cancel:(id _Nullable)token;
		[Export ("cancel:")]
		bool Cancel ([NullAllowed] NSObject token);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSErrorDomain  _Nonnull const SDWebImageErrorDomain;
		[Field ("SDWebImageErrorDomain")]
		NSString SDWebImageErrorDomain { get; }

		// extern NSErrorUserInfoKey  _Nonnull const SDWebImageErrorDownloadResponseKey;
		[Field ("SDWebImageErrorDownloadResponseKey")]
		NSString SDWebImageErrorDownloadResponseKey { get; }

		// extern NSErrorUserInfoKey  _Nonnull const SDWebImageErrorDownloadStatusCodeKey;
		[Field ("SDWebImageErrorDownloadStatusCodeKey")]
		NSString SDWebImageErrorDownloadStatusCodeKey { get; }

		// extern NSErrorUserInfoKey  _Nonnull const SDWebImageErrorDownloadContentTypeKey;
		[Field ("SDWebImageErrorDownloadContentTypeKey")]
		NSString SDWebImageErrorDownloadContentTypeKey { get; }
	}

	// @protocol SDWebImageIndicator <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol]
	[BaseType (typeof(NSObject))]
	interface SDWebImageIndicator
	{
		// @required @property (readonly, nonatomic, strong) NSView * _Nonnull indicatorView;
		[Abstract]
		[Export ("indicatorView", ArgumentSemantic.Strong)]
		NSView IndicatorView { get; }

		// @required -(void)startAnimatingIndicator;
		[Abstract]
		[Export ("startAnimatingIndicator")]
		void StartAnimatingIndicator ();

		// @required -(void)stopAnimatingIndicator;
		[Abstract]
		[Export ("stopAnimatingIndicator")]
		void StopAnimatingIndicator ();

		// @optional -(void)updateIndicatorProgress:(double)progress;
		[Export ("updateIndicatorProgress:")]
		void UpdateIndicatorProgress (double progress);
	}

	// @interface SDWebImageActivityIndicator : NSObject <SDWebImageIndicator>
	[BaseType (typeof(NSObject))]
	interface SDWebImageActivityIndicator : ISDWebImageIndicator
	{
		// @property (readonly, nonatomic, strong) NSProgressIndicator * _Nonnull indicatorView;
		[Export ("indicatorView", ArgumentSemantic.Strong)]
		NSProgressIndicator IndicatorView { get; }
	}

	// @interface Conveniences (SDWebImageActivityIndicator)
	[Category]
	[BaseType (typeof(SDWebImageActivityIndicator))]
	interface SDWebImageActivityIndicator_Conveniences
	{
		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull grayIndicator;
		[Static]
		[Export ("grayIndicator")]
		SDWebImageActivityIndicator GrayIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull grayLargeIndicator;
		[Static]
		[Export ("grayLargeIndicator")]
		SDWebImageActivityIndicator GrayLargeIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull whiteIndicator;
		[Static]
		[Export ("whiteIndicator")]
		SDWebImageActivityIndicator WhiteIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull whiteLargeIndicator;
		[Static]
		[Export ("whiteLargeIndicator")]
		SDWebImageActivityIndicator WhiteLargeIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull largeIndicator;
		[Static]
		[Export ("largeIndicator")]
		SDWebImageActivityIndicator LargeIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageActivityIndicator * _Nonnull mediumIndicator;
		[Static]
		[Export ("mediumIndicator")]
		SDWebImageActivityIndicator MediumIndicator { get; }
	}

	// @interface SDWebImageProgressIndicator : NSObject <SDWebImageIndicator>
	[BaseType (typeof(NSObject))]
	interface SDWebImageProgressIndicator : ISDWebImageIndicator
	{
		// @property (readonly, nonatomic, strong) NSProgressIndicator * _Nonnull indicatorView;
		[Export ("indicatorView", ArgumentSemantic.Strong)]
		NSProgressIndicator IndicatorView { get; }
	}

	// @interface Conveniences (SDWebImageProgressIndicator)
	[Category]
	[BaseType (typeof(SDWebImageProgressIndicator))]
	interface SDWebImageProgressIndicator_Conveniences
	{
		// @property (readonly, nonatomic, class) SDWebImageProgressIndicator * _Nonnull defaultIndicator;
		[Static]
		[Export ("defaultIndicator")]
		SDWebImageProgressIndicator DefaultIndicator { get; }

		// @property (readonly, nonatomic, class) SDWebImageProgressIndicator * _Nonnull barIndicator __attribute__((availability(macos, unavailable))) __attribute__((availability(tvos, unavailable)));
		[NoTV, NoMac]
		[Static]
		[Export ("barIndicator")]
		SDWebImageProgressIndicator BarIndicator { get; }
	}

	// @interface SDWebImagePrefetchToken : NSObject <SDWebImageOperation>
	[BaseType (typeof(NSObject))]
	interface SDWebImagePrefetchToken : ISDWebImageOperation
	{
		// -(void)cancel;
		[Export ("cancel")]
		void Cancel ();

		// @property (readonly, copy, nonatomic) NSArray<NSURL *> * _Nullable urls;
		[NullAllowed, Export ("urls", ArgumentSemantic.Copy)]
		NSUrl[] Urls { get; }
	}

	// @protocol SDWebImagePrefetcherDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface SDWebImagePrefetcherDelegate
	{
		// @optional -(void)imagePrefetcher:(SDWebImagePrefetcher * _Nonnull)imagePrefetcher didPrefetchURL:(NSURL * _Nullable)imageURL finishedCount:(NSUInteger)finishedCount totalCount:(NSUInteger)totalCount;
		[Export ("imagePrefetcher:didPrefetchURL:finishedCount:totalCount:")]
		void DidPrefetchURL (SDWebImagePrefetcher imagePrefetcher, [NullAllowed] NSUrl imageURL, nuint finishedCount, nuint totalCount);

		// @optional -(void)imagePrefetcher:(SDWebImagePrefetcher * _Nonnull)imagePrefetcher didFinishWithTotalCount:(NSUInteger)totalCount skippedCount:(NSUInteger)skippedCount;
		[Export ("imagePrefetcher:didFinishWithTotalCount:skippedCount:")]
		void DidFinishWithTotalCount (SDWebImagePrefetcher imagePrefetcher, nuint totalCount, nuint skippedCount);
	}

	// typedef void (^SDWebImagePrefetcherProgressBlock)(NSUInteger, NSUInteger);
	delegate void SDWebImagePrefetcherProgressBlock (nuint arg0, nuint arg1);

	// typedef void (^SDWebImagePrefetcherCompletionBlock)(NSUInteger, NSUInteger);
	delegate void SDWebImagePrefetcherCompletionBlock (nuint arg0, nuint arg1);

	// @interface SDWebImagePrefetcher : NSObject
	[BaseType (typeof(NSObject))]
	interface SDWebImagePrefetcher
	{
		// @property (readonly, nonatomic, strong) SDWebImageManager * _Nonnull manager;
		[Export ("manager", ArgumentSemantic.Strong)]
		SDWebImageManager Manager { get; }

		// @property (assign, nonatomic) NSUInteger maxConcurrentPrefetchCount;
		[Export ("maxConcurrentPrefetchCount")]
		nuint MaxConcurrentPrefetchCount { get; set; }

		// @property (assign, nonatomic) SDWebImageOptions options;
		[Export ("options", ArgumentSemantic.Assign)]
		SDWebImageOptions Options { get; set; }

		// @property (copy, nonatomic) SDWebImageContext * _Nullable context;
		[NullAllowed, Export ("context", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Context { get; set; }

		// @property (nonatomic, strong) dispatch_queue_t _Nonnull delegateQueue;
		[Export ("delegateQueue", ArgumentSemantic.Strong)]
		DispatchQueue DelegateQueue { get; set; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		SDWebImagePrefetcherDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<SDWebImagePrefetcherDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, class) SDWebImagePrefetcher * _Nonnull sharedImagePrefetcher;
		[Static]
		[Export ("sharedImagePrefetcher")]
		SDWebImagePrefetcher SharedImagePrefetcher { get; }

		// -(instancetype _Nonnull)initWithImageManager:(SDWebImageManager * _Nonnull)manager __attribute__((objc_designated_initializer));
		[Export ("initWithImageManager:")]
		[DesignatedInitializer]
		NativeHandle Constructor (SDWebImageManager manager);

		// -(SDWebImagePrefetchToken * _Nullable)prefetchURLs:(NSArray<NSURL *> * _Nullable)urls;
		[Export ("prefetchURLs:")]
		[return: NullAllowed]
		SDWebImagePrefetchToken PrefetchURLs ([NullAllowed] NSUrl[] urls);

		// -(SDWebImagePrefetchToken * _Nullable)prefetchURLs:(NSArray<NSURL *> * _Nullable)urls progress:(SDWebImagePrefetcherProgressBlock _Nullable)progressBlock completed:(SDWebImagePrefetcherCompletionBlock _Nullable)completionBlock;
		[Export ("prefetchURLs:progress:completed:")]
		[return: NullAllowed]
		SDWebImagePrefetchToken PrefetchURLs ([NullAllowed] NSUrl[] urls, [NullAllowed] SDWebImagePrefetcherProgressBlock progressBlock, [NullAllowed] SDWebImagePrefetcherCompletionBlock completionBlock);

		// -(void)cancelPrefetching;
		[Export ("cancelPrefetching")]
		void CancelPrefetching ();
	}

	// typedef void (^SDWebImageTransitionPreparesBlock)(__kindof NSView * _Nonnull, NSImage * _Nullable, NSData * _Nullable, SDImageCacheType, NSURL * _Nullable);
	delegate void SDWebImageTransitionPreparesBlock (NSView arg0, [NullAllowed] NSImage arg1, [NullAllowed] NSData arg2, SDImageCacheType arg3, [NullAllowed] NSUrl arg4);

	// typedef void (^SDWebImageTransitionAnimationsBlock)(__kindof NSView * _Nonnull, NSImage * _Nullable);
	delegate void SDWebImageTransitionAnimationsBlock (NSView arg0, [NullAllowed] NSImage arg1);

	// typedef void (^SDWebImageTransitionCompletionBlock)(BOOL);
	delegate void SDWebImageTransitionCompletionBlock (bool arg0);

	// @interface SDWebImageTransition : NSObject
	[BaseType (typeof(NSObject))]
	interface SDWebImageTransition
	{
		// @property (assign, nonatomic) BOOL avoidAutoSetImage;
		[Export ("avoidAutoSetImage")]
		bool AvoidAutoSetImage { get; set; }

		// @property (assign, nonatomic) NSTimeInterval duration;
		[Export ("duration")]
		double Duration { get; set; }

		// @property (nonatomic, strong) API_DEPRECATED("Use SDWebImageAnimationOptions instead, or grab NSAnimationContext.currentContext and modify the timingFunction", macos(10.10, 10.10)) CAMediaTimingFunction * timingFunction __attribute__((availability(ios, unavailable))) __attribute__((availability(tvos, unavailable))) __attribute__((availability(watchos, unavailable))) __attribute__((availability(macos, introduced=10.10, deprecated=10.10)));
		[Introduced (PlatformName.MacOSX, 10, 10, message: "Use SDWebImageAnimationOptions instead, or grab NSAnimationContext.currentContext and modify the timingFunction")]
		[Deprecated (PlatformName.MacOSX, 10, 10, message: "Use SDWebImageAnimationOptions instead, or grab NSAnimationContext.currentContext and modify the timingFunction")]
		[NoWatch, NoTV, NoiOS]
		[Export ("timingFunction", ArgumentSemantic.Strong)]
		CAMediaTimingFunction TimingFunction { get; set; }

		// @property (assign, nonatomic) SDWebImageAnimationOptions animationOptions;
		[Export ("animationOptions", ArgumentSemantic.Assign)]
		SDWebImageAnimationOptions AnimationOptions { get; set; }

		// @property (copy, nonatomic) SDWebImageTransitionPreparesBlock _Nullable prepares;
		[NullAllowed, Export ("prepares", ArgumentSemantic.Copy)]
		SDWebImageTransitionPreparesBlock Prepares { get; set; }

		// @property (copy, nonatomic) SDWebImageTransitionAnimationsBlock _Nullable animations;
		[NullAllowed, Export ("animations", ArgumentSemantic.Copy)]
		SDWebImageTransitionAnimationsBlock Animations { get; set; }

		// @property (copy, nonatomic) SDWebImageTransitionCompletionBlock _Nullable completion;
		[NullAllowed, Export ("completion", ArgumentSemantic.Copy)]
		SDWebImageTransitionCompletionBlock Completion { get; set; }
	}

	// @interface Conveniences (SDWebImageTransition)
	[Category]
	[BaseType (typeof(SDWebImageTransition))]
	interface SDWebImageTransition_Conveniences
	{
		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull fadeTransition;
		[Static]
		[Export ("fadeTransition")]
		SDWebImageTransition FadeTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull flipFromLeftTransition;
		[Static]
		[Export ("flipFromLeftTransition")]
		SDWebImageTransition FlipFromLeftTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull flipFromRightTransition;
		[Static]
		[Export ("flipFromRightTransition")]
		SDWebImageTransition FlipFromRightTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull flipFromTopTransition;
		[Static]
		[Export ("flipFromTopTransition")]
		SDWebImageTransition FlipFromTopTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull flipFromBottomTransition;
		[Static]
		[Export ("flipFromBottomTransition")]
		SDWebImageTransition FlipFromBottomTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull curlUpTransition;
		[Static]
		[Export ("curlUpTransition")]
		SDWebImageTransition CurlUpTransition { get; }

		// @property (readonly, nonatomic, class) SDWebImageTransition * _Nonnull curlDownTransition;
		[Static]
		[Export ("curlDownTransition")]
		SDWebImageTransition CurlDownTransition { get; }

		// +(instancetype _Nonnull)fadeTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("fade(duration:)")));
		[Static]
		[Export ("fadeTransitionWithDuration:")]
		SDWebImageTransition FadeTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)flipFromLeftTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("flipFromLeft(duration:)")));
		[Static]
		[Export ("flipFromLeftTransitionWithDuration:")]
		SDWebImageTransition FlipFromLeftTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)flipFromRightTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("flipFromRight(duration:)")));
		[Static]
		[Export ("flipFromRightTransitionWithDuration:")]
		SDWebImageTransition FlipFromRightTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)flipFromTopTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("flipFromTop(duration:)")));
		[Static]
		[Export ("flipFromTopTransitionWithDuration:")]
		SDWebImageTransition FlipFromTopTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)flipFromBottomTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("flipFromBottom(duration:)")));
		[Static]
		[Export ("flipFromBottomTransitionWithDuration:")]
		SDWebImageTransition FlipFromBottomTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)curlUpTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("curlUp(duration:)")));
		[Static]
		[Export ("curlUpTransitionWithDuration:")]
		SDWebImageTransition CurlUpTransitionWithDuration (double duration);

		// +(instancetype _Nonnull)curlDownTransitionWithDuration:(NSTimeInterval)duration __attribute__((swift_name("curlDown(duration:)")));
		[Static]
		[Export ("curlDownTransitionWithDuration:")]
		SDWebImageTransition CurlDownTransitionWithDuration (double duration);
	}

	// @interface ExtendedCacheData (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_ExtendedCacheData
	{
		// @property (nonatomic, strong) id<NSObject,NSCoding> _Nullable sd_extendedObject;
		[NullAllowed, Export ("sd_extendedObject", ArgumentSemantic.Strong)]
		NSObject<NSObject, NSCoding> Sd_extendedObject { get; set; }
	}

	// @interface ForceDecode (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_ForceDecode
	{
		// @property (assign, nonatomic) BOOL sd_isDecoded;
		[Export ("sd_isDecoded")]
		bool Sd_isDecoded { get; set; }

		// +(NSImage * _Nullable)sd_decodedImageWithImage:(NSImage * _Nullable)image;
		[Static]
		[Export ("sd_decodedImageWithImage:")]
		[return: NullAllowed]
		NSImage Sd_decodedImageWithImage ([NullAllowed] NSImage image);

		// +(NSImage * _Nullable)sd_decodedAndScaledDownImageWithImage:(NSImage * _Nullable)image;
		[Static]
		[Export ("sd_decodedAndScaledDownImageWithImage:")]
		[return: NullAllowed]
		NSImage Sd_decodedAndScaledDownImageWithImage ([NullAllowed] NSImage image);

		// +(NSImage * _Nullable)sd_decodedAndScaledDownImageWithImage:(NSImage * _Nullable)image limitBytes:(NSUInteger)bytes;
		[Static]
		[Export ("sd_decodedAndScaledDownImageWithImage:limitBytes:")]
		[return: NullAllowed]
		NSImage Sd_decodedAndScaledDownImageWithImage ([NullAllowed] NSImage image, nuint bytes);
	}

	// @interface GIF (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_GIF
	{
		// +(NSImage * _Nullable)sd_imageWithGIFData:(NSData * _Nullable)data;
		[Static]
		[Export ("sd_imageWithGIFData:")]
		[return: NullAllowed]
		NSImage Sd_imageWithGIFData ([NullAllowed] NSData data);
	}

	// @interface MemoryCacheCost (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_MemoryCacheCost
	{
		// @property (assign, nonatomic) NSUInteger sd_memoryCost;
		[Export ("sd_memoryCost")]
		nuint Sd_memoryCost { get; set; }
	}

	// @interface Metadata (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_Metadata
	{
		// @property (assign, nonatomic) NSUInteger sd_imageLoopCount;
		[Export ("sd_imageLoopCount")]
		nuint Sd_imageLoopCount { get; set; }

		// @property (readonly, assign, nonatomic) NSUInteger sd_imageFrameCount;
		[Export ("sd_imageFrameCount")]
		nuint Sd_imageFrameCount { get; }

		// @property (readonly, assign, nonatomic) BOOL sd_isAnimated;
		[Export ("sd_isAnimated")]
		bool Sd_isAnimated { get; }

		// @property (readonly, assign, nonatomic) BOOL sd_isVector;
		[Export ("sd_isVector")]
		bool Sd_isVector { get; }

		// @property (assign, nonatomic) SDImageFormat sd_imageFormat;
		[Export ("sd_imageFormat")]
		nint Sd_imageFormat { get; set; }

		// @property (assign, nonatomic) BOOL sd_isIncremental;
		[Export ("sd_isIncremental")]
		bool Sd_isIncremental { get; set; }

		// @property (assign, nonatomic) BOOL sd_isTransformed;
		[Export ("sd_isTransformed")]
		bool Sd_isTransformed { get; set; }

		// @property (readonly, assign, nonatomic) BOOL sd_isThumbnail;
		[Export ("sd_isThumbnail")]
		bool Sd_isThumbnail { get; }

		// @property (copy, nonatomic) SDImageCoderOptions * sd_decodeOptions;
		[Export ("sd_decodeOptions", ArgumentSemantic.Copy)]
		NSDictionary<NSString, NSObject> Sd_decodeOptions { get; set; }
	}

	// @interface MultiFormat (NSImage)
	[Category]
	[BaseType (typeof(NSImage))]
	interface NSImage_MultiFormat
	{
		// +(NSImage * _Nullable)sd_imageWithData:(NSData * _Nullable)data;
		[Static]
		[Export ("sd_imageWithData:")]
		[return: NullAllowed]
		NSImage Sd_imageWithData ([NullAllowed] NSData data);

		// +(NSImage * _Nullable)sd_imageWithData:(NSData * _Nullable)data scale:(CGFloat)scale;
		[Static]
		[Export ("sd_imageWithData:scale:")]
		[return: NullAllowed]
		NSImage Sd_imageWithData ([NullAllowed] NSData data, nfloat scale);

		// +(NSImage * _Nullable)sd_imageWithData:(NSData * _Nullable)data scale:(CGFloat)scale firstFrameOnly:(BOOL)firstFrameOnly;
		[Static]
		[Export ("sd_imageWithData:scale:firstFrameOnly:")]
		[return: NullAllowed]
		NSImage Sd_imageWithData ([NullAllowed] NSData data, nfloat scale, bool firstFrameOnly);

		// -(NSData * _Nullable)sd_imageData;
		[NullAllowed, Export ("sd_imageData")]
		[Verify (MethodToProperty)]
		NSData Sd_imageData { get; }

		// -(NSData * _Nullable)sd_imageDataAsFormat:(SDImageFormat)imageFormat __attribute__((swift_name("sd_imageData(as:)")));
		[Export ("sd_imageDataAsFormat:")]
		[return: NullAllowed]
		NSData Sd_imageDataAsFormat (nint imageFormat);

		// -(NSData * _Nullable)sd_imageDataAsFormat:(SDImageFormat)imageFormat compressionQuality:(double)compressionQuality __attribute__((swift_name("sd_imageData(as:compressionQuality:)")));
		[Export ("sd_imageDataAsFormat:compressionQuality:")]
		[return: NullAllowed]
		NSData Sd_imageDataAsFormat (nint imageFormat, double compressionQuality);

		// -(NSData * _Nullable)sd_imageDataAsFormat:(SDImageFormat)imageFormat compressionQuality:(double)compressionQuality firstFrameOnly:(BOOL)firstFrameOnly __attribute__((swift_name("sd_imageData(as:compressionQuality:firstFrameOnly:)")));
		[Export ("sd_imageDataAsFormat:compressionQuality:firstFrameOnly:")]
		[return: NullAllowed]
		NSData Sd_imageDataAsFormat (nint imageFormat, double compressionQuality, bool firstFrameOnly);
	}

	// @interface WebCache (NSImageView)
	[Category]
	[BaseType (typeof(NSImageView))]
	interface NSImageView_WebCache
	{
		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url __attribute__((swift_private));
		[Export ("sd_setImageWithURL:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:options:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder completed:(SDExternalCompletionBlock _Nullable)completedBlock __attribute__((swift_private));
		[Export ("sd_setImageWithURL:placeholderImage:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);

		// -(void)sd_setImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDExternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_setImageWithURL:placeholderImage:options:context:progress:completed:")]
		void Sd_setImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDExternalCompletionBlock completedBlock);
	}

	[Static]
	[Verify (ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern const int64_t SDWebImageProgressUnitCountUnknown;
		[Field ("SDWebImageProgressUnitCountUnknown")]
		long SDWebImageProgressUnitCountUnknown { get; }
	}

	// typedef void (^SDSetImageBlock)(NSImage * _Nullable, NSData * _Nullable, SDImageCacheType, NSURL * _Nullable);
	delegate void SDSetImageBlock ([NullAllowed] NSImage arg0, [NullAllowed] NSData arg1, SDImageCacheType arg2, [NullAllowed] NSUrl arg3);

	// @interface WebCache (NSView)
	[Category]
	[BaseType (typeof(NSView))]
	interface NSView_WebCache
	{
		// @property (readonly, nonatomic, strong) NSURL * _Nullable sd_imageURL;
		[NullAllowed, Export ("sd_imageURL", ArgumentSemantic.Strong)]
		NSUrl Sd_imageURL { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable sd_latestOperationKey;
		[NullAllowed, Export ("sd_latestOperationKey", ArgumentSemantic.Strong)]
		string Sd_latestOperationKey { get; }

		// @property (nonatomic, strong, null_resettable) NSProgress * _Null_unspecified sd_imageProgress;
		[NullAllowed, Export ("sd_imageProgress", ArgumentSemantic.Strong)]
		NSProgress Sd_imageProgress { get; set; }

		// -(id<SDWebImageOperation> _Nullable)sd_internalSetImageWithURL:(NSURL * _Nullable)url placeholderImage:(NSImage * _Nullable)placeholder options:(SDWebImageOptions)options context:(SDWebImageContext * _Nullable)context setImageBlock:(SDSetImageBlock _Nullable)setImageBlock progress:(SDImageLoaderProgressBlock _Nullable)progressBlock completed:(SDInternalCompletionBlock _Nullable)completedBlock;
		[Export ("sd_internalSetImageWithURL:placeholderImage:options:context:setImageBlock:progress:completed:")]
		[return: NullAllowed]
		SDWebImageOperation Sd_internalSetImageWithURL ([NullAllowed] NSUrl url, [NullAllowed] NSImage placeholder, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context, [NullAllowed] SDSetImageBlock setImageBlock, [NullAllowed] SDImageLoaderProgressBlock progressBlock, [NullAllowed] SDInternalCompletionBlock completedBlock);

		// -(void)sd_cancelCurrentImageLoad;
		[Export ("sd_cancelCurrentImageLoad")]
		void Sd_cancelCurrentImageLoad ();

		// @property (nonatomic, strong) SDWebImageTransition * _Nullable sd_imageTransition;
		[NullAllowed, Export ("sd_imageTransition", ArgumentSemantic.Strong)]
		SDWebImageTransition Sd_imageTransition { get; set; }

		// @property (nonatomic, strong) id<SDWebImageIndicator> _Nullable sd_imageIndicator;
		[NullAllowed, Export ("sd_imageIndicator", ArgumentSemantic.Strong)]
		SDWebImageIndicator Sd_imageIndicator { get; set; }
	}

	// @interface WebCacheOperation (NSView)
	[Category]
	[BaseType (typeof(NSView))]
	interface NSView_WebCacheOperation
	{
		// -(id<SDWebImageOperation> _Nullable)sd_imageLoadOperationForKey:(NSString * _Nullable)key;
		[Export ("sd_imageLoadOperationForKey:")]
		[return: NullAllowed]
		SDWebImageOperation Sd_imageLoadOperationForKey ([NullAllowed] string key);

		// -(void)sd_setImageLoadOperation:(id<SDWebImageOperation> _Nullable)operation forKey:(NSString * _Nullable)key;
		[Export ("sd_setImageLoadOperation:forKey:")]
		void Sd_setImageLoadOperation ([NullAllowed] SDWebImageOperation operation, [NullAllowed] string key);

		// -(void)sd_cancelImageLoadOperationWithKey:(NSString * _Nullable)key;
		[Export ("sd_cancelImageLoadOperationWithKey:")]
		void Sd_cancelImageLoadOperationWithKey ([NullAllowed] string key);

		// -(void)sd_removeImageLoadOperationWithKey:(NSString * _Nullable)key;
		[Export ("sd_removeImageLoadOperationWithKey:")]
		void Sd_removeImageLoadOperationWithKey ([NullAllowed] string key);
	}
}
