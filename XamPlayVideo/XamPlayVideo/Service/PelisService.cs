namespace XamPlayVideo.Service
{
    using System.Collections.Generic;
    using System.Linq;
    using XamPlayVideo.Model;

    public class PelisService : IPelisService
    {
        public List<Movie> Movies { get; set; }

        public PelisService()
        {
            this.Movies = new List<Movie> {
                new Movie { 
                    Id = 1,
                    Title = "A Good Woman Is Hard To Find",
                    Synopsis = "Set in the underbelly of Northern Ireland, A Good Woman is Hard to Find follows Sarah Collins (Sarah Bolger, “Mayans M.C.”, "
                             + "“The Tudors”, Emelie), a single mother struggling to raise two young children while searching for answers about the unsolved"
                             + " murder of her husband. After being coerced into helping a low-level drug dealer stash stolen narcotics, she finds herself the"
                             + " target of local crime boss Leo Miller (Edward Hogg). Forced to take desperate measures to keep her family safe, Sarah turns the "
                             + "tables on her victimizers in one final act of bloody vengeance.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/108377.jpg",
                    Url = "https://movietrailers.apple.com/movies/independent/a-good-woman-is-hard-to-find/a-good-woman-is-hard-to-find-trailer-1_h480p.mov",
                    IsFeatured = true
                },
                new Movie {
                    Id = 2,
                    Title = "The Legion",
                    Synopsis = "Mickey Rourke and Bai Ling star in this epic tale of courage and heroism in a time of war. During the invasion of Parthia, two "
                             + "Roman legions have been brought to a standstill in the snowy mountains of Armenia, leaving them slowly dying in the freezing cold."
                             + " The rest of the Roman army is a two weeks’ march away, and the region swarms with Parthian patrols. Their only hope for survival is"
                             + " Noreno, a half-Roman soldier, who is entrusted with the impossible mission of crossing the deadly terrain to seek help for his men"
                             + " and turn the tide of the battle.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/139941.jpg",
                    Url = "https://movietrailers.apple.com/movies/paramount_classics/the-legion/the-legion-trailer-1_h480p.mov",
                    IsFeatured = false
                },
                new Movie {
                    Id = 3,
                    Title = "Walkaway Joe",
                    Synopsis = "WALKAWAY JOE is the story of an unlikely friendship between a young boy searching for his father in pool halls across the country,"
                             + " and a wandering loner hiding from his past. In each other they experience the power of a second chance, and a shot at redemption.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/119390.jpg",
                    Url = "https://movietrailers.apple.com/movies/independent/walkaway-joe/walkaway-joe-trailer-1_h480p.mov",
                    IsFeatured = false
                },
                new Movie {
                    Id = 4,
                    Title = "Hope Gap",
                    Synopsis = "The intimate, intense and loving story of HOPE GAP charts the life of Grace (Annette Bening), shocked to learn her husband (Bill Nighy)"
                             + " is leaving her for another after 29 years of marriage, and the ensuing emotional fallout the dissolution has on their only grown son "
                             + "(Josh O’Connor). Unraveled and feeling displaced in her small seaside town, Grace ultimately regains her footing and discovers a new,"
                             + " powerful voice.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/78216.jpg",
                    Url = "https://movietrailers.apple.com/movies/roadsideattractions/hope-gap/hope-gap-trailer-1_h480p.mov",
                    IsFeatured = false
                },
                new Movie {
                    Id = 5,
                    Title = "Spaceship Earth",
                    Synopsis = "Spaceship Earth is the true, stranger-than-fiction, adventure of eight visionaries who in 1991 spent two years quarantined inside of a"
                             + " self-engineered replica of Earth’s ecosystem called BIOSPHERE 2. The experiment was a worldwide phenomenon, chronicling daily existence"
                             + " in the face of life threatening ecological disaster and a growing criticism that it was nothing more than a cult. The bizarre story is"
                             + " both a cautionary tale and a hopeful lesson of how a small group of dreamers can potentially reimagine a new world.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/129311.jpg",
                    Url = "https://movietrailers.apple.com/movies/independent/spaceship-earth/spaceship-earth-trailer-1d_h480p.mov",
                    IsFeatured = false
                },
                new Movie {
                    Id = 6,
                    Title = "Valley Girl",
                    Synopsis = "Julie (Jessica Rothe) is the ultimate ‘80s Valley Girl. A creative free spirit; Julie’s time is spent with her best friends shopping at "
                             + "the Galleria mall and making plans for senior prom. That is, until she falls hard for Randy (Joshua Whitehouse), a Sunset Strip punk rocker, "
                             + "who challenges everything the Valley and Julie stand for. Despite push-back from friends and family, Julie must break out of the safety of"
                             + " her world to follow her heart and discover what it really means to be a Valley Girl. Set to a rock ’n roll ‘80s soundtrack produced by"
                             + " legendary Harvey Mason, Jr. with dance numbers by choreographer Mandy Moore, Valley Girl is a musical adaptation of the classic 1983 hit"
                             + " film that changed American teenage life forever.",
                    Thumbnail = "https://devcrux.com/wp-content/uploads/136537.jpg",
                    Url = "https://movietrailers.apple.com/movies/independent/valley-girl/valley-girl-trailer-1_h480p.mov",
                    IsFeatured = false
                },
            };
        }

        public List<Movie> GetMovies()
        {
            return this.Movies;
        }

        public void SetFeatured(int id) {
            this.Movies.ForEach(m => m.IsFeatured = false);
            this.Movies.Where(m => m.Id.Equals(id)).FirstOrDefault().IsFeatured = true;
        }
    }
}
