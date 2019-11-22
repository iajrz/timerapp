namespace TimerApp
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.targetTime = new System.Windows.Forms.TextBox();
            this.TimerStart = new System.Windows.Forms.Button();
            this._timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // targetTime
            // 
            this.targetTime.Location = new System.Drawing.Point(12, 12);
            this.targetTime.Name = "targetTime";
            this.targetTime.Size = new System.Drawing.Size(100, 20);
            this.targetTime.TabIndex = 0;
            // 
            // timerStart
            // 
            this.TimerStart.Location = new System.Drawing.Point(144, 11);
            this.TimerStart.Name = "timerStart";
            this.TimerStart.Size = new System.Drawing.Size(75, 23);
            this.TimerStart.TabIndex = 1;
            this.TimerStart.Text = "Start";
            this.TimerStart.UseVisualStyleBackColor = true;
            this.TimerStart.Click += new System.EventHandler(this.TimerStart_Click);
            // 
            // timer
            // 
            this._timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerForm
            // 
            this.AcceptButton = this.TimerStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 49);
            this.Controls.Add(this.TimerStart);
            this.Controls.Add(this.targetTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimerForm";
            this.Text = "Timer App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimerForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimerForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox targetTime;
        private System.Windows.Forms.Button TimerStart;
        private System.Windows.Forms.Timer _timer;
    }
}

