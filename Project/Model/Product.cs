using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Product
    {
        #region Attributes
        private int _id;
        private string _title;
        private string _description;
        private string _price;
        private int _likes;
        private List<string> _badges;
        private List<string> _importantBadges;
        private Nutrition _nutrition;
        private string _servingSize;
        private string _numberOfServings;
        private string _imageUrl;
        private int _averageRating;
        private int _ratingCount;
        private long _score;
        private string _link;
        private int _spoonacularScore;
        private List<string> _breadcrumbs;
        private string _generatedText;
        private List<Ingredient> _ingredients;
        private int _ingredientCount;
        private string _ingredientList;
        #endregion

        #region Properties
        public string Link
        {
            get { return _link; }
            set { _link = value; }
        }
        public long Score
        {
            get { return _score; }
            set { _score = value; }
        }
        public int RatingCount
        {
            get { return _ratingCount; }
            set { _ratingCount = value; }
        }
        public int AverageRating
        {
            get { return _averageRating; }
            set { _averageRating = value; }
        }
        public string ImageUrl
        {
            get { return _imageUrl; }
            set { _imageUrl = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
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
        public string NumberOfServings
        {
            get { return _numberOfServings; }
            set { _numberOfServings = value; }
        }
        public string ServingSize
        {
            get { return _servingSize; }
            set { _servingSize = value; }
        }
        public Nutrition Nutrition
        {
            get { return _nutrition; }
            set { _nutrition = value; }
        }
        public List<string> ImportantBadges
        {
            get { return _importantBadges; }
            set { _importantBadges = value; }
        }
        public List<string> Badges
        {
            get { return _badges; }
            set { _badges = value; }
        }
        public int Likes
        {
            get { return _likes; }
            set { _likes = value; }
        }
        public string IngredientList
        {
            get { return _ingredientList; }
            set { _ingredientList = value; }
        }
        public int IngredientCount
        {
            get { return _ingredientCount; }
            set { _ingredientCount = value; }
        }
        public List<Ingredient> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; }
        }
        public string GeneratedText
        {
            get { return _generatedText; }
            set { _generatedText = value; }
        }
        public List<string> Breadcrumbs
        {
            get { return _breadcrumbs; }
            set { _breadcrumbs = value; }
        }
        public int SpoonacularScore
        {
            get { return _spoonacularScore; }
            set { _spoonacularScore = value; }
        }
        #endregion

        #region Constructor
        public Product()
        {
            _nutrition = new Nutrition();
            _importantBadges = new List<string>();
            _badges = new List<string>();
            _ingredients = new List<Ingredient>();
            _breadcrumbs = new List<string>();
        }
        #endregion
    }
}
