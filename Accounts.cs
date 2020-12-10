using System;
using System.Collections.Generic;
using System.Text;

namespace Sweng421FinalProject
{
    public interface AccountsIF
    {
        public String getName();
        public String getUserName();

    }
 
    public abstract class AccountsAC : AccountsIF
    {
        private String name;
        private String userName; 

        public AccountsAC(String name, String userName)
        {
            this.name = name;
            this.userName = userName; 
        }

        public string getName()
        {
            return name; 
        }

        public string getUserName()
        {
            return userName; 
        }
    }

    public class Teacher : AccountsAC {
    
        public Teacher(String name, String userName) : base(name, userName)
        {
            //Nothing inside right now, just passes up to accountAC
        }
    }

    public class Student : AccountsAC
    {
        public Student(String name, String userName) : base(name, userName)
        {
            //Nothing inside right now, just passes up to accountAC
        }
    }

}
