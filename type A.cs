using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace demo_oop_1
{
//Access Modifier Allowed Inside Class?
//1-Private[Default]
//2-Private Protected
//3-Protected
//4-Internal
//5-Protected Internal
//6-Public
    public class type_A
    {
        private int x;//accessible within its scope only
        internal int y; //accessible within scope and its project
        public int z; // ccessible within scope and project and external project [import]
        public type_A()
        { 
        type_B obj=new type_B();

        }

  
    }
    
}
