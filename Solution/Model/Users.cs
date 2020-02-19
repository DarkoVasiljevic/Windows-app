using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Users
    {
        private int userId;
        private string userName;
        private string userPasswd;
        private string email;
        private string role;
        private int retryAtempts;
        private int isLocked;
        private DateTime lockedDate;

        public Users()
        {
        }

        public Users(int userId, string userName, string email, string role)
        {
            this.userId = userId;
            this.userName = userName;
            this.email = email;
            this.role = role;
        }

        public Users(int userId, string userName, string userPasswd, string email, string role, int retryAtempts, int isLocked, DateTime lockedDate)
        {
            this.userId = userId;
            this.userName = userName;
            this.userPasswd = userPasswd;
            this.email = email;
            this.role = role;
            this.retryAtempts = retryAtempts;
            this.isLocked = isLocked;
            this.lockedDate = lockedDate;
        }

        public Users(int userId, string userName, string userPasswd, string email, string role)
        {
            this.userId = userId;
            this.userName = userName;
            this.userPasswd = userPasswd;
            this.email = email;
            this.role = role;
        }

        public int UserId
        {
            get { return userId; }

            set
            {
                userId = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string UserPasswd
        {
            get
            {
                return userPasswd;
            }

            set
            {
                userPasswd = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public int RetryAtempts
        {
            get
            {
                return retryAtempts;
            }

            set
            {
                retryAtempts = value;
            }
        }

        public int IsLocked
        {
            get
            {
                return isLocked;
            }

            set
            {
                isLocked = value;
            }
        }

        public DateTime LockedDate
        {
            get
            {
                return lockedDate;
            }

            set
            {
                lockedDate = value;
            }
        }
    }
}
