using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C968.Model;

namespace C968.Screens
{
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void InHouseBtn_CheckedChanged(object sender, EventArgs e)
        {
            AddPartDynamicLabel.Text = "Machine ID";
            AddPartDynamicTxt.Text = "";
        }

        private void OutsourcedBtn_CheckedChanged(object sender, EventArgs e)
        {
            AddPartDynamicLabel.Text = "Company Name";
            AddPartDynamicTxt.Text = "";
        }

        private void AddPartCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            int PartInStock = int.Parse(AddPartInStockTxt.Text);
            int PartMax = int.Parse(AddPartMaxTxt.Text);
            int PartMin = int.Parse(AddPartMinTxt.Text);
            int PartID = Inventory.AllParts.Count + 1;
            string PartName = AddPartNameTxt.Text;
            decimal PartPrice = decimal.Parse(AddPartPriceTxt.Text);

            if (InHouseBtn.Checked)
            {
                int PartMachineID = int.Parse(AddPartDynamicTxt.Text);

                Inhouse inhousePart = new Inhouse(PartID, PartName, PartInStock, PartPrice, PartMax, PartMin, PartMachineID);
                int index = PartID;
                Inventory.addPart(index, inhousePart);
            }
            else
            {
                string PartCompanyName = AddPartDynamicTxt.Text;
                Outsourced outsourcedPart = new Outsourced(PartID, PartName, PartInStock, PartPrice, PartMax, PartMin, PartCompanyName);
                int index = PartID;
                Inventory.addPart(index, outsourcedPart);
            }
            this.Close();
        }
    }
}
