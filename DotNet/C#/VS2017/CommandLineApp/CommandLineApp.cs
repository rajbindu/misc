/***************************************************************
* Copyright 2008-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using Accusoft.ImagXpressSdk;

namespace CommandLineApp
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	/// 

	class CommandLineApp
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: Add code to start application here
			//
			UnlockIXandProcessImg UnlockIXandProcessImg = new UnlockIXandProcessImg();					
		}
	}

	public class UnlockIXandProcessImg
	{
		private Accusoft.ImagXpressSdk.ImageX imagX1;
		private Accusoft.ImagXpressSdk.ImagXpress imagXpress1;
		private Accusoft.ImagXpressSdk.Processor imagProcessor;
		private string sInputFileName;
		private string sOutputFileName;
		private Accusoft.ImagXpressSdk.SaveOptions soSaveOptions;
		string strCurrentDir = System.IO.Directory.GetCurrentDirectory();

		public UnlockIXandProcessImg()
		{
			try 
			{
				imagXpress1 = new Accusoft.ImagXpressSdk.ImagXpress();
				
				//***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
				//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
				//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
				//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");
				//System.Console.WriteLine("ImagXpress successfully licensed.");

				imagProcessor = new Accusoft.ImagXpressSdk.Processor(imagXpress1);
				soSaveOptions = new Accusoft.ImagXpressSdk.SaveOptions();
				soSaveOptions.Format = ImageXFormat.Tiff;
				soSaveOptions.Tiff.Compression = Compression.Group4;
				sInputFileName = System.IO.Path.Combine(strCurrentDir, @"..\..\..\..\..\..\..\..\..\..\Common\Images\Benefits.tif");
				sOutputFileName = (strCurrentDir + "\\BenefitsRotated.tif");

				imagX1 = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, sInputFileName);
				imagProcessor.Image = imagX1;
				imagProcessor.Rotate(180);
				imagX1 = imagProcessor.Image;
				imagX1.Save(sOutputFileName, soSaveOptions);
				
				Dispose();
				System.Console.WriteLine(("Rotated TIFF saved to file " + sOutputFileName));
				System.Console.ReadLine();
			}
			catch (Accusoft.ImagXpressSdk.ImagXpressException ex) 
			{
				Dispose();
				System.Console.WriteLine(ex.Message);
				System.Console.WriteLine(ex.Source);
				System.Console.ReadLine();
			}
			catch (System.Exception ex) 
			{
				Dispose();
				System.Console.WriteLine(ex.Message);
				System.Console.WriteLine(ex.Source);
				System.Console.ReadLine();
			}
		}

		// Don't forget to Dispose ImagXpress
		void Dispose() 
		{
			if (!(imagXpress1 == null)) 
			{
				imagXpress1.Dispose();
				imagXpress1 = null;
			}
			if (!(imagProcessor == null)) 
			{
				imagProcessor.Dispose();
				imagProcessor = null;
			}
			if (!(imagX1 == null)) 
			{
				imagX1.Dispose();
				imagX1 = null;
			}
		}
	}
}
