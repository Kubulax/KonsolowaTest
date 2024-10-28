using konsolowa;

namespace KonsolowaTests
{
    public class KonsolowaTests
    {
        [Fact]
        public void GivenFilePath_WhenGetMusicAlbums_ReturnListOfAlbums()
        {
            //Arrange
            string path = "../../../Data.txt";
            File.WriteAllLines(path, ["Gorillaz", "\"The Now Now\"", "11", "2018", "11000102", "", "My Chemical Romance", "\"The Black Parade\"", "14", "2006", "304666444"]);

            //Act
            List<MusicAlbum> albums = Program.Rea
        }
    }
}