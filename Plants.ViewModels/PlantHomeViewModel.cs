﻿namespace Plants.Models
{
	using static Services.Constants.GlobalConstants.ErrorMessages;
	using static Services.Constants.GlobalConstants.PlantConstants;

	using System.ComponentModel.DataAnnotations;

	public class PlantHomeViewModel
	{
		[Required(ErrorMessage = RequiredErrorMessage)]
		public required int Id { get; set; }

        [Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(PlantNameMaxLenght, MinimumLength = PlantNameMinLenght,
		  ErrorMessage = StringLenghtErrorMessage)]
		public required string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredErrorMessage)]
		[StringLength(PlantScientificNameMaxLenght, MinimumLength = PlantScientificNameMinLenght,
			ErrorMessage = StringLenghtErrorMessage)]
		public required string ScientificName { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredErrorMessage)]
		public required string ImageUrl { get; set; }

		public int? UserId { get; set; }
	}
}
