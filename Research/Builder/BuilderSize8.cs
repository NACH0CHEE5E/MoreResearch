using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize8 : BaseResearchable
    {
        public BuilderSize8()
        {
            key = "Nach0BuilderSize8";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/buildersize8.png";
            iterationCount = 450;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize7");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.builderlimit", 12500000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}