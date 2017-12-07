using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Message
    {
        #region Attributes
        private int _status;
        private int _code;
        private string _text;
        private string _link;
        #endregion

        #region Properties
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        public int Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        #endregion

        #region Constructor
        public Message()
        {

        }
        #endregion
    }
}
