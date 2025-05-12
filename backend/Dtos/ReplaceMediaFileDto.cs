namespace backend.Dtos
{
    public class ReplaceMediaFileDto
    {
        public IFormFile MediaFile { get; set; }
        public string ExistingMediaUrl { get; set; }
    }
}


//add this file to DTOs