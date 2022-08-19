﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivingDog.Services.Models
{
    public class ListingModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public ListingModel()
        {

        }

        public ListingModel(DiveShopModel model)
        {
            Title = model.Name;
            Description = model.Description;
            Image = model.LogoUrl;
        }
    }
}