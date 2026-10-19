using BepInEx;
using System.Security.Permissions;

[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace UnJunkContent;

[BepInPlugin(PluginGUID, PluginName, PluginVersion)]
[BepInDependency(RoR2BepInExPack.RoR2BepInExPack.PluginGUID)]
public class UnJunkContent : BaseUnityPlugin
{
	public const string PluginGUID = PluginAuthor + "." + PluginName;
	public const string PluginAuthor = "Onyx";
	public const string PluginName = "UnJunkContent";
	public const string PluginVersion = "1.0.0";

	public void Awake()
	{
		RoR2BepInExPack.VanillaFixes.FixMultiplayerCompatibilityWithVanilla._hook.Undo();
		RoR2BepInExPack.VanillaFixes.FixMultiplayerCompatibilityWithVanilla._hook = null;
	}
}


