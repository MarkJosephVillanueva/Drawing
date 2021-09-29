namespace Drawing.Main.Models
{
    public class Canvas
    {
		private char[,] _pixel;
		private int _width;
		private int _height;

		public Canvas()
		{
		}

		public void AddPixel(int yCordinate, int xCordinate, char key)
		{
			_pixel[yCordinate, xCordinate] = key;
		}

		public char[,] GetPixels() 
		{ 
			return _pixel;
		}

		public void SetPixels()
		{
			_pixel = new char[_height, _width];
		}

		public int GetWidth()
		{
			return _width;
		}

		public void SetWidth(int width)
		{
            _width = width + 2;
		}

		public int GetHeight()
		{
			return _height;
		}

		public void SetHeight(int height)
		{
			_height = height + 2;
		}
	}
}
