using System;
namespace Sweepstakes
{
    public class MarketingFirm
    {
        ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            manager.InsertSweepstakes(sweepstakes);
        }

        Sweepstakes GetSweepstakes()
        {
            return manager.GetSweepstakes();
        }
    }
}
