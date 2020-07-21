using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RCT
{
   
    public class ArrayManager
    {
        public ArrayManager(int size=100) 
        {
            _close = new ArrayList(size);
            
            this.size = size;
        }
        public int count { get; set; }
        public int size { get; set; }
        public bool inited { get; set; } = false;

        #region close | C
        private ArrayList _close;
        public ArrayList close
        {
            get { return _close; }
            set { _close = value; }
        }
        public ArrayList C
        {
            get { return _close; }
            set { _close = value; }
        }
        #endregion
        #region vol | V
        private ArrayList _vol;
        public ArrayList vol
        {
            get { return _vol; }
            set { _vol = value; }
        }
        public ArrayList V
        {
            get { return _vol; }
            set { _vol = value; }
        }
        #endregion
        #region open | O
        private ArrayList _open;
        public ArrayList open
        {
            get { return _open; }
            set { _open = value; }
        }
        public ArrayList O
        {
            get { return _open; }
            set { _open = value; }
        }
        #endregion
        #region hight | H
        private ArrayList _hight;
        public ArrayList hight
        {
            get { return _hight; }
            set { _hight = value; }
        }
        public ArrayList H
        {
            get { return _hight; }
            set { _hight = value; }
        }
        #endregion
        #region low | L
        private ArrayList _low;
        public ArrayList low
        {
            get { return _low; }
            set { _low = value; }
        }
        public ArrayList L
        {
            get { return _low; }
            set { _low = value; }
        }
        #endregion

        public void update_bar(BarData barData) 
        {
            this.count++;
            if (inited && this.count>=this.size)
            {
                this.inited = true;
                this.C.RemoveAt(size-1);
                this.O.Insert(0, barData.open);
                this.V.Insert(0, barData.vol);
                this.H.Insert(0, barData.hight);
                this.L.Insert(0, barData.low);
            }
            this.C.Insert(0, barData.close);
            this.O.Insert(0, barData.open);
            this.V.Insert(0, barData.vol); 
            this.H.Insert(0, barData.hight); 
            this.L.Insert(0, barData.low);
        }
        public void ma() {
        }
    }
}
