using Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize6 : BaseResearchable
    {
        public HealthRegenSize6()
        {
            key = "Nach0PlayerHealthRegenSize6";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthregensize6.png";
            iterationCount = 250;
            AddIterationRequirement("sciencebagbasic", 5);
            AddIterationRequirement("sciencebaglife", 8);
            AddDependency("Nach0PlayerHealthRegenSize5");
            AddDependency("pipliz.baseresearch.healthsize4");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthregenmax", 200f);
        }
    }
}
