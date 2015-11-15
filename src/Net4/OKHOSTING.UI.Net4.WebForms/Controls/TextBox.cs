﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OKHOSTING.UI.Controls;

namespace OKHOSTING.UI.Net4.WebForms.Controls
{
	public class TextBox : System.Web.UI.WebControls.TextBox, UI.Controls.ITextBox
	{
		public string Name
		{
			get
			{
				return base.ID;
			}
			set
			{
				base.ID = value;
			}
		}
	}
}