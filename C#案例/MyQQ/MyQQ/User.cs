using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyQQ
{
    class User
    {
        string userId;

        public string UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        string userPwd;

        public string UserPwd
        {
            get { return userPwd; }
            set { userPwd = value; }
        }
        string nickName; 

        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
        string realName;

        public string RealName
        {
            get { return realName; }
            set { realName = value; }
        }
        string personalMsg;

        public string PersonalMsg
        {
            get { return personalMsg; }
            set { personalMsg = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        int face;

        public int Face
        {
            get { return face; }
            set { face = value; }
        }

    }
}
