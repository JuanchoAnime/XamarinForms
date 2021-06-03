namespace FitnessAppXam.ViewModels
{
    using FitnessAppXam.Model;
    using MvvmHelpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class ChallengeActiveViewModel: BaseViewModel
    {
        public ObservableCollection<Challenge> Challenges { get; set; }

        public ChallengeActiveViewModel()
        {
            this.Challenges = new ObservableCollection<Challenge>(new List<Challenge>{
                new Challenge { DaysLeft = "14", Description = "Build habits for success", Earned = "2K", Goal = "3K", Complete = 0.75,
                    Missing = "616 min", IsJoined = false, Name = "The Annual", Participants = "1,124,492", Status = "ACTIVE" },
                new Challenge { DaysLeft = "353", Description = "Build habits for success", Earned = "4K", Goal = "5K", Complete = 0.98,
                    Missing = "1K", IsJoined = true, Name = "The Monthly", Participants = "124,492", Status = "ACTIVE" },
            });
        }
    }
}
