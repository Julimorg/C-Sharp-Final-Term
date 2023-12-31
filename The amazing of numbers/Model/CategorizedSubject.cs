using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_amazing_of_numbers.Model
{
    public class CategorizedSubject
    {
        static public List<string> sv1 = new List<string>()
        {
            "Corporate culture",
            "Programing C",
            "Practice programing C",
            "Computer architecture and Operating system",
            "Practice computer architecture",
            "Practice operating system",
            "Software technology",
            "English 1",
            "English 2",
            "English 3",
            "English 4",
            "Linear algebra",
            "Discrete mathematics",
            "National defense and security 1",
            "National defense and security 2",
            "National defense and security 3",
            "National defense and security 4",
            "Project design 1",
            "Vovinam 1"

        }; //4
        static public List<string> sv2 = new List<string>()
        {
            "Programming technique",
            "Object-oriented programming",
            "Web programming",
            "Practice object-oriented programming",
            "Data structures and algorithms",
            "Practice data structures and algorithms",
            "Practice database fundamentals",
            "Practice database management",
            "Pratice graph theory",
            "English 5",
            "English 6",
            "English 7",
            "English 8",
            "Project design 2",
            "Vovinam 2"
        }; //7
        static public List<string> sv3 = new List<string>()
        {
            "Artificial intelligence",
            "Programming on the Windows platform",
            "Practice programming on the Windows platform",
            "Practical application programming with Java",
            "Information technology project management",
            "Computer network",
            "Practice computer network",
            "Information security",
            "English 9",
            "English 10",
            "English 11",
            "Probability and statistics",
            "Vovinam 3"
        }; //10
        static public List<string> sv4 = new List<string>()
        {
            "Business reality",
            "Marxism-Leninism philosophy",
            "Marxism-Leninism political economy",
            "Business communication skills"
        }; //9




        //Chỉ chọn học kỳ 
        static public List<string> HK1A = new List<string>()
        {
            "National defense and security 1",
            "National defense and security 2",
            "National defense and security 3",
            "National defense and security 4",
            "English 1",
            "Programing C",
            "Practice programing C",
            "Pratice graph theory",
            "English 5",
            "Data structures and algorithms",
            "Practice data structures and algorithms",
            "Probability and statistics",
            "English 9",
            "Practical application programming with Java",
        };
        static public List<string> HK1B = new List<string>()
        {
            "Corporate culture",
            "Linear algebra",
            "English 2",
            "Software technology",
            "Practice database fundamentals",
            "English 6",
            "Programming technique",
            "Practice database management",
            "Programming on the Windows platform",
            "English 10",
            "Artificial intelligence",
            "Practice programming on the Windows platform",
        };
        static public List<string> HK2A = new List<string>()
        {
            "Vovinam 1",
            "Vovinam 2",
            "Vovinam 3",
            "Discrete mathematics",
            "English 3",
            "Computer architecture and Operating system",
            "Practice computer architecture",
            "English 7",
            "Object-oriented programming",
            "Practice object-oriented programming",
            "English 11",
            "Computer network",
            "Practice computer network",
        };
        static public List<string> HK2B = new List<string>()
        {
            "English 4",
            "Project design 1",
            "Project design 2",
            "Computer architecture and Operating system",
            "Practice operating system",
            "English 8",
            "Web programming",
            "Information security",
            "Information technology project management",
        };


        //BELOW WILL BE RUN AFTER CHOOSE ANY COURSE 

        //Chỉ chọn theo môn
        static public List<string> IT = new List<string>()
        {
            "Programing C",
            "Computer architecture and Operating system",
            "Software technology",

            "Programming technique",
            "Object-oriented programming",
            "Web programming",
            "Data structures and algorithms",
            "Practice database fundamentals",
            "Pratice graph theory",

             "Artificial intelligence",
            "Programming on the Windows platform",
            "Practical application programming with Java",
            "Information technology project management",
            "Computer network",
            "Information security",
        }; //always in afternoon //IT (1)
        static public List<string> Math = new List<string>()
        {

            "Linear algebra",
            "Probability and statistics",
            "Discrete mathematics"

        }; //except this only in morning //IT (2)
        static public List<string> Practice = new List<string>()
        {
            "Practice programing C",
            "Practice computer architecture",
            "Practice operating system",
            "Practice data structures and algorithms",
            "Practice database management",
            "Practice object-oriented programming",
            "Practice programming on the Windows platform",
            "Practice computer network",
        }; //always in Saturday and Thursday, once/week //IT (3)
        static public List<string> Extra = new List<string>()
        {
            "Project design 1",
            "Project design 2",
            "Corporate culture",
            "Business reality",
            "Marxism-Leninism philosophy",
            "Marxism-Leninism political economy",
            "Business communication skills"

        }; //mostly morning (except "Project design 2"), with student year 4 can choose freely //VJIT, SC, DP
        static public List<string> DP = new List<string>()
        {
            "National defense and security 1",
            "National defense and security 2",
            "National defense and security 3",
            "National defense and security 4",
        }; //1 and 2 go with 3 in morning, 4 only in afernoon (2-3, 4-5)
        static public List<string> TA = new List<string>()
        {
            "English 1",
            "English 2",
            "English 3",
            "English 4",
            "English 5",
            "English 6",
            "English 7",
            "English 8",
            "English 9",
            "English 10",
            "English 11",
        }; //always in morning (2, 4, 6)
        static public List<string> PE = new List<string>()
        {
            "Vovinam 1",
            "Vovinam 2",
            "Vovinam 3",
        }; //always in afternoon (2-5, 3-6, 4-7)




        //From this 


        //Year 1
        static public List<string> sv1_HK1A_IT = new List<string>()
        {
            "Programing C",
        };


        static public List<string> sv1_HK1A_Practice = new List<string>()
        {
            "Practice programing C",

        };
        static public List<string> sv1_HK1A_DP = new List<string>()
        {
            "National defense and security 1",
            "National defense and security 2",
            "National defense and security 3",
            "National defense and security 4",
        };
        static public List<string> sv1_HK1A_TA = new List<string>()
        {
            "English 1",
        };

        static public List<string> sv1_HK1B_IT = new List<string>()
        {
            "Software technology",
        };
        static public List<string> sv1_HK1B_Math = new List<string>()
        {
            "Linear algebra",
        };
        static public List<string> sv1_HK1B_Extra = new List<string>()
        {
            "Corporate culture",
        };
        static public List<string> sv1_HK1B_TA = new List<string>()
        {
            "English 2",
        };


        //HK2 - NAM 1
        static public List<string> sv1_HK2A_IT = new List<string>()
        {
            "Computer architecture and Operating system",
        };
        static public List<string> sv1_HK2A_Math = new List<string>()
        {
            "Discrete mathematics",
        };
        static public List<string> sv1_HK2A_Practice = new List<string>()
        {
            "Practice computer architecture",
        };
        static public List<string> sv1_HK2A_TA = new List<string>()
        {
            "English 3",
        };
        static public List<string> sv1_HK2A_PE = new List<string>()
        {
            "Vovinam 1",
        };

        static public List<string> sv1_HK2B_IT = new List<string>()
        {
            "Computer architecture and Operating system",
        };
        static public List<string> sv1_HK2B_Practice = new List<string>()
        {
            "Practice operating system",
        };
        static public List<string> sv1_HK2B_Extra = new List<string>()
        {
            "Project design 1",
        };
        static public List<string> sv1_HK2B_TA = new List<string>()
        {
            "English 4",
        };

        //Year 2
        static public List<string> sv2_HK1A_IT = new List<string>()
        {
            "Data structures and algorithms",
            "Pratice graph theory",
        };
        static public List<string> sv2_HK1A_TA = new List<string>()
        {
            "English 5",
        };
        static public List<string> sv2_HK1A_Practice = new List<string>()
        {
            "Practice data structures and algorithms",
        };

        static public List<string> sv2_HK1B_IT = new List<string>()
        {
            "Practice database fundamentals",
            "Programming technique",
        };
        static public List<string> sv2_HK1B_Practice = new List<string>()
        {
            "Practice database management",
        };
        static public List<string> sv2_HK1B_TA = new List<string>()
        {
            "English 6",
        };


        //HK2 - NAM 2
        static public List<string> sv2_HK2A_IT = new List<string>()
        {
            "Object-oriented programming",
        };
        static public List<string> sv2_HK2A_Practice = new List<string>()
        {
            "Practice object-oriented programming",
        };
        static public List<string> sv2_HK2A_TA = new List<string>()
        {
            "English 7",
        };
        static public List<string> sv2_HK2A_PE = new List<string>()
        {
            "Vovinam 2",
        };

        static public List<string> sv2_HK2B_IT = new List<string>()
        {
            "Web programming",
        };
        static public List<string> sv2_HK2B_Extra = new List<string>()
        {
            "Project design 2",
        };
        static public List<string> sv2_HK2B_TA = new List<string>()
        {
            "English 8",
        };

        //Year 3
        static public List<string> sv3_HK1A_IT = new List<string>()
        {
            "Practical application programming with Java",
        };
        static public List<string> sv3_HK1A_Math = new List<string>()
        {
            "Probability and statistics",
        };
        static public List<string> sv3_HK1A_TA = new List<string>()
        {
            "English 9",
        };

        static public List<string> sv3_HK1B_IT = new List<string>()
        {
            "Artificial intelligence",
            "Programming on the Windows platform",
        };
        static public List<string> sv3_HK1B_Practice = new List<string>()
        {
           "Practice programming on the Windows platform",
        };
        static public List<string> sv3_HK1B_TA = new List<string>()
        {
            "English 10",
        };

        //HK2 - NAM 3
        static public List<string> sv3_HK2A_IT = new List<string>()
        {
            "Computer network",
        };
        static public List<string> sv3_HK2A_Practice = new List<string>()
        {
            "Practice computer network",
        };
        static public List<string> sv3_HK2A_TA = new List<string>()
        {
            "English 11",
        };
        static public List<string> sv3_HK2A_PE = new List<string>()
        {
            "Vovinam 3",
        };

        static public List<string> sv3_HK2B_IT = new List<string>()
        {
            "Information technology project management",
            "Information security",
        };


        static public Dictionary<string, string> Semesters = new Dictionary<string, string>()
        {
            {"HK1A","08/21/-10/22/" },{"HK1B"  ,"11/13/-01/07/" },{"HK2A" , "02/19/-04/14/" },{"HK2B" , "05/06/-06/30/" }
        };

        static public Dictionary<string, string> SemestersDetail = new Dictionary<string, string>()
        {
            {"HK1A-start","08/21/" },
            {"HK1A-end","10/22/" },

            {"HK1B-start","11/13/" },
            {"HK1B-end","01/07/" },

            {"HK2A-start","02/19/" },
            {"HK2A-end","04/14/" },

            {"HK2B-start","05/06/" },
            {"HK2B-end","06/30/" },
        };


        /*        static public string HK1Adates = "08/21-10/22";
                static public string HK1Bdates = "11/13-01/07";
                static public string HK2Adates = "02/19-04/14";
                static public string HK2Bdates = "05/06-06/30";*/


        static public Dictionary<string, string> Sections = new Dictionary<string, string>()
        {
            {"C1","06:45:00-09:00:00" },{"C2"  ,"09:20:00-11:35:00" },{"C3" , "12:30:00-14:45:00" },{"C4" , "15:05:00-17:20:00" }
        };

        static public Dictionary<string, string> Times = new Dictionary<string, string>()
        {
            {"06:45:00", "09:00:00"},{"09:20:00", "11:35:00"},{"12:30:00", "14:45:00"},{"15:05:00", "17:20:00"}
        };


        /*static public string C1 = "06:45:00-09:00:00";
        static public string C2 = "09:20:00-11:35:00";
        static public string C3 = "12:30:00-14:45:00";
        static public string C4 = "15:05:00-17:20:00";*/
    }
}
