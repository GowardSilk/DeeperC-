#region WARDEN
namespace wrd
{
    class DeepEye
    {
        //download function
        //  used to "download" image preset
        public static void IMG_download(wrd.Image img, wrd.JPEG imgName)
        {
            switch (imgName)
            {
                case wrd.JPEG.MRCH_2_2049:
                    break;
                case wrd.JPEG.M_5_2049:
                    break;
                case wrd.JPEG.JL_1_2049:
                    break;
                case wrd.JPEG.SP_19_2049:
                    break;
                default:
                    Console.WriteLine("Image with the name {0} does not exist!", imgName.ToString("D"));
                    break;
            }
            return;
        }
        public static void LOG_extract()
        {
            return;
        }
        //upload functions
        //  used to send image to the website
        static void render(wrd.Image img)
        {
            // var bitmap = new Bitmap(img.getResolution().x, img.getResolution().y);
            // for(var y = 0; y < img.getResolution().y; y++) {
            //     for(var x = 0; x < img.getResolution().x; x++) {
            //         bitmap.SetPixel(x, y, )
            //     }
            // }
            return;
        }
        //used to send log to the website
        static void read()
        {
            return;
        }
    }
}
#endregion //!region WARDEN