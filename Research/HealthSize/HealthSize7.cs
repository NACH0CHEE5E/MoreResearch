using Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize7 : BaseResearchable
    {
        public HealthSize7()
        {
            key = "Nach0PlayerHealthSize7";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthsize7.png";
            iterationCount = 1000;
            AddIterationRequirement("sciencebagadvanced", 9);
            AddIterationRequirement("sciencebaglife", 9);
            AddDependency("Nach0PlayerHealthSize6");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthmax", 850f);
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
