using mentoring_taf.taf.sut.dto;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.core.api.marshalling
{
    class Unmarshaller
    {

        public T Unmarshal<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }
    }
}
