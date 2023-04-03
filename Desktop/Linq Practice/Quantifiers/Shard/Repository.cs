
using System;
using System.Collections.Generic;

public static class Repository
{

    public static IEnumerable<Employee> LoadEmployees()
    {
        return new List<Employee>
            {
                    new Employee
                    {
                         Index = 1,
                         EmployeeNo = "2017-FI-1343",
                         Name = "Cochran Cole",
                         Email = "Cole.Cochran01@example.com",
                         Salary = 1032,
                         Skills = {"Javascript" , "C++" , "NodeJS"  }
                    },
                    new Employee
                    {
                         Index = 2,
                         EmployeeNo = "2018-FI-1755",
                         Name = "Jaclyn Wolfe",
                         Email = "Wolfe.Jaclyn@example.com",
                         Salary = 1924,
                         Skills = {"C#" , "Javascript" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         Index = 3,
                         EmployeeNo = "2016-IT-1441",
                         Name = "Cochran Cole",
                         Email = "Cole.Cochran02@example.com",
                         Salary = 1728,
                         Skills = {"ASP.NET" , "Javascript"  }
                    },
                    new Employee
                    {
                         Index = 4,
                         EmployeeNo = "2016-FI-3447",
                         Name = "Hester Evans",
                         Email = "Evans.Hester@example.com",
                         Salary = 1555,
                         Skills = { "CSS" , "Javascript" , "NodeJS"  }
                    },
                    new Employee
                    {
                         Index = 5,
                         EmployeeNo = "2014-IT-2956",
                         Name = "Wallace Buck",
                         Email = "Buck.Wallace@example.com",
                         Salary = 3158,
                         Skills = {"Oracle" , "HTML" , "CSS"  }
                    },
                    new Employee
                    {
                         Index = 6,
                         EmployeeNo = "2020-IT-6341",
                         Name = "Acevedo Wall",
                         Email = "Wall.Acevedo@example.com",
                         Salary = 3437,
                         Skills = {"ASP.NET"  }
                    },
                    new Employee
                    {
                         Index = 7,
                         EmployeeNo = "2021-IT-4488",
                         Name = "Jacqueline Pickett",
                         Email = "Pickett.Jacqueline@example.com",
                         Salary = 3700,
                         Skills = new() {"NodeJS"  }
                    },
                    new Employee
                    {
                         Index = 8,
                         EmployeeNo = "2017-HR-3248",
                         Name = "Oconnor Espinoza",
                         Email = "Espinoza.Oconnor@example.com",
                         Salary = 1556,
                         Skills = {"SQL Server" , "C#" , "HTML" , "C++"  }
                    },
                    new Employee
                    {
                         Index = 9,
                         EmployeeNo = "2020-AC-9097",
                         Name = "Allie Elliott",
                         Email = "Elliott.Allie@example.com",
                         Salary = 3154,
                         Skills = {"Oracle"  }
                    },
                    new Employee
                    {
                         Index = 10,
                         EmployeeNo = "2016-HR-3770",
                         Name = "Elva Decker",
                         Email = "Decker.Elva@example.com",
                         Salary = 3459,
                         Skills = {"ASP.NET" , "Javascript" , "C#"  }
                    },
                    new Employee
                    {
                         Index = 11,
                         EmployeeNo = "2020-HR-8809",
                         Name = "Hayes Beasley",
                         Email = "Beasley.Hayes@example.com",
                         Salary = 3727,
                         Skills = {"SQL Server" , "C++" , "NodeJS" , "Oracle" , "Javascript"  }
                    },
                    new Employee
                    {
                         Index = 12,
                         EmployeeNo = "2015-FI-3038",
                         Name = "Florine Cervantes",
                         Email = "Cervantes.Florine@example.com",
                         Salary = 3387,
                         Skills =  {"HTML"  }
                    },
                    new Employee
                    {
                         Index = 13,
                         EmployeeNo = "2017-AC-7409",
                         Name = "Bullock Carney",
                         Email = "Carney.Bullock@example.com",
                         Salary = 2144,
                         Skills = {"C++" , "CSS"  }
                    },
                    new Employee
                    {
                         Index = 14,
                         EmployeeNo = "2021-FI-3725",
                         Name = "Carroll Cantu",
                         Email = "Cantu.Carroll@example.com",
                         Salary = 3432,
                         Skills = {"C++" , "C#"  }
                    },
                    new Employee
                    {
                         Index = 15,
                         EmployeeNo = "2019-IT-9738",
                         Name = "Debra Hogan",
                         Email = "Hogan.Debra@example.com",
                         Salary = 2491,
                         Skills =  {"Oracle" , "NodeJS" , "HTML" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         Index = 16,
                         EmployeeNo = "2019-IT-7184",
                         Name = "Winnie Mccall",
                         Email = "Mccall.Winnie@example.com",
                         Salary = 2873,
                         Skills =  {"CSS" , "HTML"  }
                    },
                    new Employee
                    {
                         Index = 17,
                         EmployeeNo = "2015-IT-4664",
                         Name = "Manuela Berger",
                         Email = "Berger.Manuela@example.com",
                         Salary = 1725,
                         Skills = {"Oracle"  }
                    },
                    new Employee
                    {
                         Index = 18,
                         EmployeeNo = "2017-IT-3609",
                         Name = "Lakeisha Lowe",
                         Email = "Lowe.Lakeisha@example.com",
                         Salary = 3143,
                         Skills = {"NodeJS" , "Oracle" , "CSS" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         Index = 19,
                         EmployeeNo = "2016-FI-2682",
                         Name = "Stewart Lott",
                         Email = "Lott.Stewart@example.com",
                         Salary = 1466,
                         Skills = {"ASP.NET" , "C#" , "Javascript" , "SQL Server" , "HTML"  }
                    },
                    new Employee
                    {
                         Index = 20,
                         EmployeeNo = "2014-IT-3754",
                         Name = "Stafford Peck",
                         Email = "Peck.Stafford@example.com",
                         Salary = 3207,
                         Skills ={"C++" , "ASP.NET"  }
                    },
                    new Employee
                    {
                         Index = 21,
                         EmployeeNo = "2020-HR-7462",
                         Name = "Barron Bird",
                         Email = "Bird.Barron@example.com",
                         Salary = 1512,
                         Skills =  {"NodeJS" , "Javascript" , "ASP.NET"  }
                    },
                    
            };
    }
}
