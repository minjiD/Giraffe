namespace Giraffe
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            //rating = aRating;
            Rating = aRating;
        }

        //Getter & Setter
        public string Rating
        {
            get { return rating; }
            // setter : 특정 항목 정의 가능
            set
            {  
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") // value => whatever trying to set
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}