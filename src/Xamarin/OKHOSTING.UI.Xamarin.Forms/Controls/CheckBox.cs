﻿using System;
using OKHOSTING.UI.Controls;

namespace OKHOSTING.UI.Xamarin.Forms.Controls
{
	public class CheckBox : global::Xamarin.Forms.Switch, ICheckBox
	{
		bool ICheckBox.SelectedValue
		{
			get
			{
				return base.IsToggled;
			}
			set
			{
				base.IsToggled = value;
			}
		}

		void IDisposable.Dispose()
		{
		}

		#region IControl

		string IControl.Name
		{
			get; set;
		}

		bool IControl.Visible
		{
			get
			{
				return base.IsVisible;
			}
			set
			{
				base.IsVisible = value;
			}
		}

		bool IControl.Enabled
		{
			get
			{
				return base.IsEnabled;
			}
			set
			{
				base.IsEnabled = value;
			}
		}

		double? IControl.Width
		{
			get
			{
				return base.WidthRequest;
			}
			set
			{
				if (value.HasValue)
				{
					base.WidthRequest = value.Value;
				}
			}
		}

		double? IControl.Height
		{
			get
			{
				return base.HeightRequest;
			}
			set
			{
				if (value.HasValue)
				{
					base.HeightRequest = value.Value;
				}
			}
		}

		Thickness IControl.Margin
		{
			get; set;
		}

		Color IControl.BackgroundColor
		{
			get
			{
				return App.Current.Parse(base.BackgroundColor);
			}
			set
			{
				base.BackgroundColor = App.Current.Parse(value);
			}
		}

		Color IControl.BorderColor
		{
			get;
			set;
		}

		Thickness IControl.BorderWidth
		{
			get;
			set;
		}

		HorizontalAlignment IControl.HorizontalAlignment
		{
			get
			{
				return App.Current.Parse(base.HorizontalOptions.Alignment);
			}
			set
			{
				base.HorizontalOptions = new global::Xamarin.Forms.LayoutOptions(App.Current.Parse(value), false);
			}
		}

		VerticalAlignment IControl.VerticalAlignment
		{
			get
			{
				return App.Current.ParseVerticalAlignment(base.VerticalOptions.Alignment);
			}
			set
			{
				base.VerticalOptions = new global::Xamarin.Forms.LayoutOptions(App.Current.Parse(value), false);
			}
		}

		#endregion

		#region ITextControl

		string ITextControl.FontFamily
		{
			get;
			set;
		}

		Color ITextControl.FontColor
		{
			get;
			set;
		}

		bool ITextControl.Bold
		{
			get;
			set;
		}

		bool ITextControl.Italic
		{
			get;
			set;
		}

		bool ITextControl.Underline
		{
			get;
			set;
		}

		HorizontalAlignment ITextControl.TextHorizontalAlignment
		{
			get;
			set;
		}

		VerticalAlignment ITextControl.TextVerticalAlignment
		{
			get;
			set;
		}

		Thickness ITextControl.TextPadding
		{
			get;
			set;
		}

		double ITextControl.FontSize
		{
			get;
			set;
		}

		#endregion
	}
}