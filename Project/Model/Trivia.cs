using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Trivia
    {
        #region Attributes
        private string _text;
        #endregion

        #region Properties
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }
        #endregion

        #region Constructor
        public Trivia()
        {

        }
        #endregion
    }
}
