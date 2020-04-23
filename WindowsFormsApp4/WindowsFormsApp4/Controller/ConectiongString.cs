using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controller
{
    class ConectiongString
    {
        public static string constr
        {
            get 
            {
                return ConfigurationManager.ConnectionStrings["WindowsFormsApp4.Properties.Settings.ConnStr"].ConnectionString;

            }
        }
    }
}
