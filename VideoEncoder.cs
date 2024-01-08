using System;
using System.Threading;

namespace EventsANDDelegates
{
	public class VideoEventArgs : EventArgs
	{
		public Video Video { get; set; }
	}
	public class VideoEncoder
	{

			// 1- Define a delagte: determins the signiture of the method
			// 2- define an event based on that delegate
			// 3- raise the event


		// this is step number 1
			public delegate void VideoEncodedEventHandler(object source, EventArgs args);

		// this is step number 2
			public event VideoEncodedEventHandler VideoEncoded;


			public void Encode(Video video)
		{

			Console.WriteLine("Encoding Video...");
			Thread.Sleep(3000);

			// step number 3 you start with On and then the name of event VideoEncoded
			OnVideoEncoded(video);

		}

		protected virtual void OnVideoEncoded(Video video)
		{
			if (VideoEncoded != null)
				VideoEncoded(this, new VideoEventArgs(){ Video = video});
		}
	}
}

