using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace projBitABit
{
    public partial class Form1 : Form
    {
        private Bits bits;

        public Form1()
        {
            InitializeComponent();
            bits = this.bits = new Bits();
            AtualizarInterface();
        }

        private void clickou_em_SET(object sender, EventArgs e)
        {
            int a = int.Parse(txtNumero.Text);

            if (a <= 255 && a >= 0) bits.setBits((byte)a);
            AtualizarInterface();
        }


        private void clickou_no_chk(object sender, EventArgs e)
        {
            CheckBox remetente;
            int bit;

            remetente = (CheckBox)sender;
            bit = int.Parse(remetente.Tag.ToString());

            if (remetente.Checked) bits.setBit1(bit);
            else bits.setBit0(bit);

            AtualizarInterface();
        }
        public void AtualizarInterface()
        {
            lblBase10.Text = Convert.ToString(bits.getBits());
            lblBase2.Text = Convert.ToString(bits.getBits(), 2);
            lblBase16.Text = Convert.ToString(bits.getBits(), 16).ToUpper();
            chkBit1.Checked = (bits.getBits(1)) ? true : false;
            chkBit2.Checked = (bits.getBits(2)) ? true : false;
            chkBit3.Checked = (bits.getBits(3)) ? true : false;
            chkBit4.Checked = (bits.getBits(4)) ? true : false;
            chkBit5.Checked = (bits.getBits(5)) ? true : false;
            chkBit6.Checked = (bits.getBits(6)) ? true : false;
            chkBit7.Checked = (bits.getBits(7)) ? true : false;
            chkBit8.Checked = (bits.getBits(8)) ? true : false;
            picSwitch1.Image = (bits.getBits(1)) ? picSwitch1.Image = projBitABit.Properties.Resources.Button_ON : picSwitch1.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch2.Image = (bits.getBits(2)) ? picSwitch2.Image = projBitABit.Properties.Resources.Button_ON : picSwitch2.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch3.Image = (bits.getBits(3)) ? picSwitch3.Image = projBitABit.Properties.Resources.Button_ON : picSwitch3.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch4.Image = (bits.getBits(4)) ? picSwitch4.Image = projBitABit.Properties.Resources.Button_ON : picSwitch4.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch5.Image = (bits.getBits(5)) ? picSwitch5.Image = projBitABit.Properties.Resources.Button_ON : picSwitch5.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch6.Image = (bits.getBits(6)) ? picSwitch6.Image = projBitABit.Properties.Resources.Button_ON : picSwitch6.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch7.Image = (bits.getBits(7)) ? picSwitch7.Image = projBitABit.Properties.Resources.Button_ON : picSwitch7.Image = projBitABit.Properties.Resources.Button_OFF;
            picSwitch8.Image = (bits.getBits(8)) ? picSwitch8.Image = projBitABit.Properties.Resources.Button_ON : picSwitch8.Image = projBitABit.Properties.Resources.Button_OFF;
        }

        private void clickou_em_ligar(object sender, EventArgs e)
        {
            tmrTimer.Interval = int.Parse(txtTimer.Text);
            if (tmrTimer.Enabled) tmrTimer.Enabled = false;
            else tmrTimer.Enabled = true;

            if (btnDesligadoLigado.Text == "Desligado")
            {
                btnDesligadoLigado.Text = "Ligado";
            }
            else btnDesligadoLigado.Text = "Desligado";
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            int bit;
            for(bit =1; bit <=8; ++bit)
            {
                if (bits.getBits(bit))
                {
                    bits.setBit0(bit);
                }
                else bits.setBit1(bit);
            }
            AtualizarInterface();
        }
    }
}
