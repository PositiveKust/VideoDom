namespace ServerVideoDom
{
    class DownloadVideo
    {

        public int id { get; set; }

        private string name, autor, description;

        private int like, dislike;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Like
        {
            get { return like; }
            set { like = value; }
        }
        public int Dislike
        {
            get { return dislike; }
            set { dislike = value; }
        }
        public DownloadVideo() { }

        public DownloadVideo(string name, string autor, string description, int like, int dislike)
        {
            this.name = name;
            this.autor = autor;
            this.description = description;
            this.like = like;
            this.dislike = dislike;
        }

    }
}
