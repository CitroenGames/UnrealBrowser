using UnrealBuildTool;

public class UnrealbrowserTarget : TargetRules
{
	public UnrealbrowserTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Unrealbrowser");
	}
}
