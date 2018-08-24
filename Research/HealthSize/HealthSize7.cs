using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize7 : BaseResearchable
    {
        public HealthSize7()
        {
            key = "Nach0PlayerHealthSize7";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthsize7.png";
            iterationCount = 1000;
            AddIterationRequirement("sciencebagadvanced", 9);
            AddIterationRequirement("sciencebaglife", 9);
            AddDependency("Nach0PlayerHealthSize6");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthmax", 850f);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                manager.Player.SendHealthPacket();
            }
        }
    }
}
