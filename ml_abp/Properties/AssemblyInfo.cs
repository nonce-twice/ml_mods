﻿using System.Reflection;

[assembly: AssemblyTitle("AvatarBonesProximity")]
[assembly: AssemblyVersion("1.1.3")]
[assembly: AssemblyFileVersion("1.1.3")]

[assembly: MelonLoader.MelonInfo(typeof(ml_abp.Main), "AvatarBonesProximity", "1.1.3", "SDraw", "https://github.com/SDraw/ml_abp")]
[assembly: MelonLoader.MelonGame("VRChat", "VRChat")]
[assembly: MelonLoader.MelonAdditionalDependencies("VRChatUtilityKit", "UIExpansionKit")]
[assembly: MelonLoader.VerifyLoaderVersion(0, 4, 3, true)]
[assembly: MelonLoader.MelonPlatform(MelonLoader.MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]
[assembly: MelonLoader.MelonPlatformDomain(MelonLoader.MelonPlatformDomainAttribute.CompatibleDomains.IL2CPP)]