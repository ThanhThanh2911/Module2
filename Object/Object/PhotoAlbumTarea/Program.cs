using System;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        private int _numberOfPages;

        public int GetNumberOfPages()
        {
            return _numberOfPages;
        }
        public PhotoAlbum()
        {
            _numberOfPages = 16;
        }
        public PhotoAlbum(int numberOfPages)
        {
            _numberOfPages = numberOfPages;
        }
        class BigPhotoAlbum : PhotoAlbum
        {
            public BigPhotoAlbum()
            {
                _numberOfPages = 64;
            }
        }
        class AlbumTest
        {
            static void Main()
            {
                PhotoAlbum album1 = new PhotoAlbum();
                Console.WriteLine("pages of album1 " + album1.GetNumberOfPages());

                PhotoAlbum album2 = new PhotoAlbum(24);
                Console.WriteLine("pages of album2 " + album2.GetNumberOfPages());

                PhotoAlbum album3 = new BigPhotoAlbum();
                Console.WriteLine("pages of album3 " + album3.GetNumberOfPages());
            }
        }
    }
}
