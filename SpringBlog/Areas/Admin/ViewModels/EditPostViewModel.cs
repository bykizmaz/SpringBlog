﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpringBlog.Helpers;
using SpringBlog.Models;

namespace SpringBlog.Areas.Admin.ViewModels
{
    public class EditPostViewModel
    {
        public int Id { get; set; }
        
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [AllowHtml]
        public string Content { get; set; }

        public string CurrentFeaturedImage { get; set; }

        [Display(Name = "Created")]
        public DateTime CreationTime { get; set; }

        [Display(Name = "Last Modified")]
        public DateTime ModificationTime { get; set; }

        [PostedImage]
        public HttpPostedFileBase FeaturedImage { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Short Url")]
        public string Slug { get; set; }

    }
}