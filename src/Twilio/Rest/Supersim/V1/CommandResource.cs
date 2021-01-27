/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains beta products that are subject to change. Use them with caution.
///
/// CommandResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Supersim.V1
{

    public class CommandResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Sent = new StatusEnum("sent");
            public static readonly StatusEnum Delivered = new StatusEnum("delivered");
            public static readonly StatusEnum Received = new StatusEnum("received");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }

        public sealed class DirectionEnum : StringEnum
        {
            private DirectionEnum(string value) : base(value) {}
            public DirectionEnum() {}
            public static implicit operator DirectionEnum(string value)
            {
                return new DirectionEnum(value);
            }

            public static readonly DirectionEnum ToSim = new DirectionEnum("to_sim");
            public static readonly DirectionEnum FromSim = new DirectionEnum("from_sim");
        }

        private static Request BuildCreateRequest(CreateCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Supersim,
                "/v1/Commands",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Send a Command to a Sim.
        /// </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Create(CreateCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Send a Command to a Sim.
        /// </summary>
        /// <param name="options"> Create Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(CreateCommandOptions options,
                                                                                     ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Send a Command to a Sim.
        /// </summary>
        /// <param name="sim"> The sid or unique_name of the SIM to send the Command to </param>
        /// <param name="command"> The message body of the command </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call callback_url </param>
        /// <param name="callbackUrl"> The URL we should call after we have sent the command </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Create(string sim,
                                             string command,
                                             Twilio.Http.HttpMethod callbackMethod = null,
                                             Uri callbackUrl = null,
                                             ITwilioRestClient client = null)
        {
            var options = new CreateCommandOptions(sim, command){CallbackMethod = callbackMethod, CallbackUrl = callbackUrl};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// Send a Command to a Sim.
        /// </summary>
        /// <param name="sim"> The sid or unique_name of the SIM to send the Command to </param>
        /// <param name="command"> The message body of the command </param>
        /// <param name="callbackMethod"> The HTTP method we should use to call callback_url </param>
        /// <param name="callbackUrl"> The URL we should call after we have sent the command </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> CreateAsync(string sim,
                                                                                     string command,
                                                                                     Twilio.Http.HttpMethod callbackMethod = null,
                                                                                     Uri callbackUrl = null,
                                                                                     ITwilioRestClient client = null)
        {
            var options = new CreateCommandOptions(sim, command){CallbackMethod = callbackMethod, CallbackUrl = callbackUrl};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildFetchRequest(FetchCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                "/v1/Commands/" + options.PathSid + "",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Fetch a Command instance from your account.
        /// </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Fetch(FetchCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// Fetch a Command instance from your account.
        /// </summary>
        /// <param name="options"> Fetch Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(FetchCommandOptions options,
                                                                                    ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// Fetch a Command instance from your account.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static CommandResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// Fetch a Command instance from your account.
        /// </summary>
        /// <param name="pathSid"> The SID that identifies the resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<CommandResource> FetchAsync(string pathSid,
                                                                                    ITwilioRestClient client = null)
        {
            var options = new FetchCommandOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadCommandOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Supersim,
                "/v1/Commands",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// Retrieve a list of Commands from your account.
        /// </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static ResourceSet<CommandResource> Read(ReadCommandOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Commands from your account.
        /// </summary>
        /// <param name="options"> Read Command parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(ReadCommandOptions options,
                                                                                                ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<CommandResource>.FromJson("commands", response.Content);
            return new ResourceSet<CommandResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// Retrieve a list of Commands from your account.
        /// </summary>
        /// <param name="sim"> The SID or unique name of the Sim that Command was sent to or from. </param>
        /// <param name="status"> The status of the Command </param>
        /// <param name="direction"> The direction of the Command </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Command </returns>
        public static ResourceSet<CommandResource> Read(string sim = null,
                                                        CommandResource.StatusEnum status = null,
                                                        CommandResource.DirectionEnum direction = null,
                                                        int? pageSize = null,
                                                        long? limit = null,
                                                        ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions(){Sim = sim, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// Retrieve a list of Commands from your account.
        /// </summary>
        /// <param name="sim"> The SID or unique name of the Sim that Command was sent to or from. </param>
        /// <param name="status"> The status of the Command </param>
        /// <param name="direction"> The direction of the Command </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Command </returns>
        public static async System.Threading.Tasks.Task<ResourceSet<CommandResource>> ReadAsync(string sim = null,
                                                                                                CommandResource.StatusEnum status = null,
                                                                                                CommandResource.DirectionEnum direction = null,
                                                                                                int? pageSize = null,
                                                                                                long? limit = null,
                                                                                                ITwilioRestClient client = null)
        {
            var options = new ReadCommandOptions(){Sim = sim, Status = status, Direction = direction, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns>
        public static Page<CommandResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns>
        public static Page<CommandResource> NextPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(Rest.Domain.Supersim)
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns>
        public static Page<CommandResource> PreviousPage(Page<CommandResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(Rest.Domain.Supersim)
            );

            var response = client.Request(request);
            return Page<CommandResource>.FromJson("commands", response.Content);
        }

        /// <summary>
        /// Converts a JSON string into a CommandResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> CommandResource object represented by the provided JSON </returns>
        public static CommandResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<CommandResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The SID of the SIM that this Command was sent to or from
        /// </summary>
        [JsonProperty("sim_sid")]
        public string SimSid { get; private set; }
        /// <summary>
        /// The message body of the command sent to or from the SIM
        /// </summary>
        [JsonProperty("command")]
        public string Command { get; private set; }
        /// <summary>
        /// The status of the Command
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CommandResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The direction of the Command
        /// </summary>
        [JsonProperty("direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public CommandResource.DirectionEnum Direction { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The absolute URL of the Command resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }

        private CommandResource()
        {

        }
    }

}