using Pipliz.Mods.APIProvider.Science;
using Server.Science;

namespace Nach0.Research.BannerRadius
{
    [AutoLoadedResearchable]
    public class BannerRadius11 : BaseResearchable
    {
        public BannerRadius11()
        {
            key = "Nach0BannerRadius11";
            icon = "gamedata/mods/NACH0/MoreResearch/gamedata/textures/icons/bannerradius11.png";
            iterationCount = 1500;
            AddIterationRequirement("sciencebagadvanced");
            AddIterationRequirement("sciencebagcolony");
            AddDependency("Nach0BannerRadius10");
        }

        public override void OnResearchComplete(ScienceManagerPlayer manager, EResearchCompletionReason reason)
        {
            manager.Player.GetTempValues(true).Set("pipliz.bannersaferadius", 250);
            if (reason == EResearchCompletionReason.ProgressCompleted)
            {
                BannerTracker.SendPacket(manager.Player);
            }
        }
    }
}
