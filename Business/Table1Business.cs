using AutoMapper;
using Business.Interfaces;
using Entities.DTO;
using Entities.Models;
using Repository;

namespace Business
{
    public class Table1Business : ITable1Business
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Table1Business(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public List<Table1DTO> Get()
        {
            var result = _unitOfWork.Table1s.Get().ToList();
            return _mapper.Map<List<Table1DTO>>(result);
        }

        public Table1DTO Get(int id)
        {
            return _mapper.Map<Table1DTO>(_unitOfWork.Table1s.Get(id));
        }
        public Table1DTO Post(Table1DTO table1)
        {
            var result = _unitOfWork.Table1s.Add(_mapper.Map<Table1>(table1));
            _unitOfWork.Save();
            return _mapper.Map<Table1DTO>(result);
        }

        public Table1DTO Update(int id, Table1DTO table1)
        {
            var result = _unitOfWork.Table1s.Update(id, _mapper.Map<Table1>(table1));
            _unitOfWork.Save();
            return _mapper.Map<Table1DTO>(result);
        }

        public Table1DTO Delete(int id)
        {
            var result = _unitOfWork.Table1s.Delete(id);
            _unitOfWork.Save();
            return _mapper.Map<Table1DTO>(result);
        }

    }
}
