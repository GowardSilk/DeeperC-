class Image1Algo
{ 
    public static void Exec()
    {
        wrd.Image img = new wrd.Image();

        wrd.DeepEye.IMG_download(ref img, wrd.JPEG.MRCH_2_2049);

        for (int y = 0; y < img.getResolution().y; y++)
        {
            for (int x = 0; x < img.getResolution().x; x++)
            {
                img.getPixel(new Vector2<int>(x, y)).setOpaque(255);
            }
        }

        wrd.DeepEye.render(img);
    }
}