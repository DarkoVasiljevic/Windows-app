using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employees
    {
        private int userId;
        private int employeeId;
        private string firstName;
        private string lastName;
        private string title;
        private string titleCourt;
        private DateTime? birthDate;
        private DateTime? hireDate;
        private string adress;
        private string city;
        private string region;
        private string postalCode;
        private string country;
        private string homePhone;
        private string ext;
        private byte[] photo;
        private string notes;
        private int? reportsTo;
        private string photoPath;

        public Employees()
        { }

        public Employees(int employeeId, string firstName, string lastName)
        {
            this.employeeId = employeeId;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        //public Employees(int employeeId, string lastName, string firstName, string title, string titleCourt, DateTime? birthDate, 
        //                    DateTime? hireDate, string adress, string city, string region, string postalCode, string country, 
        //                    string homePhone, string ext, byte[] photo, string notes, int? reportsTo, string photoPath)
        //    : base(lastName, firstName, title, adress, city, region, postalCode, country, homePhone)
        //{
        //    this.employeeId = employeeId;
        //    this.titleCourt = titleCourt;
        //    this.birthDate = birthDate;
        //    this.hireDate = hireDate;
        //    this.ext = ext;
        //    this.photo = photo;
        //    this.notes = notes;
        //    this.reportsTo = reportsTo;
        //    this.photoPath = photoPath;
        //}

        public Employees(string firstName, string lastName, string title)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.title = title;          
        }

        public Employees(int userId, int employeeId, string lastName, string firstName, string title, string titleCourt, DateTime? birthDate, DateTime? hireDate, string adress, string city, string region, string postalCode, string country, string homePhone, string ext, byte[] photo, string notes, int? reportsTo, string photoPath)
        {
            this.userId = userId;
            this.employeeId = employeeId;
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
        }

        public Employees(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string TitleCourt
        {
            get { return titleCourt; }
            set { titleCourt = value; }
        }

        public DateTime? Birthday
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public DateTime? HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }

        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public string Ext
        {
            get { return ext; }
            set { ext = value; }
        }

        public byte[] Photo
        {
            get { return photo; }
            set { photo = value; }
        }

        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        public int? ReportsTo
        {
            get { return reportsTo; }
            set { reportsTo = value; }
        }

        public string PhotoPath
        {
            get { return photoPath; }
            set { photoPath = value; }
        }

    }
}
