using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MichielMulder2eZit14
{

    public class Rootobject
    {
        public Personen[] Personen { get; set; }
    }

    public class Personen : INotifyCollectionChanged
    {
        public string _id { get; set; }
        public int index { get; set; }
        public bool isActive { get; set; }
        public string balance { get; set; }
        public string mugshot { get; set; }
        public int age { get; set; }
        public string eyeColor { get; set; }
        public string fullname { get; set; }
        public string gender { get; set; }
        public string company { get; set; }
        public string email { get; set; }
        public string telnumber { get; set; }
        public string address { get; set; }
        public string about { get; set; }
        public string registered { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public string[] tags { get; set; }
        public Friend[] friends { get; set; }
        public string greeting { get; set; }
        public string favoriteFruit { get; set; }
        public event NotifyCollectionChangedEventHandler CollectionChanged;
    }

    public class Friend
    {
        public int id { get; set; }
        public string fullname { get; set; }
    }

}
