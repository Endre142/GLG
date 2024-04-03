using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GLG
{
    internal class CliensDataTabel
    {
        private string _name;
        private string _regnumber;
        private string _cif;
        private string _address;
        private string _iBan1;
        private string _tel;
        private string _email;
        private string _website;
        private string _banka;
        private string _tara;
        private string _judet;
        public CliensDataTabel(CliensDataTabel other)
        {
            _name = other._name;
            _regnumber = other._regnumber;
            _cif = other._cif;
            _address = other._address;
            _judet=other._judet;
            _iBan1 = other._iBan1;
            _tel = other._tel;
            _email = other._email;
            _website = other._website;
            _banka = other._banka;
            _tara = other._tara;
        }
        public CliensDataTabel() { }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string RegNumber
        {
            get { return _regnumber; }
            set { _regnumber = value; }
        }

        public string CIF
        {
            get { return _cif; }
            set { _cif = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string IBan1
        {
            get { return _iBan1; }
            set { _iBan1 = value; }
        }

        public string Tel
        {
            get { return _tel; }
            set { _tel = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Website
        {
            get { return _website; }
            set { _website = value; }
        }

        public string Banka
        {
            get { return _banka; }
            set { _banka = value; }
        }
        public string Tara
        {
            get { return _tara; }
            set { _tara = value; }
        }
        public string Judet
        {
            get { return _judet; }
            set { _judet = value; }
        }

        public int CountNonEmptyFields()
        {
            int count = 0;

            if (!string.IsNullOrEmpty(Name))
                count++;

            if (!string.IsNullOrEmpty(RegNumber))
                count++;

            if (!string.IsNullOrEmpty(CIF))
                count++;

            if (!string.IsNullOrEmpty(Address))
                count++;

            if (!string.IsNullOrEmpty(IBan1))
                count++;

            if (!string.IsNullOrEmpty(Tel))
                count++;

            if (!string.IsNullOrEmpty(Email))
                count++;

            if (!string.IsNullOrEmpty(Website))
                count++;

            if (!string.IsNullOrEmpty(Banka))
                count++;

            if (!string.IsNullOrEmpty(Tara))
                count++;
            if (!string.IsNullOrEmpty(Judet))
                count++;
           
            return count;
        }
        public List<string> GetNonEmptyFields()
        {
            List<string> nonEmptyFields = new List<string>();

            if (!string.IsNullOrEmpty(this.Name))
            {   
                nonEmptyFields.Add("Name:");
                nonEmptyFields.Add(this.Name);
            }


            if (!string.IsNullOrEmpty(this.RegNumber))
            {
                nonEmptyFields.Add("Reg. com.:");
                nonEmptyFields.Add(this.RegNumber);
            }

            if (!string.IsNullOrEmpty(this.CIF))
            {
                nonEmptyFields.Add("CIF:");
                nonEmptyFields.Add(this.CIF);
            }

            if (!string.IsNullOrEmpty(this.Address))
            {
                nonEmptyFields.Add("Adresa:");
                nonEmptyFields.Add(this.Address);
            }
            if (!string.IsNullOrEmpty(this.Judet))
            {
                nonEmptyFields.Add("Judet: ");
                nonEmptyFields.Add(this.Judet);
            }
            if (!string.IsNullOrEmpty(this.Tara))
            {
                nonEmptyFields.Add("Tara:");
                nonEmptyFields.Add(this.Tara);
            }

            if (!string.IsNullOrEmpty(this.IBan1))
            {
                nonEmptyFields.Add("IBAN:");
                nonEmptyFields.Add(this.IBan1);
            }

            if (!string.IsNullOrEmpty(this.Tel))
            {
                nonEmptyFields.Add("Tel.:");
                nonEmptyFields.Add(this.Tel);
            }

            if (!string.IsNullOrEmpty(this.Email))
            {
                nonEmptyFields.Add("Email:");
                nonEmptyFields.Add(this.Email);
            }

            if (!string.IsNullOrEmpty(this.Website))
            {
                nonEmptyFields.Add("Website:");
                nonEmptyFields.Add(this.Website);
            }

            if (!string.IsNullOrEmpty(this.Banka))
            {
                nonEmptyFields.Add("Banka:");
                nonEmptyFields.Add(this.Banka);
            }

            

            return nonEmptyFields;
        }
    
    }

}
