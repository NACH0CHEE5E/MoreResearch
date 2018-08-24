using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Nach0.Research.BannerRadius
{
    [AutoLoadedResearchable]
    public class BannerRadius6 : BaseResearchable
    {
        public BannerRadius6()
        {
            key = "Nach0BannerRadius6";
            icon = "gamedata/mods/NACH0/MoreBannerResearch/gamedata/textures/icons/bannerradius6.png";
            iterationCount = 200;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("pipliz.baseresearch.bannerradius5");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.bannersaferadius", 225);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                BannerTracker.SendPacket(manager.Player);
            }
        }
    }
}
