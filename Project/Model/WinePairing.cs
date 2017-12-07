using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class WinePairing
    {
        #region Attributes
        private List<string> _pairedWines;
        private string _pairingText;
        private List<Product> _productMatches;
        #endregion

        #region Properties
        public List<Product> ProductMatches
        {
            get { return _productMatches; }
            set { _productMatches = value; }
        }
        public string PairingText
        {
            get { return _pairingText; }
            set { _pairingText = value; }
        }
        public List<string> PairedWines
        {
            get { return _pairedWines; }
            set { _pairedWines = value; }
        }
        #endregion

        #region Constructor
        public WinePairing()
        {
            _productMatches = new List<Product>();
            _pairedWines = new List<string>();
        }
        #endregion
    }
}
