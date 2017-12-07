using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Item
    {
        #region Attributes
        private int _day;
        private int _mealPlanId;
        private int _slot;
        private int _position;
        private string _type;
        private string _value;
        #endregion

        #region Properties
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public int Slot
        {
            get { return _slot; }
            set { _slot = value; }
        }
        public int MealPlanId
        {
            get { return _mealPlanId; }
            set { _mealPlanId = value; }
        }
        public int Day
        {
            get { return _day; }
            set { _day = value; }
        }
        #endregion

        #region Constructor
        public Item()
        {

        }
        #endregion
    }
}
