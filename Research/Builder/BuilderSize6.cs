using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize6 : BaseResearchable
    {
        public BuilderSize6()
        {
            key = "Nach0BuilderSize6";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize6.png";
            iterationCount = 400;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("pipliz.baseresearch.constructionbuildersize5");
        }

        public override void OnResearchComplete (ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 2500000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}