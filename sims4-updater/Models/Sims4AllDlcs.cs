using sims4_updater.Helpers;
using System.Collections.ObjectModel;

namespace sims4_updater.Models
{
    public class Sims4AllDlcs
    {
        public ObservableCollection<Sims4DLC> Sims4DLCs { get; set; } = new ObservableCollection<Sims4DLC>();

        public Sims4AllDlcs()
        {
            //Rozszerzenia (EP)
            Sims4DLCs.Add(new Sims4DLC { Code = "EP01", Name = "The Sims 4 Get to Work", Url = "https://example.com/get-to-work", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP02", Name = "The Sims 4 Get Together", Url = "https://example.com/get-together", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP03", Name = "The Sims 4 City Living", Url = "https://example.com/city-living", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP04", Name = "The Sims 4 Cats & Dogs", Url = "https://example.com/cats-and-dogs", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP05", Name = "The Sims 4 Seasons", Url = "https://example.com/seasons", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP06", Name = "The Sims 4 Get Famous", Url = "https://example.com/get-famous", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP07", Name = "The Sims 4 Island Living", Url = "https://example.com/island-living", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP08", Name = "The Sims 4 Discover University", Url = "https://example.com/discover-university", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP09", Name = "The Sims 4 Eco Lifestyle", Url = "https://example.com/eco-lifestyle", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP10", Name = "The Sims 4 Snowy Escape", Url = "https://example.com/snowy-escape", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP11", Name = "The Sims 4 Cottage Living", Url = "https://example.com/cottage-living", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP12", Name = "The Sims 4 High School Years", Url = "https://example.com/high-school-years", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP13", Name = "The Sims 4 Growing Together", Url = "https://example.com/growing-together", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP14", Name = "The Sims 4 Horse Ranch", Url = "https://example.com/horse-ranch", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP15", Name = "The Sims 4 For Rent", Url = "https://example.com/for-rent", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP16", Name = "The Sims 4 Lovestruck", Url = "https://example.com/lovestruck", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP17", Name = "The Sims 4 Life & Death", Url = "https://example.com/life-and-death", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP18", Name = "The Sims 4 Enchanted by Nature", Url = "https://example.com/enchanted-by-nature", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP19", Name = "The Sims 4 Adventure Awaits", Url = "https://example.com/adventure-awaits", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP20", Name = "The Sims 4 Business & Hobbies", Url = "https://example.com/business-hobbies", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "EP21", Name = "The Sims 4 Royalty & Legacy", Url = "https://example.com/royalty-legacy", Installed = false });
            //Pakiety (GP)
            Sims4DLCs.Add(new Sims4DLC { Code = "GP01", Name = "The Sims 4 Outdoor Retreat", Url = "https://example.com/outdoor-retreat", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP02", Name = "The Sims 4 Spa Day", Url = "https://example.com/spa-day", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP03", Name = "The Sims 4 Dine Out", Url = "https://example.com/dine-out", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP04", Name = "The Sims 4 Vampires", Url = "https://example.com/vampires", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP05", Name = "The Sims 4 Parenthood", Url = "https://example.com/parenthood", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP06", Name = "The Sims 4 Jungle Adventure", Url = "https://example.com/jungle-adventure", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP07", Name = "The Sims 4 StrangerVille", Url = "https://example.com/strangerville", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP08", Name = "The Sims 4 Realm of Magic", Url = "https://example.com/realm-of-magic", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP09", Name = "The Sims 4 Star Wars: Journey to Batuu", Url = "https://example.com/journey-to-batuu", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP10", Name = "The Sims 4 Dream Home Decorator", Url = "https://example.com/dream-home-decorator", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP11", Name = "The Sims 4 My Wedding Stories", Url = "https://example.com/my-wedding-stories", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "GP12", Name = "The Sims 4 Werewolves", Url = "https://example.com/werewolves", Installed = false });
            //Akcesoria (SP)
            Sims4DLCs.Add(new Sims4DLC { Code = "SP01", Name = "The Sims 4 Luxury Party Stuff", Url = "https://example.com/luxury-party", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP02", Name = "The Sims 4 Perfect Patio Stuff", Url = "https://example.com/perfect-patio", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP03", Name = "The Sims 4 Cool Kitchen Stuff", Url = "https://example.com/cool-kitchen", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP04", Name = "The Sims 4 Spooky Stuff", Url = "https://example.com/spooky-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP05", Name = "The Sims 4 Movie Hangout Stuff", Url = "https://example.com/movie-hangout", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP06", Name = "The Sims 4 Romantic Garden Stuff", Url = "https://example.com/romantic-garden", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP07", Name = "The Sims 4 Kids Room Stuff", Url = "https://example.com/kids-room", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP08", Name = "The Sims 4 Backyard Stuff", Url = "https://example.com/backyard-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP09", Name = "The Sims 4 Vintage Glamour Stuff", Url = "https://example.com/vintage-glamour", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP10", Name = "The Sims 4 Bowling Night Stuff", Url = "https://example.com/bowling-night", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP11", Name = "The Sims 4 Fitness Stuff", Url = "https://example.com/fitness-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP12", Name = "The Sims 4 Toddler Stuff", Url = "https://example.com/toddler-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP13", Name = "The Sims 4 Laundry Day Stuff", Url = "https://example.com/laundry-day", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP14", Name = "The Sims 4 My First Pet Stuff", Url = "https://example.com/my-first-pet", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP15", Name = "The Sims 4 Moschino Stuff", Url = "https://example.com/moschino-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP16", Name = "The Sims 4 Tiny Living Stuff", Url = "https://example.com/tiny-living", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP17", Name = "The Sims 4 Nifty Knitting Stuff", Url = "https://example.com/nifty-knitting", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP18", Name = "The Sims 4 Paranormal Stuff", Url = "https://example.com/paranormal-stuff", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP46", Name = "The Sims 4 Home Chef Hustle Stuff", Url = "https://example.com/home-chef-hustle", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP49", Name = "The Sims 4 Crystal Creations Stuff", Url = "https://example.com/crystal-creations", Installed = false });
            // Kolekcje (Kits)
            Sims4DLCs.Add(new Sims4DLC { Code = "SP20", Name = "The Sims 4 Throwback Fit Kit", Url = "https://example.com/throwback-fit", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP21", Name = "The Sims 4 Country Kitchen Kit", Url = "https://example.com/country-kitchen", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP22", Name = "The Sims 4 Bust the Dust Kit", Url = "https://example.com/bust-the-dust", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP23", Name = "The Sims 4 Courtyard Oasis Kit", Url = "https://example.com/courtyard-oasis", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP24", Name = "The Sims 4 Industrial Loft Kit", Url = "https://example.com/industrial-loft", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP25", Name = "The Sims 4 Fashion Street Kit", Url = "https://example.com/fashion-street", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP26", Name = "The Sims 4 Incheon Arrivals Kit", Url = "https://example.com/incheon-arrivals", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP28", Name = "The Sims 4 Modern Menswear Kit", Url = "https://example.com/modern-menswear", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP29", Name = "The Sims 4 Blooming Rooms Kit", Url = "https://example.com/blooming-rooms", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP30", Name = "The Sims 4 Carnaval Streetwear Kit", Url = "https://example.com/carnaval-streetwear", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP31", Name = "The Sims 4 Décor to the Max Kit", Url = "https://example.com/decor-to-the-max", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP32", Name = "The Sims 4 Moonlight Chic Kit", Url = "https://example.com/moonlight-chic", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP33", Name = "The Sims 4 Little Campers Kit", Url = "https://example.com/little-campers", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP34", Name = "The Sims 4 First Fits Kit", Url = "https://example.com/first-fits", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP35", Name = "The Sims 4 Desert Luxe Kit", Url = "https://example.com/desert-luxe", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP36", Name = "The Sims 4 Pastel Pop Kit", Url = "https://example.com/pastel-pop", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP37", Name = "The Sims 4 Everyday Clutter Kit", Url = "https://example.com/everyday-clutter", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP38", Name = "The Sims 4 Simtimates Collection Kit", Url = "https://example.com/simtimates-collection", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP39", Name = "The Sims 4 Bathroom Clutter Kit", Url = "https://example.com/bathroom-clutter", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP40", Name = "The Sims 4 Greenhouse Haven Kit", Url = "https://example.com/greenhouse-haven", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP41", Name = "The Sims 4 Basement Treasures Kit", Url = "https://example.com/basement-treasures", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP42", Name = "The Sims 4 Grunge Revival Kit", Url = "https://example.com/grunge-revival", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP43", Name = "The Sims 4 Book Nook Kit", Url = "https://example.com/book-nook", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP44", Name = "The Sims 4 Poolside Splash Kit", Url = "https://example.com/poolside-splash", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP45", Name = "The Sims 4 Modern Luxe Kit", Url = "https://example.com/modern-luxe", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP47", Name = "The Sims 4 Goth Galore Kit", Url = "https://example.com/goth-galore", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP48", Name = "The Sims 4 Castle Estate Kit", Url = "https://example.com/castle-estate", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP50", Name = "The Sims 4 Urban Homage Kit", Url = "https://example.com/urban-homage", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP51", Name = "The Sims 4 Party Essentials Kit", Url = "https://example.com/party-essentials", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP52", Name = "The Sims 4 Riviera Retreat Kit", Url = "https://example.com/riviera-retreat", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP53", Name = "The Sims 4 Cozy Bistro Kit", Url = "https://example.com/cozy-bistro", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP54", Name = "The Sims 4 Artist Studio Kit", Url = "https://example.com/artist-studio", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP55", Name = "The Sims 4 Storybook Nursery Kit", Url = "https://example.com/storybook-nursery", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP56", Name = "The Sims 4 Sweet Slumber Party Kit", Url = "https://example.com/sweet-slumber-party", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP57", Name = "The Sims 4 Sleepover Sleepwear Kit", Url = "https://example.com/sleepover-sleepwear", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP58", Name = "The Sims 4 Tea Time Solarium Kit", Url = "https://example.com/tea-time-solarium", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP59", Name = "The Sims 4 Silver Screen Style Kit", Url = "https://example.com/silver-screen-style", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP68", Name = "The Sims 4 SpongeBob's House Kit", Url = "https://mega.nz/file/8jYkzZ7K#V3w6AHfnwymtHzSk9eoarOOEN4QgcM2gP7uEn1I2Le0", Installed = false });
            Sims4DLCs.Add(new Sims4DLC { Code = "SP61", Name = "The Sims 4 SpongeBob Kid's Room Kit", Url = "https://example.com/spongebob-kids-room", Installed = false });
        }


        public async Task DownloadAndInstallSelectedDlcsAsync(Logger logger, string gamepath)
        {
            int maxProgress = Sims4DLCs.Count(dlc => dlc.ToInstall && !dlc.Installed) * 4;
            int currentProgress = 0;

            foreach (var dlc in Sims4DLCs)
            {
                if (dlc.ToInstall && !dlc.Installed)
                {
                    logger.AddLog($"Downloading DLC: {dlc.Code} - {dlc.Name}");
                    await Task.Run(() => dlc.Download());

                    currentProgress++;
                    StaticsVariables.Instance.Progress = (currentProgress * 100) / maxProgress;

                    logger.AddLog($"Extracting DLC: {dlc.Code} - {dlc.Name}");
                    await Task.Run(() => dlc.Extract(logger));

                    currentProgress++;
                    StaticsVariables.Instance.Progress = (currentProgress * 100) / maxProgress;

                    logger.AddLog($"Installing DLC: {dlc.Code} - {dlc.Name}");
                    await Task.Run(() => dlc.Install(gamepath, logger));

                    currentProgress++;
                    StaticsVariables.Instance.Progress = (currentProgress * 100) / maxProgress;

                    logger.AddLog($"Installed DLC: {dlc.Code} - {dlc.Name}");
                    logger.AddLog($"Clearing TEMP files");
                    await Task.Run(() => dlc.Remove(logger));

                    currentProgress++;
                    StaticsVariables.Instance.Progress = (currentProgress * 100) / maxProgress;

                    logger.AddLog("---------------------------------------------");
                }
            }
        }
    }
}
