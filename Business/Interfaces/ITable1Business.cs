using Entities.DTO;

namespace Business.Interfaces
{
    public interface ITable1Business
    {
        List<Table1DTO> Get();
        Table1DTO Get(int id);
        Table1DTO Post(Table1DTO table1);
        Table1DTO Update(int id, Table1DTO table1);
        Table1DTO Delete(int id);
    }
}
