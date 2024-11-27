using PurpleApp.Models;

namespace PurpleApp.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Work> Works { get; set; }
    }
}
