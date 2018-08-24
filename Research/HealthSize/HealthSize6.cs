using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize6 : BaseResearchable
    {
        public HealthSize6()
        {
            key = "Nach0PlayerHealthSize6";
            icon = "gamedata/mods/NACH0/MorePlayerHealthResearch/gamedata/textures/icons/healthsize6.png";
            iterationCount = 550;
            AddIterationRequirement("sciencebagadvanced", 5);
            AddIterationRequirement("sciencebaglife", 5);
            AddDependency("Nach0PlayerHealthSize5");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.healthmax", 500f);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                manager.Player.SendHealthPacket();
            }
        }
    }
}
