using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models

{
    public class TeamModel
    {
        //properties
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        public string TeamName { get; set; }


    }
}
