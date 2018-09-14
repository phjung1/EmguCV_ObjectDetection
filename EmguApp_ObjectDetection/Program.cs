using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Diagnostics;


namespace EmguApp_ObjectDetection
{
    class Program
    {


        private const string BackgroundFrameWindowName = "Background Frame";


        private static Mat rawFrame = new Mat(); // Frame as obtained from video
        private static Mat finalFrame = new Mat(); // Video frame with detected object marked
        private static Mat backgroundFrame = new Mat(); // Frame used as base for change detection


        static void Main(string[] args)
        {
            using(var capture = new VideoCapture(0))
            {
                while (true)
                {
                    backgroundFrame = capture.QueryFrame();
                    CvInvoke.Imshow(BackgroundFrameWindowName, backgroundFrame);

                    int key = CvInvoke.WaitKey(100);

                    if (key ==27) Environment.Exit(0);
                }
              
            }
        }


        

    }
}
