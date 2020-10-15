using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.dto
{
    class GetEmployeeDTO : DTO
    {
        private String name;

        private String salary;

        private String age;

        private int id;

        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return this.name;
        }
        public void setSalary(String salary)
        {
            this.salary = salary;
        }
        public String getSalary()
        {
            return this.salary;
        }
        public void setAge(String age)
        {
            this.age = age;
        }
        public String getAge()
        {
            return this.age;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
    }
}
