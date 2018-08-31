/***************************************************************
* Copyright 2009-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;

namespace SimpleImagXpressDemo
{
	public partial class MainForm : Form
	{
		private System.String filename;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			// ***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
			//imagXpress1.Licensing.SetSolutionName("YourSolutionName");
			//imagXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//imagXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation�");
			//thumbnailXpress1.Licensing.SetSolutionName("YourSolutionName");
			//thumbnailXpress1.Licensing.SetSolutionKey(12345,12345,12345,12345);
			//thumbnailXpress1.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation");
			//thumbnailXpress1.Licensing.SetIXSolutionName("YourSolutionName");
			//thumbnailXpress1.Licensing.SetIXSolutionKey(12345,12345,12345,12345);
			//thumbnailXpress1.Licensing.SetIXOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation");

			// Load an image.
			filename = System.IO.Path.Combine(Application.StartupPath, @"..\..\..\..\..\..\..\..\..\..\Common\Images\ImagXpress Mult-Page Sample.tif");
			imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, filename, 1);

			// Because in this sample the ImageX object is always located in the ImageXView
			// tell the ImageXView component to dispose of the ImageX object when itself is
			// disposed. Otherwise, we would have to dispose of the ImageX object in the Form's
			// Dispose method before the components.Dispose() section.
			imageXView1.AutoImageDispose = true;

			// Select the corresponding thumbnail.
			thumbnailXpress1.Items.AddItemsFromFile(filename, 0, true);
			thumbnailXpress1.SelectedItems.Add(thumbnailXpress1.Items[0]);

			// Connect NotateXpress to ImagXpress.
			notateXpress1.ClientWindow = imageXView1.Handle;

			// Load the first page's annotations if any have been saved.
			LoadAnnotations(1);
		}

		private void ChangePage(int newPage)
		{
			// Save the previous page's annotations.
			SaveAnnotations(imageXView1.Image.Page);

			// Dispose the current image if it exists.
			if (imageXView1.Image != null)
				imageXView1.Image.Dispose();
			// Load the specified page.
			imageXView1.Image = Accusoft.ImagXpressSdk.ImageX.FromFile(imagXpress1, filename, newPage);

			// Select the corresponding thumbnail.
			thumbnailXpress1.SelectedItems.Clear();
			thumbnailXpress1.SelectedItems.Add(thumbnailXpress1.Items[newPage - 1]);

			// Load the new page's annotations if any have been saved.
			LoadAnnotations(newPage);
		}

		private void buttonPageBack_Click(object sender, EventArgs e)
		{
			// If the current page is not the first page, load the previous page.
			if (imageXView1.Image.Page >= 2)
				ChangePage(imageXView1.Image.Page - 1);
		}

		private void buttonPageForward_Click(object sender, EventArgs e)
		{
			// If the current page is not the last page, load the next page.
			if (imageXView1.Image.Page < imageXView1.Image.PageCount)
				ChangePage(imageXView1.Image.Page + 1);
		}

		private void buttonZoomIn_Click(object sender, EventArgs e)
		{
			// Zoom in.
			imageXView1.ZoomFactor = imageXView1.ZoomFactor * 5 / 4;
		}

		private void buttonZoomOut_Click(object sender, EventArgs e)
		{
			// Zoom out.
			imageXView1.ZoomFactor = imageXView1.ZoomFactor * 4 / 5;
		}

		private void thumbnailXpress1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Load the page of the selected thumbnail.
			ChangePage(thumbnailXpress1.SelectedItems[0].Page);
		}

		private void SaveAnnotations(int page)
		{
			// Save the annotations of the specified page.
			Accusoft.NotateXpressSdk.SaveOptions saveOptions = new Accusoft.NotateXpressSdk.SaveOptions();
			saveOptions.AnnType = Accusoft.NotateXpressSdk.AnnotationType.NotateXpressXml;
			notateXpress1.PageNumber = page;
			notateXpress1.Layers.SaveToFile(Application.StartupPath + "\\annotations.nxxml", saveOptions);
			notateXpress1.Layers.Clear();
		}

		private void LoadAnnotations(int page)
		{
			// Load the annotations of the specified page.
			Accusoft.NotateXpressSdk.LoadOptions loadOptions = new Accusoft.NotateXpressSdk.LoadOptions();
			loadOptions.AnnType = Accusoft.NotateXpressSdk.AnnotationType.NotateXpressXml;
			notateXpress1.PageNumber = page;
			try
			{
				notateXpress1.Layers.FromFile(Application.StartupPath + "\\annotations.nxxml", loadOptions);
			}
			catch (Accusoft.NotateXpressSdk.PageNotFoundException)
			{
				// A page not found exception is expected if there are no
				// annotations on this page.
			}

			// If a layer does not exist, create a layer.
			if (notateXpress1.Layers.Count < 1)
				notateXpress1.Layers.Add(new Accusoft.NotateXpressSdk.Layer());
			// Display the NotateXpress toolbar.
			notateXpress1.ToolbarDefaults.ToolbarActivated = true;
		}
	}
}