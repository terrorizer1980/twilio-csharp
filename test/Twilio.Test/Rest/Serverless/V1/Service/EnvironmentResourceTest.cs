/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Serverless.V1.Service;

namespace Twilio.Tests.Rest.Serverless.V1.Service
{

    [TestFixture]
    public class EnvironmentTest : TwilioTest
    {
        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Serverless,
                "/v1/Services/ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Environments",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                EnvironmentResource.Read("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"environments\": [],\"meta\": {\"first_page_url\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments?PageSize=50&Page=0\",\"key\": \"environments\",\"next_page_url\": null,\"page\": 0,\"page_size\": 50,\"previous_page_url\": null,\"url\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments?PageSize=50&Page=0\"}}"
                                     ));

            var response = EnvironmentResource.Read("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Serverless,
                "/v1/Services/ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Environments/ZEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                EnvironmentResource.Fetch("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "ZEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"ZE00000000000000000000000000000000\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ZS00000000000000000000000000000000\",\"build_sid\": \"ZB00000000000000000000000000000000\",\"unique_name\": \"testing-environment\",\"domain_suffix\": \"testing\",\"domain_name\": \"foobar-1234-testing.twil.io\",\"date_created\": \"2018-11-10T20:00:00Z\",\"date_updated\": \"2018-11-10T20:00:00Z\",\"url\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000\",\"links\": {\"variables\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000/Variables\",\"deployments\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000/Deployments\"}}"
                                     ));

            var response = EnvironmentResource.Fetch("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "ZEXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Serverless,
                "/v1/Services/ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Environments",
                ""
            );
            request.AddPostParam("UniqueName", Serialize("unique_name"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                EnvironmentResource.Create("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "unique_name", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"ZE00000000000000000000000000000000\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"service_sid\": \"ZS00000000000000000000000000000000\",\"build_sid\": null,\"unique_name\": \"staging\",\"domain_suffix\": \"stage\",\"domain_name\": \"foobar-1234-stage.twil.io\",\"date_created\": \"2018-11-10T20:00:00Z\",\"date_updated\": \"2018-11-10T20:00:00Z\",\"url\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000\",\"links\": {\"variables\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000/Variables\",\"deployments\": \"https://serverless.twilio.com/v1/Services/ZS00000000000000000000000000000000/Environments/ZE00000000000000000000000000000000/Deployments\"}}"
                                     ));

            var response = EnvironmentResource.Create("ZSXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "unique_name", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}