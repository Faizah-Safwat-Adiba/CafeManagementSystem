using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginapp
{
    public partial class MainForm2 : Form
    {
        Double mcSubTotal;
        Double mcTotal;
        Double mcServic;

        const double Espresso_Price = 120.0;
        const double Mocha_Price = 140.0;
        const double Cappa_Price = 130.0;
        const double Latte_Price = 130.0;
        const double Tea_Price = 60.0;
        const double Sand_Price = 110.0;
        const double Pizza_Price = 80.0;
        const double Dough_Price = 50.0;
        const double Muffin_Price = 50.0;
        const double Cookie_Price = 50.0;
        const double Srev_Price = 45.0;
        const double Tax_Price = 1.0;
        public MainForm2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBoxEspresso.Clear();
            textBoxMocha.Clear();
            textBoxCapp.Clear();
            textBoxLatte.Clear();
            textBoxLtea.Clear();
            textBoxSand.Clear();
            textBoxPizza.Clear();
            textBoxDough.Clear();
            textBoxMuffin.Clear();
            textBoxCookies.Clear();
            labelServiceC.Text = "";
            labelSTotal.Text = "";
            labelTax.Text = "";
            labelToTal.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Double EsCost;
            Double MocCost;
            Double CappCost;
            Double LatteCost;
            Double TeaCost;
            Double SandCost;
            Double PizzaCost;
            Double DoughCost;
            Double BlueCost;
            Double CookieCost;
            Double ServCost;
            Double TaxCost;
            Double ItemEspresso;
            Double ItemMocha;
            Double ItemCappa;
            Double ItemLatte;
            Double ItemTea;
            Double ItemSand;
            Double ItemPizza;
            Double ItemDough;
            Double ItemBlue;
            Double ItemCookie;
            Double MC1;
            Double MC2;
            Double MC3;
            Double MC4;
            Double MC5;
            Double MC6;
            Double MC7;
            Double MC8;
            Double MC9;
            Double MC10;
            

            int NumberofOrder;

            EsCost = Espresso_Price;
            MocCost = Mocha_Price;
            CappCost = Cappa_Price;
            LatteCost = Latte_Price;
            TeaCost = Tax_Price;
            SandCost = Sand_Price;
            PizzaCost = Pizza_Price;
            DoughCost = Dough_Price;
            BlueCost = Mocha_Price;
            CookieCost = Cookie_Price;
            ServCost = Srev_Price;



            if (chkESPRESSO.Checked)
            {
                EsCost = Espresso_Price;
            }

            if (chkMOCHA.Checked)
            {
                MocCost = Mocha_Price;
            }

            if (chkCAPP.Checked)
            {
                CappCost = Cappa_Price;
            }

            if (chkLATTE.Checked)
            {
                LatteCost = Latte_Price;
            }

            if (chkTEA.Checked)
            {
                TeaCost = Tax_Price;
            }

            if (chkCsand.Checked)
            {
                SandCost = Sand_Price;
            }

            if (chkSpizza.Checked)
            {
                PizzaCost = Pizza_Price;
            }

            if (chkDOUGH.Checked)
            {
                DoughCost = Dough_Price;
            }

            if (chkMUFFIN.Checked)
            {
                BlueCost = Mocha_Price;
            }

            if (chkCOOKIE.Checked)
            {
                CookieCost = Cookie_Price;
            }

            //calculation

            if (int.TryParse(textBoxEspresso.Text, out NumberofOrder))
            {
                ItemEspresso = Double.Parse(textBoxEspresso.Text);
                MC1 = EsCost * ItemEspresso;

                if (int.TryParse(textBoxMocha.Text, out NumberofOrder))
                {
                    ItemMocha = Double.Parse(textBoxMocha.Text);
                    MC2 = MocCost * ItemMocha;


                    if (int.TryParse(textBoxCapp.Text, out NumberofOrder))
                    {
                        ItemCappa = Double.Parse(textBoxCapp.Text);
                        MC3 = CappCost * ItemCappa;


                        if (int.TryParse(textBoxLatte.Text, out NumberofOrder))
                        {
                            ItemLatte = Double.Parse(textBoxLatte.Text);
                            MC4 = LatteCost * ItemLatte;


                            if (int.TryParse(textBoxLtea.Text, out NumberofOrder))
                            {
                                ItemTea = Double.Parse(textBoxLtea.Text);
                                MC5 = TeaCost * ItemTea;


                                if (int.TryParse(textBoxSand.Text, out NumberofOrder))
                                {
                                    ItemSand = Double.Parse(textBoxSand.Text);
                                    MC6 = SandCost * ItemSand;


                                    if (int.TryParse(textBoxPizza.Text, out NumberofOrder))
                                    {
                                        ItemPizza = Double.Parse(textBoxPizza.Text);
                                        MC7 = PizzaCost * ItemPizza;


                                        if (int.TryParse(textBoxDough.Text, out NumberofOrder))
                                        {
                                            ItemDough = Double.Parse(textBoxDough.Text);
                                            MC8 = DoughCost * ItemDough;


                                            if (int.TryParse(textBoxMuffin.Text, out NumberofOrder))
                                            {
                                                ItemBlue = Double.Parse(textBoxMuffin.Text);
                                                MC9 = BlueCost * ItemBlue;


                                                if (int.TryParse(textBoxCookies.Text, out NumberofOrder))
                                                {
                                                    ItemCookie = Double.Parse(textBoxCookies.Text);
                                                    MC10 = CookieCost * ItemCookie;
                                                    mcSubTotal = MC1 + MC2 + MC3 + MC4 + MC5 + MC6 + MC7 + MC8 + MC9 + MC10;
                                                    labelSTotal.Text = String.Format("{0:C}", mcSubTotal);
                                                    mcServic = MC1 + MC2 + MC3 + MC4 + MC5 + MC6 + MC7 + MC8 + MC9 + MC10 + ServCost;
                                                    labelServiceC.Text = String.Format("{0:C}", mcServic);
                                                    TaxCost = (mcSubTotal * Tax_Price) / 100;
                                                    labelTax.Text = String.Format("{0:C}", TaxCost);
                                                    mcTotal = mcServic + TaxCost;
                                                    labelToTal.Text = String.Format("{0:C}", mcTotal);
                                                    


                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //checks Error
            if (int.TryParse(textBoxEspresso.Text , out NumberofOrder) && (chkESPRESSO.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxEspresso, "Enter a Number!");
            }


            if (int.TryParse(textBoxMocha.Text, out NumberofOrder) && (chkMOCHA.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxMocha, "Enter a Number!");
            }


            if (int.TryParse(textBoxCapp.Text, out NumberofOrder) && (chkCAPP.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxCapp, "Enter a Number!");
            }


            if (int.TryParse(textBoxLatte.Text, out NumberofOrder) && (chkLATTE.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxLatte, "Enter a Number!");
            }


            if (int.TryParse(textBoxLtea.Text, out NumberofOrder) && (chkTEA.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxLtea, "Enter a Number!");
            }

            if (int.TryParse(textBoxSand.Text, out NumberofOrder) && (chkCsand.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxSand, "Enter a Number!");
            }


            if (int.TryParse(textBoxPizza.Text, out NumberofOrder) && (chkSpizza.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxPizza, "Enter a Number!");
            }


            if (int.TryParse(textBoxDough.Text, out NumberofOrder) && (chkDOUGH.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxDough, "Enter a Number!");
            }


            if (int.TryParse(textBoxMuffin.Text, out NumberofOrder) && (chkMUFFIN.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxMuffin, "Enter a Number!");
            }


            if (int.TryParse(textBoxCookies.Text, out NumberofOrder) && (chkCOOKIE.Checked = true))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBoxCookies, "Enter a Number!");
            }
        }

        private void LabelCost_Click(object sender, EventArgs e)
        {

        }

        private void MainForm2_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxEspresso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
