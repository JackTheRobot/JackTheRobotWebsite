namespace JackTheRobotSite.Components.Models
{
    public class ProjectCardModel
    {
        public ProjectCardModel(string projectTitle,
            string projectRole,
            string projectDescription,
            string imagePath,
            string videoURL,
            bool leftAligned)
        {
            ProjectTitle = projectTitle;
            ProjectRole = projectRole;
            ProjectDescription = projectDescription;
            ImagePath = imagePath;
            VideoURL = videoURL;
            LeftAligned = leftAligned;
        }

        public string ProjectTitle { get; private set; } = "";
        public string ProjectRole { get; private set; } = "";
        public string ProjectDescription { get; private set; } = "";
        public string ImagePath { get; private set; } = "";
        public string VideoURL { get; private set; } = "";
        public bool LeftAligned { get; private set; }
    }
}
