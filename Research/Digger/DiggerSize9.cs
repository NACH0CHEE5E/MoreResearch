using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize9 : BaseResearchable
    {
        public DiggerSize9()
        {
            key = "Nach0DiggerSize9";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize9.png";
            iterationCount = 1000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize8");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 25000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}