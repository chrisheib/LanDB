using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

/// <summary>
/// TODO: Wenn eine Löschcombobox nicht gefüllt werden kann, soll keine Exception geworfen werden, sondern einfach die cb disabled werden.
/// </summary>

namespace LanDB {
    class CLanDB {
        public static MySqlConnection oDB = new MySqlConnection("Server=localhost;Database=lan;Uid=root");

        public static DataSet SQLOpen(string cSQL) {
            MySqlCommand qCmd = oDB.CreateCommand();
            qCmd.CommandText = cSQL;
            MySqlDataAdapter adap = new MySqlDataAdapter(qCmd);
            DataSet set = new DataSet();
            adap.Fill(set);
            return set;
        }

        public static void Cb_val(ComboBox cb, string cValue, string cDisplay, string cFrom, string cWhere) {
            cb.DataSource = SQLOpen("SELECT " + cValue + ", " + cDisplay + " FROM " + cFrom +  ((cWhere != "")?(" WHERE " + cWhere):"") ).Tables[0];
            cb.ValueMember = cValue;
            cb.DisplayMember = cDisplay;
        }

        public static bool ExecuteCommand(MySqlCommand cmd, Form1 sender) {
            bool returnValue = false;
            try {
                cmd.Connection = oDB;
                oDB.Open();
                cmd.ExecuteNonQuery();
                returnValue = true;
            } catch (Exception error) {
                sender.postError(error);
                returnValue = false;
            } finally {
                oDB.Close();
            }
            return returnValue;
        }
        
        // Lans

        public static void AddLan(object l_datum, Form1 sender) {
            string addLan = "INSERT into lans (l_datum) VALUES (@l_datum)";
            MySqlCommand queryAddLan = new MySqlCommand(addLan);
            queryAddLan.Parameters.Add("@l_datum", MySqlDbType.VarChar, 30).Value = l_datum;
            ExecuteCommand(queryAddLan, sender);
        }

        public static void DeleteLan(object l_id, Form1 sender) {
            string deleteLan = "DELETE FROM lans WHERE l_id = (@l_id)";
            MySqlCommand queryDeleteLan = new MySqlCommand(deleteLan);
            queryDeleteLan.Parameters.Add("@l_id", MySqlDbType.VarChar, 30).Value = l_id;
            if (!ExecuteCommand(queryDeleteLan, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }

        // Personen

        public static void AddPerson(object p_name, object p_adresse, object p_telefon, object p_email, Form1 sender) {
            string addPerson = "INSERT into personen (p_name,p_adresse, p_telefon, p_email) VALUES (@p_name, @p_adresse, @p_telefon, @p_email)";
            MySqlCommand queryAddPerson = new MySqlCommand(addPerson);
            queryAddPerson.Parameters.Add("@p_name", MySqlDbType.VarChar, 30).Value = p_name;
            queryAddPerson.Parameters.Add("@p_adresse", MySqlDbType.VarChar, 30).Value = p_adresse;
            queryAddPerson.Parameters.Add("@p_telefon", MySqlDbType.VarChar, 30).Value = p_telefon;
            queryAddPerson.Parameters.Add("@p_email", MySqlDbType.VarChar, 30).Value = p_email;
            ExecuteCommand(queryAddPerson, sender);
        }

        public static void DeletePerson(object p_id, Form1 sender) {
            string deletePerson = "DELETE FROM personen WHERE p_id = (@p_id)";
            MySqlCommand queryDeletePerson = new MySqlCommand(deletePerson);
            queryDeletePerson.Parameters.Add("@s_id", MySqlDbType.VarChar, 30).Value = p_id;
            if (!ExecuteCommand(queryDeletePerson, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }
        // Spiele

        public static void AddSpiel(object s_name, object s_dienst, object s_kosten, Form1 sender) {
            string addSpiel = "INSERT into spiele (s_name,s_dienst, s_kosten) VALUES (@s_name, @s_dienst, @s_kosten)";
            MySqlCommand queryAddSpiel = new MySqlCommand(addSpiel);
            queryAddSpiel.Parameters.Add("@s_name", MySqlDbType.VarChar, 30).Value = s_name;
            queryAddSpiel.Parameters.Add("@s_dienst", MySqlDbType.VarChar, 30).Value = s_dienst;
            queryAddSpiel.Parameters.Add("@s_kosten", MySqlDbType.Decimal).Value = s_kosten;
            ExecuteCommand(queryAddSpiel, sender);
        }

        public static void DeleteSpiel(object s_id, Form1 sender) {
            string deleteSpiel = "DELETE FROM spiele WHERE s_id = (@s_id)";
            MySqlCommand queryDeleteSpiel = new MySqlCommand(deleteSpiel);
            queryDeleteSpiel.Parameters.Add("@s_id", MySqlDbType.VarChar, 30).Value = s_id;
            if (!ExecuteCommand(queryDeleteSpiel, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }

        //Keys

        public static void AddKey(object k_person, object k_spiel, object k_key, Form1 sender) {
            string addKey = "INSERT into gamekeys (k_person,k_spiel, k_key) VALUES (@k_person, @k_spiel, @k_key)";
            MySqlCommand queryAddKey = new MySqlCommand(addKey);
            queryAddKey.Parameters.Add("@k_person", MySqlDbType.VarChar, 30).Value = k_person;
            queryAddKey.Parameters.Add("@k_spiel", MySqlDbType.VarChar, 30).Value = k_spiel;
            queryAddKey.Parameters.Add("@k_key", MySqlDbType.VarChar, 30).Value = k_key;
            ExecuteCommand(queryAddKey, sender);
        }

        public static void DeleteKey(object k_id, Form1 sender) {
            string deleteDienst = "DELETE FROM gamekeys WHERE k_id = (@k_id)";
            MySqlCommand queryDeleteKey = new MySqlCommand(deleteDienst);
            queryDeleteKey.Parameters.Add("@k_id", MySqlDbType.VarChar, 30).Value = k_id;
            if (!ExecuteCommand(queryDeleteKey, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }

        //Dienste

        public static void AddDienst(object d_name, Form1 sender) {
            string addDienst = "INSERT into dienste (d_name) VALUES (@d_name)";
            MySqlCommand queryAddDienst = new MySqlCommand(addDienst);
            queryAddDienst.Parameters.Add("@d_name", MySqlDbType.VarChar, 30).Value = d_name;
            ExecuteCommand(queryAddDienst, sender);
        }

        public static void DeleteDienst(object d_id, Form1 sender) {
            string deleteDienst = "DELETE FROM dienste WHERE d_id = (@d_id)";
            MySqlCommand queryDeleteDienst = new MySqlCommand(deleteDienst);
            queryDeleteDienst.Parameters.Add("@d_id", MySqlDbType.VarChar, 30).Value = d_id;
            if (!ExecuteCommand(queryDeleteDienst, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }

        //Teilnahmen

        public static void AddTeilnahme(object t_lan, object t_person, Form1 sender) {
            string addTeilnahme = "INSERT into teilnahmen (t_lan, t_person) VALUES (@t_lan, @t_person)";
            MySqlCommand queryAddTeilnahme = new MySqlCommand(addTeilnahme);
            queryAddTeilnahme.Parameters.Add("@t_lan", MySqlDbType.VarChar, 30).Value = t_lan;
            queryAddTeilnahme.Parameters.Add("@t_person", MySqlDbType.VarChar, 30).Value = t_person;
            ExecuteCommand(queryAddTeilnahme, sender);
        }

        public static void DeleteTeilnahme(object t_id, Form1 sender)
        {
            string deleteTeilnahme = "DELETE FROM teilnahmen WHERE t_id = (@t_id)";
            MySqlCommand queryDeleteTeilnahme = new MySqlCommand(deleteTeilnahme);
            queryDeleteTeilnahme.Parameters.Add("@t_id", MySqlDbType.VarChar, 30).Value = t_id;
            if (!ExecuteCommand(queryDeleteTeilnahme, sender))
            {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }

        //Ofen 

        public static void AddOfen(object o_lan, object o_person, Form1 sender) {
            string addOfen = "INSERT into ofen (o_person, o_lan) VALUES (@o_person, @o_lan)";
            MySqlCommand queryAddOfen = new MySqlCommand(addOfen);
            queryAddOfen.Parameters.Add("@o_person", MySqlDbType.VarChar, 30).Value = o_person;
            queryAddOfen.Parameters.Add("@o_lan", MySqlDbType.VarChar, 30).Value = o_lan;
            ExecuteCommand(queryAddOfen, sender);
        }

        public static void DeleteOfen(object o_id, Form1 sender) {
            string deleteOfen = "DELETE FROM ofen WHERE o_id = (@o_id)";
            MySqlCommand queryDeleteOfen = new MySqlCommand(deleteOfen);
            queryDeleteOfen.Parameters.Add("@o_id", MySqlDbType.VarChar, 30).Value = o_id;
            if (!ExecuteCommand(queryDeleteOfen, sender)) {
                MessageBox.Show("Fehler beim Löschen!");
            }
        }


    }
}
