﻿using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
	public interface IPhanQuyenRepository
	{
        IEnumerable<QuyenModel> GetAllPermission();
        IEnumerable<ChucNangModel> GetAllMethod();
    }
}
