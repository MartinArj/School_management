﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApp
{
   public class staffDetails
    {
       public List<StaffAddress> AddressList = new List<StaffAddress>();
       public List<staffMobileNumber> mobilenumbers = new List<staffMobileNumber>();
   
       private int _Id;

       public int Id
       {
           get { return _Id; }
           set { _Id = value; }
       }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private string _Dob;

        public string Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }

        private string _Qualification;

        public string Qualification
        {
            get { return _Qualification; }
            set { _Qualification = value; }
        }
        private string _JoiningYear;

        public string JoiningYear
        {
            get { return _JoiningYear; }
            set { _JoiningYear = value; }
        }
        private string _PreviousExperience;

        public string PreviousExperience
        {
            get { return _PreviousExperience; }
            set { _PreviousExperience = value; }
        }
        public staffDetails(string Name,string dob, string Qualification, string JoiningYear, string PreviousExperience)
        {
            this._Name = Name;
            this._Dob = dob;
            this._Qualification = Qualification;
            this._JoiningYear = JoiningYear;
            this._PreviousExperience = PreviousExperience;
        }

    }
}
