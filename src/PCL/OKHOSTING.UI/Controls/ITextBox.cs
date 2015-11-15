﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKHOSTING.UI.Controls
{
	/// <summary>
	/// A single line textbox
	/// </summary>
	public interface ITextBox: IControl
	{ 
		string Text { get; set; }
	}
}