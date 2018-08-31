/***************************************************************
* Copyright 2011-2016 - Accusoft Corporation, Tampa Florida.   *
* This sample code is provided to Accusoft licensees "as is"   *
* with no restrictions on use or modification. No warranty for *
* use of this sample code is provided by Accusoft.             *
****************************************************************/
using System;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;
using Accusoft.TwainProSdk;

namespace ImagXpressDemo
{
    public partial class TwainScanForm : ScanForm
    {
        private TwainDevice twainDevice;

        public bool ShowUserInterface
        {
            get
            {
                return twainDevice.ShowUserInterface;
            }
            set
            {
                twainDevice.ShowUserInterface = value;
            }
        }

        public DataSourceManagerVersion DataSourceManagerVersion
        {
            get
            {
                return twainDevice.DataSourceManagerVersion;
            }
            set
            {
                twainDevice.DataSourceManagerVersion = value;
            }
        }

        private TwainPro twainProInstance;
        public TwainPro TwainProInstance
        {
            get
            {
                return twainProInstance;
            }
            set
            {
                twainProInstance = value;
                twainProInstance.ParentWindowHandle = this.Handle;
                twainDevice = new TwainDevice(twainProInstance);
            }
        }

        public TwainScanForm()
        {
            InitializeComponent();
        }

        private void TwainScanForm_Load(object sender, System.EventArgs e)
        {


            //**The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime**
            //twainProInstance.Licensing.SetSolutionName("YourSolutionName");
            //twainProInstance.Licensing.SetSolutionKey(12345, 12345, 12345, 12345);
            //twainProInstance.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");


#if LICENSED
            if (license.Unlocked)
            {
                twainProInstance.Licensing.SetSolutionName(license.SolutionName);
                if (System.IntPtr.Size == 8)
                {
                    twainProInstance.Licensing.SetSolutionKey(license.Solution64Key1, license.Solution64Key2, license.Solution64Key3, license.Solution64Key4);
                }
                else
                {
                    twainProInstance.Licensing.SetSolutionKey(license.Solution32Key1, license.Solution32Key2, license.Solution32Key3, license.Solution32Key4);
                }
                twainProInstance.Licensing.SetOEMLicenseKey(license.OEMLicenseKeyTwainPro);
            }
#endif

            twainDevice.Scanned += new ScannedEventHandler(twainDevice_Scanned);

            UserInterfaceCheckBox.Checked = twainDevice.ShowUserInterface;
            DsmComboBox.SelectedIndex = (int)twainDevice.DataSourceManagerVersion;
            DsmInUseTextBox.Text = twainDevice.DataSourceManagerVersionInUse.ToString();
        }

        private void SelectSourceButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                EnableScanUI(false);
                EnableCapabilitiesUI(false);

                twainDevice.SelectSource();

                EnableScanUI(true);
            }
            catch (OperationCancelledException ex)
            {
                StatusBarLabel.Text = ex.Message;
            }
            catch (TwainDllLoadException ex)
            {
                Helper.ShowBalloonToolTipWarning(DsmComboBox.Width - Constants.balloonToolTipHorizontalSpacer,
                    -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay,
                    Constants.tooltipDuration, Constants.dsmErrorString, ex.Message, DsmComboBox);
            }
        }

        private void twainDevice_Scanned(object sender, ScannedEventArgs e)
        {
            IntPtr hdib = e.ScannedImage.ToHdib();

            //must set last parameter to true so Hdib will be cleaned up
            using (ImageX scannedImage = ImageX.FromHdib(imagXpress1, hdib, true))
            {
                imagesScanned.Add(scannedImage.Copy());
            }

            imagesScannedCount = imagesScanned.Count;
            imagesScannedIndex++;

            UpdatePageUI();
        }

        private void DsmComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                twainDevice.DataSourceManagerVersion = (DataSourceManagerVersion)DsmComboBox.SelectedIndex;
            }
            catch (TwainDllLoadException ex)
            {
                Helper.ShowBalloonToolTipWarning(DsmComboBox.Width - Constants.balloonToolTipHorizontalSpacer,
                    -Constants.balloonToolTipVerticalSpacer, Constants.tooltipInitialDelay,
                    Constants.tooltipDuration, Constants.dsmErrorString, ex.Message, DsmComboBox);
            }
            finally
            {
                DsmInUseTextBox.Text = twainDevice.DataSourceManagerVersionInUse.ToString();
            }
        }

        private void AcquireButton_Click(object sender, EventArgs e)
        {
            try
            {
                EnableCapabilitiesUI(false);
                twainDevice.StartSession();

                if (imageXView1.Image != null)
                {
                    AcceptImageButton.Enabled = PageTextBox.Enabled = true;
                }
            }
            catch (TwainException ex)
            {
                MessageBox.Show(String.Format(Constants.twainErrorString, (int)ex.ConditionCode, ex.ConditionDescription), Constants.acquireErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SequenceException ex)
            {
                MessageBox.Show(ex.Message, Constants.acquireErrorString, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserInterfaceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            twainDevice.ShowUserInterface = UserInterfaceCheckBox.Checked;
        }

        private void NegotiateButton_Click(object sender, EventArgs e)
        {
            try
            {
                twainDevice.OpenSession();

                CapabilitiesComboBox.Items.Clear();
                foreach (AdvancedCapability cap in Enum.GetValues(typeof(AdvancedCapability)))
                {
                    if (twainDevice.IsCapabilitySupported(cap))
                    {
                        CapabilitiesComboBox.Items.Add(cap);
                    }
                }

                CapabilitiesComboBox.SelectedIndex = 0;
                EnableCapabilitiesUI(true);
            }
            catch (TwainException ex)
            {
                MessageBox.Show(String.Format(Constants.twainErrorString, (int)ex.ConditionCode, ex.ConditionDescription), "Error negotiating capabilities.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CapabilitiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCapabilitiesUI();

            int selectedCapability = (int)CapabilitiesComboBox.Items[CapabilitiesComboBox.SelectedIndex];

            CapabilityContainer capContainer = twainDevice.GetCapability(selectedCapability);

            ExtractCapabilityFromContainer(capContainer, ValueTextBox, ValueLabel);
        }

        private void EnableCapabilitiesUI(bool isEnabled)
        {
            CapabilitiesComboBox.Enabled = isEnabled;
            CapabilitiesGroupBox.Visible = isEnabled;
        }

        private void EnableScanUI(bool isEnabled)
        {
            NegotiateButton.Enabled = isEnabled;
            AcquireButton.Enabled = isEnabled;
        }

        private void ResetCapabilitiesUI()
        {
            ValueTextBox.Text = CurrentValueTextBox.Text = DefaultValueTextBox.Text
                = MinimumTextBox.Text = MaximumTextBox.Text = StepTextBox.Text
                = String.Empty;
            ValuesListBox.Items.Clear();

            ValueTextBox.Visible = ValueLabel.Visible = CurrentValueTextBox.Visible = CurrentValueLabel.Visible
                = DefaultValueLabel.Visible = DefaultValueTextBox.Visible = MinimumLabel.Visible
                = MinimumTextBox.Visible = MaximumLabel.Visible = MaximumTextBox.Visible
                = StepLabel.Visible = StepTextBox.Visible = ValuesLabel.Visible = ValuesListBox.Visible
                = false;

            UpdateButton.Enabled = true;
        }

        private void ExtractCapabilityFromContainer(CapabilityContainer capContainer, TextBox textBox, Label label)
        {
            if (capContainer is CapabilityContainerOneValueFloat)
            {
                CapabilityContainerOneValueFloat capContainerFloat = capContainer as CapabilityContainerOneValueFloat;

                if (textBox != null)
                {
                    textBox.Text = capContainerFloat.Value.ToString();
                    textBox.Visible = label.Visible = true;
                }
                else
                {
                    ValuesListBox.Items.Add(capContainerFloat.Value);
                    ValuesListBox.Visible = ValuesLabel.Visible = true;
                }
            }
            else if (capContainer is CapabilityContainerOneValueString)
            {
                CapabilityContainerOneValueString capContainerString = capContainer as CapabilityContainerOneValueString;

                if (textBox != null)
                {
                    textBox.Text = capContainerString.Value;
                    textBox.Visible = label.Visible = true;
                }
                else
                {
                    ValuesListBox.Items.Add(capContainerString.Value);
                    ValuesListBox.Visible = ValuesLabel.Visible = true;
                }
            }
            else if (capContainer is CapabilityContainerEnum)
            {
                CapabilityContainerEnum capContainerEnum = capContainer as CapabilityContainerEnum;
                CapabilityContainerOneValue capCurrentValue = capContainerEnum.CurrentValue;
                CapabilityContainerOneValue capDefaultValue = capContainerEnum.DefaultValue;
                CapabilityContainerOneValueCollection capValues = capContainerEnum.Values;

                ExtractCapabilityFromContainer(capCurrentValue, CurrentValueTextBox, CurrentValueLabel);
                ExtractCapabilityFromContainer(capDefaultValue, DefaultValueTextBox, DefaultValueLabel);

                foreach (CapabilityContainerOneValue capValue in capValues)
                {
                    ExtractCapabilityFromContainer(capValue, null, null);
                }
            }
            else if (capContainer is CapabilityContainerArray)
            {
                CapabilityContainerArray capContainerArray = capContainer as CapabilityContainerArray;
                CapabilityContainerOneValueCollection capValues = capContainerArray.Values;

                foreach (CapabilityContainerOneValue capValue in capValues)
                {
                    ExtractCapabilityFromContainer(capValue, null, null);
                }

                UpdateButton.Enabled = false;
            }
            else if (capContainer is CapabilityContainerRange)
            {
                CapabilityContainerRange capContainerRange = capContainer as CapabilityContainerRange;
                DefaultValueTextBox.Text = capContainerRange.Default.ToString();
                ValueTextBox.Text = capContainerRange.Value.ToString();
                MaximumTextBox.Text = capContainerRange.Maximum.ToString();
                MinimumTextBox.Text = capContainerRange.Minimum.ToString();
                StepTextBox.Text = capContainerRange.Step.ToString();

                DefaultValueTextBox.Visible = DefaultValueLabel.Visible = ValueTextBox.Visible = ValueLabel.Visible
                    = MaximumTextBox.Visible = MaximumLabel.Visible = MinimumTextBox.Visible = MinimumLabel.Visible
                    = StepTextBox.Visible = StepLabel.Visible = true;
            }
        }

        private void UpdateCapability(CapabilityContainer capContainer)
        {
            try
            {
                if (capContainer is CapabilityContainerOneValueFloat)
                {
                    CapabilityContainerOneValueFloat capContainerFloat = capContainer as CapabilityContainerOneValueFloat;

                    float newFloatValue;
                    if (float.TryParse(ValueTextBox.Text, out newFloatValue))
                    {
                        capContainerFloat.Value = newFloatValue;
                    }
                }
                else if (capContainer is CapabilityContainerOneValueString)
                {
                    CapabilityContainerOneValueString capContainerString = capContainer as CapabilityContainerOneValueString;

                    capContainerString.Value = ValueTextBox.Text;
                }
                else if (capContainer is CapabilityContainerEnum)
                {
                    CapabilityContainerEnum capContainerEnum = capContainer as CapabilityContainerEnum;
                    CapabilityContainerOneValue capCurrentValue = capContainerEnum.CurrentValue;

                    if (capCurrentValue is CapabilityContainerOneValueFloat)
                    {
                        CapabilityContainerOneValueFloat capCurrentValueFloat = capCurrentValue as CapabilityContainerOneValueFloat;

                        float newFloatValue;
                        if (float.TryParse(CurrentValueTextBox.Text, out newFloatValue))
                        {
                            capCurrentValueFloat.Value = newFloatValue;
                        }
                    }
                    else if (capCurrentValue is CapabilityContainerOneValueString)
                    {
                        CapabilityContainerOneValueString capCurrentValueString = capCurrentValue as CapabilityContainerOneValueString;

                        capCurrentValueString.Value = CurrentValueTextBox.Text;
                    }
                }
                else if (capContainer is CapabilityContainerRange)
                {
                    CapabilityContainerRange capContainerRange = capContainer as CapabilityContainerRange;

                    float newMaximumValue;
                    if (float.TryParse(MaximumTextBox.Text, out newMaximumValue))
                    {
                        capContainerRange.Maximum = newMaximumValue;
                    }
                    float newMinimumValue;
                    if (float.TryParse(MinimumTextBox.Text, out newMinimumValue))
                    {
                        capContainerRange.Minimum = newMinimumValue;
                    }
                    float newValue;
                    if (float.TryParse(ValueTextBox.Text, out newValue))
                    {
                        capContainerRange.Value = newValue;
                    }
                    float newStepValue;
                    if (float.TryParse(StepTextBox.Text, out newStepValue))
                    {
                        capContainerRange.Step = newStepValue;
                    }
                }

                twainDevice.SetCapability(capContainer);
            }
            catch (TwainException ex)
            {
                MessageBox.Show(String.Format(Constants.twainErrorString, (int)ex.ConditionCode, ex.ConditionDescription), "Error setting capabilities.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            int selectedCapability = (int)CapabilitiesComboBox.Items[CapabilitiesComboBox.SelectedIndex];

            CapabilityContainer capContainer = twainDevice.GetCapability(selectedCapability);

            UpdateCapability(capContainer);
        }
    }
}