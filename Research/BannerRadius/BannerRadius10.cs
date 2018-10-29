using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Nach0.Research.BannerRadius
{
    [AutoLoadedResearchable]
    public class BannerRadius10 : BaseResearchable
    {
        public BannerRadius10()
        {
            key = "Nach0BannerRadius10";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/bannerradius10.png";
            iterationCount = 1000;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BannerRadius9");
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
