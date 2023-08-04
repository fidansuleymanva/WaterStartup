
namespace WaterStartup.Model
{
    public class Ocean_theme
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 256, ErrorMessage = "Title size is too much!")]
        public string Title { get; set; }
        [StringLength(maximumLength: 256, ErrorMessage = "Description size is too much!")]
        public string Description { get; set; }
        public string URL { get; set; }
    }
}
