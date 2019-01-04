using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadacha_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<IVehicle> vehicle = new List<IVehicle>();

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                IVehicle veh = new Tram(NameTextBox.Text, Convert.ToInt32(YearTextBox.Text), Convert.ToInt32(CostTextBox.Text), Convert.ToInt32(CapTextBox.Text));
                vehicle.Add(veh);
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void RepairButton_Click(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.Text += vehicle[Convert.ToInt32(numericUpDown1.Value) - 1].Repair() + Environment.NewLine;
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void FuelButton_Click(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.Text += vehicle[Convert.ToInt32(numericUpDown1.Value) - 1].Fuel() + Environment.NewLine;
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            try
            {
                PublicTransport ptran = (PublicTransport)vehicle[Convert.ToInt32(numericUpDown1.Value) - 1];
                InfoTextBox.Text += ptran.ShowInfo() + Environment.NewLine;
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void CapacityButton_Click(object sender, EventArgs e)
        {
            try
            {
                PublicTransport ptran = (PublicTransport)vehicle[Convert.ToInt32(numericUpDown1.Value) - 1];
                InfoTextBox.Text += ptran.ShowCapacity() + Environment.NewLine;
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tram tram = (Tram)vehicle[Convert.ToInt32(CommentnumericUpDown2.Value) - 1];
                tram.AddComment(CommentTextBox.Text);
                vehicle[Convert.ToInt32(CommentnumericUpDown2.Value) - 1] = tram;
            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }

        private void ShowCommentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Tram tram = (Tram)vehicle[Convert.ToInt32(CommentnumericUpDown2.Value) - 1];
                InfoTextBox.Text += tram.ShowComment() + Environment.NewLine;

            }
            catch { MessageBox.Show("Проверьте корректность данных."); }
        }
    }
}
