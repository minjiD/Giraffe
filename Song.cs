namespace Giraffe
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0; //Static Class Attributes : 기본적으로 클래스에 관한 속성

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}