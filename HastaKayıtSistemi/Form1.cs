using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaKayıtSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Adı", 150);
            listView1.Columns.Add("Soyadı", 150);
            listView1.Columns.Add("Email", 150);
            listView1.Columns.Add("Adres", 150);
            listView1.Columns.Add("Meslek", 150);


            listView2.View = View.Details;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("Adı", 150);
            listView2.Columns.Add("Tipi", 150);
            listView2.Columns.Add("Adresi", 150);
            listView2.Columns.Add("Yatak Sayısı", 150);
            listView2.Columns.Add("Doktor Sayısı", 150);

            listView3.View = View.Details;
            listView3.FullRowSelect = true;
            listView3.Columns.Add("Adı", 120);
            listView3.Columns.Add("Soyadı", 120);
            listView3.Columns.Add("Çalışıyor mu", 100);
            listView3.Columns.Add("Hastane Adı", 100);
            listView3.Columns.Add("Tel No", 140);
            listView3.Columns.Add("Çalıştığı Bölümler", 300);

            listView4.View = View.Details;
            listView4.FullRowSelect = true;
            listView4.Columns.Add("Hastane Adı", 120);
            listView4.Columns.Add("Hasta Adı", 120);
            listView4.Columns.Add("Doktor Adı", 100);
            listView4.Columns.Add("Randevu Saati", 300);
            


        }

        private void btn_HastaneTanımlama_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage1) == true)
            {
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage1);
            }
        }
        private void btn_HastaTanımlama_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage2) == true)
            {
                tabControl1.SelectedTab = tabPage2;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage2);
            }
        }
        private void btn_DoktorTanımlama_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage3) == true)
            {
                tabControl1.SelectedTab = tabPage3;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage3);
            }
        }
        private void btn_RandevuOluşturma_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage4) == true)
            {
                tabControl1.SelectedTab = tabPage4;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage4);
            }
        }
        private void btn_TeşhisKayıt_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage5) == true)
            {
                tabControl1.SelectedTab = tabPage5;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage5);
            }
        }
        private void btn_TestTahlil_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Contains(tabPage6) == true)
            {
                tabControl1.SelectedTab = tabPage6;
            }
            else
            {
                tabControl1.Visible = true;
                tabControl1.TabPages.Add(tabPage6);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TabPage current_tab = tabControl1.SelectedTab;
                tabControl1.TabPages.Remove(current_tab);
            }
            catch
            {
                MessageBox.Show("Seçili Bir Sayfa Olmadığından Silme İşlemi Gerçekleşmedi.", "Sayfa Kaldırma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"] )
            {
                
                string[] row = { textBox1.Text, textBox2.Text, textBox3.Text ,textBox3.Text, comboBox1.Text };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);

                comboBox5.Items.Add(textBox1.Text);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";

                
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                string[] row = { textBox5.Text, textBox6.Text, comboBox2.Text, textBox8.Text, textBox7.Text };
                var listViewItem = new ListViewItem(row);
                listView2.Items.Add(listViewItem);

                comboBox4.Items.Add(textBox5.Text);
                comboBox3.Items.Add(textBox5.Text);

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox2.Text = "";


            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {
                string aaa = "";
                for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++) { 
                    aaa += (checkedListBox1.CheckedItems[i].ToString()) + ",";
                }

                String aaaa = "Hayır";
                if (checkBox1.Checked)
                {
                    aaaa = "Evet";
                }

                string[] row = { textBox9.Text, textBox10.Text,aaaa, comboBox3.Text, textBox11.Text, aaa.ToString() };
                var listViewItem = new ListViewItem(row);
                listView3.Items.Add(listViewItem);

                comboBox6.Items.Add(textBox9.Text);

                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                comboBox3.Text = "";
                foreach (int i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {
                string[] row = { comboBox4.Text, comboBox5.Text,  comboBox6.Text, dateTimePicker1.Text };
                var listViewItem = new ListViewItem(row);
                listView4.Items.Add(listViewItem);



                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";
               
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
            {
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
                listView1.SelectedItems[0].SubItems[3].Text = textBox4.Text;
                listView1.SelectedItems[0].SubItems[4].Text = comboBox1.Text;

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                comboBox1.Text = "";
            }else if(tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"]) {

                listView2.SelectedItems[0].SubItems[0].Text = textBox5.Text;
                listView2.SelectedItems[0].SubItems[1].Text = textBox6.Text;
                listView2.SelectedItems[0].SubItems[2].Text = comboBox2.Text;
                listView2.SelectedItems[0].SubItems[3].Text = textBox7.Text;
                listView2.SelectedItems[0].SubItems[4].Text = textBox8.Text;
                

                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                comboBox2.Text = "";
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
            {

                listView3.SelectedItems[0].SubItems[0].Text = textBox9.Text;
                listView3.SelectedItems[0].SubItems[1].Text = textBox10.Text;
                listView3.SelectedItems[0].SubItems[2].Text = checkBox1.Text;
                listView3.SelectedItems[0].SubItems[3].Text = comboBox3.Text;
                listView3.SelectedItems[0].SubItems[4].Text = textBox11.Text;
                listView3.SelectedItems[0].SubItems[5].Text = checkedListBox1.Text;

                textBox9.Text = "";
                textBox10.Text = "";
                textBox11.Text = "";
                comboBox3.Text = "";
                checkBox1.Text = "";
                checkedListBox1.Text = "";
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
            {

                listView4.SelectedItems[0].SubItems[2].Text = comboBox4.Text;
                listView4.SelectedItems[0].SubItems[2].Text = comboBox5.Text;
                listView4.SelectedItems[0].SubItems[2].Text = comboBox6.Text;

                comboBox4.Text = "";
                comboBox5.Text = "";
                comboBox6.Text = "";

            }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])
                {
                    listView1.SelectedItems[0].Remove();
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
                {

                    listView2.SelectedItems[0].Remove();
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage3"])
                {

                    listView3.SelectedItems[0].Remove();
                }
                else if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage4"])
                {

                    listView4.SelectedItems[0].Remove();
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);
            }
        }
        
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox4.Text = listView1.SelectedItems[0].SubItems[3].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[4].Text;
            
        }

        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView2.SelectedItems.Count == 0)
                return;
            textBox5.Text = listView2.SelectedItems[0].SubItems[0].Text;
            textBox6.Text = listView2.SelectedItems[0].SubItems[1].Text;
            comboBox2.Text = listView2.SelectedItems[0].SubItems[2].Text;
            textBox7.Text = listView2.SelectedItems[0].SubItems[3].Text;
            textBox8.Text = listView2.SelectedItems[0].SubItems[4].Text;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
                return;
            textBox9.Text = listView3.SelectedItems[0].SubItems[0].Text;
            textBox10.Text = listView3.SelectedItems[0].SubItems[1].Text;
            checkBox1.Text = listView3.SelectedItems[0].SubItems[2].Text;
            textBox11.Text = listView3.SelectedItems[0].SubItems[4].Text;
            comboBox3.Text = listView3.SelectedItems[0].SubItems[3].Text;
            checkedListBox1.Text = listView3.SelectedItems[0].SubItems[5].Text;
        }


        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView4.SelectedItems.Count == 0)
                return;
            
            comboBox4.Text = listView4.SelectedItems[0].SubItems[0].Text;
            comboBox5.Text = listView4.SelectedItems[0].SubItems[1].Text;
            comboBox6.Text = listView4.SelectedItems[0].SubItems[2].Text;
            dateTimePicker1.Text = listView4.SelectedItems[0].SubItems[3].Text;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}