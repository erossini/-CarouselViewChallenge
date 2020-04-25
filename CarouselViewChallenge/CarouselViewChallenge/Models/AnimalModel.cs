using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CarouselViewChallenge.Models
{
    /// <summary>
    /// Class AnimalModel.
    /// </summary>
    public class AnimalModel
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }
        /// <summary>
        /// Gets or sets the image path.
        /// </summary>
        /// <value>The image path.</value>
        public ImageSource ImagePath { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }
    }
}