using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7CsharpNet6
{
    internal class Billetera
    {
        private int _billetesDe10;
        private int _billetesDe20;
        private int _billetesDe50;
        private int _billetesDe100;
        private int _billetesDe200;
        private int _billetesDe500;
        private int _billetesDe1000;
        public int BilletesDe10 
        {
            get { return _billetesDe10; } 
            set { _billetesDe10 = value; } 
        
        }
        public int BilletesDe20
        {
            get { return _billetesDe20; }
            set { _billetesDe20 = value; }

        }
        public int BilletesDe50
        {
            get { return _billetesDe50; }
            set { _billetesDe50 = value; }

        }
        public int BilletesDe100
        {
            get { return _billetesDe100; }
            set { _billetesDe100 = value; }

        }
        public int BilletesDe200
        {
            get { return _billetesDe200; }
            set { _billetesDe200 = value; }

        }
        public int BilletesDe500
        {
            get { return _billetesDe500; }
            set { _billetesDe500 = value; }

        }
        public int BilletesDe1000
        {
            get { return _billetesDe1000; }
            set { _billetesDe1000 = value; }

        }

        public decimal Total()
        {
            decimal total = 0;
            total = BilletesDe10 * 10 + BilletesDe20 * 20 + BilletesDe50 * 50 
                + BilletesDe100 * 100 + BilletesDe200 * 200 + BilletesDe500 * 500
                + BilletesDe1000 * 1000;
            return total;
        }

        public void vaciar()
        {
            this.BilletesDe10 = 0;
            this.BilletesDe20 = 0;
            this.BilletesDe50 = 0;
            this.BilletesDe100 = 0;
            this.BilletesDe200 = 0;
            this.BilletesDe500 = 0;
            this.BilletesDe1000 = 0;
        }

        public Billetera Combinar(Billetera billetera)
        {
            Billetera nueva = new Billetera();
            nueva.BilletesDe10 = this.BilletesDe10 + billetera.BilletesDe10;
            nueva.BilletesDe20 = this.BilletesDe20 + billetera.BilletesDe20;
            nueva.BilletesDe50 = this.BilletesDe50 + billetera.BilletesDe50;
            nueva.BilletesDe100 = this.BilletesDe100 + billetera.BilletesDe100;
            nueva.BilletesDe200 = this.BilletesDe200 + billetera.BilletesDe200;
            nueva.BilletesDe500 = this.BilletesDe500 + billetera.BilletesDe500;
            nueva.BilletesDe1000 = this.BilletesDe1000 + billetera.BilletesDe1000;
            this.vaciar();
            billetera.vaciar();
            return nueva;
        }
    }
}
