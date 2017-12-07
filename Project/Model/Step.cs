using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Step
    {
        #region Attributes
        private int _number;
        private string _description;
        private List<Ingredient> _ingredients;
        private List<Equipment> _equipments;
        #endregion

        #region Properties
        public List<Equipment> Equipments
        {
            get { return _equipments; }
            set { _equipments = value; }
        }
        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        #endregion

        #region Constructor
        public Step()
        {
            _equipments = new List<Equipment>();
            _ingredients = new List<Ingredient>();
        }
        #endregion
    }
}
