using System.Windows.Forms;
using System;


namespace LM555_Monostable
{
	public partial class frmCalcMonoMain : Form
	{
		/************************* constructor *************************/
		public frmCalcMonoMain()
		{
			InitializeComponent();
			toolTip1.InitialDelay = 150;
			toolTip1.AutoPopDelay = 2000;
			toolTip1.ReshowDelay = 5000;
			toolTip1.IsBalloon = false;
		}

		/************************* global vars *************************/
		enum CalcType { Period, Resistance, Capacitance };
		double fResistance = 0.0, fCapacitance = 0.0, fPeriod = 0.0;

		/************************* private methods *************************/
		bool ValidateInputs(CalcType Which)
		{
			bool retVal = false;
			bool bRvalid = false, bCvalid = false, bPvalid = false;

			bRvalid = double.TryParse(txtR1.Text, out fResistance);
			bPvalid = double.TryParse(txtPeriod.Text, out fPeriod);
			bCvalid = double.TryParse(txtC1.Text, out fCapacitance);

			try
			{
				switch (Which)
				{
					case CalcType.Capacitance:
						if (!bRvalid)
						{ throw new Exception("Resistance Value Not A Valid Number"); }
						if (!bPvalid)
						{ throw new Exception("Period Value Not A Valid Number"); }
						retVal = true;
						break;
					case CalcType.Resistance:
						if (!bCvalid)
						{ throw new Exception("Capacitance Value Not A Valid Number"); }
						if (!bPvalid)
						{ throw new Exception("Period Value Not A Valid Number"); }
						retVal = true;
						break;
					case CalcType.Period:
						if (!bRvalid)
						{ throw new Exception("Resistance Value Not A Valid Number"); }
						if (!bCvalid)
						{ throw new Exception("Capacitance Value Not A Valid Number"); }
						retVal = true;
						break;
				}
				if (bRvalid)
				{
					switch (cmbOhmsR1.SelectedItem)
					{
						case "kilo ohms":
							fResistance *= 1e3;
							break;
						case "mega ohms":
							fResistance *= 1e6;
							break;
					}
				}
				if (bPvalid)
				{
					if (lblMilliseconds.Text == "Milliseconds")
					{
						fPeriod /= 1000;
					}
				}
				if (bCvalid)
				{
					switch (cmbFarads.SelectedItem)
					{
						case "micro farads":
							fCapacitance *= 1e-6;
							break;
						case "nano farads":
							fCapacitance *= 1e-9;
							break;
						case "pico farads":
							fCapacitance *= 1e-12;
							break;
					}
				}
			}
			catch (Exception e)
			{
				MessageBox.Show(this, e.Message, "Input Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return retVal;
		}


		/************************* event handlers *************************/
		private void btnCalcPeriod_Click(object sender, System.EventArgs e)
		{
			if (!ValidateInputs(CalcType.Period))
			{ return; }
			fPeriod = 1.1 * fResistance * fCapacitance;
			if (fPeriod > 1.0)
			{
				txtPeriod.Text = fPeriod.ToString("0.##");
				lblMilliseconds.Text = "Seconds";
			}
			else if (fPeriod > 1e-3)
			{
				txtPeriod.Text = (fPeriod * 1000).ToString("0.##");
				lblMilliseconds.Text = "Milliseconds";
			}
			else
			{
				txtPeriod.Text = "###";
				MessageBox.Show(this, "Period is less than 1 millisecond. Not in Range.", "Too Small Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnCalcR_Click(object sender, System.EventArgs e)
		{
			if (!ValidateInputs(CalcType.Resistance))
			{ return; }
			fResistance = fPeriod / fCapacitance;
			if (fResistance < 1000.0)
			{
				cmbOhmsR1.SelectedIndex = cmbOhmsR1.Items.IndexOf("ohms");
				cmbOhmsR1.Text = "ohms";
				txtR1.Text = fResistance.ToString("0.##");
			}
			else if (fResistance < 1000000)
			{
				cmbOhmsR1.SelectedIndex = cmbOhmsR1.Items.IndexOf("kilo ohms");
				cmbOhmsR1.Text = "kilo ohms";
				txtR1.Text = (fResistance / 1000).ToString("0.##");
			}
			else
			{
				cmbOhmsR1.SelectedIndex = cmbOhmsR1.Items.IndexOf("mega ohms");
				cmbOhmsR1.Text = "mega ohms";
				txtR1.Text = (fResistance / 1e6).ToString("0.##");
			}
		}

		private void btnCalcC_Click(object sender, System.EventArgs e)
		{
			if (!ValidateInputs(CalcType.Capacitance))
			{ return; }
			fCapacitance = fPeriod / fResistance;
			// todo: finish this
			if (fCapacitance >= 1e-6)
			{
				txtC1.Text = (fCapacitance * 1e6).ToString("0.##");
				cmbFarads.SelectedIndex = cmbFarads.Items.IndexOf("micro farads");
				cmbFarads.Text = cmbFarads.SelectedItem.ToString();
			}
			else if (fCapacitance >= 1e-9)
			{
				txtC1.Text = (fCapacitance * 1e9).ToString("0.##");
				cmbFarads.SelectedIndex = cmbFarads.Items.IndexOf("nano farads");
				cmbFarads.Text = cmbFarads.SelectedItem.ToString();
			}
			else if (fCapacitance >= 1e-12)
			{
				txtC1.Text = (fCapacitance * 1e12).ToString("0.##");
				cmbFarads.SelectedIndex = cmbFarads.Items.IndexOf("pico farads");
				cmbFarads.Text = cmbFarads.SelectedItem.ToString();
			}
			else
			{
				MessageBox.Show(this, "Capacitor value is less than one pico farad. Choose a different resistor value and try again.",
					 "Unusable Value Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void lblMilliseconds_Click(object sender, EventArgs e)
		{

		}

		private void lblMilliseconds_DoubleClick(object sender, EventArgs e)
		{
			if (lblMilliseconds.Text == "Milliseconds")
			{ lblMilliseconds.Text = "Seconds"; }
			else if (lblMilliseconds.Text == "Seconds")
			{ lblMilliseconds.Text = "Milliseconds"; }
		}

		private void btnExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}  // end class
}  // end namespace
