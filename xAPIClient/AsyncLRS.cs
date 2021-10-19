using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TinCan.Documents;
using TinCan.LRSResponses;

namespace TinCan
{
    public class AsyncLRS : IAsyncLRS
    {
        public ILRS lrs;

        public Task<AboutLRSResponse> About()
        {
            return Task.FromResult(lrs.About());
        }

        public Task<LRSResponse> ClearState(Activity activity, Agent agent, Guid? registration = null)
        {
            return Task.FromResult(lrs.ClearState(activity, agent, registration));
        }

        public Task<LRSResponse> DeleteActivityProfile(ActivityProfileDocument profile)
        {
            return Task.FromResult(lrs.DeleteActivityProfile(profile));
        }

        public Task<LRSResponse> DeleteAgentProfile(AgentProfileDocument profile)
        {
            return Task.FromResult(lrs.DeleteAgentProfile(profile));
        }

        public Task<LRSResponse> DeleteState(StateDocument state)
        {
            return Task.FromResult(lrs.DeleteState(state));
        }

        public Task<StatementsResultLRSResponse> MoreStatements(StatementsResult result)
        {
            return Task.FromResult(lrs.MoreStatements(result));
        }

        public Task<StatementsResultLRSResponse> QueryStatements(StatementsQuery query)
        {
            return Task.FromResult(lrs.QueryStatements(query));
        }

        public Task<ActivityProfileLRSResponse> RetrieveActivityProfile(string id, Activity activity)
        {
            return Task.FromResult(lrs.RetrieveActivityProfile(id, activity));
        }

        public Task<ProfileKeysLRSResponse> RetrieveActivityProfileIds(Activity activity)
        {
            return Task.FromResult(lrs.RetrieveActivityProfileIds(activity));
        }

        public Task<AgentProfileLRSResponse> RetrieveAgentProfile(string id, Agent agent)
        {
            return Task.FromResult(lrs.RetrieveAgentProfile(id, agent));
        }

        public Task<ProfileKeysLRSResponse> RetrieveAgentProfileIds(Agent agent)
        {
            return Task.FromResult(lrs.RetrieveAgentProfileIds(agent));
        }

        public Task<StateLRSResponse> RetrieveState(string id, Activity activity, Agent agent, Guid? registration = null)
        {
            return Task.FromResult(lrs.RetrieveState(id, activity, agent, registration));
        }

        public Task<ProfileKeysLRSResponse> RetrieveStateIds(Activity activity, Agent agent, Guid? registration = null)
        {
            return Task.FromResult(lrs.RetrieveStateIds(activity, agent, registration));
        }

        public Task<StatementLRSResponse> RetrieveStatement(Guid id)
        {
            return Task.FromResult(lrs.RetrieveStatement(id));
        }

        public Task<StatementLRSResponse> RetrieveVoidedStatement(Guid id)
        {
            return Task.FromResult(lrs.RetrieveVoidedStatement(id));
        }

        public Task<LRSResponse> SaveActivityProfile(ActivityProfileDocument profile)
        {
            return Task.FromResult(lrs.SaveActivityProfile(profile));
        }

        public Task<LRSResponse> SaveAgentProfile(AgentProfileDocument profile)
        {
            return Task.FromResult(lrs.SaveAgentProfile(profile));
        }

        public Task<LRSResponse> SaveState(StateDocument state)
        {
            return Task.FromResult(lrs.SaveState(state));
        }

        public Task<StatementLRSResponse> SaveStatement(Statement statement)
        {
            return Task.FromResult(lrs.SaveStatement(statement));
        }

        public Task<StatementsResultLRSResponse> SaveStatements(List<Statement> statements)
        {
            return Task.FromResult(lrs.SaveStatements(statements));
        }

        public Task<StatementLRSResponse> VoidStatement(Guid id, Agent agent)
        {
            return Task.FromResult(lrs.VoidStatement(id, agent));
        }
    }
}
