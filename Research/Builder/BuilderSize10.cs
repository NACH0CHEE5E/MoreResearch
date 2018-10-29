using Science;
using Pipliz.Mods.BaseGame.Researches;

namespace Nach0.Research.Builder
{
    [AutoLoadedResearchable]
    public class BuilderSize10 : BaseResearchable
    {
        public BuilderSize10()
        {
            key = "Nach0BuilderSize10";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/buildersize10.png";
            iterationCount = 1250;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BuilderSize9");
        }

        public override void OnResearchComplete(ColonyScienceState manager, EResearchCompletionReason reason)
        {
            manager.Colony.TemporaryData.SetAs("pipliz.builderlimit", 50000000);
            ConstructionHelper.SendPacket(manager.Colony);
        }
    }
}