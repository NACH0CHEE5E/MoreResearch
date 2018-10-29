using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize7 : BaseResearchable
    {
        public BuilderSize7()
        {
            key = "Nach0BuilderSize7";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize7.png";
            iterationCount = 550;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize6");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 5000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}