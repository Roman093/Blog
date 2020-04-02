using System.Collections.Generic;

namespace BlogBL.Interface
{
    public interface IGenereicService<BLModel> where BLModel : class
    {
        BLModel FindById(int id);
        IEnumerable<BLModel> GetAll();
    }
}