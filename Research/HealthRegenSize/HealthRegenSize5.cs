using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize5 : BaseResearchable
    {
        public HealthRegenSize5()
        {
            key = "Nach0PlayerHealthRegenSize5";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthregensize5.png";
            iterationCount = 125;
            AddIterationRequirement("sciencebagbasic", 4);
            AddIterationRequirement("sciencebaglife", 7);
            AddDependency("pipliz.baseresearch.healthregensize4");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthregenmax", 125f);
        }
    }
}
