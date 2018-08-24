using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize6 : BaseResearchable
    {
        public HealthRegenSize6()
        {
            key = "Nach0PlayerHealthRegenSize6";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthregensize6.png";
            iterationCount = 250;
            AddIterationRequirement("sciencebagbasic", 5);
            AddIterationRequirement("sciencebaglife", 8);
            AddDependency("Nach0PlayerHealthRegenSize5");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthregenmax", 200f);
        }
    }
}
