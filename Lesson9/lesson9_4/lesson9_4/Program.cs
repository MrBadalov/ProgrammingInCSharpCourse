using System;

namespace lesson9_4
{
    class Program
    {
        static void Main()
        {
            Photobook photoAlbum1 = new Photobook();
            Console.WriteLine(photoAlbum1.GetNumberPages());

            Photobook photoAlbum2 = new Photobook(24);
            Console.WriteLine(photoAlbum2.GetNumberPages());

            BigPhotobook bigPhotoAlbum1 = new BigPhotobook();
            Console.WriteLine(bigPhotoAlbum1.GetNumberPages());
        }
    }

    public class Photobook
    {
         protected int numPages;
        public Photobook()
        {
            numPages = 16;

        }
        public Photobook(int numPages)
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }

    public class BigPhotobook : Photobook
    {

        public BigPhotobook()
        {
            numPages = 64;
        }
    }
}
