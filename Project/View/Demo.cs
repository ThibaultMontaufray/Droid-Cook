using Droid_Cook.Controler;
using Droid_Cook.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid_Cook
{
    public partial class Demo : Form
    {
        #region Attributes
        private SearchRecipe _searchRecipe;
        #endregion

        #region Properties
        public SearchRecipe SearchRecipe
        {
            get { return _searchRecipe; }
            set { _searchRecipe = value; }
        }
        #endregion

        #region Constructor
        public Demo()
        {
            InitializeComponent();

            textBoxDiet.Text = "vegetarian";
            textBoxExclude.Text = "coconut";
            textBoxInput.Text = "lasagne";
            numericUpDown1.Value = 10;
        }
        #endregion

        #region Methods public

        #endregion

        #region Methods private
        private void LoadRecipes()
        {
            try
            {
                string diet = textBoxDiet.Text;
                string excludeIngredient = textBoxExclude.Text;
                string instruction = checkBoxInstructionRequiered.Checked ? "true" : "false";
                string search = textBoxInput.Text;
                string response = ApiAccessor.JsonGetAuth(string.Format("{0}recipes/search?diet={1}&excludeIngredients={2}&instructionsRequired={3}&intolerances={4}&limitLicense=false&number={5}&offset=0&query={6}&type=main+course", ApiAccessor.DESTINATION, diet, excludeIngredient, instruction, "egg%2C+gluten", numericUpDown1.Value, search));
                
                // For testing : 
                //string response = "{\"results\":[{\"id\":602826,\"title\":\"Raw Lasagna\",\"readyInMinutes\":45,\"image\":\"Raw-Lasagna-602826.jpg\",\"imageUrls\":[\"Raw-Lasagna-602826.jpg\"]},{\"id\":759983,\"title\":\"Tortilla Lasagna with Swiss Chard\",\"readyInMinutes\":45,\"image\":\"tortilla-lasagna-with-swiss-chard-759983.jpg\",\"imageUrls\":[\"tortilla-lasagna-with-swiss-chard-759983.jpg\"]},{\"id\":618304,\"title\":\"NO NOODLE EGGPLANT LASAGNA\",\"readyInMinutes\":120,\"image\":\"NO-NOODLE-EGGPLANT-LASAGNA-618304.jpg\",\"imageUrls\":[\"NO-NOODLE-EGGPLANT-LASAGNA-618304.jpg\"]},{\"id\":602979,\"title\":\"The Best Raw Lasagna\",\"readyInMinutes\":45,\"image\":\"the-best-raw-lasagna-602979.jpg\",\"imageUrls\":[\"the-best-raw-lasagna-602979.jpg\"]},{\"id\":798607,\"title\":\"Eggplant Lasagna Rollatini\",\"readyInMinutes\":370,\"image\":\"eggplant-lasagna-rollatini-798607.jpg\",\"imageUrls\":[\"eggplant-lasagna-rollatini-798607.jpg\"]},{\"id\":612816,\"title\":\"Artichoke Lasagna\",\"readyInMinutes\":60,\"image\":\"Artichoke-Lasagna-612816.jpg\",\"imageUrls\":[\"Artichoke-Lasagna-612816.jpg\"]},{\"id\":543059,\"title\":\"Mom's Lasagna - Gluten & Dairy Free\",\"readyInMinutes\":75,\"image\":\"Moms-Lasagna---Gluten---Dairy-Free-543059.jpg\",\"imageUrls\":[\"Moms-Lasagna---Gluten---Dairy-Free-543059.jpg\"]},{\"id\":629773,\"title\":\"Polenta Enchilada Vegetarian Lasagna\",\"readyInMinutes\":40,\"image\":\"Polenta-Enchilada-Vegetarian-Lasagna-629773.jpg\",\"imageUrls\":[\"Polenta-Enchilada-Vegetarian-Lasagna-629773.jpg\"]},{\"id\":624827,\"title\":\"Polenta Lasagna Bites\",\"readyInMinutes\":45,\"image\":\"Polenta-Lasagna-Bites-624827.jpg\",\"imageUrls\":[\"Polenta-Lasagna-Bites-624827.jpg\"]},{\"id\":647563,\"title\":\"How Sweet It Is Sweet Potato Lasagne\",\"readyInMinutes\":45,\"image\":\"How-Sweet-It-Is-Sweet-Potato-Lasagne-647563.jpg\",\"imageUrls\":[\"How-Sweet-It-Is-Sweet-Potato-Lasagne-647563.jpg\"]}],\"baseUri\":\"https://spoonacular.com/recipeImages/\",\"offset\":0,\"number\":10,\"totalResults\":48,\"processingTimeMs\":265,\"expires\":1512954045041}";

                _searchRecipe = ApiAccessor.Deserialize<SearchRecipe>(response);

                ParseAnswer();

                this.Text = "Recipes";
            }
            catch (Exception exp)
            {
                this.Text = exp.Message;
            }
        }
        private void ParseAnswer()
        {
            WebRequest request;
            DataGridViewRow row;
            dataGridView1.Rows.Clear();
            foreach (var result in _searchRecipe.Results)
            {
                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Height = 100;
                dataGridView1.Rows[index].Cells[ColumnId.Index].Value = result.Id;
                dataGridView1.Rows[index].Cells[ColumnTitle.Index].Value = result.Title;
                dataGridView1.Rows[index].Cells[ColumnTime.Index].Value = result.ReadyInMinutes;

                request = WebRequest.Create(Path.Combine(_searchRecipe.BaseUri, result.Image));
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    dataGridView1.Rows[index].Cells[ColumnImage.Index].Value = Bitmap.FromStream(stream);
                }
            }
        }
        #endregion

        #region Event
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadRecipes();
        }
        #endregion
    }
}
