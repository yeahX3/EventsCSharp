using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EventsCSharp
{
    class VideoEncoder
    {
        //1) create delegate
        //2) create event asosiated to delegate
        //3) raise event

        //Step 1 Create Delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        //Step 2 create event associated to delegate
        public event VideoEncodedEventHandler VideoEncoded;

        //Step 3 Write a method that raises the event
        protected virtual void OnVideoEncoded()
        {
            //check that list of subscribers is not empty
            if(VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }

        //Step 4 write a method that calls the OnVideoEncoded function
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded();


        }

    }

    public class Video
    {
    }
}
