using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.UseCases.Reports.Interfaces;
using Aisoftware.Tracker.Borders.ReportStops.Entities;
using Aisoftware.Tracker.Borders.ReportTrips.Entities;
using Aisoftware.Tracker.Borders.Events.Entities;
using Aisoftware.Tracker.Borders.ReportRoutes.Entities;
using Aisoftware.Tracker.Borders.ReportSummaries.Entities;

namespace Aisoftware.Tracker.UseCases.Reports.UseCases
{
    public class ReportUseCase : IReportUseCase
    {
        public Task<IEnumerable<Event>> FindEvents(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ReportRoute>> FindRoute(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ReportStop>> FindStops(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ReportSummary>> FindSummary(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<ReportTrip>> FindTrips(KeyValuePair<string, string> param)
        {
            throw new System.NotImplementedException();
        }
    }
}