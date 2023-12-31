using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_amazing_of_numbers.Model
{
    public class UserViolations
    {
        public string rule_name;
        public string date_violate;
        public string rule_punishment;
        public string status;

        public UserViolations(string rule_name, string date_violate, string rule_punishment, string status)
        {
            this.rule_name = rule_name;
            this.date_violate = date_violate;
            this.rule_punishment = rule_punishment;
            this.status = status;
        }
    }
}
