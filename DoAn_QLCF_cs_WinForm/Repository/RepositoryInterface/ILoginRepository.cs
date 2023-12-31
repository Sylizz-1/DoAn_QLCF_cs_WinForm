﻿using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface ILoginRepository
    {
        NhanVienModel LoginEmployee(String username, String password);
        KhachHangModel LoginCustomer(String username, String password);
        bool Register(String username, String password);
    }
}
