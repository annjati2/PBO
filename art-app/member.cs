using System;

namespace art_app
{
    public class member
    {
        public int id { get; }
        public string owner { get; set; }    
        public bool is_illustrator { get;}
        public string occupation { get; set; }
        public int token { get; set; }
        public member(string name , string job)
        {
            this.owner = name;
            this.occupation = job;
            this.token = 10;
        }
    } 
}
