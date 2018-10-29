using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Nach0.Research.BannerRadius
{
    [AutoLoadedResearchable]
    public class BannerRadius7 : BaseResearchable
    {
        public BannerRadius7()
        {
            key = "Nach0BannerRadius7";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/bannerradius7.png";
            iterationCount = 250;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BannerRadius6");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.bannersaferadius", 150);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                BannerTracker.SendPacket(manager.Player);
            }
        }
    }
}
