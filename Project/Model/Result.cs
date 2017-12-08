using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid_Cook.Model
{
    public class Result
    {
        #region Attributes
        private int _id;
        private string _title;
        private int _readyInMinutes;
        private string _image;
        private List<string> _imageUrls;
        #endregion

        #region Properties
        public List<string> ImageUrls
        {
            get { return _imageUrls; }
            set { _imageUrls = value; }
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
        #endregion

        #region Constructor
        #endregion
    }
}
