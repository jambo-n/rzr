using Razar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Razar.Services
{
    public class IAnouncementServices
    {
        Task<IEnumerable<Announcement>> GetAnnouncementsAsync();
       
    }
}