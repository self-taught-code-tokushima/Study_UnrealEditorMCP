// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class SampleThirdPerson : ModuleRules
{
	public SampleThirdPerson(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"SampleThirdPerson",
			"SampleThirdPerson/Variant_Platforming",
			"SampleThirdPerson/Variant_Platforming/Animation",
			"SampleThirdPerson/Variant_Combat",
			"SampleThirdPerson/Variant_Combat/AI",
			"SampleThirdPerson/Variant_Combat/Animation",
			"SampleThirdPerson/Variant_Combat/Gameplay",
			"SampleThirdPerson/Variant_Combat/Interfaces",
			"SampleThirdPerson/Variant_Combat/UI",
			"SampleThirdPerson/Variant_SideScrolling",
			"SampleThirdPerson/Variant_SideScrolling/AI",
			"SampleThirdPerson/Variant_SideScrolling/Gameplay",
			"SampleThirdPerson/Variant_SideScrolling/Interfaces",
			"SampleThirdPerson/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
