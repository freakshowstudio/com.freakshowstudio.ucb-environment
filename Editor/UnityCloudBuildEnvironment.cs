
using System;


namespace UcbEnvironment.Editor
{
    public static class UnityCloudBuildEnvironment
    {
        private static string GetVar(string name) => 
            Environment.GetEnvironmentVariable(name) ?? "<UNKNOWN>";

        private static void SetVar(string name, string value) => 
            Environment.SetEnvironmentVariable(name, value);

        // System

        /// <summary>
        /// Local path to the Android Lib
        /// </summary>
        public static string AndroidHome
        {
            get => GetVar("ANDROID_HOME");
            set => SetVar("ANDROID_HOME", value);
        }

        /// <summary>
        /// Local path to the Android NDK Root directory
        /// </summary>
        public static string AndroidNdkRoot
        {
            get => GetVar("ANDROID_NDK_ROOT");
            set => SetVar("ANDROID_NDK_ROOT", value);
        }

        /// <summary>
        /// The operating system type that the build is running on. MAC or
        /// WINDOWS.
        /// </summary>
        public static string BuilderOS
        {
            get => GetVar("BUILDER_OS");
            set => SetVar("BUILDER_OS", value);
        }

        /// <summary>
        /// The local path to the Cloud Content Delivery binary executable
        /// </summary>
        public static string CcdBinaryPath
        {
            get => GetVar("CCD_BINARY_PATH");
            set => SetVar("CCD_BINARY_PATH", value);
        }

        /// <summary>
        /// The homedrive location
        /// </summary>
        public static string HomeDrive
        {
            get => GetVar("HOMEDRIVE");
            set => SetVar("HOMEDRIVE", value);
        }

        /// <summary>
        /// Relative path to the home directory
        /// </summary>
        public static string HomePath
        {
            get => GetVar("HOMEPATH");
            set => SetVar("HOMEPATH", value);
        }

        /// <summary>
        /// The path to the directory containing the output
        /// of the build process
        /// </summary>
        public static string OutputDirectory
        {
            get => GetVar("OUTPUT_DIRECTORY");
            set => SetVar("OUTPUT_DIRECTORY", value);
        }

        /// <summary>
        /// The path to the Plastic CLI.
        ///
        /// If you use a Windows environment, you may want to convert
        /// to the Cygwin path to ensure that the path is valid.
        /// </summary>
        public static string PlasticCmPath
        {
            get => GetVar("PLASTIC_CM_PATH");
            set => SetVar("PLASTIC_CM_PATH", value);
        }

        /// <summary>
        /// The path to the Plastic CLI config files
        /// </summary>
        public static string PlasticCmConfigDirectory
        {
            get => GetVar("PLASTIC_CM_CONFIG_DIRECTORY");
            set => SetVar("PLASTIC_CM_CONFIG_DIRECTORY", value);
        }

        /// <summary>
        /// The host of the Build Service API (e.g.
        /// usersvc-live.cloud.unity3d.com)
        /// </summary>
        public static string PlatformHost
        {
            get => GetVar("PLATFORM_HOST");
            set => SetVar("PLATFORM_HOST", value);
        }

        /// <summary>
        /// The path to the root directory of the project to build
        /// </summary>
        public static string ProjectDirectory
        {
            get => GetVar("PROJECT_DIRECTORY");
            set => SetVar("PROJECT_DIRECTORY", value);
        }

        /// <summary>
        /// Max number of retries that will be attempted when checking
        /// out source code
        /// </summary>
        public static string ScmMaxRetries
        {
            get => GetVar("SCM_MAX_RETRIES");
            set => SetVar("SCM_MAX_RETRIES", value);
        }

        /// <summary>
        /// The location of the Unity engine executable
        /// </summary>
        public static string UnityExe
        {
            get => GetVar("UNITY_EXE");
            set => SetVar("UNITY_EXE", value);
        }

        /// <summary>
        /// Url of the Unity Package Manager
        /// </summary>
        public static string UpmRegistry
        {
            get => GetVar("UPM_REGISTRY");
            set => SetVar("UPM_REGISTRY", value);
        }

        /// <summary>
        /// When set to true, will start a UPM Server on the agent
        /// </summary>
        public static string UpmServerEnabled
        {
            get => GetVar("UPM_SERVER_ENABLED");
            set => SetVar("UPM_SERVER_ENABLED", value);
        }

        /// <summary>
        /// Path to the Unity Package Manager Server executable
        /// </summary>
        public static string UpmServerExe
        {
            get => GetVar("UPM_SERVER_EXE");
            set => SetVar("UPM_SERVER_EXE", value);
        }

        /// <summary>
        /// Port that the UPM Server runs at
        /// </summary>
        public static string UpmServerPort
        {
            get => GetVar("UPM_SERVER_PORT");
            set => SetVar("UPM_SERVER_PORT", value);
        }

        /// <summary>
        /// The user home location on the OS
        /// </summary>
        public static string UserProfile
        {
            get => GetVar("USERPROFILE");
            set => SetVar("USERPROFILE", value);
        }

        /// <summary>
        /// When set to true, excludes StreamingAssets from WebGL archive
        /// </summary>
        public static string WebglStreamingEnabled
        {
            get => GetVar("WEBGL_STREAMING_ENABLED");
            set => SetVar("WEBGL_STREAMING_ENABLED", value);
        }

        /// <summary>
        /// The local path on the agent where all folders for a given
        /// build target are created
        /// </summary>
        public static string Workspace
        {
            get => GetVar("WORKSPACE");
            set => SetVar("WORKSPACE", value);
        }


        // Build

        /// <summary>
        /// When set to "true", enables error backtracing to be logged
        /// </summary>
        public static string BacktraceEnabled
        {
            get => GetVar("BACKTRACE_ENABLED");
            set => SetVar("BACKTRACE_ENABLED", value);
        }

        /// <summary>
        /// The type of target being built
        /// </summary>
        public static string BuildPlatform
        {
            get => GetVar("BUILD_PLATFORM");
            set => SetVar("BUILD_PLATFORM", value);
        }

        /// <summary>
        /// The ID of the UCB build-target
        /// </summary>
        public static string BuildTarget
        {
            get => GetVar("BUILD_TARGET");
            set => SetVar("BUILD_TARGET", value);
        }

        /// <summary>
        /// The current revision of the source code that is going to be built
        /// </summary>
        public static string BuildRevision
        {
            get => GetVar("BUILD_REVISION");
            set => SetVar("BUILD_REVISION", value);
        }

        /// <summary>
        /// The local path to the build config file
        /// </summary>
        public static string BuildCfgFile
        {
            get => GetVar("BUILDCFG_FILE");
            set => SetVar("BUILDCFG_FILE", value);
        }

        /// <summary>
        /// The name (or id) of the target being built
        /// </summary>
        public static string BuildCfgTarget
        {
            get => GetVar("BUILDCFG_TARGET");
            set => SetVar("BUILDCFG_TARGET", value);
        }

        /// <summary>
        /// The type of files to cache when a build completes
        /// (library/workspace)
        /// </summary>
        public static string BuildJobCache
        {
            get => GetVar("BUILDJOB_CACHE");
            set => SetVar("BUILDJOB_CACHE", value);
        }

        /// <summary>
        /// When set to true will not pull cached data and will force clean
        /// checkout
        /// </summary>
        public static string CleanBuild
        {
            get => GetVar("CLEAN_BUILD");
            set => SetVar("CLEAN_BUILD", value);
        }

        /// <summary>
        /// Set to true when running on a build agent, false when local
        /// </summary>
        public static string IsBuilder
        {
            get => GetVar("IS_BUILDER");
            set => SetVar("IS_BUILDER", value);
        }

        /// <summary>
        /// Set to '1' when verbose option is passed to Xcode projects
        /// </summary>
        public static string LogVerbose
        {
            get => GetVar("LOG_VERBOSE");
            set => SetVar("LOG_VERBOSE", value);
        }

        /// <summary>
        /// The id of the UCB organization
        /// </summary>
        public static string OrgId
        {
            get => GetVar("ORG_ID");
            set => SetVar("ORG_ID", value);
        }

        /// <summary>
        /// Primary artifact for this build will be re-signed (only set when
        /// re-signing)
        /// </summary>
        public static string ParentBuildGuid
        {
            get => GetVar("PARENT_BUILD_GUID");
            set => SetVar("PARENT_BUILD_GUID", value);
        }

        /// <summary>
        /// The last revision of the target that was built successfully
        /// </summary>
        public static string PreviousSuccessfulBuildRevision
        {
            get => GetVar("PREVIOUS_SUCCESSFUL_BUILD_REVISION");
            set => SetVar("PREVIOUS_SUCCESSFUL_BUILD_REVISION", value);
        }

        /// <summary>
        /// The id of the UCB project
        /// </summary>
        public static string ProjectId
        {
            get => GetVar("PROJECT_ID");
            set => SetVar("PROJECT_ID", value);
        }

        /// <summary>
        /// The name of the branch to build
        /// </summary>
        public static string ScmBranch
        {
            get => GetVar("SCM_BRANCH");
            set => SetVar("SCM_BRANCH", value);
        }

        /// <summary>
        /// Specific commit hash to checkout (only set when specified)
        /// </summary>
        public static string ScmRevision
        {
            get => GetVar("SCM_REVISION");
            set => SetVar("SCM_REVISION", value);
        }

        /// <summary>
        /// The host url for a Source Control Manager
        /// </summary>
        public static string ScmHost
        {
            get => GetVar("SCM_HOST");
            set => SetVar("SCM_HOST", value);
        }

        /// <summary>
        /// The username for checking out code from an SCM
        /// </summary>
        public static string ScmUser
        {
            get => GetVar("SCM_USER");
            set => SetVar("SCM_USER", value);
        }

        /// <summary>
        /// When set to '1' will skip uploading the built artifacts to UCB
        /// </summary>
        public static string SkipUploadArtifacts
        {
            get => GetVar("SKIP_UPLOAD_ARTIFACTS");
            set => SetVar("SKIP_UPLOAD_ARTIFACTS", value);
        }

        /// <summary>
        /// Build Number for the specific target being built
        /// </summary>
        public static string UcbBuildNumber
        {
            get => GetVar("UCB_BUILD_NUMBER");
            set => SetVar("UCB_BUILD_NUMBER", value);
        }

        /// <summary>
        /// The local path to the Xcode Archives file
        /// </summary>
        public static string XcArchivePath
        {
            get => GetVar("XCARCHIVE_PATH");
            set => SetVar("XCARCHIVE_PATH", value);
        }


        // Cloud Content Delivery

        /// <summary>
        /// ID of the bucket to upload the content to
        /// </summary>
        public static string CcdBucketId
        {
            get => GetVar("CCD_BUCKET_ID");
            set => SetVar("CCD_BUCKET_ID", value);
        }

        /// <summary>
        /// When set to "true" will create a release from the latest bucket
        /// </summary>
        public static string CcdCreateRelease
        {
            get => GetVar("CCD_CREATE_RELEASE");
            set => SetVar("CCD_CREATE_RELEASE", value);
        }

        /// <summary>
        /// When set to "true", will use Cloud Content Delivery
        /// </summary>
        public static string CcdEnabled
        {
            get => GetVar("CCD_ENABLED");
            set => SetVar("CCD_ENABLED", value);
        }

        /// <summary>
        /// When set to true will not delete existing bucket contents
        /// </summary>
        public static string CcdPreserveBucket
        {
            get => GetVar("CCD_PRESERVE_BUCKET");
            set => SetVar("CCD_PRESERVE_BUCKET", value);
        }

        /// <summary>
        /// When set to 'true' will upload files directly to root instead of
        /// folder level
        /// </summary>
        public static string CcdStripRemotePath
        {
            get => GetVar("CCD_STRIP_REMOTE_PATH");
            set => SetVar("CCD_STRIP_REMOTE_PATH", value);
        }


        // Fastlane

        /// <summary>
        /// The App Store Connect / Apple Developer Portal user for fastlane
        /// </summary>
        public static string FastlaneUser
        {
            get => GetVar("FASTLANE_USER");
            set => SetVar("FASTLANE_USER", value);
        }

        /// <summary>
        /// When set to 'true' will enable verbose logging for fastlane
        /// </summary>
        public static string FastlaneVerbose
        {
            get => GetVar("FASTLANE_VERBOSE");
            set => SetVar("FASTLANE_VERBOSE", value);
        }

        /// <summary>
        /// WWDR team id for the provider
        /// </summary>
        public static string FlNotarizeAscProvider
        {
            get => GetVar("FL_NOTARIZE_ASC_PROVIDER");
            set => SetVar("FL_NOTARIZE_ASC_PROVIDER", value);
        }

        /// <summary>
        /// When using Xcode 13 and set to true, use the Xcode notary tool
        /// </summary>
        public static string FlNotarizeUseNotarytool
        {
            get => GetVar("FL_NOTARIZE_USE_NOTARYTOOL");
            set => SetVar("FL_NOTARIZE_USE_NOTARYTOOL", value);
        }

        /// <summary>
        /// The App Store Connect / Apple Developer Portal user
        /// for notarization
        /// </summary>
        public static string FlNotarizeUsername
        {
            get => GetVar("FL_NOTARIZE_USERNAME");
            set => SetVar("FL_NOTARIZE_USERNAME", value);
        }


        // Perforce

        /// <summary>
        /// When set to "true" will run a deleteclient when checking out from
        /// Perforce
        /// </summary>
        public static string P4CleanupClient
        {
            get => GetVar("P4_CLEANUPCLIENT");
            set => SetVar("P4_CLEANUPCLIENT", value);
        }

        /// <summary>
        /// When set to "true" Perforce will use SSL when communicating
        /// </summary>
        public static string P4Ssl
        {
            get => GetVar("P4_SSL");
            set => SetVar("P4_SSL", value);
        }

        /// <summary>
        /// The Perforce Client to use
        /// </summary>
        public static string P4Client
        {
            get => GetVar("P4CLIENT");
            set => SetVar("P4CLIENT", value);
        }

        /// <summary>
        /// The port that the Perforce SCM is running on
        /// </summary>
        public static string P4Port
        {
            get => GetVar("P4PORT");
            set => SetVar("P4PORT", value);
        }

        /// <summary>
        /// The username to checkout code from Perforce with
        /// </summary>
        public static string P4User
        {
            get => GetVar("P4USER");
            set => SetVar("P4USER", value);
        }


        // UVCS (Plastic SCM)

        /// <summary>
        /// The method used to authenticate with Plastic SCM
        /// </summary>
        public static string PlasticAuthType
        {
            get => GetVar("PLASTIC_AUTH_TYPE");
            set => SetVar("PLASTIC_AUTH_TYPE", value);
        }

        /// <summary>
        /// The type of encryption on the Plastic SCM
        /// </summary>
        public static string PlasticEncryptionMethod
        {
            get => GetVar("PLASTIC_ENCRYPTION_METHOD");
            set => SetVar("PLASTIC_ENCRYPTION_METHOD", value);
        }


        // Unity

        /// <summary>
        /// Set to "No" which disables the THS XML Serializer for Mono builds
        /// </summary>
        public static string MonoXmlSerializerThs
        {
            get => GetVar("MONO_XMLSERIALIZER_THS");
            set => SetVar("MONO_XMLSERIALIZER_THS", value);
        }

        /// <summary>
        /// Extra parameters passed to Unity Editor in batch mode
        /// </summary>
        public static string UnityExtraParams
        {
            get => GetVar("UNITY_EXTRA_PARAMS");
            set => SetVar("UNITY_EXTRA_PARAMS", value);
        }

        /// <summary>
        /// The local path to the Unity Player
        /// </summary>
        public static string UnityPlayerPath
        {
            get => GetVar("UNITY_PLAYER_PATH");
            set => SetVar("UNITY_PLAYER_PATH", value);
        }

        /// <summary>
        /// The local path to the Unity Player Data file (Windows/Mac)
        /// </summary>
        public static string UnityPlayerPathData
        {
            get => GetVar("UNITY_PLAYER_PATH_DATA");
            set => SetVar("UNITY_PLAYER_PATH_DATA", value);
        }

        /// <summary>
        /// The local path to the Unity Player Debug Symbols for Android builds
        /// </summary>
        public static string UnityPlayerPathDebugSymbols
        {
            get => GetVar("UNITY_PLAYER_PATH_DEBUG_SYMBOLS");
            set => SetVar("UNITY_PLAYER_PATH_DEBUG_SYMBOLS", value);
        }

        /// <summary>
        /// The local path to the Unity Player Debug Symbols for iOS builds
        /// </summary>
        public static string UnityPlayerPathDsym
        {
            get => GetVar("UNITY_PLAYER_PATH_DSYM");
            set => SetVar("UNITY_PLAYER_PATH_DSYM", value);
        }

        /// <summary>
        /// The number of retry attempts when compiling shaders in Unity
        /// </summary>
        public static string UnityShaderCompilerRetryCount
        {
            get => GetVar("UNITY_SHADER_COMPILER_RETRY_COUNT");
            set => SetVar("UNITY_SHADER_COMPILER_RETRY_COUNT", value);
        }

        /// <summary>
        /// The version of Unity the build will run
        /// </summary>
        public static string UnityVersion
        {
            get => GetVar("UNITY_VERSION");
            set => SetVar("UNITY_VERSION", value);
        }

        /// <summary>
        /// True if the Unity version differs from the last build
        /// </summary>
        public static string UnityVersionDiff
        {
            get => GetVar("UNITY_VERSION_DIFF");
            set => SetVar("UNITY_VERSION_DIFF", value);
        }
    }
}
