using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class MealPlan
    {
        #region Attributes
        private string _name;
        private List<Item> _items;
        #endregion

        #region Properties
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion

        #region Constructor
        public MealPlan()
        {
            _items = new List<Item>();
        }
        #endregion
    }
}
