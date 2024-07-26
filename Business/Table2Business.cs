using AutoMapper;
using Business.Interfaces;
using Entities.DTO;
using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Table2Business : ITable2Business
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Table2Business(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public List<Table2DTO> Get()
        {
            var result = _unitOfWork.Table2s.Get().ToList();
            return _mapper.Map<List<Table2DTO>>(result);
        }

        public Table2DTO Get(int id)
        {
            return _mapper.Map<Table2DTO>(_unitOfWork.Table2s.Get(id));
        }
        public Table2DTO Post(Table2DTO Table2)
        {
            var result = _unitOfWork.Table2s.Add(_mapper.Map<Table2>(Table2));
            _unitOfWork.Save();
            return _mapper.Map<Table2DTO>(result);
        }

        public Table2DTO Update(int id, Table2DTO Table2)
        {
            var result = _unitOfWork.Table2s.Update(id, _mapper.Map<Table2>(Table2));
            _unitOfWork.Save();
            return _mapper.Map<Table2DTO>(result);
        }

        public Table2DTO Delete(int id)
        {
            var result = _unitOfWork.Table2s.Delete(id);
            _unitOfWork.Save();
            return _mapper.Map<Table2DTO>(result);
        }
    }
}
