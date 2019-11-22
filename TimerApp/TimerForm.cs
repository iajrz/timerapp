using System;
using System.Windows.Forms;

namespace TimerApp
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerStart_Click(object sender, EventArgs e)
        {
            if (targetTime.Text != "")
            {
                float minutes = float.Parse(targetTime.Text);
                _timer.Interval = (int)(minutes * 1000);
                _timer.Start();
                TimerStart.Enabled = false;
            }
            else
            {
                MessageBox.Show("No Can Do. Make sure there's a number in the textbox!", "No Can Do", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timer.Stop();
            MessageBox.Show("Time Is Up!");
            TimerStart.Enabled = true;
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void TimerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Hide();
            }
        }

    }
}
