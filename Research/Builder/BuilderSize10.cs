using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize10 : BaseResearchable
    {
        public BuilderSize10()
        {
            key = "Nach0BuilderSize10";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/buildersize10.png";
            iterationCount = 3500;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize9");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.builderlimit", 50000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}