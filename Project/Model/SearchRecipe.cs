using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class SearchRecipe
    {
        #region Attributes
        private List<Result> _results;
        private string _baseUri;
        private int _offset;
        private int _number;
        private int _totalResults;
        private int _processingTimeMs;
        private double _expires;
        #endregion

        #region Properties
        public double Expires
        {
            get { return _expires; }
            set { _expires = value; }
        }
        public int ProcessingTimeMs
        {
            get { return _processingTimeMs; }
            set { _processingTimeMs = value; }
        }
        public int TotalResults
        {
            get { return _totalResults; }
            set { _totalResults = value; }
        }
        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        public int Offset
        {
            get { return _offset; }
            set { _offset = value; }
        }
        public string BaseUri
        {
            get { return _baseUri; }
            set { _baseUri = value; }
        }
        public List<Result> Results
        {
            get { return _results; }
            set { _results = value; }
        }
        #endregion

        #region Constructor
        public SearchRecipe()
        {
            _results = new List<Result>();
        }
        #endregion
    }
}
