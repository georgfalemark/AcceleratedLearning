using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndLists.Core
{
    public class StringListToNumber
    {
        public int ElevatorGoUpAndDown(string[] input)
        {
            if (input == null)
            {
                return 0;
            }

            int elevatorFloor = 0;

            foreach (string item in input)
            {
                if (item == "UPP")
                {
                    elevatorFloor++;
                }
                else if (item == "NER")
                {
                    elevatorFloor--;
                }
            }
            return elevatorFloor;
        }

        public int ElevatorGoUpAndDown_Linq(string[] input)
        {
            if (input == null)
            {
                return 0;
            }
            return input.Sum(x => x == "UPP" ? 1 : x == "NER" ? -1 : 0);
        }




        public int ElevatorGoUpAndDown_Linq(IEnumerable<string> list)
        {
            if (list == null)
                return 0;

            return list.Count(x => x == "UPP") - list.Count(x => x == "NER");
        }

        public int ElevatorGoUpAndDown_Linq_OneLiner(IEnumerable<string> list)

        {
            if (list == null)
                return 0;

            return list.Sum(x => x == "UPP" ? 1 : x == "NER" ? -1 : 0);
        }
    }
}
