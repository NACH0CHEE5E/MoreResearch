using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize6 : BaseResearchable
    {
        public DiggerSize6()
        {
            key = "Nach0DiggerSize6";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/diggersize6.png";
            iterationCount = 400;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("pipliz.baseresearch.constructiondiggersize5");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.diggerlimit", 2500000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}