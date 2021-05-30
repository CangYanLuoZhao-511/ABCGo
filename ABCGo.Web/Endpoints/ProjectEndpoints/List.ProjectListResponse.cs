using ABCGo.Core.ProjectAggregate;
using System.Collections.Generic;

namespace ABCGo.Web.Endpoints.ProjectEndpoints
{
    public class ProjectListResponse
    {
        public List<ProjectRecord> Projects { get; set; } = new();
    }
}
