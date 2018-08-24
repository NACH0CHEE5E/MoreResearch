using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize6 : BaseResearchable
    {
        public BuilderSize6()
        {
            key = "Nach0BuilderSize6";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/buildersize6.png";
            iterationCount = 450;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("pipliz.baseresearch.constructionbuildersize5");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.builderlimit", 2500000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}