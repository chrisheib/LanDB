using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LanDB {
    public partial class Form1 : Form {
        static string CRLF = Environment.NewLine;

        public Form1() {
            InitializeComponent();
        }
        
        //Aktualisieren

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e) {
            aktualisieren();
        }

        /// <summary>
        /// Aktualisiert den Inhalt der Komponenten
        /// </summary>
        /// <param name="tab">
        ///     <list type="bullet">
        ///         <listheader>
        ///             <term>string tab: Index des zu aktualisierenden Tabs</term>
        ///         </listheader>
        ///         <item>
        ///             <term>0 : Lans</term>
        ///         </item>
        ///         <item>
        ///             <term>1: Personen</term>
        ///         </item>
        ///         <item>
        ///             <term>2: Spiele</term>
        ///         </item>
        ///         <item>
        ///             <term>3: Keys</term>
        ///         </item>
        ///         <item>
        ///             <term>4: Dienste</term>
        ///         </item>
        ///         <item>
        ///             <term>5: Teilnahmen</term>
        ///         </item>
        ///     </list>
        /// </param>
        private void aktualisieren() {

            switch (tabControl1.SelectedIndex) {
                case 0: //Lans
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT l_datum as LAN, count(t_id) as Teilnehmer from lans l left join teilnahmen t on l.l_id = t.t_lan group by l_id order by l_datum DESC").Tables[0].DefaultView;

                    CLanDB.Cb_val(cb_lans_id, "l_id", "l_datum", "lans", "");

                    break;
                case 1: //Personen
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT p_name as Name, p_adresse as Adresse, p_telefon as Telefon, p_email as EMail from personen order by p_name").Tables[0].DefaultView;
                    
                    CLanDB.Cb_val(cb_personen_id, "p_id", "p_name", "personen", "");
                    
                    break;
                case 2: //Spiele
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT s_name as Spiel, d_name as Dienst, s_kosten as Kosten from spiele left join dienste on d_id = s_dienst").Tables[0].DefaultView;
                    
                    CLanDB.Cb_val(cb_spiele_id, "s_id", "s_name", "spiele", "");
                    
                    CLanDB.Cb_val(cb_spiele_dienst, "d_id", "d_name", "dienste", "");

                    break;
                case 3: //Keys
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT k_key as Gamekey, p_name as Person, s_name as Spiel from gamekeys "
                        + "left join personen on k_person = p_id left join spiele on k_spiel = s_id order by s_name, p_name").Tables[0].DefaultView;
                    
                    CLanDB.Cb_val(cb_keys_person, "p_id", "p_name", "personen", "");
                    
                    CLanDB.Cb_val(cb_keys_spiel, "s_id", "s_name", "spiele", "");
                    
                    CLanDB.Cb_val(cb_keys_del_person, "p_id", "p_name", "gamekeys left join personen on k_person = p_id", "");

                    aktualisiere_keys_del_spiel();

                    aktualisiere_keys_del_key();
                    break;
                case 4: //Dienste
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT d_name as Dienst from dienste").Tables[0].DefaultView;

                    CLanDB.Cb_val(cb_dienste_id, "d_id", "d_name", "dienste", "");
                    break;
                case 5: //Teilnahmen
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT p_name as Person, l_datum as LAN from teilnahmen " +
                        "left join lans on t_lan = l_id left join personen on t_person = p_id order by LAN DESC, Person ASC").Tables[0].DefaultView;
                    
                    CLanDB.Cb_val(cb_teiln_add_lan, "l_id", "l_datum", "lans order by l_datum desc", "");

                    CLanDB.Cb_val(cb_teiln_add_person, "p_id", "p_name", "personen", "");

                    CLanDB.Cb_val(cb_teiln_delete_datum, "l_id", "l_datum", "teilnahmen join lans on t_lan = l_id group by l_id order by l_datum DESC", "");

                    aktualisiere_teiln_del_person();

                    break;
                case 6: //Ofen
                    gridViewLans.DataSource = CLanDB.SQLOpen("SELECT p_name as Person, l_datum as Lan " +
                        "from ofen left join lans on l_id = o_lan " +
                        " left join personen on p_id = o_person order by Lan DESC").Tables[0].DefaultView;

                    cb_ofen_person.DataSource = CLanDB.SQLOpen("SELECT p_id, p_name from personen").Tables[0];
                    cb_ofen_person.ValueMember = "p_id";
                    cb_ofen_person.DisplayMember = "p_name";

                    cb_ofen_lan.DataSource = CLanDB.SQLOpen("SELECT l_id, l_datum from lans order by l_datum desc").Tables[0];
                    cb_ofen_lan.ValueMember = "l_id";
                    cb_ofen_lan.DisplayMember = "l_datum";
                    break;

                default:
                    break;
            }
        }

        //Lans

        private void cmd_lan_add_Click(object sender, EventArgs e) {
            CLanDB.AddLan(datetime_lan_add.Value.Date.ToString(CultureInfo.InvariantCulture.DateTimeFormat.SortableDateTimePattern), this);
            aktualisieren();
        }

        private void cmd_lan_entfernen_Click(object sender, EventArgs e) {
            CLanDB.DeleteLan(cb_lans_id.SelectedValue, this);
            aktualisieren();
        }

        //Personen

        private void cmd_personen_add_Click(object sender, EventArgs e) {
            CLanDB.AddPerson(txt_personen_name.Text, txt_personen_adresse.Text, txt_personen_telefon.Text, txt_personen_email.Text, this);
            aktualisieren();
        }

        private void cmd_personen_delete_Click(object sender, EventArgs e) {

        }

        //Spiele        

        private void cmdAddSpiel_Click(object sender, EventArgs e) {
            Regex r = new Regex("([0-9]{0,10})([,.]?)([0-9]{0,2})");
            if (r.Match(txt_spiele_add_kosten.Text).Length == txt_spiele_add_kosten.Text.Length) {
                CLanDB.AddSpiel(txt_spiele_name.Text, cb_spiele_dienst.SelectedValue, txt_spiele_add_kosten.Text, this);
                txt_spiele_name.Text = "";
                txt_spiele_add_kosten.Text = "";
                txt_spiele_name.Focus();
            } else {
                MessageBox.Show("Korrekte Kosten eingeben!");
            }
            aktualisieren();
        }

        private void cmdDeleteSpiel_Click(object sender, EventArgs e) {
            CLanDB.DeleteSpiel(cb_spiele_id.SelectedValue, this);
            aktualisieren();
        }

        //Keys

        private void cmd_keys_add_Click(object sender, EventArgs e) {
            CLanDB.AddKey(cb_keys_person.SelectedValue, cb_keys_spiel.SelectedValue, txt_keys_key.Text, this);
            aktualisieren();
        }

        private void cmd_keys_del_Click(object sender, EventArgs e) {
            CLanDB.DeleteKey(cb_keys_del_key.SelectedValue, this);
            aktualisieren();
        }

        private void cb_keys_del_person_SelectedValueChanged(object sender, EventArgs e) {

            aktualisiere_keys_del_spiel();
        }

        private void cb_keys_del_spiel_SelectedValueChanged(object sender, EventArgs e) {
            
            aktualisiere_keys_del_key();
        }

        private void aktualisiere_keys_del_spiel() {
            try {
                DataSet temp = CLanDB.SQLOpen("select s_id, s_name from gamekeys " +
                    "left join spiele on k_spiel = s_id where k_person = " + cb_keys_del_person.SelectedValue);
                if (temp.Tables[0].Rows.Count > 0) {
                    cb_keys_del_spiel.DataSource = temp.Tables[0];
                    cb_keys_del_spiel.ValueMember = "s_id";
                    cb_keys_del_spiel.DisplayMember = "s_name";
                }
            } catch (Exception) {
            }
        }

        private void aktualisiere_keys_del_key()
        {
            try
            {
                DataSet temp = CLanDB.SQLOpen("select k_id, k_key from gamekeys where k_person = " + cb_keys_del_person.SelectedValue
                + " and k_spiel = " + cb_keys_del_spiel.SelectedValue);

                if (temp.Tables[0].Rows.Count > 0)
                {
                    cb_keys_del_key.DataSource = temp.Tables[0];
                    cb_keys_del_key.ValueMember = "k_id";
                    cb_keys_del_key.DisplayMember = "k_key";
                }
            }
            catch (Exception)
            {
            }
        }

        //Dienste

        private void cmdAddDienst_Click(object sender, EventArgs e) {
            CLanDB.AddDienst(txtDienstName.Text, this);
            aktualisieren();
        }

        private void cmdDeleteDienst_Click(object sender, EventArgs e) {
            CLanDB.DeleteDienst(cb_dienste_id.SelectedValue, this);
            aktualisieren();
        }

        private void txtDienstName_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                cmdAddDienst_Click(sender, e);
            }
        }

        private void cb_dienste_id_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                cmdDeleteDienst_Click(sender, e);
            }
        }

        //Teilnahmen
        
        private void cmd_teiln_add_Click(object sender, EventArgs e) {
            CLanDB.AddTeilnahme(cb_teiln_add_lan.SelectedValue, cb_teiln_add_person.SelectedValue, this);
            aktualisieren();
        }

        private void cmd_teiln_delete_click(object sender, EventArgs e)
        {
            CLanDB.DeleteTeilnahme(cb_teilnahme_delete_person.SelectedValue, this);
            aktualisieren();
        }

        private void cb_teiln_delete_datum_SelectedValueChanged(object sender, EventArgs e)
        {
            aktualisiere_teiln_del_person();
        }

        private void aktualisiere_teiln_del_person()
        {
            try
            {
                DataSet temp = CLanDB.SQLOpen("select t_id, p_name from teilnahmen join personen on t_person = p_id where t_lan = " + cb_teiln_delete_datum.SelectedValue);

                if (temp.Tables[0].Rows.Count > 0)
                {
                    cb_teilnahme_delete_person.DataSource = temp.Tables[0];
                    cb_teilnahme_delete_person.ValueMember = "t_id";
                    cb_teilnahme_delete_person.DisplayMember = "p_name";
                }
            }
            catch (Exception)
            {
            }
        }

        //Ofen

        private void cmdAddOfen_click(object sender, EventArgs e) {
            CLanDB.AddOfen(cb_ofen_lan.SelectedValue, cb_ofen_person.SelectedValue, this);
            aktualisieren();
        }
        

        //Status
       
        public void postError(Exception error) {
            lb_status.Items.Clear();
            foreach (string cStr in (error.Source + CRLF + error.Message + CRLF + error.StackTrace).Split(new string[] { Environment.NewLine }, StringSplitOptions.None)){
                lb_status.Items.Add(cStr);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "lanDataSet.lans". Sie können sie bei Bedarf verschieben oder entfernen.
            lansTableAdapter.Fill(lanDataSet.lans);
            aktualisieren();
        }

        private void txt_personen_telefon_TextChanged(object sender, EventArgs e) {

        }

        private void gridViewLans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}