/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace Threading
{
	/// <summary>
	/// Summary description for ProcessingThread
	/// </summary>
	public class ProcessorThread
	{
		//changing any of the ReferenceToMy stuff is not allowed. In order to properly manipulate
		private System.Windows.Forms.Label myReferenceToMyLabel;
		private Accusoft.ImagXpressSdk.ImageXView myReferenceToMyViewer; 
		//these, you need to use Invoke. The reason is that these objects are owned by a different thread

		private System.String myImageFileName;
		private System.Int32 myResize;
		private Accusoft.ImagXpressSdk.ImageX myImage;
		private Accusoft.ImagXpressSdk.Processor myProcessor;
		private ImagXpress daImagXpress;

		static void AccusoftError(Accusoft.ImagXpressSdk.ImagXpressException e) 
		{
			MessageBox.Show(null,e.Message,"ImageXPress Error " + e.Number.ToString());
		}

		public ProcessorThread (System.String daImageFileName,
			Accusoft.ImagXpressSdk.ImageXView daViewer,
			System.Windows.Forms.Label daLabel,
			System.Int32 daSize, ImagXpress daImagXpress)
		{			
			//set our references to these objects
			this.myReferenceToMyViewer = daViewer;
			this.myReferenceToMyLabel = daLabel;
			this.daImagXpress = daImagXpress;
			//since we do not need to pass back the filename, we can clone it to eliminate cross thread fears
			this.myImageFileName = (string)daImageFileName.Clone(); 
			
			//types such as System.Int32 are not real objects, so no cross thread fears.
			this.myResize = daSize;
		}

		private delegate void SafeContextImageChanger(Accusoft.ImagXpressSdk.ImageX newImage);

		private delegate void SafeContextLabelChanger(string newText);

		private delegate void SafeContextZoomChanger(Accusoft.ImagXpressSdk.ZoomToFitType newZoomFitType);

		private void RealZoomToFitChangerInTheSafeContext(Accusoft.ImagXpressSdk.ZoomToFitType newZoomFitType)
		{
			myReferenceToMyViewer.ZoomToFit(newZoomFitType);
		}

		private void RealImageChangerInTheSafeContext(Accusoft.ImagXpressSdk.ImageX newImage)
		{
			Accusoft.ImagXpressSdk.ImageX oldImage = myReferenceToMyViewer.Image;
	
			myReferenceToMyViewer.Image = newImage;

			if (oldImage != null)
			{
				oldImage.Dispose();
				oldImage = null;
			}
			GC.Collect();
			System.Threading.Thread.Sleep(25);
		}

		private void RealLabelChangerInTheSafeContext(string newText)
		{
			myReferenceToMyLabel.Text = newText;
		}

		private void ChangeLabelText(string newText)
		{
			object[] theArgs = {newText};
			myReferenceToMyLabel.Invoke(new SafeContextLabelChanger(this.RealLabelChangerInTheSafeContext),theArgs);
		}

		private void ChangeImage(Accusoft.ImagXpressSdk.ImageX newImage)
		{
			object[] theArgs = {newImage.Copy()};
			myReferenceToMyViewer.Invoke(new SafeContextImageChanger(this.RealImageChangerInTheSafeContext),theArgs);
		}

		private void ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType newZoomFitType)
		{
			object[] theArgs = {newZoomFitType};
			myReferenceToMyViewer.Invoke(new SafeContextZoomChanger(this.RealZoomToFitChangerInTheSafeContext),theArgs);
		}

		public void Process()
		{	
			bool imageOpened = false;
			int TryCount = 0;
			while((!imageOpened) && (TryCount < 25))
			{
				try 
				{
					//Create the image object and open the image
					myImage = Accusoft.ImagXpressSdk.ImageX.FromFile(daImagXpress, myImageFileName);
					imageOpened = true;
				} 
				catch (ImagXpressException ex) 
				{
					ChangeLabelText("Error opening image - " + ex.Number.ToString() + ". Retrying...");
				}
				TryCount++;
			}

			if (TryCount >= 25)
			{
				throw new Exception("Unable to open the image for processing.");
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try
			{
				//Create the processor object and tie it to the image we just opened
				myProcessor = new Accusoft.ImagXpressSdk.Processor(daImagXpress, myImage);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);

				//Set the viewing zoom type
				ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Processing...");

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Resizing...");

			try
			{
				//Resize the image
				myProcessor.Resize(new System.Drawing.Size(myImage.ImageXData.Width * (myResize), myImage.ImageXData.Height * myResize), Accusoft.ImagXpressSdk.ResizeType.Quality);
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Blurring...");

			try
			{
				//Resize the image
				myProcessor.Blur();
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Negating...");

			try
			{
				//Resize the image
				myProcessor.Negate();
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Zooming...");

			try 
			{
				//Set the viewing zoom type
				ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitWidth);
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);

				//Set the viewing zoom type
				ChangeZoomToFitType(Accusoft.ImagXpressSdk.ZoomToFitType.FitBest);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("(Un)Negating...");

			try
			{
				//Resize the image
				myProcessor.Negate();
			}
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			try 
			{
				//Set the viewer's image object equal to the one we are operating on...
				//we have to do this each time the image changes because we are making
				//copies of the image each time
				ChangeImage(myImage);
			} 
			catch (ImagXpressException ex) 
			{
				AccusoftError(ex);
			}

			//Rest
			System.Threading.Thread.Sleep(10);

			//Change the viewer's label.
			ChangeLabelText("Processed.");
          
			//Rest
			System.Threading.Thread.Sleep(10);

			//kill the processor
			myProcessor.Dispose();
			myProcessor = null;

			//kill the local copy of the image
			myImage.Dispose();
			myImage = null;

			GC.Collect();
			System.Threading.Thread.Sleep(100);
		}
	}
}
