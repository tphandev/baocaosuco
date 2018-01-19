using BaoCaoSuCo.Data.Infrastructure;
using BaoCaoSuCo.Data.Repositories;
using BaoCaoSuCo.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoCaoSuCo.Service
{
    public interface IDonViService
    {
        void Add(DonVi donVi);

        void Update(DonVi donVi);

        void Detele(string MaDonVi);

        IEnumerable<DonVi> GetAll();

        IEnumerable<DonVi> GetAllPaging(int page, int pageSize, out int totalRow);

        DonVi GetByMa(string maDonVi);

        void SaveChanges();
    }
    public class DonViService : IDonViService
    {
        IDonViRepository _donViRepository;
        IUnitOfWork _unitOfWork;

        public DonViService(IDonViRepository donViRepository, IUnitOfWork unitOfWork)
        {
            _donViRepository = donViRepository;
            _unitOfWork = unitOfWork;
        }
        public void Add(DonVi donVi)
        {
            _donViRepository.Add(donVi);
        }

        public void Detele(string MaDonVi)
        {
            _donViRepository.DeleteMulti(x => x.MaDonVi == MaDonVi);
        }

        public IEnumerable<DonVi> GetAll()
        {
           return _donViRepository.GetAll();
        }        

        public IEnumerable<DonVi> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _donViRepository.GetMultiPaging(x => x.xoa == false, out totalRow, page, pageSize);
        }

        public DonVi GetByMa(string maDonVi)
        {
            return _donViRepository.GetSingleByCondition(x => x.MaDonVi == maDonVi);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(DonVi donVi)
        {
            _donViRepository.Update(donVi);
        }
    }
}
