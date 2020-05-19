using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyGiaoVien.ConnectionDatabase
{
    class Fixbugs
    {
       public static bool emptyError(string s)
        {
            if (s.Equals(""))
            {
                
                return false;
            }
            return true;
               
            
        }

        public static bool duplicateErrors(string s)
        {
            if (s.Equals(ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString))
                return true;

            return false ;
        }


    }
}
