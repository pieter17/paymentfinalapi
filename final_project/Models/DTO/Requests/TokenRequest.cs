using System.ComponentModel.DataAnnotations;

namespace final_project.Models.DTO.Requests
{
    public class TokenRequest
    {
        [Required] public string Token { get; set; }
        [Required] public string RefreshToken { get; set; }
    }
}