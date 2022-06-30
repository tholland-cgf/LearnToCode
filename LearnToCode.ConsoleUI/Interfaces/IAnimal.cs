using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnToCode.ConsoleUI.Interfaces
{
    interface IAnimal
    {
       
        public string Name { get; set; }
        public int Age { get; set; }




        void Move();
        void MakeNoise();
    }


}
