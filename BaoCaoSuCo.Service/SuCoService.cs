using BaoCaoSuCo.Data.Infrastructure;
using BaoCaoSuCo.Data.Repositories;
using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;

namespace BaoCaoSuCo.Service
{
    public interface ISuCoService
    {
        void Add(SuCo suCo);

        void Update(SuCo suCo);

        void Detele(int id);

        IEnumerable<SuCo> GetAll();

        IEnumerable<SuCo> GetAllPaging(int page, int pageSize, out int totalRow);

        SuCo GetById(int id);

        IEnumerable<SuCo> GetAllByDonViPaging(string maDonVi, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class SuCoService : ISuCoService
    {
        ISuCoRepository _suCoRepository;
        IUnitOfWork _unitOfWork;

        public SuCoService(ISuCoRepository suCoRepository, IUnitOfWork unitOfWork)
        {
            _suCoRepository = suCoRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(SuCo suCo)
        {
            _suCoRepository.Add(suCo);
        }

        public void Detele(int id)
        {
            _suCoRepository.Delete(id);
        }

        public IEnumerable<SuCo> GetAll()
        {
           return _suCoRepository.GetAll(new string[] { "DonVi"});
        }

        public IEnumerable<SuCo> GetAllByDonViPaging(string maDonvi,int page, int pageSize, out int totalRow)
        {
            return _suCoRepository.GetMultiPaging(x=>x.xoa==false && x.MaDonVi==maDonvi,out totalRow, page, pageSize);
        }

        public IEnumerable<SuCo> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _suCoRepository.GetMultiPaging(x => x.xoa == false, out totalRow, page, pageSize);
        }

        public SuCo GetById(int id)
        {
            return _suCoRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(SuCo suCo)
        {
            _suCoRepository.Update(suCo);
        }
    }
}