using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize8 : BaseResearchable
    {
        public HealthRegenSize8()
        {
            key = "Nach0PlayerHealthRegenSize8";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthregensize8.png";
            iterationCount = 1150;
            AddIterationRequirement("sciencebagbasic", 10);
            AddIterationRequirement("sciencebaglife", 18);
            AddDependency("Nach0PlayerHealthRegenSize7");
            AddDependency("Nach0PlayerHealthSize6");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthregenmax", 500f);
        }
    }
}
