XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/texture
PROJECT=$(PROJECT_ROOT)/AsyncDisplayKit.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET=AsyncDisplayKit
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORK_PATH=Products/Library/Frameworks/AsyncDisplayKit.framework
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
IOS_SDK=iphoneos16.1
BINDING_PROJECT_IOS=$(ROOT)/Texture.Binding/Texture.Binding

all: iossimulator iosdevice maccatalyst xcframework

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET) -configuration Release -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET) -configuration Release -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET) -configuration Release -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/AsyncDisplayKit.xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/simulator.xcarchive/$(FRAMEWORK_PATH)  -framework $(BUILD_ROOT)/iOS.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/catalyst.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/AsyncDisplayKit.xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	mv $(BUILD_ROOT)/AsyncDisplayKit.xcframework $(FRAMEWORKS)/AsyncDisplayKit.xcframework

dotnet:
	dotnet build
	dotnet pack --configuration:Release

sharpie:
	rm -rf $(BINDING_PROJECT_IOS)
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_PROJECT_IOS)" --namespace="Drastic.Texture" --scope="$(PROJECT_ROOT)/Source/Base" --scope="$(PROJECT_ROOT)/Source" $(PROJECT_ROOT)/Source/*.h