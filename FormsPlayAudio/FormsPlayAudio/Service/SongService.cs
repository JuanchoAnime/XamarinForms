namespace FormsPlayAudio.Service
{
    using FormsPlayAudio.Model;
    using System.Collections.ObjectModel;
    using Xamarin.Forms.Internals;

    public class SongService
    {
        private static SongService INSTANCE;

        public ObservableCollection<Music> Music { get; set; }

        public SongService()
        {
            this.Music = new ObservableCollection<Music>
            {
                new Music {
                    Title = "Spring Song",
                    Artist = "Chopin",
                    Direction = "chopi_spring_song.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/chopin-spring-song_fJT3KLBu_NWM.mp3",
                    IsRecent = true
                },
                new Music {
                    Title = "Moonlight Sonata",
                    Artist = "Beethoven",
                    Direction = "Music.ssm-102518-beethoven-moonlight-sonata_NWM.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/SxoktnUHBjzy8oizv/ssm-102518-beethoven-moonlight-sonata_NWM.mp3",
                },
                new Music {
                    Title = "Eine Kleine Nachtmusik",
                    Artist = "Mozart",
                    Direction = "Music.mozart-eine-kleine-nachtmusik-full_zJ8IiEVd_NWM.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/mozart-eine-kleine-nachtmusik-full_zJ8IiEVd_NWM.mp3"
                },
                new Music {
                    Title = "Fur Elise",
                    Artist = "Beethoven",
                    Direction = "Music.nc-040417-Fur-Elise-Beethoven_NWM.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/nc-040417-Fur-Elise-Beethoven_NWM.mp3"
                },
                new Music {
                    Title = "Overture 1812",
                    Artist = "Tchaikovsky",
                    Direction = "Music.tchaikovsky-1812-overture_Mk7d0MHO.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/music/mp3preview/tchaikovsky-1812-overture_Mk7d0MHO.mp3"
                },
                new Music {
                    Title = "Les Toreadors",
                    Artist = "Bizet",
                    Direction = "Music.bizet-les-toreadors_zy0CFVE__NWM.mp3",
                    Url = "https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/bizet-les-toreadors_zy0CFVE__NWM.mp3"
                },
                new Music {
                    Title = "Symphony #5 (1st Movement)",
                    Artist = "Beethoven",
                    Direction="Music.beethoven-symphony-5-1st-movement_MkPPmyBd.mp3",
                    Url="https://d1490khl9dq1ow.cloudfront.net/music/mp3preview/beethoven-symphony-5-1st-movement_MkPPmyBd.mp3"
                },
                new Music {
                    Title = "Symphony #9 (2st Movement)",
                    Artist = "Beethoven",
                    Direction="Music.beethoven-symphony-9-2nd-movement_fyPw7yrd.mp3",
                    Url="https://d1490khl9dq1ow.cloudfront.net/music/mp3preview/beethoven-symphony-9-2nd-movement_fyPw7yrd.mp3"
                },
                new Music {
                    Title = "Nutcracker (Dance Of The Sugar Plum Fairy)",
                    Artist = "Tchaikovsky",
                    Direction="Music.tchaikovsky-dance-of-the-sugar-plum-fairy_fyV_Azru_NWM.mp3",
                    Url="https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/tchaikovsky-dance-of-the-sugar-plum-fairy_fyV_Azru_NWM.mp3"
                },
                new Music {
                    Title = "In The Hall Of The Mountain King",
                    Artist = "Eduard Grieg",
                    Direction="Music.ssm-102518-in-the-hall-of-the-mountain-king_NWM.mp3",
                    Url="https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/SxoktnUHBjzy8oizv/ssm-102518-in-the-hall-of-the-mountain-king_NWM.mp3"
                },
                new Music {
                    Title = "Sueño de una Noche de Verano",
                    Artist = "Mendelssohn",
                    Direction="Music.felix-mendelssohn-wedding-march-traditional-church-organ_fyWL9ENu_NWM.mp3",
                    Url="https://d1490khl9dq1ow.cloudfront.net/audio/music/mp3preview/BsTwCwBHBjzwub4i4/felix-mendelssohn-wedding-march-traditional-church-organ_fyWL9ENu_NWM.mp3"
                }
            };
        }

        public static SongService GetInstance() 
        {
            INSTANCE = INSTANCE ?? new SongService();
            return INSTANCE;
        }

        public void SetRecient(int num) 
        {
            this.Music.ForEach(m => m.IsRecent = false);
            this.Music[num].IsRecent = true;
        }
    }
}
