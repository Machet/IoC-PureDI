using System.Collections.Generic;

namespace PureCinema.Business.DTO
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<SeanseDTO> ShowTimes { get; set; }
    }
}
