using MusicApp.Entities.Models;
using System.Collections.Generic;

namespace MusicApp.BusinessLogic
{
    public interface IPublisherRepository
    {
        public List<Publisher> GetAllPublishersList();
        public Publisher GetPublisher(string name);
    }
}
