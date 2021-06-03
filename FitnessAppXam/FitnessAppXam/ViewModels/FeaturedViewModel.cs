namespace FitnessAppXam.ViewModels
{
    using FitnessAppXam.Model;
    using MvvmHelpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public class FeaturedViewModel : BaseViewModel
    {
        public ObservableCollection<ActivityProgram> RecommendedPrograms
        { 
            get; 
            set; 
        }

        public FeaturedViewModel()
        {
            RecommendedPrograms = new ObservableCollection<ActivityProgram>(new List<ActivityProgram> {
                new ActivityProgram { Activity = "Running", Program = "4 WEEKS" },
                new ActivityProgram { Activity = "Running", Program = "6 WEEKS" },
                new ActivityProgram { Activity = "Cycling", Program = "4 WEEKS" },
                new ActivityProgram { Activity = "Cycling", Program = "6 WEEKS" },
                new ActivityProgram { Activity = "Meditation", Program = "4 WEEKS" },
                new ActivityProgram { Activity = "Meditation", Program = "6 WEEKS" },
                new ActivityProgram { Activity = "Strength", Program = "4 WEEKS" },
                new ActivityProgram { Activity = "Strength", Program = "6 WEEKS" },
            });
        }
    }
}
