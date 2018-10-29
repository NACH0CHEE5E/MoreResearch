using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize11 : BaseResearchable
    {
        public BuilderSize11()
        {
            key = "Nach0BuilderSize11";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize11.png";
            iterationCount = 2000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize10");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 100000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}