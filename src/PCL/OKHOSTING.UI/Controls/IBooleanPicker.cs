﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OKHOSTING.UI.Controls
{
	public interface IBooleanPicker: ITextControl
	{
		bool SelectedValue { get; set; }
	}
}