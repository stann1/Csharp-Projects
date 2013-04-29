using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Implementation of the undefined classes and methods is not included because the purpose of the excercise is different
and the task itself is very simple*/

namespace _01.StraightLineCode
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
        }

        private Potato GetPotato()
        {
            //...
        }

        private Carrot GetCarrot()
        {
            //...
        }       
        
        private void Cut(Vegetable potato)
        {
            //...
        }

        public void Cook()
        {
            Bowl bowl = GetBowl();

            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);
            bowl.Add(potato);
            
            Carrot carrot = GetCarrot();           
            Peel(carrot);
            Cut(carrot);
            bowl.Add(carrot);            
        }
        
    }

}
