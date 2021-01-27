/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Studio.V2.Flow
{

    /// <summary>
    /// Fetch flow test users
    /// </summary>
    public class FetchFlowTestUserOptions : IOptions<FlowTestUserResource>
    {
        /// <summary>
        /// Unique identifier of the flow.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFlowTestUserOptions
        /// </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        public FetchFlowTestUserOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// Update flow test users
    /// </summary>
    public class UpdateFlowTestUserOptions : IOptions<FlowTestUserResource>
    {
        /// <summary>
        /// Unique identifier of the flow.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// List of test user identities that can test draft versions of the flow.
        /// </summary>
        public List<string> TestUsers { get; }

        /// <summary>
        /// Construct a new UpdateFlowTestUserOptions
        /// </summary>
        /// <param name="pathSid"> Unique identifier of the flow. </param>
        /// <param name="testUsers"> List of test user identities that can test draft versions of the flow. </param>
        public UpdateFlowTestUserOptions(string pathSid, List<string> testUsers)
        {
            PathSid = pathSid;
            TestUsers = testUsers;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (TestUsers != null)
            {
                p.AddRange(TestUsers.Select(prop => new KeyValuePair<string, string>("TestUsers", prop)));
            }

            return p;
        }
    }

}