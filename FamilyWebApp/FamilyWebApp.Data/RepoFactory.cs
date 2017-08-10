using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FamilyWebApp.Data.Interfaces;

namespace FamilyWebApp.Data
{
    public class RepoFactory
    {
        public static IFamilyRepository Create()
        {
            string config = ConfigurationManager.AppSettings["Mode"].ToString();

            switch (config)
            {
                case "MockRepo":
                    return new MockRepo();
                case "EntityFrameworkRepo":
                    return new EntityFrameworkRepo();
            }
            return null;
        }
    }
}
