using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfKetiranyuAdatkotes
{
    public class BindClass:INotifyPropertyChanged
    {
        private int bindadat;
        private int min, max;

        public event PropertyChangedEventHandler PropertyChanged;

        public int BindAdat
        {
            get { return bindadat; }

            set
            {
                if (value!=bindadat && value>=min && value<=max)
                {
                    bindadat = value;
                    Prop_Changed("BindAdat");
                }
            }
        }

        public BindClass(int ertek,int min,int max)
        {
            BindAdat = ertek;
            this.min = min;
            this.max = max;
        }

        private void Prop_Changed(string prop)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
