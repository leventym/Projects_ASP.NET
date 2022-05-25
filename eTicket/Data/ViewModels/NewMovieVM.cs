using eTicket.Data;
using eTicket.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTicket.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Price in SEK")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Movie poster URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Movie category is required")]
        public MovieCategory MovieCategory { get; set; }


        //Relationships
        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Actor(s) is required")]
        public List<int> ActorIds { get; set; }


        //Cinema
        [Display(Name = "Select cinema(s)")]
        [Required(ErrorMessage = "Cinema(s) is required")]
        public int CinemaId { get; set; }


        //Producer
        [Display(Name = "Select producer(s)")]
        [Required(ErrorMessage = "Producer(s) is required")]
        public int ProducerId { get; set; }

    }
}
