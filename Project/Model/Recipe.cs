using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Recipe
    {
        #region Attributes
        private bool _vegetarian;
        private bool _vegan;
        private bool _glutenFree;
        private bool _dairyFree;
        private bool _veryHealthy;
        private bool _cheep;
        private bool _veryPopular;
        private bool _sustainable;
        private string _weightWatcherSmartPoints;
        private string _gaps;
        private bool _lowFodmap;
        private bool _ketogenic;
        private bool _whole30;
        private int _servings;
        private string _sourceUrl;
        private string _spoonacularSourceUrl;
        private int _aggregateLikes;
        private int _spoonacularScore;
        private int _healthScore;
        private string _creditText;
        private string _sourceName;
        private double _pricePerServing;
        private List<ExtendedIngredient> _extendedIngredients;
        private int _id;
        private string _title;
        private int _readyInMinutes;
        private string _image;
        private string _imageStyle;
        private List<string> _cuisines;
        private List<string> _dishTypes;
        private List<string> _diets;
        private List<string> _occasions;
        private WinePairing _winePairing;
        private string _instructions;
        private List<AnalyzedInstruction> _analyzedInstructions;
        #endregion

        #region Properties
        public List<AnalyzedInstruction> AnalyzedInstructions
        {
            get { return _analyzedInstructions; }
            set { _analyzedInstructions = value; }
        }
        public string Instructions
        {
            get { return _instructions; }
            set { _instructions = value; }
        }
        public WinePairing WinePairing
        {
            get { return _winePairing; }
            set { _winePairing = value; }
        }
        public List<string> Occasions
        {
            get { return _occasions; }
            set { _occasions = value; }
        }
        public List<string> Diets
        {
            get { return _diets; }
            set { _diets = value; }
        }
        public List<string> DishTypes
        {
            get { return _dishTypes; }
            set { _dishTypes = value; }
        }
        public List<string> Cuisines
        {
            get { return _cuisines; }
            set { _cuisines = value; }
        }
        public string ImageStyle
        {
            get { return _imageStyle; }
            set { _imageStyle = value; }
        }
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
        public int ReadyInMinutes
        {
            get { return _readyInMinutes; }
            set { _readyInMinutes = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public List<ExtendedIngredient> ExtendedIngredients
        {
            get { return _extendedIngredients; }
            set { _extendedIngredients = value; }
        }
        public double PricePerServing
        {
            get { return _pricePerServing; }
            set { _pricePerServing = value; }
        }
        public string SourceName
        {
            get { return _sourceName; }
            set { _sourceName = value; }
        }
        public string CreditText
        {
            get { return _creditText; }
            set { _creditText = value; }
        }
        public int HealthScore
        {
            get { return _healthScore; }
            set { _healthScore = value; }
        }
        public int SpoonacularScore
        {
            get { return _spoonacularScore; }
            set { _spoonacularScore = value; }
        }
        public int AggregateLikes
        {
            get { return _aggregateLikes; }
            set { _aggregateLikes = value; }
        }
        public string SpoonacularSourceUrl
        {
            get { return _spoonacularSourceUrl; }
            set { _spoonacularSourceUrl = value; }
        }
        public string SourceUrl
        {
            get { return _sourceUrl; }
            set { _sourceUrl = value; }
        }
        public int Servings
        {
            get { return _servings; }
            set { _servings = value; }
        }
        public bool Whole30
        {
            get { return _whole30; }
            set { _whole30 = value; }
        }
        public bool Ketogenic
        {
            get { return _ketogenic; }
            set { _ketogenic = value; }
        }
        public bool LowFodmap
        {
            get { return _lowFodmap; }
            set { _lowFodmap = value; }
        }
        public string Gaps
        {
            get { return _gaps; }
            set { _gaps = value; }
        }
        public string WeightWatcherSmartPoints
        {
            get { return _weightWatcherSmartPoints; }
            set { _weightWatcherSmartPoints = value; }
        }
        public bool Sustainable
        {
            get { return _sustainable; }
            set { _sustainable = value; }
        }
        public bool VeryPopular
        {
            get { return _veryPopular; }
            set { _veryPopular = value; }
        }
        public bool Cheep
        {
            get { return _cheep; }
            set { _cheep = value; }
        }
        public bool VeryHealthy
        {
            get { return _veryHealthy; }
            set { _veryHealthy = value; }
        }
        public bool DairyFree
        {
            get { return _dairyFree; }
            set { _dairyFree = value; }
        }
        public bool GlutenFree
        {
            get { return _glutenFree; }
            set { _glutenFree = value; }
        }
        public bool Vegan
        {
            get { return _vegan; }
            set { _vegan = value; }
        }
        public bool Vegetarian
        {
            get { return _vegetarian; }
            set { _vegetarian = value; }
        }
        #endregion

        #region Constructor
        public Recipe()
        {
            _analyzedInstructions = new List<AnalyzedInstruction>();
            _occasions = new List<string>();
            _diets = new List<string>();
            _dishTypes = new List<string>();
            _cuisines = new List<string>();
            _extendedIngredients = new List<ExtendedIngredient>();
        }
        #endregion
    }
}
