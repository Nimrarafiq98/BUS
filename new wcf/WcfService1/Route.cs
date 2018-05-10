using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [DataContract]
    public class Route     //class of routes containing all the attributes
    {

        private string BusNumber;
        [DataMember]
        public string BusNumber1     // to access busnumber
        {
            get { return BusNumber; }
            set { BusNumber = value; }
        }
        private string RouteNumber;   //to access routenumber
        [DataMember]
        public string RouteNumber1
        {
            get { return RouteNumber; }
            set { RouteNumber = value; }
        }

        private  List<Stops> mystops = new List<Stops>();          //enlisting stops
        [DataMember]
        public  List<Stops> Mystops
        {
            get { return mystops; }
            set { mystops = value; }
        }
        private int distance;
        [DataMember]

        public int Distance             // calculating distance
        { // getters and setters of distance
            get { return distance; }
            set { distance = value; }
        }
        private int time;    // calculating time
        [DataMember]

        public int Time
        {   // getters and setters of time
            get { return time; }      
            set { time = value; }
        }



    }
}