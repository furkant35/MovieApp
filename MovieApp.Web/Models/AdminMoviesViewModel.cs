﻿using MovieApp.Web.Entity;
using MovieApp.Web.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Web.Models
{
    public class AdminMoviesViewModel
    {
        public List<AdminMovieViewModel> Movies { get; set; }
    }
    public class AdminMovieViewModel
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<Genre> Genres { get; set; }
    }
    public class AdminCreateMovieModel
    {
        [Display(Name = "Film adı")]
        [Required(ErrorMessage = "Film adı girmelisiniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Film adı için 3-50 karakter girmelisiniz.")]
        public string Title { get; set; }
        [Display(Name = "Film açıklama")]
        [Required(ErrorMessage = "Film açıklama girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film açıklama için 10-3000 karakter girmelisiniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public int[] GenreIds { get; set; }
        public bool isClassic { get; set; }
        [ClassicMovie(1950)]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = DateTime.Now;
    }
    public class AdminEditMovieViewModel
    {
        public int MovieId { get; set; }
        [Display(Name = "Film adı")]
        [Required(ErrorMessage = "Film adı girmelisiniz.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Film adı için 3-50 karakter girmelisiniz.")]
        public string Title { get; set; }
        [Display(Name = "Film açıklama")]
        [Required(ErrorMessage = "Film açıklama girmelisiniz.")]
        [StringLength(3000, MinimumLength = 10, ErrorMessage = "Film açıklama için 10-3000 karakter girmelisiniz.")]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "En az bir tür seçmelisiniz.")]
        public int[] GenreIds { get; set; }
    }
}
