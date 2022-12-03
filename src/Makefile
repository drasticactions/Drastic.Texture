XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/SDWebImage
PROJECT=$(PROJECT_ROOT)/SDWebImage.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS=SDWebImage
TARGET_MAC=SDWebImage
TARGET_TVOS=SDWebImage
PROJECTNAME=SDWebImage
OUTPUT=$(ROOT)/Build
FRAMEWORK_PATH=Products/Library/Frameworks/SDWebImage.framework
BINDING_PROJECT_IOS=$(ROOT)/SDWebImage.Binding/SDWebImage.Binding
BINDING_PROJECT_MACOS=$(ROOT)/SDWebImage.Binding/SDWebImage.Binding.Mac
FRAMEWORKS=$(ROOT)/Frameworks
FRAMEWORKS_IOS=$(ROOT)/Frameworks/ios
FRAMEWORKS_MAC=$(ROOT)/Frameworks/mac
FRAMEWORKS_TVOS=$(ROOT)/Frameworks/tvos
IOS_SDK=iphoneos16.1
MAC_SDK=macosx13.0

all: iossimulator iosdevice maccatalyst tvossimulator tvosdevice mac xcframework dotnet

build: iossimulator iosdevice maccatalyst tvossimulator tvosdevice mac xcframework dotnet

pack: build nuget

iossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS Simulator" -archivePath $(BUILD_ROOT)/simulator.xcarchive -sdk iphonesimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

iosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=iOS" -archivePath $(BUILD_ROOT)/iOS.xcarchive -sdk iphoneos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

maccatalyst:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_IOS) -destination "generic/platform=macOS,variant=Mac Catalyst,name=Any Mac" -archivePath $(BUILD_ROOT)/catalyst.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

tvossimulator:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_TVOS) -destination "generic/platform=tvOS Simulator,name=Any tvOS Simulator Device" -archivePath $(BUILD_ROOT)/tvsimulator.xcarchive -sdk appletvsimulator SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

tvosdevice:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_TVOS) -destination "generic/platform=tvOS,name=Any tvOS Device" -archivePath $(BUILD_ROOT)/tvos.xcarchive -sdk appletvos SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

mac:
	$(XBUILD) archive ONLY_ACTIVE_ARCH=NO -project $(PROJECT) -scheme $(TARGET_MAC) -destination "generic/platform=macOS,name=Any Mac" -archivePath $(BUILD_ROOT)/mac.xcarchive SKIP_INSTALL=NO BUILD_LIBRARY_FOR_DISTRIBUTION=YES

xcframework:
	rm -rf $(BUILD_ROOT)/SDWebImage.xcframework
	$(XBUILD) -create-xcframework -framework $(BUILD_ROOT)/simulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/tvsimulator.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/tvos.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/mac.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/iOS.xcarchive/$(FRAMEWORK_PATH) -framework $(BUILD_ROOT)/catalyst.xcarchive/$(FRAMEWORK_PATH) -output $(BUILD_ROOT)/SDWebImage.xcframework
	rm -rf $(FRAMEWORKS)
	mkdir -p $(FRAMEWORKS)
	mv $(BUILD_ROOT)/SDWebImage.xcframework $(FRAMEWORKS)/SDWebImage.xcframework

dotnet:
	dotnet build

nuget:
	dotnet pack --configuration Release

sharpie_ios:
	rm -rf $(BINDING_PROJECT_IOS)
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_PROJECT_IOS)" --namespace="Drastic.SDWebImage" --scope="$(FRAMEWORKS)/SDWebImage.xcframework/ios-arm64/SDWebImage.framework/Headers" $(FRAMEWORKS)/SDWebImage.xcframework/ios-arm64/SDWebImage.framework/Headers/*.h

sharpie_mac:
	rm -rf $(BINDING_PROJECT_MACOS)
	sharpie bind --sdk=$(MAC_SDK) --output="$(BINDING_PROJECT_MACOS)" --namespace="Drastic.SDWebImage" --scope="$(FRAMEWORKS)/SDWebImage.xcframework/macos-arm64_x86_64/SDWebImage.framework/Headers" $(FRAMEWORKS)/SDWebImage.xcframework/macos-arm64_x86_64/SDWebImage.framework/Headers/*.h