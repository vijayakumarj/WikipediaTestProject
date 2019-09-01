using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Drawing.Imaging;
using System.Drawing;

namespace WikipediaTestProject.Framework
{
    public class ScreenshotHandler
    {
        private string FileName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Screenshot";
               

        public Image CaptureElementScreenShot(IWebElement element, string uniqueName)
        {
            Screenshot screenshot = ((ITakesScreenshot)Framework.webDriver).GetScreenshot();
            screenshot.SaveAsFile(FileName, ScreenshotImageFormat.Jpeg);

            Image img = Bitmap.FromFile(uniqueName);
            Rectangle rect = new Rectangle();

            if (element != null)
            {
                // Get the Width and Height of the WebElement using
                int width = element.Size.Width;
                int height = element.Size.Height;

                // Get the Location of WebElement in a Point.
                // This will provide X & Y co-ordinates of the WebElement
                Point p = element.Location;

                // Create a rectangle using Width, Height and element location
                rect = new Rectangle(p.X, p.Y, width, height);
            }

            // croping the image based on rect.
            Bitmap bmpImage = new Bitmap(img);
            var cropedImag = bmpImage.Clone(rect, bmpImage.PixelFormat);

            return cropedImag;
        }
    }
}
