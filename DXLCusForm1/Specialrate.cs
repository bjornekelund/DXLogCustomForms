using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DXLog.net;

namespace DXLog.net
{
    public partial class SpecialRate : KForm
    {
        ContestData cdata;
        FrmMain frmMain;

        public static String CusWinName
        {
            get { return "Special rate"; }
        }

        public static Int32 CusFormID
        {
            get { return 1001; }
        }
        
        private ContestData _cdata = null;
        private Font _windowFont = new Font("Courier New", 10, FontStyle.Regular);

        private FrmMain mainForm = null;

        public SpecialRate()
        {
            InitializeComponent();
        }

        public SpecialRate(ContestData cdata)
        {
            InitializeComponent();
            ColorSetTypes = new String[] { "Background", "Color", "Header back color", "Header color", "Footer back color", "Footer color", "Final score color", "Selection back color", "Selection color" };
            DefaultColors = new Color[] { Color.Turquoise, Color.Black, Color.Gray, Color.Black, Color.Silver, Color.Black, Color.Blue, Color.SteelBlue, Color.White };
            _cdata = cdata;
            this.FormLayoutChangeEvent += new FormLayoutChange(Handle_FormLayoutChangeEvent);
        }

        private void Handle_FormLayoutChangeEvent()
        {
            InitializeLayout();
        }

        public override void InitializeLayout()
        {
            base.InitializeLayout(_windowFont);
            if (base.FormLayout.FontName.Contains("Courier"))
                _windowFont = new Font(base.FormLayout.FontName, base.FormLayout.FontSize, FontStyle.Regular);
            else
                _windowFont = Helper.GetSpecialFont(FontStyle.Regular, base.FormLayout.FontSize);

            if (mainForm == null)
            {
                mainForm = (FrmMain)(this.ParentForm == null ? this.Owner : this.ParentForm);
                if (mainForm != null)
                {
                    cdata = mainForm.ContestDataProvider;
                    frmMain = mainForm;
                    cdata.FocusedRadioChanged += new ContestData.FocusedRadioChange(MainForm_Focusshifted);
                }
            }
        }

        private void MainForm_Focusshifted()
        {
            string[] listenModeName = { "Radio 1", "Radio 2 toggle", "Radio 2", "Both radio" };
            string[] operatingModeName = { "Illegal", "SO1R", "SO2R", "SO2R Advanced", "SO2V" };

            int focusedRadio = frmMain.ContestDataProvider.FocusedRadio;
            int operatingMode = frmMain.ContestDataProvider.OPTechnique;
            int listenMode = frmMain.ListenStatusMode; // requires DXLog 2.3.18

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Focus shift. Focus is now Radio #{0}.", focusedRadio));
            sb.AppendLine(String.Format("Operating mode is {0}.", operatingModeName[operatingMode]));
            sb.AppendLine(String.Format("Audio mode is \"{0}\".", listenModeName[listenMode]));  // requires DXLog 2.3.18

            lbInfo.Text = sb.ToString();
        }
    }
}
