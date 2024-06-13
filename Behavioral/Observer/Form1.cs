namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ColorObservable observable = new ColorObservable();

        public void Notify()
        {
            observable.Notify();
        }

        public void Subscribe(IColorObserver observer)
        {
            observable.Subscribe(observer);
        }

        public void UnSubscribe(IColorObserver observer)
        {
            observable.UnSubscribe(observer);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(observable);
            form2.Show();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                observable.Color = colorDialog.Color;
            }
        }
    }
}
