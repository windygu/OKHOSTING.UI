﻿using System;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;
using System.IO;

namespace OKHOSTING.UI.Test
{
	/// <summary>
	/// It's a simple button with a background image.
	/// <para xml:lang="es">
	/// Es un boton simple con ina imagen de fondo.
	/// </para>
	/// </summary>
	public class ImageButtonController: Controller
	{
		// Declare an image
		IImage imgPicture;

		/// <summary>
		/// Start this instance.
		/// <para xml:lang="es">
		/// Inicia la instancia de este objeto.
		/// </para>
		/// </summary>
		public override void Start()
		{
			base.Start();

			// Create an Stack
			IStack stack = Platform.Current.Create<IStack>();

			// Create an Label with text and size specified and adds it to the Stack
			ILabel lblLabel = Platform.Current.Create<ILabel>();
			lblLabel.Text = "View an image from Url";
			lblLabel.Height = 30;
			stack.Children.Add(lblLabel);

			// Create a button with a specific size and indicating the URL of your background image also your event clic and adds it to the stack
			IImageButton imgbtn = Platform.Current.Create<IImageButton>();
			imgbtn.LoadFromUrl(new Uri("http://okhosting.com/wp-content/uploads/2016/02/okhosting-150x150.png"));
			imgbtn.Height = 100;
			imgbtn.Width = 100;
			imgbtn.Click += CmdViewImage_Click;
			stack.Children.Add(imgbtn);

			// Create a image not visible, with an size specified and indicating the URL and adds it to Stack
			imgPicture = Platform.Current.Create<IImage>();
			imgPicture.LoadFromUrl(new Uri("http://www.patycantu.com/wp-content/uploads/2014/07/91.jpg"));
			imgPicture.Height = 250;
			imgPicture.Width = 600;
			imgPicture.Visible = false;
			stack.Children.Add(imgPicture);

			// Creates the Button cmdClose with text specific, with the event also click and adds it to the stack.
			IButton cmdClose = Platform.Current.Create<IButton>();
			cmdClose.Text = "Close";
			cmdClose.Click += CmdClose_Click;
			stack.Children.Add(cmdClose);

			// Establishes the content and title of the page
			Platform.Current.Page.Title = "Test label";
			Platform.Current.Page.Content = stack;
		}

		/// <summary>
		/// It is the button click event imgbtn, that makes visible to click the image.
		/// <para xml:lang="es">
		/// Es el evento clic del boton imgbtn, que al darle clic hace visible la imagen.
		/// </para>
		/// </summary>
		/// <returns>The view image click.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void CmdViewImage_Click(object sender, EventArgs e)
		{
			imgPicture.Visible = true;
		}

		/// <summary>
		/// It is the button click event cmdClose, what it does is end this instance.
		/// <para xml:lang="es">
		/// Es el evento clic del boton cmdClose, lo que hace es finalizar esta instancia.
		/// </para>
		/// </summary>
		/// <returns>The close click.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void CmdClose_Click(object sender, EventArgs e)
		{
			this.Finish();
		}
	}
}