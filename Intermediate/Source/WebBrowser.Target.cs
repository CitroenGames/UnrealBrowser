using UnrealBuildTool;

public class WebBrowserTarget : TargetRules
{
	public WebBrowserTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("WebBrowser");
	}
}
