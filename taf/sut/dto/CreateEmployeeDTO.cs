using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.dto
{
    class CreateEmployeeDTO:DTO
    {
        public String name { get; set; }
        public String salary { get; set; }
        public String age { get; set; }

        public static CreateEmployeeDTO Generated()
        {
            var newEmployee = new CreateEmployeeDTO();

            newEmployee.age = "30";
            newEmployee.salary = "1000";
            newEmployee.name = "John";

            return newEmployee;
        }
    }
}
