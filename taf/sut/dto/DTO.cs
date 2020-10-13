using System;
using System.Collections.Generic;
using System.Text;

namespace mentoring_taf.taf.sut.dto
{
    public class DTO
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{ ");
            foreach (System.Reflection.PropertyInfo property in this.GetType().GetProperties())
            {

                sb.Append(property.Name);
                sb.Append(": ");
                if (property.GetIndexParameters().Length > 0)
                {
                    sb.Append("Indexed Property cannot be used");
                }
                else
                {
                    sb.Append(property.GetValue(this, null));
                }

                sb.Append(", ");
            }
            sb.Append(" }");
            return sb.ToString();
        }
    }
}
