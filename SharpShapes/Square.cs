using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SharpShapes
{
    public class Square : Rectangle
    {
        //here u can give whatever name you like instead of edgeLength like for eg. side, sidelength
        //base here is usefull in getting the directives or copies(overrides) from the parent rectangle 
        public Square(int edgeLength): base(edgeLength, edgeLength)
        {
           
        }
    }
}

