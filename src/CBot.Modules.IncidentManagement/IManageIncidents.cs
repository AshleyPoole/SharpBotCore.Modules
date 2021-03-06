﻿using System.Collections.Generic;
using System.Threading.Tasks;

using CBot.Modules.IncidentManagement.Models;

namespace CBot.Modules.IncidentManagement
{
	internal interface IManageIncidents
	{
		Task<IncidentResponse> DeclareNewIncident(string incidentTitle, string reportedByUser);

		Task<IncidentResponse> ResolveIncident(string resolvedBy, string incidentChannelId);

		Task<IncidentResponse> AddPostmortemToIncident(
			string postmortemLink,
			string addedByUser,
			string incidentChannelId);

		Task<IncidentResponse> CloseIncident(string closedBy, string incidentChannelId);

		Task<IncidentResponse> ForceCloseIncident(string closedBy, string incidentChannelId);

		Task<IncidentResponse> DeleteIncident(string deletedBy, string incidentChannelId);

		Task<List<Incident>> GetActiveIncidents();

		Task<List<Incident>> GetRecentIncidents(int pastDays = 14);
	}
}