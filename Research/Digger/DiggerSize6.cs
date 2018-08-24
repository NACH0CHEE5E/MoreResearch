using Server.Science;
using Pipliz.Mods.APIProvider.Science;

namespace Nach0.Research.Digger
{
    [AutoLoadedResearchable]
    public class DiggerSize6 : BaseResearchable
    {
        public DiggerSize6()
        {
            key = "Nach0DiggerSize6";
            icon = "gamedata/mods/NACH0/MoreBuilderResearch/gamedata/textures/icons/diggersize6.png";
            iterationCount = 450;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("pipliz.baseresearch.constructiondiggersize5");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.diggerlimit", 2500000);
            Pipliz.Mods.BaseGame.Researches.ConstructionHelper.SendPacket(manager.Player);
        }
    }
}