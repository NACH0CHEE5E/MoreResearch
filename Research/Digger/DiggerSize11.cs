using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize11 : BaseResearchable
    {
        public DiggerSize11()
        {
            key = "Nach0DiggerSize11";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize11.png";
            iterationCount = 2000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize10");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 100000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}