using System.ComponentModel.DataAnnotations;

namespace abpVue.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}