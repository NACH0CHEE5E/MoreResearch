using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize5 : BaseResearchable
    {
        public HealthSize5()
        {
            key = "Nach0PlayerHealthSize5";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthsize5.png";
            iterationCount = 250;
            AddIterationRequirement("sciencebagadvanced", 3);
            AddIterationRequirement("sciencebaglife", 3);
            AddDependency("pipliz.baseresearch.healthsize4");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthmax", 350f);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                manager.Player.SendHealthPacket();
            }
        }
    }
}
