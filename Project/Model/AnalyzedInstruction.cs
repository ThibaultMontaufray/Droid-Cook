using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class AnalyzedInstruction
    {
        #region Attributes
        private string _name;
        private List<Step> _steps;
        #endregion

        #region Properties
        public List<Step> Steps
        {
            get { return _steps; }
            set { _steps = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructor
        public AnalyzedInstruction()
        {
            _steps = new List<Step>();
        }
        #endregion
    }
}
