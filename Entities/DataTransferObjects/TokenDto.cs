namespace Entities.DataTransferObjects
{
    public record TokenDto
    {
        public String AccessToken { get; set; }
        public String RefreshToken { get; set; }
    }
}
