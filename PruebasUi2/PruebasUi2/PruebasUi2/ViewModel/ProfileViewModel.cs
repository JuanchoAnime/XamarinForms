namespace PruebasUi2.ViewModel
{
    public class ProfileViewModel: BaseViewModel
    {

        public string Description  { get; set;  }

        public string Location  { get; set; }

        public string ImgUrl  { get; set; }

        public string Name  { get; set; }

        public string Email { get; set; }

        public ProfileViewModel()
        {
            this.Email = "Judas3991@gmail.com";
            this.Location = "Turbaco, Bolivar - COLOMBIA";
            this.ImgUrl = "ProfilleImage.png";
            this.Name = "Juan David Sierra";
            this.Description = "I am a dedicated person with a family of four. " +
                "I enjoy reading, and the knowledge and perspective that my reading " +
                "gives me has strengthened my teaching skills and presentation abilities." +
                " I have been successful at raising a family, " +
                "and I attribute this success to my ability to plan," +
                " schedule, and handle many different tasks at once. " +
                "This flexibility will help me in the classroom, where there are many different personalities and learning styles.";
        }
    }
}
