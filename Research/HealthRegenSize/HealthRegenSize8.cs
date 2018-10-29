using Science;

namespace Nach0.Research.HealthRegenSize
{
    [AutoLoadedResearchable]
    public class HealthRegenSize8 : BaseResearchable
    {
        public HealthRegenSize8()
        {
            key = "Nach0PlayerHealthRegenSize8";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthregensize8.png";
            iterationCount = 1150;
            AddIterationRequirement("sciencebagbasic", 10);
            AddIterationRequirement("sciencebaglife", 18);
            AddDependency("Nach0PlayerHealthRegenSize7");
            AddDependency("Nach0PlayerHealthSize6");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthregenmax", 500f);
        }
    }
}
