using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form2 : Form, IColorObserver
    {
        private readonly IObservable observable;

        public Form2(IObservable observable)
        {
            InitializeComponent();
            this.observable = observable;
        }

        public void onColorChanged(Color color)
        {
            BackColor = color;
        }

        private void buttonSubcribe_Click(object sender, EventArgs e)
        {
            observable.Subscribe(this);
        }

        private void buttonUnsubscribe_Click(object sender, EventArgs e)
        {
            observable.UnSubscribe(this);
        }
    }
}
