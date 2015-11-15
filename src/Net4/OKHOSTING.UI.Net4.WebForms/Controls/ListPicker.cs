﻿using System;
using System.Collections.Generic;
using OKHOSTING.UI.Controls;

namespace OKHOSTING.UI.Net4.WebForms.Controls
{
	public class ListPicker : System.Web.UI.WebControls.DropDownList, IListPicker
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

		IPage IControl.Page
		{
			get
			{
				return (Page)Page;
			}
		}

		IEnumerable<string> IListPicker.DataSource
		{
			get
			{
				return (IEnumerable<string>) base.DataSource;
			}
			set
			{
				base.DataSource = value;
			}
		}

		string IListPicker.SelectedItem
		{
			get
			{
				return base.SelectedValue;
			}
			set
			{
				base.SelectedValue = value;
			}
		}
	}
}
