using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Nach0.Research.BannerRadius
{
    [AutoLoadedResearchable]
    public class BannerRadius9 : BaseResearchable
    {
        public BannerRadius9()
        {
            key = "Nach0BannerRadius9";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/bannerradius9.png";
            iterationCount = 850;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BannerRadius8");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.bannersaferadius", 200);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                BannerTracker.SendPacket(manager.Player);
            }
        }
    }
}
