using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize11 : BaseResearchable
    {
        public BuilderSize11()
        {
            key = "Nach0BuilderSize11";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/buildersize11.png";
            iterationCount = 5000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize10");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.builderlimit", 100000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}