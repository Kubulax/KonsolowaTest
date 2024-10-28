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
            List<MusicAlbum> expectedAlbums = new List<MusicAlbum>([new MusicAlbum("Gorillaz", "\"The Now Now\"", 11, "2018", 11000102), new MusicAlbum("My Chemical Romance", "\"The Black Parade\"", 14, "2006", 304666444)]);

            //Act
            List<MusicAlbum> albums = Program.GetMusicAlbums(path);

            //Assert
            Assert.Equal(2, albums.Count);

            Assert.Equal(expectedAlbums[0].artist, albums[0].artist);
            Assert.Equal(expectedAlbums[0].album, albums[0].album);
            Assert.Equal(expectedAlbums[0].songsNumber, albums[0].songsNumber);
            Assert.Equal(expectedAlbums[0].year, albums[0].year);
            Assert.Equal(expectedAlbums[0].downloadNumber, albums[0].downloadNumber);

            Assert.Equal(expectedAlbums[1].artist, albums[1].artist);
            Assert.Equal(expectedAlbums[1].album, albums[1].album);
            Assert.Equal(expectedAlbums[1].songsNumber, albums[1].songsNumber);
            Assert.Equal(expectedAlbums[1].year, albums[1].year);
            Assert.Equal(expectedAlbums[1].downloadNumber, albums[1].downloadNumber);
        }
    }
}