using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    public class MyIdAttribute : ValidationAttribute
    {
        public bool IsValid(int value)
        {
            if (value > 0)
            {
                return true;
            }
            return false;
        }
    }
}
