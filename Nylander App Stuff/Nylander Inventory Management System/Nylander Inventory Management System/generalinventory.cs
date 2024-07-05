using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nylander_Inventory_Management_System
{
    public partial class generalinventory : Form
    {
        string table_query = "SELECT * FROM nylander_inv ORDER BY [spec_id] DESC";
        string case_query = "SELECT * FROM cases ORDER BY [case_id]";
        public generalinventory()
        {
            InitializeComponent();
            populatetable1fromaccess();
            populatecasesfromaccess();
            fillcaseidbox();
            fillowneridbox();

        }

        private void populatecasesfromaccess()
        {

            casedata.Rows.Clear();

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

                OleDbCommand cmd = new OleDbCommand(case_query, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    casedata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

            try
            {
                conn.Open();
                String cases = caseidbox.Text.ToString();
                String specid = specidbox.Text.ToString();
                String dataid = databaseidbox.Text.ToString();
                String spectype = spectypebox.Text.ToString();
                String assetid = assetidbox.Text.ToString();
                String collector = collectorbox.Text.ToString();
                String ownerid = owneridbox.Text.ToString();
                String category = categorybox.Text.ToString();
                String locate = locationbox.Text.ToString();
                String quantity = quantitybox.Text.ToString();
                String length = lengthcmbox.Text.ToString();
                String height = heightcmbox.Text.ToString();
                String width = widthcmbox.Text.ToString();
                String weight = weightbox.Text.ToString();
                String shortd = shortdescbox.Text.ToString();
                String detail = detaildescbox.Text.ToString();
                String comment = commentbox.Text.ToString();

                String my_query = "INSERT INTO nylander_inv([case_id], [spec_id], [database_id], [spec_type], [asset_id], [short_desc], [category], [location], [detail_desc], [comment], [collector_name], [owner_id], [quantity], [length_cm], [width_cm], [height_cm], [weight])VALUES('" + cases + "','" + specid + "','" + dataid + "','" + spectype + "','" + assetid + "','" + shortd + "','" + category + "','" + locate + "','" + detail + "','" + comment + "','" + collector + "','" + ownerid + "','" + quantity + "','" + length + "','" + width + "','" + height + "','" + weight + "')";

                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Data saved successfuly...!");
                populatetable1fromaccess();
                populatecasesfromaccess();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);


            }
            finally
            {
                conn.Close();

            }
        }

        private void populatetable1fromaccess()
        {

            inventorydata.Rows.Clear();

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

                OleDbCommand cmd = new OleDbCommand(table_query, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    inventorydata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home home = new home();
            home.Closed += (s, args) => this.Close();
            home.Show();
        }
        private void searchbutton_Click(object sender, EventArgs e)
        {
            { }
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            populatetable1fromaccess();
            populatecasesfromaccess();
        }

        private void searchbutton_Click_1(object sender, EventArgs e)
        {
            generalsearchdata.Rows.Clear();

            try
            {
                String search = generalsearchbox.Text.ToString();

                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
                String search_query = "SELECT * FROM nylander_inv WHERE case_id & spec_id & database_id & spec_type & asset_id & short_desc & category & location & detail_desc & comment & collector_name LIKE '%" + search + "%' ORDER BY spec_id DESC";


                OleDbCommand cmd = new OleDbCommand(search_query, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    generalsearchdata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), reader[11].ToString(), reader[12].ToString(), reader[13].ToString(), reader[14].ToString(), reader[15].ToString(), reader[16].ToString(), reader[17].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {

            }
        }
        private void fillcaseidbox()
        {

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
                {
                    string strSql = "SELECT case_id FROM cases";
                    OleDbCommand cmd = new OleDbCommand(strSql, con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, con));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    caseidbox.DataSource = ds.Tables[0];
                    caseidbox.DisplayMember = "case_id";
                    caseidbox.ValueMember = "case_id";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }
        }
        private void fillowneridbox()
        {

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
                {
                    string strSql = "SELECT DISTINCT[owner_id] FROM nylander_inv";
                    OleDbCommand cmd = new OleDbCommand(strSql, con);
                    con.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(new OleDbCommand(strSql, con));
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    owneridbox.DataSource = ds.Tables[0];
                    owneridbox.DisplayMember = "owner_id";
                    owneridbox.ValueMember = "owner_id";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);
            }
        }

        private void update1_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

            try
            {
                conn.Open();
                String assetid = assetchange.Text.ToString();
                String specid = newspecid.Text.ToString();

                String my_query = "UPDATE nylander_inv SET spec_id='" + specid + "' WHERE asset_id='" + assetid + "'";

                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Data saved successfuly...!");
                populatetable1fromaccess();
                populatecasesfromaccess();
                populateupdate1fromaccess();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);


            }
            finally
            {
                conn.Close();

            }
        }

        private void populateupdate1fromaccess()
        {

            specimenupdatedata.Rows.Clear();

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
 con.Open();
              
                string assetid = assetchange.Text.ToString();
                string update_query1 = "SELECT asset_id, specimen_id, short_desc FROM nylander_inv WHERE asset_id='" + assetid + "'";

                OleDbCommand cmd = new OleDbCommand(update_query1, con);
               
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    specimenupdatedata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {
                
            }
        }

        private void update2_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

            try
            {
                conn.Open();
                String assetid = assetchange1.Text.ToString();
                String comm = newcomment.Text.ToString();

                String my_query = "UPDATE nylander_inv SET comment='" + comm + "' WHERE asset_id='" + assetid + "'";

                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Data saved successfuly...!");
                populatetable1fromaccess();
                populatecasesfromaccess();
                populateupdate2fromaccess();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);


            }
            finally
            {
                conn.Close();

            }
        }

        private void populateupdate2fromaccess()
        {

            commentupdatedata.Rows.Clear();

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
                String assetid = assetchange1.Text.ToString();
                string update_query1 = "SELECT asset_id, specimen_id, comment FROM nylander_inv WHERE asset_id='" + assetid + "'";

                OleDbCommand cmd = new OleDbCommand(update_query1, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    commentupdatedata.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {

            }
        }

        private void update3_Click(object sender, EventArgs e)
        {

            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";

            try
            {
                conn.Open();
                String assetid2 = assetchange2.Text.ToString();
                String shortd = newshortdesc.Text.ToString();

                String my_query = "UPDATE nylander_inv SET short_desc='" + shortd + "' WHERE asset_id='" + assetid2 + "'";

                OleDbCommand cmd = new OleDbCommand(my_query, conn);
                cmd.ExecuteNonQuery();


                MessageBox.Show("Data saved successfuly...!");
                populatetable1fromaccess();
                populatecasesfromaccess();
                populateupdate3fromaccess3();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to: " + ex.Message);


            }
            finally
            {
                conn.Close();

            }
        }

        private void populateupdate3fromaccess3()
        {

            shortdescupdate.Rows.Clear();

            try
            {
                System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
                con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\pjbal\Desktop\Nylander Inventory\NylanderINV2_Workspace1.accdb";
                String assetid2 = assetchange2.Text.ToString();
                string update_query1 = "SELECT asset_id, specimen_id, short_desc FROM nylander_inv WHERE asset_id='" + assetid2 + "'";

                OleDbCommand cmd = new OleDbCommand(update_query1, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    shortdescupdate.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed due to: " + ex.Message);

            }

            finally
            {

            }
        }
    }


}
