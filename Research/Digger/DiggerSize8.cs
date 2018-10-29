using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize8 : BaseResearchable
    {
        public DiggerSize8()
        {
            key = "Nach0DiggerSize8";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize8.png";
            iterationCount = 675;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize7");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 12500000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}