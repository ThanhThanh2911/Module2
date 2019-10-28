using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuanLyTruongMamNon.Models
{
    public interface IChildrenDiemDanhRePo
    {
        IEnumerable<ChildrenDiemDanh> GetAll();
    }
}
