using OpenQA.Selenium;
using System.IO;
using System.Reflection;
using System.Drawing;
using System;
using System.Drawing.Imaging;

namespace WikipediaTestProject.Framework
{
    public class ScreenshotHandler
    {
        public void TakeScreenshot1(IWebElement element)
        {
            try
            {
                string fileName = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".jpg";
                Byte[] byteArray = ((ITakesScreenshot)Framework.webDriver).GetScreenshot().AsByteArray;
                Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));
                Rectangle croppedImage = new Rectangle(element.Location.X, element.Location.Y, element.Size.Width, element.Size.Height);
                screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);
                screenshot.Save(String.Format(fileName, ImageFormat.Jpeg));
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

    }
}
