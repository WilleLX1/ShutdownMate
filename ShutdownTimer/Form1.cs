using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBoxFast.Checked = true;
            checkBoxPrecise.Checked = false;
            checkBoxPrecise_CheckedChanged(null, null);
            checkBoxFast_CheckedChanged(null, null);
            checkBoxShutdown.Checked = true;
        }

        public void log(string text)
        {
            txtDebugLog.Text += text + Environment.NewLine;
        }

        public void Hold()
        {
            btnSet.Enabled = false;
            btnReset.Enabled = false;
            btnClear.Enabled = false;
        }

        public void Release()
        {
            btnSet.Enabled = true;
            btnReset.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                Hold();

                string powerOption = checkBoxShutdown.Checked ? "-s" : checkBoxRestart.Checked ? "-r" : string.Empty;
                if (string.IsNullOrEmpty(powerOption))
                {
                    log("Error: No power option selected.");
                    Release();
                    return;
                }

                if (checkBoxFast.Checked)
                {
                    if (!int.TryParse(txtFastDays.Text, out int days) ||
                        !int.TryParse(txtFastHours.Text, out int hours) ||
                        !int.TryParse(txtFastMinutes.Text, out int minutes) ||
                        !int.TryParse(txtFastSeconds.Text, out int seconds))
                    {
                        log("Error: Invalid input for fast mode.");
                        Release();
                        return;
                    }

                    int totalSeconds = days * 24 * 60 * 60 + hours * 60 * 60 + minutes * 60 + seconds;
                    if (totalSeconds <= 0)
                    {
                        log("Error: Total time must be greater than zero.");
                        Release();
                        return;
                    }

                    ExecuteShutdownCommand(powerOption, totalSeconds);
                }
                else if (checkBoxPrecise.Checked)
                {
                    if (!TimeSpan.TryParse(txtPreciseTime.Text, out TimeSpan preciseTime))
                    {
                        log("Error: Invalid precise time format.");
                        Release();
                        return;
                    }

                    DateTime preciseDateTime = dtpPreciseDate.Value.Date + preciseTime;
                    DateTime now = DateTime.Now;

                    if (preciseDateTime <= now)
                    {
                        log("Error: The precise date and time is in the past.");
                        Release();
                        return;
                    }

                    int totalSeconds = (int)(preciseDateTime - now).TotalSeconds;
                    ExecuteShutdownCommand(powerOption, totalSeconds);
                }
            }
            catch (Exception ex)
            {
                log("Error: " + ex.Message);
            }
            finally
            {
                Release();
            }
        }

        private void ExecuteShutdownCommand(string powerOption, int totalSeconds)
        {
            string command = $"shutdown {powerOption} -t {totalSeconds}";
            txtDebugFinalCommand.Text = command;

            try
            {
                ProcessStartInfo psi = new ProcessStartInfo("shutdown", $"{powerOption} -t {totalSeconds}")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                };
                Process.Start(psi)?.WaitForExit();
                log($"Shutdown timer set to {totalSeconds} seconds.");
            }
            catch (Exception ex)
            {
                log($"Error executing shutdown command: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                Hold();

                dtpPreciseDate.Value = DateTime.Now;
                txtPreciseTime.Text = DateTime.Now.ToString("HH:mm:ss");
                txtFastDays.Text = "0";
                txtFastHours.Text = "0";
                txtFastMinutes.Text = "0";
                txtFastSeconds.Text = "60";
                checkBoxShutdown.Checked = true;
                checkBoxRestart.Checked = false;

                txtDebugFinalCommand.Text = "shutdown -s -t 60";
                log("Reset to default values.");
            }
            catch (Exception ex)
            {
                log("Error: " + ex.Message);
            }
            finally
            {
                Release();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                Hold();

                txtDebugFinalCommand.Text = "shutdown -a";

                ProcessStartInfo psi = new ProcessStartInfo("shutdown", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                };
                Process.Start(psi)?.WaitForExit();
                log("Shutdown timer cleared.");
            }
            catch (Exception ex)
            {
                log("Error clearing shutdown timer: " + ex.Message);
            }
            finally
            {
                Release();
            }
        }

        private void checkBoxPrecise_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrecise.Checked)
            {
                EnablePrecise();
                DisableFast();
                checkBoxFast.Checked = false;
            }
            else
            {
                DisablePrecise();
                EnableFast();
                checkBoxFast.Checked = true;
            }
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFast.Checked)
            {
                EnableFast();
                DisablePrecise();
                checkBoxPrecise.Checked = false;
            }
            else
            {
                DisableFast();
                EnablePrecise();
                checkBoxPrecise.Checked = true;
            }
        }

        private void checkBoxShutdown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShutdown.Checked && checkBoxRestart.Checked)
            {
                checkBoxRestart.Checked = false;
            }
        }

        private void checkBoxRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRestart.Checked && checkBoxShutdown.Checked)
            {
                checkBoxShutdown.Checked = false;
            }
        }

        public void DisablePrecise()
        {
            dtpPreciseDate.Enabled = false;
            txtPreciseTime.Enabled = false;
        }

        public void EnablePrecise()
        {
            dtpPreciseDate.Enabled = true;
            txtPreciseTime.Enabled = true;
        }

        public void DisableFast()
        {
            txtFastDays.Enabled = false;
            txtFastHours.Enabled = false;
            txtFastMinutes.Enabled = false;
            txtFastSeconds.Enabled = false;
        }

        public void EnableFast()
        {
            txtFastDays.Enabled = true;
            txtFastHours.Enabled = true;
            txtFastMinutes.Enabled = true;
            txtFastSeconds.Enabled = true;
        }
    }
}
