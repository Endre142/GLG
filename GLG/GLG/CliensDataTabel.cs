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
        public CliensDataTabel(CliensDataTabel other)
        {
            _name = other._name;
            _regnumber = other._regnumber;
            _cif = other._cif;
            _address = other._address;
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
    }
}
