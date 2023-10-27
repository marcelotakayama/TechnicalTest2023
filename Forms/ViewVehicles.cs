namespace TesteTecnico2023.Forms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class ViewVehicles : Form
    {
        public ViewVehicles()
        {
            InitializeComponent();
        }

        private void ViewVehicles_Load(object sender, EventArgs e)
        {
            listData.View = View.Details;

            listData.Columns.Add("Tipo");
            listData.Columns.Add("Marca");
            listData.Columns.Add("Modelo");
            listData.Columns.Add("Rodas");
            listData.Columns.Add("Autonomia");
            listData.Columns.Add("Peso Suportado (KG)");
            listData.Columns.Add("Combustivel");

            listData.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var item in Data.VEHICLES)
            {
                listData.Items.Add(new ListViewItem(new string[] {item.Type(), item.Brand, item.ModelName, item.Wheels.ToString(), item.Autonomy.ToString(), item.WeightSupported.ToString(), item.Fuel }));
            }

            listData.Columns[0].Width = -1;
            listData.Columns[1].Width = -1;
            listData.Columns[2].Width = -1;
        }
    }
}
