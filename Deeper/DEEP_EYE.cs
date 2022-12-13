using System.Drawing;
using System.Runtime.Serialization;

#region WARDEN
namespace wrd
{
    class DeepEye
    {
        //download function
        //  used to "download" image preset
        public static void IMG_download(ref wrd.Image img, wrd.JPEG imgName)
        {
            switch (imgName)
            {
                case wrd.JPEG.MRCH_2_2049:
                    img.setResolution(100, 100);
                    for(int y = 0; y < 100; y++)
                    {
                        for(int x = 0; x < 100; x++)
                        {
                            if (x % 2 == 0)
                                img.setPixel(new Vector2<int>(x, y), new wrd.Pixel(wrd.Color.WHITE));
                            else
                                img.setPixel(new Vector2<int>(x, y), new wrd.Pixel(wrd.Color.BLACK));
                        }
                    }
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
        public static void render(wrd.Image img)
        {
            using (var bitmap = new Bitmap(img.getResolution().x, img.getResolution().y, System.Drawing.Imaging.PixelFormat.Format32bppArgb))
            {
                for (var y = 0; y < img.getResolution().y; y++)
                {
                    for (var x = 0; x < img.getResolution().x; x++)
                    {
                        wrd.Pixel pxl = img.getPixel(x, y);
                        System.Drawing.Color color = System.Drawing.Color.FromArgb(
                            pxl.getOpaque(), //ALPHA
                            pxl.getRGB()._triplet_unit_1, //R
                            pxl.getRGB()._triplet_unit_2, //G
                            pxl.getRGB()._triplet_unit_3 //B
                        );
                        bitmap.SetPixel(x, y, color);
                    }
                }
                bitmap.Save("Image.bmp");
            }
            return;
        }
        //used to send log to the website
        public static void read()
        {
            return;
        }
    }
}
#endregion //!region WARDEN