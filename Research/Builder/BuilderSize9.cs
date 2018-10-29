using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize9 : BaseResearchable
    {
        public BuilderSize9()
        {
            key = "Nach0BuilderSize9";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize9.png";
            iterationCount = 1000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize8");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 25000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}