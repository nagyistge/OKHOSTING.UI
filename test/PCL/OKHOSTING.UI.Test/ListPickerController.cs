﻿using System;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;

namespace OKHOSTING.UI.Test
{
	/// <summary>
	/// A list of items where the user can select an item.
	/// <para xml:lang="es">
	/// Una lista de elementos donde el usuario puede seleccionar un elemento.
	/// </para>
	/// </summary>
	public class ListPickerController : Controller
	{
		// Create an Stack
		IStack stack = Platform.Current.Create<IStack>();
		// Create an ListPicker
		IListPicker lstColor;

		/// <summary>
		/// Start this instance.
		/// <para xml:lang="es">
		/// Inicia una instancia de este objeto
		/// </para>
		/// </summary>
		public override void Start()
		{
			base.Start();

			// Create an Label with text and size specific and adds it to the Stack.
			ILabel lblLabel = Platform.Current.Create<ILabel>();
			lblLabel.Text = "This is a label";
			lblLabel.Height = 30;
			stack.Children.Add(lblLabel);

			// Create the ListPicker lstFont with the specific items, here can change the fontfamily of the label and adds it to the Stack.
			IListPicker lstFont = Platform.Current.Create<IListPicker>();
			lstFont.Items = new string[] { "Arial", "Verdana", "Times new roman", "Helvetica" };
			lstFont.ValueChanged += (object sender, string e) => lblLabel.FontFamily = lstFont.Value;
			stack.Children.Add(lstFont);

			// Create the ListPicker lstColor with the specific items and adds it to Stack  
			lstColor = Platform.Current.Create<IListPicker>();
			lstColor.Items = new string[] { "Red", "Green", "Blue" };
			stack.Children.Add(lstColor);

			// Create the button cmdColor with specific text, with the event also click and adds it to the stack.
			IButton cmdColor = Platform.Current.Create<IButton>();
			cmdColor.Text = "Set Color";
			cmdColor.Click += CmdSetColor_Click;
			stack.Children.Add(cmdColor);

			// Creates the Button cmdClose with text specific, with the event also click and adds it to the stack.
			IButton cmdClose = Platform.Current.Create<IButton>();
			cmdClose.Text = "Close";
			cmdClose.Click += CmdClose_Click;
			stack.Children.Add(cmdClose);

			// Establishes the content and title of the page.
			Platform.Current.Page.Title = "Test label";
			Platform.Current.Page.Content = stack;
		}

		/// <summary>
		/// It is the button click event cmd Color, what it does is change the background color of the stack.
		/// <para xml:lang="es">
		/// Es el evento clic del boton cmdColor, lo que hace es cambiar el color de fondo del stack.
		/// </para>
		/// </summary>
		/// <returns>The set color click.</returns>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		private void CmdSetColor_Click(object sender, EventArgs e)
		{
			if(lstColor.Value == "Red")
			{
				stack.BackgroundColor = new Color(1,255,0,0);
			}
			else if (lstColor.Value == "Green")
			{
				stack.BackgroundColor = new Color(1, 0, 255, 0);
			}
			else if (lstColor.Value == "Blue")
			{
				stack.BackgroundColor = new Color(1, 0, 0, 255);
			}
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