using Science;

namespace Nach0.Research.HealthSize
{
    [AutoLoadedResearchable]
    public class HealthSize6 : BaseResearchable
    {
        public HealthSize6()
        {
            key = "Nach0PlayerHealthSize6";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/healthsize6.png";
            iterationCount = 550;
            AddIterationRequirement("sciencebagadvanced", 5);
            AddIterationRequirement("sciencebaglife", 5);
            AddDependency("Nach0PlayerHealthSize5");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.healthmax", 500f);
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
