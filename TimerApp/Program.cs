using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerApp
{
    class TimerAppContext : ApplicationContext
    {
        private TimerForm _timerForm;
        private NotifyIcon _notifyIcon;
        public TimerAppContext()
        {
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            _notifyIcon = new NotifyIcon()
            {
                ContextMenuStrip = new ContextMenuStrip(),
                Icon = new Icon("clock.ico"),
                Text = "Test Tooltip Text",
                Visible = true
            };
            _timerForm = new TimerForm();
            _notifyIcon.ContextMenuStrip.Items.Add("Set Timer", null, (object s, EventArgs e) => _timerForm.Show());
            _notifyIcon.ContextMenuStrip.Items.Add("E&xit", null, (object sender, EventArgs e) => ExitThread());
            _notifyIcon.DoubleClick += _notifyIcon_DoubleClick;

        }
        


        private void _notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            _timerForm.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            _notifyIcon.Dispose();
            // do any cleanup, saving of data that needs to get done
            Console.WriteLine("You hear the Fat Lady's song.");

        }
    }
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TimerForm timerForm = new TimerForm();
            ApplicationContext applicationContext = new TimerAppContext();

            Application.Run(applicationContext);
        }
    }
}
