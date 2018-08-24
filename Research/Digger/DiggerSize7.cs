using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize7 : BaseResearchable
    {
        public DiggerSize7()
        {
            key = "Nach0DiggerSize7";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/diggersize7.png";
            iterationCount = 800;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize6");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.diggerlimit", 5000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}