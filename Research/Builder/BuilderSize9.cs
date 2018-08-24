using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize9 : BaseResearchable
    {
        public BuilderSize9()
        {
            key = "Nach0BuilderSize9";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/buildersize9.png";
            iterationCount = 450;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize8");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.builderlimit", 25000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}