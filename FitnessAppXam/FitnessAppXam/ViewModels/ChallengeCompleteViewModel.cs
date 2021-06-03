namespace FitnessAppXam.ViewModels
{
    using FitnessAppXam.Model;
    using MvvmHelpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class ChallengeCompleteViewModel : BaseViewModel
    {
        public ObservableCollection<Challenge> Challenges { get; set; }

        public ChallengeCompleteViewModel()
        {
            this.Challenges = new ObservableCollection<Challenge>(new List<Challenge>{
                new Challenge { Weather = "29 Days",
                                Description = "Holiday Acitvity Challenge",
                                Ended = "12/31/2020",
                                Earned = "Gift 3"},

                new Challenge { Weather = "29 Days",
                                Description = "December Acitvity Challenge",
                                Ended = "12/31/2020",
                                Earned = "Gold"},

                new Challenge { Weather = "704 min",
                                Description = "The Annual 2020",
                                Ended = "12/31/2020"},
                new Challenge { Weather = "29 Days",
                                Description = "Holiday Acitvity Challenge",
                                Ended = "12/31/2020",
                                Earned = "Gift 3"},

                new Challenge { Weather = "29 Days",
                                Description = "December Acitvity Challenge",
                                Ended = "12/31/2020",
                                Earned = "Gold"},

                new Challenge { Weather = "704 min",
                                Description = "The Annual 2020",
                                Ended = "12/31/2020"},
            });
        }
    }
}
