
using PIXEL_VECTOR = System.Collections.Generic.List<System.Collections.Generic.List<wrd.Pixel>>;

#region WARDEN
namespace wrd
{
    struct RGBA
    {
        public Triplet<int> rgb;
        public int alpha;
    }
    enum Color
    {
        BLACK, WHITE, RED, GREEN, BLUE
    }
    enum JPEG
    {
        MRCH_2_2049, M_5_2049, JL_1_2049, SP_19_2049
    }
    class Pixel
    {
        //default constructor
        public Pixel()
        {
            this.rgb = new Triplet<int>(0, 0, 0);
            this.alpha = 255;
        }
        //constructor
        //  with r,g,b as integer parameters and
        //  opque as default values
        public Pixel(int r, int g, int b, int alpha = 255)
        {
            setRGBA(r, g, b, alpha);
        }
        public Pixel(Color clr)
        {
            switch (clr)
            {
                case Color.BLACK:
                    setRGBA(0, 0, 0);
                    break;
                case Color.WHITE:
                    setRGBA(255, 255, 255);
                    break;
                case Color.RED:
                    setRGBA(255, 0, 0);
                    break;
                case Color.GREEN:
                    setRGBA(0, 255, 0);
                    break;
                case Color.BLUE:
                    setRGBA(0, 0, 255);
                    break;
            }
        }
        //constructor
        //  with r,g,b as triplet parameter and
        //  opaque as default value
        public Pixel(Triplet<int> rgb, int alpha = 255)
        {
            setRGBA(rgb, alpha);
        }
        //constructor
        //  with RGBA container parameter
        public Pixel(RGBA rgba_container)
        {
            setRGBA(rgba_container.rgb, rgba_container.alpha);
        }

        //set functions
        public void setOpaque(int alpha = 255)
        {
            this.alpha = alpha;
        }
        public void setRGB(int r, int g, int b)
        {
            this.rgb = new Triplet<int>(r, g, b);
        }
        public void setRGB(Triplet<int> rgb)
        {
            this.rgb = rgb;
        }
        public void setRGBA(int r, int g, int b, int alpha = 255)
        {
            setRGB(r, g, b);
            this.alpha = alpha;
        }
        public void setRGBA(Triplet<int> rgb, int alpha = 255)
        {
            setRGB(rgb);
            this.alpha = alpha;
        }
        //!set functions

        //get functions
        public int getOpaque()
        {
            return this.alpha;
        }
        public Triplet<int> getRGB()
        {
            return this.rgb;
        }
        public RGBA getRGBA()
        {
            return new RGBA
            {
                rgb = this.rgb,
                alpha = this.alpha
            };
        }
        //!get functions

        //member data
        private Triplet<int> rgb;
        private int alpha;
        //!member data
    }
    class Image
    {
        //member data
        private Vector2<int> resolution;
        private PIXEL_VECTOR pixelContainer = new PIXEL_VECTOR();
        //!member data

        //constructors
        public Image()
        {
            this.resolution = new Vector2<int>(0, 0);
        }
        public Image(int width, int height)
        {
            setResolution(width, height);
        }
        //constructor
        //  Vector2 as parameter (x->width, y->height)
        public Image(Vector2<int> resolution)
        {
            setResolution(resolution);
        }
        //IEnumerable constructor
        public Image(wrd.Pixel[,] pxl_arr)
        {
            resolution = new Vector2<int>(pxl_arr.GetLength(1), pxl_arr.GetLength(0));
            for (int i = 0; i < pxl_arr.GetLength(0); i++)
            {
                List<wrd.Pixel> temp = new wrd.Pixel[pxl_arr.GetLength(1)].ToList();
                for (int n = 0; n < temp.Count; n++)
                {
                    temp[n] = pxl_arr[i, n];
                }

                this.pixelContainer.Add(temp);
            }
        }
        //destructor
        ~Image() { }
        //set functions
        public void setResolution(int width, int height)
        {
            this.resolution = new Vector2<int>(width, height);
            //resize existing vector
            //Console.WriteLine(this.pixelContainer.Capacity);
            if (this.resolution.y > this.pixelContainer.Capacity)
            {
                this.pixelContainer.AddRange(Enumerable.Repeat(new List<Pixel>(this.resolution.x), this.resolution.y));
            }
        }
        public void setResolution(Vector2<int> resolution)
        {
            this.resolution = resolution;
            //create new PIXEL_VECTOR of size:
            //  resolution.y = ROW_COUNT
            //  resolution.x = COL_COUNT
            //pixel_container.resize(resolution.y, std::vector<Pixel>(resolution.x));
            if (this.resolution.y > this.pixelContainer.Capacity)
                this.pixelContainer.AddRange(Enumerable.Repeat(new List<Pixel>(this.resolution.x), this.resolution.y - this.pixelContainer.Count));
        }
        public void setPixel(int x, int y, Pixel pxl)
        {
            if (y > this.pixelContainer.Count || x > this.pixelContainer[0].Count)
            {
                Console.WriteLine("Image::setPixel(int, int, Pixel): invalid size!");
                System.Environment.Exit(1);
            }
            else
                this.pixelContainer[y][x] = pxl;
        }
        public void setPixel(Vector2<int> position, Pixel pxl)
        {
            //std::cout << pxl.getRGB()._triplet_unit_1 << "," << pxl.getRGB()._triplet_unit_2 << "," << pxl.getRGB()._triplet_unit_3 << std::endl;
            //if (position.y > this.pixelContainer.Count || position.x > this.pixelContainer[0].Count)
            //{
            //    Console.WriteLine("Image::setPixel(int, int, Pixel): invalid size!");
            //    Console.WriteLine("position: [{0}]X[{0}]", position.x, position.y);
            //    Console.WriteLine("size: [{0}]X[{0}]", this.pixelContainer[0].Count, this.pixelContainer.Count);
            //    throw new Exception();
            //}
            if (position.y == 0 && position.x == 0)
                this.pixelContainer.AddRange(Enumerable.Repeat(new List<Pixel>(this.resolution.x), this.resolution.y));
            else
                this.pixelContainer[position.x].Insert(position.y, pxl);
        }
        //get functions
        public Vector2<int> getResolution()
        {
            return this.resolution;
        }
        public Pixel getPixel(Vector2<int> position)
        {
            return this.pixelContainer[position.y][position.x];
        }
        public Pixel getPixel(int x, int y)
        {
            return this.pixelContainer[y][x];
        }
    }
}
#endregion //!region WARDEN