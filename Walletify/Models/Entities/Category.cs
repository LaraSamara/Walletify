﻿using System.ComponentModel.DataAnnotations;

namespace Walletify.Models.Entities
{
    public enum CategoryType
    {
        Spending,
        Income
    }

    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Category Name must be less than 20 chars")]
        public string Name { get; set; }

        [Required]
        public CategoryType CategoryType { get; set; }

    }
}
