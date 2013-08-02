using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStructure
{
    public class CustomSergiuState: IGameObject
    {
        public void Update(double elapsedTime)
        {
            Console.WriteLine("update Sergiu State");
        }

        public void Render()
        {
            Console.WriteLine("Render Sergiu State");
        }
    }
}
