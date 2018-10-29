using Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize5 : BaseResearchable
    {
        public HealthRegenSize5()
        {
            key = "Nach0PlayerHealthRegenSize5";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthregensize5.png";
            iterationCount = 125;
            AddIterationRequirement("sciencebagbasic", 4);
            AddIterationRequirement("sciencebaglife", 7);
            AddDependency("pipliz.baseresearch.healthregensize4");
            AddDependency("pipliz.baseresearch.healthsize1");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthregenmax", 125f);
        }
    }
}
