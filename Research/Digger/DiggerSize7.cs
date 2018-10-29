using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize7 : BaseResearchable
    {
        public DiggerSize7()
        {
            key = "Nach0DiggerSize7";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize7.png";
            iterationCount = 550;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize6");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 25000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}