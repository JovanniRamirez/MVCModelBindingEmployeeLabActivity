using System.ComponentModel.DataAnnotations;

namespace MVCModelBindingEmployee.Models
{
	public class Employee
	{
		[Required(ErrorMessage = "Need valid first name")]
		[Display(Name = "First Name")]
		/// <summary>
		/// First Name of the Employee
		/// </summary>
        public string FirstName { get; set; }

		[Required(ErrorMessage ="Need valid last name")]
		[Display(Name = "Last Name")]
		/// <summary>
		/// Last Name of the Employee
		/// </summary>
		public string LastName { get; set; }

		[Required(ErrorMessage ="Valid Email required")]
		[Display(Name = "Email")]
		/// <summary>
		/// Employee Email
		/// </summary>
		public string Email { get; set; }

		[Required(ErrorMessage ="Enter a valid start date")]
		[Display(Name = "Start date")]
		[DataType(DataType.Date)]
		/// <summary>
		/// Employee Start date
		/// </summary>
		public DateOnly DateStart { get; set; }

		[Display(Name ="End Date Optional")]
		[DataType(DataType.Date)]
		/// <summary>
		/// Employee end date optional
		/// </summary>
		public DateOnly? DateEnd { get; set; }

		[Required(ErrorMessage ="Enter a valid Birth date")]
		[Display(Name ="Birth Date")]
		[DataType(DataType.Date)]
		/// <summary>
		/// Employee Date of Birth
		/// </summary>
		public DateOnly DateOfBirth { get; set; }

		[Required(ErrorMessage ="Enter valid years of experience")]
		[Display(Name ="Years of Experience")]
		[Range(0, double.MaxValue, ErrorMessage= "Years must be equal or greater than 0.")]
		/// <summary>
		/// Employee Years of work experience 
		/// </summary>
		public int YearsOFExperience { get; set; }

		[Required(ErrorMessage = "Valid job title required")]
		[Display(Name = "Job Title")]
		/// <summary>
		/// Employee job title
		/// </summary>
		public string JobTitle { get; set; }

		[Required(ErrorMessage = "Valid Job description required")]
		[Display(Name = "Job Description")]
		/// <summary>
		/// Employee Job description
		/// </summary>
		public string JobDescription { get; set; }

		[Required(ErrorMessage = "Valid selection required (full/half")]
		[Display(Name = "Full time or Half time")]
		/// <summary>
		/// Employee job status as full or part time
		/// </summary>
		public string FullTimeOrHalfTime { get; set; }
	}
}
