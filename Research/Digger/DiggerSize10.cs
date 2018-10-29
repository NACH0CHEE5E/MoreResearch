using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize10 : BaseResearchable
    {
        public DiggerSize10()
        {
            key = "Nach0DiggerSize10";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize10.png";
            iterationCount = 1250;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize9");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 50000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}