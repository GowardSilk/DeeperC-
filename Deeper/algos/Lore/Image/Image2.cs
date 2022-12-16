class Image2Algo
{ 
    public static void Exec()
    {
        wrd.Image img = new wrd.Image();

        wrd.DeepEye.IMG_download(ref img, wrd.JPEG.M_5_2049);

        img.setResolution(100, 100);
        for (int y = 0; y < 100; y++)
        {
            for (int x = 0; x < 100; x++)
            {
                if (x % 2 == 0)
                    img.setPixel(new Vector2<int>(x, y), new wrd.Pixel(wrd.Color.RED));
                else
                    img.setPixel(new Vector2<int>(x, y), new wrd.Pixel(0, 0, 0, 255));
            }
        }

        //for (int y = 0; y < img.getResolution().y; y++)
        //{
        //    for (int x = 0; x < img.getResolution().x; x++)
        //    {
        //        img.getPixel(new Vector2<int>(x, y)).setOpaque(255);
        //        Console.WriteLine(img.getPixel(new Vector2<int>(x, y)).getRGB());
        //    }
        //}

        wrd.DeepEye.render(ref img);
    }
}