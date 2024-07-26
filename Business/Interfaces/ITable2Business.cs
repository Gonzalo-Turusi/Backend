using Entities.DTO;

namespace Business.Interfaces
{
    public interface ITable2Business
    {
        List<Table2DTO> Get();
        Table2DTO Get(int id);
        Table2DTO Post(Table2DTO table1);
        Table2DTO Update(int id, Table2DTO table1);
        Table2DTO Delete(int id);
    }
}
