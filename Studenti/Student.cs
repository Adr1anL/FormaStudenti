using System;

namespace Studenti
{
    internal class Student
    {
        private string _imeStudenta;
        private string _prezimeStudenta;
        private string _smjerStudenta;
        private string _brojIndeksaStudenta;
        private string _datumRodjenjaStudenta;

        public string ImeStudenta
        {
            get => _imeStudenta;
            set => _imeStudenta = value;
        }

        public string PrezimeStudenta
        {
            get => _prezimeStudenta;
            set => _prezimeStudenta = value;
        }

        public string SmjerStudenta
        {
            get => _smjerStudenta;
            set => _smjerStudenta = value;
        }

        public string BrojIndeksaStudenta
        {
            get => _brojIndeksaStudenta;
            set => _brojIndeksaStudenta = value;
        }

        public string DatumRodjenjaStudenta
        {
            get => _datumRodjenjaStudenta;
            set => _datumRodjenjaStudenta = value;
        }

        public Student(string imeStudenta, string prezimeStudenta, string smjerStudenta, string brojIndeksaStudenta, string datumRodjenjaStudenta)
        {
            _imeStudenta = imeStudenta;
            _prezimeStudenta = prezimeStudenta;
            _smjerStudenta = smjerStudenta;
            _brojIndeksaStudenta = brojIndeksaStudenta;
            _datumRodjenjaStudenta = datumRodjenjaStudenta;
        }

        public Student() { }

        public override string ToString()
        {
            return $"{BrojIndeksaStudenta}. {ImeStudenta} {PrezimeStudenta} - {SmjerStudenta} ( {DatumRodjenjaStudenta} )";
        }
    }
}
