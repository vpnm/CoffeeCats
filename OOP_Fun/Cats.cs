using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fun
{
    public class Cats
    {
        #region Cat
        public string catName;
       
        #endregion

        public string catName2;

        #region Names
        public string _catNames
        {
            get { return catName; }
            set { catName = value;  }
        }

        public string _catNames2
        {
            get { return catName2; }
            set { catName2 = value; }
        }
        #endregion


    }
}
