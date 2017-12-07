using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class ExtendedIngredient
    {
        #region Attributes
        private int _id;
        private string _aisle;
        private string _image;
        private string _consistancy;
        private string _name;
        private double _amount;
        private string _unit;
        private string _unitShort;
        private string _unitLong;
        private string _originalString;
        private List<string> _metaInformation;
        #endregion

        #region Properties
        public List<string> MetaInformation
        {
            get { return _metaInformation; }
            set { _metaInformation = value; }
        }
        public string OriginalString
        {
            get { return _originalString; }
            set { _originalString = value; }
        }
        public string UnitLong
        {
            get { return _unitLong; }
            set { _unitLong = value; }
        }
        public string UnitShort
        {
            get { return _unitShort; }
            set { _unitShort = value; }
        }
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Consistancy
        {
            get { return _consistancy; }
            set { _consistancy = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public string Aisle
        {
            get { return _aisle; }
            set { _aisle = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public ExtendedIngredient()
        {
            _metaInformation = new List<string>();
        }
        #endregion
    }
}
