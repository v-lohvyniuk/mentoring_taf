using RestSharp;
using RestSharp.Serialization.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.logging
{
    public class RequestResponseLogger
    {

        public static void LogRequest(RestClient client, IRestRequest request)
        {
            Log.Info("----------------------REQUEST----------------------");
            Log.Info(client.BuildUri(request).AbsoluteUri);
            LogRequestBody(request);
            Log.Info("--------------------END REQUEST----------------------");

        }
        public static void LogResponse(IRestResponse response)
        {
            Log.Info("----------------------RESPONSE----------------------");
            Log.Info("Status code: " + response.StatusCode);
            Log.Info("Body: " + response.Content);
            Log.Info("--------------------END RESPONSE----------------------");

        }

        private static void LogRequestBody(IRestRequest request)
        {
            if (request.Parameters.Exists(IsParamRequestBody()))
            {
                var body = request.Parameters.Find(IsParamRequestBody()).Value;
                Log.Info("Body: " + new JsonSerializer().Serialize(body));
            }
        }

        private static Predicate<Parameter> IsParamRequestBody()
        {
            return x => x.Type.Equals(ParameterType.RequestBody);
        }
    }
}
