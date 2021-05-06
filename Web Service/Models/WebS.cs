
namespace Web_Service.Models
{
    public class WebS
    {
        public int Id { get; set; }

        public string WebSite { get; set; }

        public System.Collections.Generic.List<CompetitionsListInfo> CompetitionsListInfo { get; set; } = new System.Collections.Generic.List<CompetitionsListInfo>();

    }
}