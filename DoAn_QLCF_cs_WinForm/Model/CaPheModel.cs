﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Model
{
	public class CaPheModel
	{
		private int id;
		private string name;

		public int Id 
		{ get => id;
			set => id = value; }

		public string Name { get => name; 
			set  {
				name = value;

			}
		}

	}
}