using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.dto
{
    class CreateEmployeeRsDTO:DTO
    {

        //{"status":"success","data":{"name":"John","salary":"1000","age":"30","id":5968},"message":"Successfully! Record has been added."}
        public String status { get; set; }
        public String message{ get; set; }
        public UserData data { get; set; }
        
        public class UserData
        {
            public String name { get; set; }
            public String salary { get; set; }
            public String age { get; set; }
            public String id { get; set; }

        }
    }
}
