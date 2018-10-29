using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize8 : BaseResearchable
    {
        public BuilderSize8()
        {
            key = "Nach0BuilderSize8";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize8.png";
            iterationCount = 675;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize7");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 12500000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}