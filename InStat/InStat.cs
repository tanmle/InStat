using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace InStat
{
    public partial class InStat : Form
    {
        private readonly Logic _logic = new Logic();
        private Dictionary<string, List<string>> _availablePlayersDic;
        internal string url = "";

        public InStat()
        {
            InitializeComponent();
            _availablePlayersDic = GetRegisteredDic();
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            if (lst_AvPlayers.Items.Count > 0)
            {
                lst_AvPlayers.View = View.List;

                Random rnd = new Random();
                var randCase = rnd.Next(1, 3);
                var playersList = _availablePlayersDic.Keys.ToList();

                lstBox1.Items.Clear();
                lstBox2.Items.Clear();

                switch (randCase)
                {
                    case 1:
                        // Team A
                        var oddList = _logic.RandomTeam(_availablePlayersDic, playersList, "Team A");

                        foreach (var player in oddList)
                        {
                            lstBox1.Items.Add(player);
                        }

                        //Team B
                        var evenList = _logic.RandomTeam(_availablePlayersDic, playersList, "Team B");

                        foreach (var player in evenList)
                        {
                            lstBox2.Items.Add(player);
                        }
                        break;

                    case 2:
                        // Team A
                        oddList = _logic.RandomTeam_Case2(_availablePlayersDic, playersList, "Team A");

                        foreach (var player in oddList)
                        {
                            lstBox1.Items.Add(player);
                        }

                        //Team B
                        evenList = _logic.RandomTeam_Case2(_availablePlayersDic, playersList, "Team B");

                        foreach (var player in evenList)
                        {
                            lstBox2.Items.Add(player);
                        }
                        break;

                    case 3:
                        // Team A
                        oddList = _logic.RandomTeam_Case3(_availablePlayersDic, playersList, "Team A");

                        foreach (var player in oddList)
                        {
                            lstBox1.Items.Add(player);
                        }

                        //Team B
                        evenList = _logic.RandomTeam_Case3(_availablePlayersDic, playersList, "Team B");

                        foreach (var player in evenList)
                        {
                            lstBox2.Items.Add(player);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show("Click Show players first!!!");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            // Make sure all fields are filled 
            if (tbx_Name.Text != "" && lbx_Pos.Text != "" && tbx_Level.Text != "" && tbx_Email.Text != "")
            {
                // Validate duplicated input key
                if (!_availablePlayersDic.ContainsKey(tbx_Name.Text))
                {
                    lst_AvPlayers.Items.Add(tbx_Name.Text);
                    // Update dictionary
                    _availablePlayersDic.Add(tbx_Name.Text, new List<string>() { lbx_Pos.Text, tbx_Level.Text, tbx_Email.Text });
                    ClearTextboxes();
                }
                else
                {
                    MessageBox.Show("Player's already added");
                }
            }
            else
            {
                MessageBox.Show("Missing data");
            }
        }

        private void ClearTextboxes()
        {
            tbx_Name.Clear();
            lbx_Pos.ResetText();
            tbx_Level.Clear();
            tbx_Email.Clear();
        }

        // Get wildcard players, filter by database
        private List<string> GetWildCard()
        {
            var playersList = _logic.GetAvailablePlayers();
            var keyList = new List<string>(Data.Bio.Keys);

            var wildcard = playersList.Except(keyList).ToList();
            return wildcard;
        }

        private void btn_ShowPlayers_Click(object sender, EventArgs e)
        {
            lst_AvPlayers.View = View.List;
            lst_Wildcard.View = View.List;
            lst_AvPlayers.Items.Clear();
            lst_Wildcard.Items.Clear();
            lstBox1.Items.Clear();
            lstBox2.Items.Clear();

            var wildcards = GetWildCard();
            var playersList = _logic.GetAvailablePlayers();
            var keyList = playersList.Except(wildcards).ToList();
            tbx_Total.Text = playersList.Count().ToString();

            // Display playerlist on box
            foreach (var players in keyList)
            {
                lst_AvPlayers.Items.Add(players);
            }

            foreach (var wildcard in wildcards)
            {
                lst_Wildcard.Items.Add(wildcard);

            }
        }

        public Dictionary<string, List<string>> GetRegisteredDic()
        {
            var wildcards = GetWildCard();
            var secondDict = (from x in Data.Bio
                              select x).ToDictionary(x => x.Key, x => x.Value);
            var playersList = _logic.GetAvailablePlayers();
            var sub = playersList.Except(wildcards).ToList();
            var keyList = secondDict.Keys.Except(sub).ToList();
            foreach (var key in keyList)
            {
                secondDict.Remove(key);
            }

            return secondDict;
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            var imagePath = Environment.CurrentDirectory + "\\team.PNG";

            if (File.Exists(imagePath))
            {
                File.Delete(imagePath);
            }

            bitmap.Save(imagePath);
            Thread.Sleep(2);

            _logic.SendEmail(_availablePlayersDic, Data.Bio, url);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fwArrow_Click(object sender, EventArgs e)
        {
            if (lstBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player");
            }
            else
            {
                lstBox2.Items.Add(lstBox1.SelectedItem);
                lstBox1.Items.Remove(lstBox1.SelectedItem);
            }           
        }

        private void backArrow_Click(object sender, EventArgs e)
        {
            if (lstBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player");
            }
            else
            {
                lstBox1.Items.Add(lstBox2.SelectedItem);
                lstBox2.Items.Remove(lstBox2.SelectedItem);
            }
        }

        private void btn_AddURL_Click(object sender, EventArgs e)
        {
            if (tbx_URL.Text != "")
            {
                url = tbx_URL.Text;
            }

            tbx_URL.Clear();
        }
    }
}
