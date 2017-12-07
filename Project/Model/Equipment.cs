using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Equipment
    {
        #region Attributes
        private int _id;
        private string _name;
        private string _image;
        #endregion

        #region Properties
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Equipment()
        {

        }
        #endregion
    }
}
