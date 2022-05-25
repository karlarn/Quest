using System;
using System.Collections.Generic;

namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set;}


        public string ShininessDescription(int shineLevel)
        {
            if(shineLevel<2)
            {
                return "dull";
            }
            else if(shineLevel>1 && shineLevel<6)
            {
                return "noticeable";
            }
            else if(shineLevel>5 && shineLevel<10)
            {
                return "bright";
            }
            else if(shineLevel>9)
            {
                return "blinding";
            }
            else{return "";}
        }



    }
}