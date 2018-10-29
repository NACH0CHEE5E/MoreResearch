using Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize7 : BaseResearchable
    {
        public HealthRegenSize7()
        {
            key = "Nach0PlayerHealthRegenSize7";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthregensize7.png";
            iterationCount = 550;
            AddIterationRequirement("sciencebagbasic", 7);
            AddIterationRequirement("sciencebaglife", 10);
            AddDependency("Nach0PlayerHealthRegenSize6");
            AddDependency("Nach0PlayerHealthSize5");

        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthregenmax", 350f);
        }
    }
}
