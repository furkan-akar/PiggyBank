using PiggyBank.Abstract;
using PiggyBank.Concrete;
using PiggyBank.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiggyBank
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        MoneyBox _moneyBox;
        MoneyObjects _moneyObjects;
        Money _selectedMoney;
        List<Money> _moneys;

        private void Form1_Load(object sender, EventArgs e)
        {
            _moneyBox = new MoneyBox(80000);
            _moneyObjects = new MoneyObjects();
        }

        private void Btn5TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get5Lira();               
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;                     
        }

        private void Btn10TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get10Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;
        }

        private void Btn20TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get20Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;
        }

        private void btn50TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get50Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;
        }

        private void btn100TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get100Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;
        }

        private void btn200TL_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get200Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = true;
        }

        private void btn1Krs_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get1Kurus();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void btn5Krs_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get5Kurus();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void btn10Krs_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get10Kurus();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void btn25Krs_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get25Kurus();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void btn50Krs_Click(object sender, EventArgs e)
        {
            _selectedMoney = _moneyObjects.Get50Kurus();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void btn1TL_Click(object sender, EventArgs e)
        {            
            _selectedMoney = _moneyObjects.Get1Lira();
            UIMethods.DisableMoneys(grpMoney, (Button)sender);
            btnFold.Enabled = false;
        }

        private void BtnFold_Click(object sender, EventArgs e)
        {
            ((BankNote)_selectedMoney).Fold();
            _selectedMoney.CreateAdditionalVolume();
            MessageBox.Show($"Para Katlandı.\nHacim: {_selectedMoney.Volume}\nFazladan Hacim: {_selectedMoney.AdditionalVolume}");
        }

        private void BtnPutMoney_Click(object sender, EventArgs e)
        {
            ExceptionHandling.HandleException(() => _moneyBox.Add(_selectedMoney));
            PrintVolumes();
            UIMethods.EnableMoneys(grpMoney);
            btnFold.Enabled = true;
        }

        private void BtnShake_Click(object sender, EventArgs e)
        {
            _moneyBox.Shake();
            PrintVolumes();
        }

        private void BtnBreak_Click(object sender, EventArgs e)
        {
            _moneys = _moneyBox.Break();
            lstMoney.DataSource = _moneys;
            lstMoney.ValueMember = "Value";
            lstMoney.DisplayMember = "Name";
            btnPaste.Enabled = true;
            btnFold.Enabled = false;
            btnPutMoney.Enabled = false;
            btnShake.Enabled = false;
            MessageBox.Show($"Kumbara bakiyesi: {_moneyBox.Balance}");
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            lstMoney.DataSource = null;
            bool result = ExceptionHandling.HandleException(() => _moneyBox.Paste());
            PrintVolumes();
            if (!result)
            {
                btnFold.Enabled = true;
                btnPutMoney.Enabled = true;
                btnShake.Enabled = true;
            }            
        }

        private void PrintVolumes()
        {
            lblTotalVolume.Text = _moneyBox.MoneysVolume.ToString();
            lblAdditionalVolume.Text = _moneyBox.AdditionalVolume.ToString();
        }        
    }
}
