using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inditas.Models
{
    public class Persones : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
                Persone();
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                Persone();
            }
        }

        private string age;

        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
                Persone();
            }
        }

        private string city;

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                Persone();
            }
        }

        private string profession;

        public string Profession
        {
            get
            {
                return profession;
            }
            set
            {
                profession = value;
                Persone();
            }
        }

        private string hobby;

        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
                Persone();
            }
        }

        public Persones(int id, string name, string age, string city, string profession, string hobby)
        {
            Id = id;
            Name = name;
            Age = age;
            City = city;
            Profession = profession;
            Hobby = hobby;
        }

        public Persones(string sor)
        {
            string[] a = sor.Split(';');
            Name = a[0];
            Age = a[1];
            City = a[2];
            Profession = a[3];
            Hobby = a[4];
        }

        public Persones()
        {
        }

        public override string ToString()
        {
            return Name != null ? $"Név: {Name}, Épület: {Age}, Város: {City}, Szakma: {Profession}, Hobbi: {Hobby}" : "";
        }

        private void Persone([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
