﻿using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface INhanVienRepository
    {
        IEnumerable<NhanVienModel> GetAll();
        IEnumerable<QuyenModel> GetAllQuyen();
        int GetNextId();
        bool Add(NhanVienModel nhanVienModel);
        bool Edit(NhanVienModel nhanVienModel);
        bool Delete(NhanVienModel nhanVienModel);

    }
}
