using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project_Group_C
{
    public partial class Form1 : Form
    {
        Cone cone;
        Customer customer;
        Order order;

        FileStream fsRead, fsWrite;
        StreamReader sReader;
        StreamWriter sWriter;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sReader.Close();
            sWriter.Close();
            fsRead.Close();
            fsWrite.Close();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fsRead = new FileStream("Customer.txt", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                sReader = new StreamReader(fsRead);
                fsWrite = new FileStream("Customer.txt", FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                sWriter = new StreamWriter(fsWrite);

                updatecomboBoxCustomer();
            }
            catch (IOException ioe)
            {
                MessageBox.Show("IOException occurred: " + ioe.Message, "File Error");
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != string.Empty || textBoxLastName.Text != string.Empty)
            {
                Customer c = new Customer();
                textBoxCustomerID.Text = textBoxFirstName.Text + textBoxLastName.Text + comboBoxCustomer.Items.Count;
                c.FirstName = textBoxFirstName.Text;
                c.LastName = textBoxLastName.Text;
                c.CustomerID = textBoxCustomerID.Text;
                sWriter.WriteLine(c.ToString());
                sWriter.Flush();
                textBoxFirstName.Text = string.Empty;
                textBoxLastName.Text = string.Empty;
                textBoxCustomerID.Text = string.Empty;
                updatecomboBoxCustomer();
                updatelistBoxManageCustomers();
            }
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            updatelistBoxManageCustomers();
        }
        private void buttonRemoveCustomer_Click(object sender, EventArgs e)
        {
            listBoxManageCustomers.Items.Remove(listBoxManageCustomers.SelectedItem);
            sReader.Close();
            sWriter.Close();
            fsRead.Close();
            fsWrite.Close();
            try
            {
                fsWrite = new FileStream("Customer.txt", FileMode.Create, FileAccess.Write);
                sWriter = new StreamWriter(fsWrite);
                for (int i = 0; i < listBoxManageCustomers.Items.Count; i++)
                {
                    string[] temp = listBoxManageCustomers.Items[i].ToString().Split(' ');
                    string s = string.Empty;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        s += temp[j] + ',';
                    }
                    sWriter.WriteLine(s.Trim());
                }
                sWriter.Close();
                fsWrite.Close();
                Form1_Load(sender, e);
            }
            catch (IOException ioe)
            {
                MessageBox.Show("IOException occurred: " + ioe.Message, "File Error");
            }
        }
        private void updatecomboBoxCustomer()
        {
            comboBoxCustomer.Items.Clear();
            while (sReader.Peek() >= 0)
            {
                string[] temp = sReader.ReadLine().Split(',');
                string s = string.Empty;
                for (int i = 0; i < temp.Length; i++)
                {
                    s += temp[i] + " ";
                }
                comboBoxCustomer.Items.Add(s.Trim());
            }
            sReader.BaseStream.Position = 0;
            sReader.DiscardBufferedData();
        }
        private void updatelistBoxManageCustomers()
        {
            listBoxManageCustomers.Items.Clear();
            while (sReader.Peek() >= 0)
            {
                string[] temp = sReader.ReadLine().Split(',');
                string s = string.Empty;
                for (int i = 0; i < temp.Length; i++)
                {
                    s += temp[i] + " ";
                }
                listBoxManageCustomers.Items.Add(s.Trim());
            }
            sReader.BaseStream.Position = 0;
            sReader.DiscardBufferedData();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sReader.Close();
            sWriter.Close();
            fsRead.Close();
            fsWrite.Close();
        }

        private void buttonAddToOrder_Click(object sender, EventArgs e)
        {
            if (listBoxOrderNum.Items.Count < 10)
            {
                if (checkBoxMakeItSuper.Checked)
                {
                    cone = new Supercone();
                }
                else
                {
                    cone = new Cone();
                }
                setChoice(cone);
                setFlavor(cone);
                setConeType(cone);
                cone.numScoop = int.Parse(textBoxNumScoop.Text);

                order.addCone(cone);

                listBoxOrderNum.Items.Add("cone " + (listBoxOrderNum.Items.Count + 1).ToString());
            }

        }
        private void setChoice(Cone c)
        {
            if (radioButtonIceCream.Checked)
            {
                cone.coneChoice = choice.iceCream;
            }
            else
            {
                cone.coneChoice = choice.yogurt;
            }
        }
        private void setFlavor(Cone c)
        {
            if (radioButtonVanilla.Checked)
            {
                cone.coneFlavor = flavor.FrenchVanilla;
            }
            else if (radioButtonChocolate.Checked)
            {
                cone.coneFlavor = flavor.CoffeeLover;
            }
            else
            {
                cone.coneFlavor = flavor.plain;
            }
        }
        private void setConeType(Cone c)
        {
            if (radioButtonSmall.Checked)
            {
                cone.typeOfCone = coneType.Likeit;
            }
            else if (radioButtonRegular.Checked)
            {
                cone.typeOfCone = coneType.Loveit;
            }
            else
            {
                cone.typeOfCone = coneType.GottaHaveit;
            }
        }
        private void comboBoxCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            order = new Order();
            customer = new Customer();
            string[] s;
            s = comboBoxCustomer.SelectedItem.ToString().Split(' ');
            customer.FirstName = s[0];
            customer.LastName = s[1];
            customer.CustomerID = s[2];
            order.CustomerInfo = customer;
            clearTheOrderForm();
        }

        private void listBoxOrderNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cone c = order.getCone(listBoxOrderNum.SelectedIndex);

            textBoxOrderSummary.Text = string.Empty;
            textBoxOrderSummary.Text = order.CustomerInfo.ToString() + ":" + Environment.NewLine;
            textBoxOrderSummary.Text += "Total " + order.numCones().ToString() + " cones ordered at "
                                        + order.getTotalPriceForOrders().ToString("C") + Environment.NewLine + Environment.NewLine;
            textBoxOrderSummary.Text += c.coneChoice.ToString() + ',' + c.coneFlavor + ',' + c.typeOfCone + ','
                                        + c.numScoop + ' ' + c.getConePrice().ToString("C") + Environment.NewLine;
        }
        private void clearTheOrderForm()
        {
            listBoxOrderNum.Items.Clear();
            textBoxOrderSummary.Text = string.Empty;
            textBoxNumScoop.Text = "3";
            checkBoxMakeItSuper.Checked = false;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                ((RadioButton)groupBox1.Controls[i]).Checked = false;
            }
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                ((RadioButton)groupBox2.Controls[i]).Checked = false;
            }
            for (int i = 0; i < groupBox3.Controls.Count; i++)
            {
                ((RadioButton)groupBox3.Controls[i]).Checked = false;
            }

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            checkBoxMakeItSuper.Checked = false;
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                ((RadioButton)groupBox1.Controls[i]).Checked = false;
            }
            for (int i = 0; i < groupBox2.Controls.Count; i++)
            {
                ((RadioButton)groupBox2.Controls[i]).Checked = false;
            }
            for (int i = 0; i < groupBox3.Controls.Count; i++)
            {
                ((RadioButton)groupBox3.Controls[i]).Checked = false;
            }
        }
    }
}
