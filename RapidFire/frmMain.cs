using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RapidFire
{
    public partial class frmMain : Form
    {
        public Keys TriggerKey = Keys.F7; //Default
        public const Keys ExitKey = Keys.Escape;

        private bool _TriggerState = false;
        public bool TriggerState
        {
            get { return _TriggerState; }
            set
            {
                _TriggerState = value;
                lblTriggerState.Text = TriggerState ? "ON" : "OFF";
            }
        }


        public frmMain()
        {
            InitializeComponent();
            txtKeyToUse.Text = TriggerKey.ToString();
            lblDelay.Text = trkDelay.Value + "ms delay";
        }

        private void trkDelay_Scroll(object sender, EventArgs e)
        {
            tmrFire.Interval = trkDelay.Value;
            lblDelay.Text = trkDelay.Value + "ms delay";
        }

        private void txtKeyToUse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ExitKey)
                return; //This key is protected

            TriggerKey = e.KeyCode;
            txtKeyToUse.Text = TriggerKey.ToString();
        }

        private void gblEventHandler_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ExitKey)
            {
                TriggerState = false;
                return;
            }

            if (txtKeyToUse.Focused
                && e.KeyCode != ExitKey)
            {
                return;
            }

            //Toggle the trigger
            if (e.KeyCode == TriggerKey)
            {
                TriggerState = !TriggerState;
                return;
            }
        }

        private void tmrFire_Tick(object sender, EventArgs e)
        {
            if (TriggerState)
            {
                Program.DoMouseClick(radBtnLeft.Checked);
            }
        }
    }
}
