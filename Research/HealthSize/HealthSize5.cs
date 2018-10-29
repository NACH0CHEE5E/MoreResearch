using Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize5 : BaseResearchable
    {
        public HealthSize5()
        {
            key = "Nach0PlayerHealthSize5";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthsize5.png";
            iterationCount = 250;
            AddIterationRequirement("sciencebagadvanced", 3);
            AddIterationRequirement("sciencebaglife", 3);
            AddDependency("pipliz.baseresearch.healthsize4");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthmax", 350f);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                for (int i = 0; i < manager.Colony.Owners.Length; i++)
                {
                    if (manager.Colony.Owners[i].ShouldSendData)
                    {
                        manager.Colony.Owners[i].SendHealthPacket();
                    }
                }
            }
        }
    }
}
