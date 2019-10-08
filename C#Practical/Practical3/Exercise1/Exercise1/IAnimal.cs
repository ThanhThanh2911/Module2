using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    interface IAnimal
    {
        int ID { get; set; }
        string Name { get; set; }
        int Age { get; set; }

        //void Move();
    }
}
