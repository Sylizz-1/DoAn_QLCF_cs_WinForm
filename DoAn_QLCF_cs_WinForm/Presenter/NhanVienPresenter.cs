﻿using DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface;
using DoAn_QLCF_cs_WinForm.View.ViewInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Presenter
{
	public class NhanVienPresenter
	{
		private INhanVienView view;
		private INhanVienRepository repo;

		public NhanVienPresenter(INhanVienView view, INhanVienRepository repo)
		{
			this.view = view;
			this.repo = repo;
		}
	}
}
