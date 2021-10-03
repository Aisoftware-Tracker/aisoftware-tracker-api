using System.Threading.Tasks;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.ReportStops.Entities;
using Aisoftware.Tracker.Borders.ReportRoutes.Entities;
using Aisoftware.Tracker.Borders.ReportTrips.Entities;
using Aisoftware.Tracker.Borders.ReportSummaries.Entities;
using Aisoftware.Tracker.Borders.Events.Entities;

namespace Aisoftware.Tracker.UseCases.Reports.Interfaces
{
    public interface IReportUseCase
    {
        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<ReportRoute>> FindRoute(KeyValuePair<string, string> param);

        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<Event>> FindEvents(KeyValuePair<string, string> param);

        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<ReportSummary>> FindSummary(KeyValuePair<string, string> param);

        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<ReportTrip>> FindTrips(KeyValuePair<string, string> param);

        /// <summary>
        /// @Get
        /// </summary>        
        Task<IEnumerable<ReportStop>> FindStops(KeyValuePair<string, string> param); //TODO criar um param generico pra herdar

    }
}