using System;
using System.Drawing;
using System.Windows.Forms;

namespace LM555_Freq_Calculator
{
	public partial class frmCalcMain : Form
	{


		/************************* class constructor *************************/
		public frmCalcMain()
		{
			InitializeComponent();
			toolTip1.InitialDelay = 150;
			toolTip1.AutoPopDelay = 2000;
			toolTip1.IsBalloon = false;
			toolTip1.ReshowDelay = 5000;
		}

		/************************** class methods ***************************/

		private void PostValueErrorMsg(string sWho)
		{
			MessageBox.Show(this, "The value for " + sWho + " does not parse. Correct it and try again.", "Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/************************** event handlers *************************/

		private void btnCalcFreq_Click(object sender, EventArgs e)
		{
			bool bEscapeClause = false;
			// try parsing the inputs and fail out if bad
			double fR1 = 0.0, fR2 = 0.0, fC1 = 0.0;
			if (!double.TryParse(txtR1.Text, out fR1))
			{
				PostValueErrorMsg("Resistor R1");
				bEscapeClause = true;
			}
			if (cmbOhmsR1.Text == "kilo ohms")
			{
				fR1 *= 1000.0;
			}
			else if (cmbOhmsR1.Text == "mega ohms")
			{
				fR1 *= 1000000.0;
			}
			if (!double.TryParse(txtR2.Text, out fR2))
			{
				PostValueErrorMsg("Resistor R2");
				bEscapeClause = true;
			}
			if (cmbOhmsR2.Text == "kilo ohms")
			{
				fR2 *= 1000.0;
			}
			else if (cmbOhmsR2.Text == "mega ohms")
			{
				fR2 *= 1000000.0;
			}
			if (!double.TryParse(txtC1.Text, out fC1))
			{
				PostValueErrorMsg("Capacitor C1");
				bEscapeClause = true;
			}
			if (cmbFarads.Text == "micro farads")
			{
				fC1 /= Math.Pow(10, 6);
			}
			else if (cmbFarads.Text == "nano farads")
			{
				fC1 /= Math.Pow(10, 9);
			}
			else if (cmbFarads.Text == "pico farads")
			{
				fC1 /= Math.Pow(10, 12);
			}
			if (bEscapeClause) return; // needs fix ups on inputs
			double fFreq = 0.0, fPeriod = 0.0;
			fFreq = 1.44 / ((fR1 + 2 * fR2) * fC1);
			fPeriod = 1 / fFreq;
			if (fFreq < 1000)
			{
				lblHertz.Text = "Hz";
				txtFrequency.BackColor = Color.White;
			}
			else if (fFreq >= 1000 && fFreq < 1000000)
			{
				fFreq /= 1000;
				lblHertz.Text = "KHz";
				if (fFreq > 500)
				{
					txtFrequency.BackColor = Color.Yellow;
				}
				else
				{
					txtFrequency.BackColor = Color.White;
				}
			}
			else if (fFreq >= 1000000)
			{
				fFreq /= 1000000;
				if (fFreq > 2)
				{
					txtFrequency.BackColor = Color.Red;
				}
				else
				{
					txtFrequency.BackColor = Color.LightPink;
				}
				lblHertz.Text = "MHz";
			}
			txtFrequency.Text = fFreq.ToString("##0.0");
			PeriodFromFreq(fFreq);
			txtDutyCycle.Text = (100 * ((fR1 + fR2) / ((fR2 * 2) + fR1))).ToString("0.0");
		}

		private void btnCalcR_Click(object sender, EventArgs e)
		{
			// check for usable values
			bool bEscapeClause = false;
			// try parsing the inputs and fail out if bad
			double fR1 = 0.0, fR2 = 0.0, fC1 = 0.0, fRtotal = 0.0;
			double fFreq = 0.0, fPeriod = 0.0, fDutyCycle = 0.0;
			txtR1.Text = "";
			txtR2.Text = "";
			if (!double.TryParse(txtC1.Text, out fC1))
			{
				PostValueErrorMsg("Capacitor C1");
				bEscapeClause = true;
			}
			if (cmbFarads.Text == "micro farads")
			{
				fC1 /= Math.Pow(10, 6);
			}
			else if (cmbFarads.Text == "nano farads")
			{
				fC1 /= Math.Pow(10, 9);
			}
			if (cmbFarads.Text == "pico farads")
			{
				fC1 /= Math.Pow(10, 12);
			}
			if (!double.TryParse(txtFrequency.Text, out fFreq) && !double.TryParse(txtPeriod.Text, out fPeriod))
			{
				PostValueErrorMsg("Frequency and Period");
				bEscapeClause = true;
			}
			if (bEscapeClause) return; // needs fix ups on inputs
												//--------------------
			double.TryParse(txtDutyCycle.Text, out fDutyCycle); // a zero is okay, means we don't care
			fDutyCycle /= 100;
			//-------------------
			if (fFreq == 0)
			{
				//---- fix up fPeriod first
				if (lblMilliseconds.Text == "Milliseconds")
				{
					fPeriod /= 1000;
				}
				else if (lblMilliseconds.Text == "Microseconds")
				{
					fPeriod /= 1000000;
				}
				fFreq = 1 / fPeriod;
			}
			else
			{
				if (lblHertz.Text == "KHz")
				{
					fFreq *= 1000;
				}
				else if (lblHertz.Text == "MHz")
				{
					fFreq *= 1000000;
				}
			}
			//---- calculate the total resistance needed for the frequency
			//    (fR1 + 2 * fR2) = 1.44 / (fFreq * fC1);
			fRtotal = 1.44 / (fC1 * fFreq);
			//---- if duty cycle is stated, adjust for it, or 
			AdjustDutyCycleR(out fR1, out fR2, fDutyCycle, fRtotal);
			//---- display R1
			if (fR1 >= 1000000)
			{
				cmbOhmsR1.Text = "mega ohms";
				fR1 /= 1000000;
			}
			else if (fR1 >= 1000 && fR1 < 1000000)
			{
				cmbOhmsR1.Text = "kilo ohms";
				fR1 /= 1000;
			}
			else
			{
				cmbOhmsR1.Text = "ohms";
			}
			txtR1.Text = fR1.ToString("##0.0");

			//---- display R2
			if (fR2 >= 1000000)
			{
				cmbOhmsR2.Text = "mega ohms";
				fR2 /= 1000000;
			}
			else if (fR2 >= 1000 && fR2 < 1000000)
			{
				cmbOhmsR2.Text = "kilo ohms";
				fR2 /= 1000;
			}
			else
			{
				cmbOhmsR2.Text = "ohms";
			}
			txtR2.Text = fR2.ToString("##0.0");

			if (fDutyCycle == 0) // a don't care, so display what we've got
			{
				fDutyCycle = 100 * (fR1 + fR2) / (fR1 + (2 * fR2));
			}
			else // convert it back to percent
			{
				fDutyCycle *= 100;
			}
			txtDutyCycle.Text = fDutyCycle.ToString("#0.0");
			if (fPeriod == 0) // fix it up
			{
				PeriodFromFreq(fFreq);
			}
		}

		private void AdjustDutyCycleR(out double R1, out double R2, double DutyCycle, double Rtotal)
		{
			//    Rtotal = fR1 + 2 * fR2;
			//    duty cycle = ((R1 + R2) / ((R2 * 2) + R1))

			double fR1 = 0.0, fR2 = 0.0;

			fR2 = Rtotal * (1 - DutyCycle);
			fR1 = Rtotal - (fR2 * 2);
			R1 = fR1;
			R2 = fR2;
			return;
		}

		private void btnCalcC_Click(object sender, EventArgs e)
		{
			bool bEscapeClause = false;
			double fR1 = 0.0, fR2 = 0.0;
			double fCap = 0.0;
			double fFreq = 0.0, fPeriod = 0.0;
			//------ check inputs
			if (double.TryParse(txtR1.Text, out fR1))
			{
				//---- adjust the scale
				if (cmbOhmsR1.Text == "kilo ohms")
				{ fR1 *= 1000.0; }
				else if (cmbOhmsR1.Text == "mega ohms")
				{ fR1 *= 1000000.0; }
			}
			else
			{
				bEscapeClause = true;
				PostValueErrorMsg("Resistor R1");
			}
			if (double.TryParse(txtR2.Text, out fR2))
			{
				//---- adjust the scale
				if (cmbOhmsR2.Text == "kilo ohms")
				{ fR2 *= 1000.0; }
				else if (cmbOhmsR2.Text == "mega ohms")
				{ fR2 *= 1000000.0; }
			}
			else
			{
				bEscapeClause = true;
				PostValueErrorMsg("Resistor R2");
			}
			if (!double.TryParse(txtFrequency.Text, out fFreq) && !double.TryParse(txtPeriod.Text, out fPeriod))
			{
				PostValueErrorMsg("Frequency and Period");
				bEscapeClause = true;
			}
			if (bEscapeClause) return; // needs fix ups on inputs
			if (fFreq > 0) // fix up the scale
			{
				if (lblHertz.Text == "KHz")
				{
					fFreq *= 1000;
				}
				else if (lblHertz.Text == "MHz")
				{
					fFreq *= 1000000;
				}
			}
			else // it's period ---> freq
			{
				fFreq = 1 / fPeriod;
				if (lblMilliseconds.Text == "milliseconds")
				{
					fFreq *= 1000;
				}
				if (lblMilliseconds.Text == "microseconds")
				{
					fFreq *= 1000000;
				}
			}
			//---- now we can finally do the simple calculation
			//fFreq = 1.44 / ((fR1 + 2 * fR2) * fC1);
			fCap = 1.44 / ((fR1 + 2 * fR2) * fFreq);
			//---- now format it for the output
			string sOut = "", sLabel = "";
			if (fCap >= 1 * Math.Pow(10.0, -6))
			{
				sLabel = "micro farads";
				sOut = (fCap * Math.Pow(10, 6)).ToString("###0.0");
			}
			else if (fCap >= 1 * Math.Pow(10, -9))
			{
				sLabel = "nano farads";
				sOut = (fCap * Math.Pow(10, 9)).ToString("###0.0");
			}
			else
			{
				sLabel = "pico farads";
				sOut = (fCap * Math.Pow(10, 12)).ToString("###0.0");
			}

			cmbFarads.Text = sLabel;
			txtC1.Text = sOut;
			//---- make sure the duty cycle is correct
			txtDutyCycle.Text = (100 * ((fR1 + fR2) / ((fR2 * 2) + fR1))).ToString("0.0");
			;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lblMilliseconds_DoubleClick(object sender, EventArgs e)
		{
			if (lblMilliseconds.Text == "Milliseconds")
			{ lblMilliseconds.Text = "Seconds"; }
			else if (lblMilliseconds.Text == "Seconds")
			{ lblMilliseconds.Text = "Microseconds"; }
			else
			{ lblMilliseconds.Text = "Milliseconds"; }
		}

		private void lblHertz_DoubleClick(object sender, EventArgs e)
		{
			if (lblHertz.Text == "KHz")
			{ lblHertz.Text = "MHz"; }
			else if (lblHertz.Text == "MHz")
			{ lblHertz.Text = "Hz"; }
			else // it's Hz
			{ lblHertz.Text = "KHz"; }
		}

		private void PeriodFromFreq(double Freq)
		{
			double fPeriod = 1 / Freq;
			if (fPeriod >= 1)
			{
				lblMilliseconds.Text = "Seconds";
			}
			else if (fPeriod < 1 && fPeriod >= 0.001)
			{
				lblMilliseconds.Text = "Milliseconds";
				fPeriod *= 1000;
			}
			else if (fPeriod < 0.001)
			{
				lblMilliseconds.Text = "Microseconds";
				fPeriod *= 1000000;
			}
			txtPeriod.Text = fPeriod.ToString("0.0");
		}

	}
}
