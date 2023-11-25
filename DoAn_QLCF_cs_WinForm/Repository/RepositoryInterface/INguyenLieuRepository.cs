﻿using DoAn_QLCF_cs_WinForm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLCF_cs_WinForm.Repository.RepositoryInterface
{
    public interface INguyenLieuRepository
    {
        void Add(NguyenLieuModel obj);
        void Update(NguyenLieuModel obj);
        void Delete(int id);
        int GetNextId();
        IEnumerable<NguyenLieuModel> GetAll();

        IEnumerable<NguyenLieuModel> GetByValue(string value);

        NguyenLieuModel GetById(int id);
        bool IsExit(int id);
    }
}
