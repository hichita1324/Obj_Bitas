using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bitas
{
    public class Ob_Phanquyen
    {
        private string mota;
        private bool xem;
        private bool themmoi;
        private bool sua;
        private bool xoa;
        private bool xuatbaocao;
        public string MOTA { get { return mota; } set { mota = value; } }
        public bool XEM { get { return xem; } set { xem = value; } }
        public bool THEMMOI { get { return themmoi; } set { themmoi = value; } }
        public bool SUA { get { return sua; } set { sua = value; } }
        public bool XOA { get { return xoa; } set { xoa = value; } }
        public bool XUATBAOCAO { get { return xuatbaocao; } set { xuatbaocao = value; } }
    }
}
