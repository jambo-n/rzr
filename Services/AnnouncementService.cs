using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Razar.Models;


namespace Razar.Services
{
    public interface AnnouncementService : IAnouncementServices
    {

        public async Task<IEnumerable<Announcement>> GetAnnouncementsAsync()
        {
            List<Announcement> announcements = new List<Announcement>()
            {
                new Announcement() {Title = "Announcement 1", Content = "I'm baby chia yuccie deep v taxidermy bespoke put a bird on it. Church-key fanny pack roof party vice. Butcher bespoke ennui, thundercats wayfarers hot chicken chia poke try-hard listicle succulents. Food truck bushwick brooklyn tousled, disrupt semiotics post-ironic church-key pop-up. Keffiyeh hammock yuccie, pickled meggings tumblr palo santo yr small batch pop-up post-ironic etsy roof party lomo tacos."},
                new Announcement() {Title = "Announcement 1", Content = "Tilde scenester tattooed, tumblr lyft bitters franzen selfies hot chicken jean shorts tacos ramps. Air plant bicycle rights pour-over locavore vice. Truffaut direct trade heirloom pickled, sartorial pork belly fixie meditation mixtape next level helvetica. Before they sold out tattooed you probably haven't heard of them, squid listicle unicorn tacos sustainable."},
                new Announcement() {Title = "Announcement 1", Content = "Squid edison bulb ennui tote bag humblebrag adaptogen XOXO coloring book swag snackwave art party farm-to-table man bun. Small batch vinyl wolf affogato typewriter brooklyn hell of pop-up. Man braid authentic readymade la croix raclette microdosing umami. Listicle snackwave affogato copper mug gentrify irony hell of taxidermy. Umami heirloom VHS retro photo booth tumblr. Gochujang quinoa wolf pop-up schlitz succulents hella man bun, brunch iceland williamsburg. Jianbing cardigan copper mug humblebrag cloud bread twee etsy palo santo shabby chic."}

            };
            return announcements;
        } 
    }
}