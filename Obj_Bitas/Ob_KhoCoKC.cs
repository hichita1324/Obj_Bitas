using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitas
{
    public class Ob_KhoCoKC
    {
        private int id_kho;
		private DateTime ngayketchuyen;
        public int ID_KHO { get { return id_kho; } set { id_kho = value; } }
        public DateTime NGAYKETCHUYEN { get { return ngayketchuyen; } set { ngayketchuyen = value; } }

		public Ob_KhoCoKC()
		{
			id_kho = 0;
			ngayketchuyen = DateTime.MinValue;
		}

        public Ob_KhoCoKC(int new_id_kho, DateTime new_ngayketchuyen)	
		{
            id_kho = new_id_kho;
            ngayketchuyen = new_ngayketchuyen;
		}

        public Ob_KhoCoKC(Ob_KhoCoKC newOb)
		{
            id_kho = newOb.ID_KHO;
            ngayketchuyen = newOb.NGAYKETCHUYEN;
		}
    }
}
