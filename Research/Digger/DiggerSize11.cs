using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize11 : BaseResearchable
    {
        public DiggerSize11()
        {
            key = "Nach0DiggerSize11";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/diggersize11.png";
            iterationCount = 5000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0DiggerSize10");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.diggerlimit", 100000000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}