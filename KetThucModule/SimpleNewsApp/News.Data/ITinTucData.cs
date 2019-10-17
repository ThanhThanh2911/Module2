using News.Core;
using System.Collections.Generic;

namespace News.Data
{
    public interface ITinTucData
    {
        IEnumerable<TinTuc> GetAll();
        TinTuc GetById(int Id);
        TinTuc Add(TinTuc newTinTuc);
        TinTuc Detail(int Id);
        TinTuc Delete(int Id);
        int Commit();

    }
}
