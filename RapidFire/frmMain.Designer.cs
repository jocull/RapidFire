namespace RapidFire
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyToUse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTriggerState = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tmrFire = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.trkDelay = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.gblEventHandler = new Gma.UserActivityMonitor.GlobalEventProvider();
            this.radBtnLeft = new System.Windows.Forms.RadioButton();
            this.radBtnRight = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.trkDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select this box and press a key to use it:";
            // 
            // txtKeyToUse
            // 
            this.txtKeyToUse.Location = new System.Drawing.Point(13, 30);
            this.txtKeyToUse.Name = "txtKeyToUse";
            this.txtKeyToUse.ReadOnly = true;
            this.txtKeyToUse.Size = new System.Drawing.Size(77, 20);
            this.txtKeyToUse.TabIndex = 1;
            this.txtKeyToUse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKeyToUse_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rapid Fire is...";
            // 
            // lblTriggerState
            // 
            this.lblTriggerState.AutoSize = true;
            this.lblTriggerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriggerState.Location = new System.Drawing.Point(18, 127);
            this.lblTriggerState.Name = "lblTriggerState";
            this.lblTriggerState.Size = new System.Drawing.Size(44, 20);
            this.lblTriggerState.TabIndex = 3;
            this.lblTriggerState.Text = "OFF";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(119, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "When rapid fire is on, your mouse will be clicked like crazy! SWEET.\r\n";
            // 
            // tmrFire
            // 
            this.tmrFire.Enabled = true;
            this.tmrFire.Tick += new System.EventHandler(this.tmrFire_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(10, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "If you panic and need to stop firing, ESC always stops.";
            // 
            // trkDelay
            // 
            this.trkDelay.LargeChange = 100;
            this.trkDelay.Location = new System.Drawing.Point(12, 56);
            this.trkDelay.Maximum = 1000;
            this.trkDelay.Minimum = 20;
            this.trkDelay.Name = "trkDelay";
            this.trkDelay.Size = new System.Drawing.Size(263, 45);
            this.trkDelay.SmallChange = 5;
            this.trkDelay.TabIndex = 6;
            this.trkDelay.TickFrequency = 20;
            this.trkDelay.Value = 100;
            this.trkDelay.Scroll += new System.EventHandler(this.trkDelay_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(212, 33);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(69, 13);
            this.lblDelay.TabIndex = 7;
            this.lblDelay.Text = "100 ms delay";
            // 
            // gblEventHandler
            // 
            this.gblEventHandler.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gblEventHandler_KeyUp);
            // 
            // radBtnLeft
            // 
            this.radBtnLeft.AutoSize = true;
            this.radBtnLeft.Checked = true;
            this.radBtnLeft.Location = new System.Drawing.Point(105, 157);
            this.radBtnLeft.Name = "radBtnLeft";
            this.radBtnLeft.Size = new System.Drawing.Size(77, 17);
            this.radBtnLeft.TabIndex = 8;
            this.radBtnLeft.TabStop = true;
            this.radBtnLeft.Text = "Left Button";
            this.radBtnLeft.UseVisualStyleBackColor = true;
            // 
            // radBtnRight
            // 
            this.radBtnRight.AutoSize = true;
            this.radBtnRight.Location = new System.Drawing.Point(188, 156);
            this.radBtnRight.Name = "radBtnRight";
            this.radBtnRight.Size = new System.Drawing.Size(84, 17);
            this.radBtnRight.TabIndex = 9;
            this.radBtnRight.TabStop = true;
            this.radBtnRight.Text = "Right Button";
            this.radBtnRight.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 208);
            this.Controls.Add(this.radBtnRight);
            this.Controls.Add(this.radBtnLeft);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.trkDelay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTriggerState);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeyToUse);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Rapid Fiyahhhh!";
            ((System.ComponentModel.ISupportInitialize)(this.trkDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gma.UserActivityMonitor.GlobalEventProvider gblEventHandler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyToUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTriggerState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrFire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trkDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.RadioButton radBtnLeft;
        private System.Windows.Forms.RadioButton radBtnRight;
    }
}

