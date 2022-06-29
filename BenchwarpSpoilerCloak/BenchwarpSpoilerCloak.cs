using Modding;

namespace BenchwarpSpoilerCloak
{
    public class BenchwarpSpoilerCloak : Mod, ITogglableMod
    {
        public override void Initialize()
        {
            Benchwarp.Events.OnGetBenchName += HideUnvisitedBenchNames;
            Benchwarp.Events.OnGetBenchSceneName += HideUnvisitedBenchNames;
        }

        public void Unload()
        {
            Benchwarp.Events.OnGetBenchName -= HideUnvisitedBenchNames;
            Benchwarp.Events.OnGetBenchSceneName -= HideUnvisitedBenchNames;
        }

        private void HideUnvisitedBenchNames(Benchwarp.Bench bench, ref string name)
        {
            if (!bench.HasVisited())
            {
                name = "???";
            }
        }

        public override string GetVersion() => "1.0";
    }
}
