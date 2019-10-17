using System;
using System.Collections.Generic;
using Myself;
using System.Linq;

namespace Myself.Data
{
    public interface IMyselfData
    {
        IEnumerable<Myself1> GetMyselvesByName(string name);
        Myself1 GetById(int myselfId);
        IEnumerable<Myself1> RemoveMyselvesByName(string name);
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

        public IEnumerable<Myself1> GetMyselvesByName(string name = null)
        {
            return from c in Myselves
                   where string.IsNullOrEmpty(name) || c.Name.StartsWith(name)
                   orderby c.Name
                   select c;
        }
        public Myself1 GetById(int myselfId)
        {
            return Myselves.SingleOrDefault(c => c.Id == myselfId);
        }
        public IEnumerable<Myself1> RemoveMyselvesByName(string name)
        {
            foreach (var item in Myselves)
            {
                if (item.Name == name)
                {
                    Myselves.Remove(item);
                }
            }
            return Myselves;
        }
    }

}
