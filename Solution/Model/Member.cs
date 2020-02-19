using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member
    {
        protected int memberIntId;
        protected string memberStringId;
        protected string lastName;
        protected string firstName;
        protected string title;
        protected string titleCourt;
        protected DateTime? birthDate;
        protected DateTime? hireDate;
        protected string adress;
        protected string city;
        protected string region;
        protected string postalCode;
        protected string country;
        protected string homePhone;
        protected string ext;
        protected byte[] photo;
        protected string notes;
        protected int? reportsTo;
        protected string photoPath;
        protected string fax;

        public Member()
        {

        }

        public Member(int memberIntId, string memberStringId, string lastName, string firstName, string title, string titleCourt, 
                        DateTime? birthDate, DateTime? hireDate, string adress, string city, string region, string postalCode, 
                        string country, string homePhone, string ext, byte[] photo, string notes, int? reportsTo, 
                        string photoPath, string fax)
        {
            this.memberIntId = memberIntId;
            this.memberStringId = memberStringId;
            this.lastName = lastName;
            this.firstName = firstName;
            this.title = title;
            this.titleCourt = titleCourt;
            this.birthDate = birthDate;
            this.hireDate = hireDate;
            this.adress = adress;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.homePhone = homePhone;
            this.ext = ext;
            this.photo = photo;
            this.notes = notes;
            this.reportsTo = reportsTo;
            this.photoPath = photoPath;
            this.fax = fax;
        }

        public Member(string lastName, string firstName, string title, string adress, string city,
                        string region, string postalCode, string country, string homePhone)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.title = title;
            this.adress = adress;
            this.city = city;
            this.region = region;
            this.postalCode = postalCode;
            this.country = country;
            this.homePhone = homePhone;
        }

        public Member(string lastName, string firstName, string title, string adress, string city,
                        string region, string postalCode, string country, string homePhone, string fax)
            : this(lastName, firstName, title, adress, city, region, postalCode, country, homePhone)
        {
            this.fax = fax;
        }

        public int MemberIntId
        {
            get
            { return memberIntId; }
            set
            { memberIntId = value; }
        }

        public string MemberStringId
        {
            get
            { return memberStringId; }
            set
            { memberStringId = value; }
        }

        public string LastName
        {
            get
            { return lastName; }
            set
            { lastName = value; }
        }

        public string FirstName
        {
            get
            {  return firstName; }
            set
            { firstName = value; }
        }

        public string Title
        {
            get
            { return title; }
            set
            { title = value; }
        }

        public string TitleCourt
        {
            get
            { return titleCourt; }
            set
            { titleCourt = value; }
        }

        public DateTime? BirthDate
        {
            get
            { return birthDate; }
            set
            { birthDate = value; }
        }

        public DateTime? HireDate
        {
            get
            { return hireDate; }
            set
            { hireDate = value; }
        }

        public string Adress
        {
            get
            { return adress; }
            set
            { adress = value; }
        }

        public string City
        {
            get
            { return city; }
            set
            { city = value; }
        }

        public string Region
        {
            get
            { return region; }
            set
            { region = value; }
        }

        public string PostalCode
        {
            get
            { return postalCode; }
            set
            { postalCode = value; }
        }

        public string Country
        {
            get
            { return country; }
            set
            { country = value; }
        }

        public string HomePhone
        {
            get
            { return homePhone; }
            set
            { homePhone = value; }
        }

        public string Ext
        {
            get
            { return ext; }
            set
            { ext = value; }
        }

        public byte[] Photo
        {
            get
            { return photo; }
            set
            { photo = value; }
        }

        public string Notes
        {
            get
            { return notes; }
            set
            { notes = value; }
        }

        public int? ReportsTo
        {
            get
            { return reportsTo; }
            set
            { reportsTo = value; }
        }

        public string PhotoPath
        {
            get
            { return photoPath; }
            set
            { photoPath = value; }
        }

        public string Fax
        {
            get
            { return fax; }
            set
            { fax = value; }
        }
   
    }
}
