using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Nutrition
    {
        #region Attributes
        private int _calories;
        private string _fat;
        private string _protein;
        private string _carbs;
        #endregion

        #region Properties
        public string Carbs
        {
            get { return _carbs; }
            set { _carbs = value; }
        }
        public string Protein
        {
            get { return _protein; }
            set { _protein = value; }
        }
        public string Fat
        {
            get { return _fat; }
            set { _fat = value; }
        }
        public int Calories
        {
            get { return _calories; }
            set { _calories = value; }
        }
        #endregion

        #region Constructor
        public Nutrition()
        {

        }
        #endregion
    }
}
