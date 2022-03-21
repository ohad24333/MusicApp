using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicApp.BusinessLogic
{
    public class PublisherRepository : IDisposable, IPublisherRepository
    {
        private MusicAppDBContext _context;
        public PublisherRepository()
        {
            _context = new MusicAppDBContext();
        }
        public List<Publisher> GetAllPublishersList()
        {
            return _context.Publishers.Select(p => p).ToList();
        }
        public Publisher GetPublisher(string name)
        {
            return _context.Publishers.Single(p => p.CompanyName == name);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
