namespace FitnessAppXam.Model
{
    public class Challenge
    {
        public string Status { get; set; }

        public string DaysLeft { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsJoined { get; set; }

        public string Participants { get; set; }

        public string Earned { get; set; }

        public string Missing { get; set; }

        public string Goal { get; set; }

        public double Complete { get; set; }


        public string Ended { get; set; }

        public string Weather { get; set; }

        public bool IsEarned => !string.IsNullOrEmpty(Earned);
    }
}
