using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using SDWebImage;
using UIKit;

namespace Drastic.SDWebImage
{
	[Native]
	public enum SDAnimatedImagePlaybackMode : ulong
	{
		Normal = 0,
		Reverse,
		Bounce,
		ReversedBounce
	}

	static class CFunctions
	{
		// extern CGFloat SDImageScaleFactorForKey (NSString * _Nullable key);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern nfloat SDImageScaleFactorForKey ([NullAllowed] NSString key);

		// extern UIImage * _Nullable SDScaledImageForKey (NSString * _Nullable key, UIImage * _Nullable image);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDScaledImageForKey ([NullAllowed] NSString key, [NullAllowed] UIImage image);

		// extern UIImage * _Nullable SDScaledImageForScaleFactor (CGFloat scale, UIImage * _Nullable image);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDScaledImageForScaleFactor (nfloat scale, [NullAllowed] UIImage image);

		// extern UIImage * _Nullable SDImageCacheDecodeImageData (NSData * _Nonnull imageData, NSString * _Nonnull cacheKey, SDWebImageOptions options, SDWebImageContext * _Nullable context);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDImageCacheDecodeImageData (NSData imageData, NSString cacheKey, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// extern SDImageCoderOptions * _Nonnull SDGetDecodeOptionsFromContext (SDWebImageContext * _Nullable context, SDWebImageOptions options, NSString * _Nonnull cacheKey);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern NSDictionary<NSString, NSObject> SDGetDecodeOptionsFromContext ([NullAllowed] NSDictionary<NSString, NSObject> context, SDWebImageOptions options, NSString cacheKey);

		// extern void SDSetDecodeOptionsToContext (SDWebImageMutableContext * _Nonnull mutableContext, SDWebImageOptions * _Nonnull mutableOptions, SDImageCoderOptions * _Nonnull decodeOptions);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern unsafe void SDSetDecodeOptionsToContext (NSMutableDictionary<NSString, NSObject> mutableContext, SDWebImageOptions* mutableOptions, NSDictionary<NSString, NSObject> decodeOptions);

		// extern UIImage * _Nullable SDImageLoaderDecodeImageData (NSData * _Nonnull imageData, NSURL * _Nonnull imageURL, SDWebImageOptions options, SDWebImageContext * _Nullable context);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDImageLoaderDecodeImageData (NSData imageData, NSUrl imageURL, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// extern UIImage * _Nullable SDImageLoaderDecodeProgressiveImageData (NSData * _Nonnull imageData, NSURL * _Nonnull imageURL, BOOL finished, id<SDWebImageOperation> _Nonnull operation, SDWebImageOptions options, SDWebImageContext * _Nullable context);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDImageLoaderDecodeProgressiveImageData (NSData imageData, NSUrl imageURL, bool finished, SDWebImageOperation operation, SDWebImageOptions options, [NullAllowed] NSDictionary<NSString, NSObject> context);

		// extern id<SDProgressiveImageCoder> _Nullable SDImageLoaderGetProgressiveCoder (id<SDWebImageOperation> _Nonnull operation);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern SDProgressiveImageCoder SDImageLoaderGetProgressiveCoder (SDWebImageOperation operation);

		// extern void SDImageLoaderSetProgressiveCoder (id<SDWebImageOperation> _Nonnull operation, id<SDProgressiveImageCoder> _Nullable progressiveCoder);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SDImageLoaderSetProgressiveCoder (SDWebImageOperation operation, [NullAllowed] SDProgressiveImageCoder progressiveCoder);

		// extern NSString * _Nullable SDTransformedKeyForKey (NSString * _Nullable key, NSString * _Nonnull transformerKey);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern NSString SDTransformedKeyForKey ([NullAllowed] NSString key, NSString transformerKey);

		// extern NSString * _Nullable SDThumbnailedKeyForKey (NSString * _Nullable key, CGSize thumbnailPixelSize, BOOL preserveAspectRatio);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern NSString SDThumbnailedKeyForKey ([NullAllowed] NSString key, CGSize thumbnailPixelSize, bool preserveAspectRatio);

		// extern CGContextRef _Nullable SDGraphicsGetCurrentContext () __attribute__((cf_returns_not_retained));
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern CGContext SDGraphicsGetCurrentContext ();

		// extern void SDGraphicsBeginImageContext (CGSize size);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SDGraphicsBeginImageContext (CGSize size);

		// extern void SDGraphicsBeginImageContextWithOptions (CGSize size, BOOL opaque, CGFloat scale);
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SDGraphicsBeginImageContextWithOptions (CGSize size, bool opaque, nfloat scale);

		// extern void SDGraphicsEndImageContext ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		static extern void SDGraphicsEndImageContext ();

		// extern UIImage * _Nullable SDGraphicsGetImageFromCurrentImageContext ();
		[DllImport ("__Internal")]
		[Verify (PlatformInvoke)]
		[return: NullAllowed]
		static extern UIImage SDGraphicsGetImageFromCurrentImageContext ();
	}

	[Flags]
	[Native]
	public enum SDWebImageOptions : ulong
	{
		RetryFailed = 1uL << 0,
		LowPriority = 1uL << 1,
		ProgressiveLoad = 1uL << 2,
		RefreshCached = 1uL << 3,
		ContinueInBackground = 1uL << 4,
		HandleCookies = 1uL << 5,
		AllowInvalidSSLCertificates = 1uL << 6,
		HighPriority = 1uL << 7,
		DelayPlaceholder = 1uL << 8,
		TransformAnimatedImage = 1uL << 9,
		AvoidAutoSetImage = 1uL << 10,
		ScaleDownLargeImages = 1uL << 11,
		QueryMemoryData = 1uL << 12,
		QueryMemoryDataSync = 1uL << 13,
		QueryDiskDataSync = 1uL << 14,
		FromCacheOnly = 1uL << 15,
		FromLoaderOnly = 1uL << 16,
		ForceTransition = 1uL << 17,
		AvoidDecodeImage = 1uL << 18,
		DecodeFirstFrameOnly = 1uL << 19,
		PreloadAllFrames = 1uL << 20,
		MatchAnimatedImageClass = 1uL << 21,
		WaitStoreCache = 1uL << 22,
		TransformVectorImage = 1uL << 23
	}

	[Native]
	public enum SDImageCacheType : long
	{
		None,
		Disk,
		Memory,
		All
	}

	[Native]
	public enum SDImageScaleMode : ulong
	{
		Fill = 0,
		AspectFit = 1,
		AspectFill = 2
	}

	[Native]
	public enum SDGraphicsImageRendererFormatRange : long
	{
		Unspecified = -1,
		Automatic = 0,
		Extended,
		Standard
	}

	[Native]
	public enum SDImageCacheConfigExpireType : ulong
	{
		AccessDate,
		ModificationDate,
		CreationDate,
		ChangeDate
	}

	[Flags]
	[Native]
	public enum SDImageCacheOptions : ulong
	{
		QueryMemoryData = 1uL << 0,
		QueryMemoryDataSync = 1uL << 1,
		QueryDiskDataSync = 1uL << 2,
		ScaleDownLargeImages = 1uL << 3,
		AvoidDecodeImage = 1uL << 4,
		DecodeFirstFrameOnly = 1uL << 5,
		PreloadAllFrames = 1uL << 6,
		MatchAnimatedImageClass = 1uL << 7
	}

	[Native]
	public enum SDImageCachesManagerOperationPolicy : ulong
	{
		Serial,
		Concurrent,
		HighestOnly,
		LowestOnly
	}

	[Native]
	public enum SDImageCoderDecodeSolution : ulong
	{
		Automatic,
		CoreGraphics,
		UIKit
	}

	[Native]
	public enum SDWebImageDownloaderExecutionOrder : long
	{
		FIFOExecutionOrder,
		LIFOExecutionOrder
	}

	[Flags]
	[Native]
	public enum SDWebImageDownloaderOptions : ulong
	{
		LowPriority = 1uL << 0,
		ProgressiveLoad = 1uL << 1,
		UseNSURLCache = 1uL << 2,
		IgnoreCachedResponse = 1uL << 3,
		ContinueInBackground = 1uL << 4,
		HandleCookies = 1uL << 5,
		AllowInvalidSSLCertificates = 1uL << 6,
		HighPriority = 1uL << 7,
		ScaleDownLargeImages = 1uL << 8,
		AvoidDecodeImage = 1uL << 9,
		DecodeFirstFrameOnly = 1uL << 10,
		PreloadAllFrames = 1uL << 11,
		MatchAnimatedImageClass = 1uL << 12
	}

	[Native]
	public enum SDWebImageError : long
	{
		InvalidURL = 1000,
		BadImageData = 1001,
		CacheNotModified = 1002,
		BlackListed = 1003,
		InvalidDownloadOperation = 2000,
		InvalidDownloadStatusCode = 2001,
		Cancelled = 2002,
		InvalidDownloadResponse = 2003,
		InvalidDownloadContentType = 2004
	}
}
