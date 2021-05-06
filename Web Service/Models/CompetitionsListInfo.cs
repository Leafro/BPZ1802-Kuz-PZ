
namespace Web_Service.Models
{
    public class CompetitionsListInfo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Theme { get; set; }

        public string OlympiadType { get; set; }

        public string Class { get; set; }

        public string Stage { get; set; }

        public string OlympiadDate { get; set; }

        public string SchoolYear { get; set; }

        public System.Collections.Generic.List<WebS> WebSite { get; set; } = new System.Collections.Generic.List<WebS>();

    }
}