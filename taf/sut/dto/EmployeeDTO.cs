using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.dto
{
    class EmployeeDTO:DTO
    {
        private String id;

        private String employee_name;

        private String employee_salary;

        private String employee_age;

        private String profile_image;

        public void setId(String id)
        {
            this.id = id;
        }
        public String getId()
        {
            return this.id;
        }
        public void setEmployee_name(String employee_name)
        {
            this.employee_name = employee_name;
        }
        public String getEmployee_name()
        {
            return this.employee_name;
        }
        public void setEmployee_salary(String employee_salary)
        {
            this.employee_salary = employee_salary;
        }
        public String getEmployee_salary()
        {
            return this.employee_salary;
        }
        public void setEmployee_age(String employee_age)
        {
            this.employee_age = employee_age;
        }
        public String getEmployee_age()
        {
            return this.employee_age;
        }
        public void setProfile_image(String profile_image)
        {
            this.profile_image = profile_image;
        }
        public String getProfile_image()
        {
            return this.profile_image;
        }
    }
}
