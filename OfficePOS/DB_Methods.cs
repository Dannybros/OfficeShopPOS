using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace OfficePOS
{
    public class DB_Methods
    {
        MySqlConnection conn = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=office_db");

        private MySqlCommand cmd;
        private MySqlDataAdapter adp;

        public void InsertNewSupplier(string id, string name, string addr, string email, string tel, PictureBox pb, Action afterSave)
        {
            cmd = new MySqlCommand("INSERT INTO `suppliers`(`Supplier_ID`, `Supplier_Name`, `Supplier_Address`, `Supplier_Email`, `Supplier_Tel`, `Supplier_Img`) VALUES (@id, @name, @address, @email, @tel, @img)", conn);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", addr);
            cmd.Parameters.AddWithValue("@email", email); ;
            cmd.Parameters.AddWithValue("@tel", tel);

            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);

            cmd.Parameters.Add("@img", MySqlDbType.LongBlob).Value = ms.ToArray();
            conn.Open();
            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("You have successfully added new Employee", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                afterSave();
            }
            else
            {
                MessageBox.Show("error");
            }

            conn.Close();
        }
    }
}
