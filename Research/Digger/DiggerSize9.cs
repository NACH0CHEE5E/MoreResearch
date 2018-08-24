using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize9 : BaseResearchable
    {
        public DiggerSize9()
        {
            key = "Nach0DiggerSize9";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/diggersize9.png";
            iterationCount = 2750;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize8");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.diggerlimit", 25000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}