using System;
using System.Collections.Generic;
using Myself;
using System.Linq;

namespace Myself.Data
{
    public interface IMyselfData
    {
        IEnumerable<Myself1> GetAll();
    }

    public class InMemoryMyselfData : IMyselfData
    {
        public List<Myself1> Myselves { get; set; }
        public InMemoryMyselfData()
        {
            Myselves = new List<Myself1>()
            {
                new Myself1{ Id = 1, Name = "CodeGym", Location = "28 NTP", MyselfType = MyselfType.CNTT},
                new Myself1{ Id = 2, Name = "3S", Location = "28 NTP", MyselfType = MyselfType.UnKnow},
                new Myself1{ Id = 3, Name = "DeHa", Location = "28 NTP", MyselfType = MyselfType.CNTT}
            };
        }

        public IEnumerable<Myself1> GetAll()
        {
            return from c in Myselves
                   orderby c.Name
                   select c;
        }
    }

}
