using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize10 : BaseResearchable
    {
        public DiggerSize10()
        {
            key = "Nach0DiggerSize10";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/diggersize10.png";
            iterationCount = 3500;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize9");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.diggerlimit", 50000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}