using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace tournament
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        List<List<Player>> tables = new List<List<Player>>();

        static string[] houses = { "Старк", "Ланнистер", "Баратеон", "Грейджой", "Тирелл", "Мартелл"};
        public Form1()
        {
            InitializeComponent();
        }

        private void InitGrid()
        {
            for (int i = 0; i < DataGrid.Columns.Count; i++)
                DataGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGrid.Font = new Font("Book Antiqua", 12);
            DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < DataGrid.Rows.Count; i++)
                DataGrid.Rows[i].HeaderCell.Value = (i + 1).ToString();

            DataGrid.RowHeadersWidth += 15;

            int width = 0;
            for (int i = 0; i < DataGrid.Columns.Count; i++)
                width += DataGrid.Rows[0].Cells[i].Size.Width;

            DataGrid.Width = width + DataGrid.TopLeftHeaderCell.Size.Width + 10;
            DataGrid.Left = 0;
            this.Width = DataGrid.Width + 16;

            SortBtn.Left = (this.Width - SortBtn.Width)/2;
            SortBtn.Top = DataGrid.Bottom + 30;

            this.Height = SortBtn.Bottom + 58;
        }

        private void DrawGrids()
        {
            this.Height += 500;
            int tc = tables.Count;
            List<DataGridView> Grids = new List<DataGridView>();
            for (int i = 0; i < tc; i++)
            {
                Grids.Add(new DataGridView());
                this.Controls.Add(Grids.Last());
                Grids.Last().Top = SortBtn.Bottom + 30;
                if (i == 0)
                    Grids.Last().Left = 0;
                else
                    Grids.Last().Left = Grids[i - 1].Right + 30;

                Grids.Last().Font = new System.Drawing.Font("Bookman Old Style", 15);
                Grids.Last().AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                Grids.Last().AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                Grids.Last().ReadOnly = true;

                DataGridViewTextBoxColumn c1;
                for (int cind = 0; cind < 2; cind++)
                {
                    c1 = new DataGridViewTextBoxColumn();
                    Grids.Last().Columns.Add(c1);
                }

                DataGridViewRow row;
                for (int rind = 0; rind < 5; rind++)
                {
                    DataGridViewCell[] Cells = new DataGridViewCell[2];
                    for (int cind = 0; cind < 2; cind++)
                        Cells[cind] = new DataGridViewTextBoxCell();

                    row = new DataGridViewRow();
                    row.Cells.AddRange(Cells);

                    Grids.Last().Rows.Add(row);
                    Grids.Last().Rows[rind].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                Grids.Last().Rows[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


                Grids.Last().Columns[0].HeaderText = "Player";
                Grids.Last().Columns[1].HeaderText = "House";
                Grids.Last().ColumnHeadersHeight += 15;
                Grids.Last().RowHeadersWidth += 15;
                Grids.Last().ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //DefineHouses(tables[i]);
                for (int ii = 0; ii < Grids.Last().Rows.Count; ii++)
                {
                    Grids.Last().Rows[ii].HeaderCell.Value = (ii + 1).ToString();
                    Grids.Last()[0, ii].Value = tables[i][ii].name;
                    Grids.Last()[1, ii].Value = tables[i][ii].NewHouse;
                }


                int width = 0, height = 0;
                for (int p = 0; p < Grids.Last().Rows.Count; p++)
                    height += Grids.Last().Rows[p].Height;
                for (int q = 0; q < Grids.Last().Columns.Count; q++)
                {
                    width += Grids.Last().Columns[q].Width;
                }
                Grids.Last().Height = height + Grids.Last().ColumnHeadersHeight + 2;
                Grids.Last().Width = width + Grids.Last().RowHeadersWidth + 2;
            }

            this.Width = Grids.Last().Right + 17;
            this.Height = Grids.Last().Bottom + 70;
            DataGrid.Left = (this.Width - DataGrid.Width) / 2;
            this.Location = new Point(50, 50);
            SortBtn.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tournamentDataSet34._3_4' table. You can move, or remove it, as needed.
            this._3_4TableAdapter.Fill(this.tournamentDataSet34._3_4);
            InitGrid();
        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            InitPlayers();

            GetTables();
            for (int i = 0; i < tables.Count; i++)
                GiveHouses(i);
            DrawGrids();
        }

        private void InitPlayers()
        {
            for (int i = 0; i < DataGrid.Rows.Count; i++)
            {
                players.Add(new Player());
                players[i].name = DataGrid[0, i].Value.ToString();
                if (DataGrid[1, i].Value != System.DBNull.Value)
                    players[i].NewHouse = DataGrid[1, i].Value.ToString();
                players[i].NewTable = Convert.ToInt32(DataGrid[2, i].Value.ToString());
                
                for (int j = 3; j<DataGrid.Columns.Count; j++)
                    players[i].houses.Add(DataGrid[j, i].Value.ToString());
            }

            //Shuffle<Player>(players);
        }

        //public void Shuffle<T>(IList<T> list)
        //{
        //    Random rng = new Random();
        //    int n = list.Count;
        //    while (n > 1)
        //    {
        //        n--;
        //        int k = rng.Next(n + 1);
        //        Thread.Sleep(10);
        //        T value = list[k];
        //        list[k] = list[n];
        //        list[n] = value;
        //    }
        //}

        private void CalculateConnections(List<List<Player>> tables)
        {
            for (int i = 0; i < players.Count; i++)
                players[i].connections = 0;

            for (int i = 0; i < tables.Count; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        if (j != k)
                        {
                            if (tables[i][j].tables.Last() == tables[i][k].tables.Last())
                                tables[i][j].connections++;
                        }
                    }
                }
            }
        }

        private void SortByConnections(List<List<Player>> tables)
        {
            CalculateConnections(tables);

            bool sorted = false;

            while (!sorted)
            {
                CalculateConnections(tables);

                int prev_table = 0;
                int tn = 0;
                for (int i = 0; i < tables.Count; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (tables[i][j].connections > 1)
                        {
                            tn = i;
                            prev_table = tables[i][j].tables.Last();
                        }
                    }
                }

                if (prev_table == 0)
                    sorted = true;
                else
                {
                    List<Player> excess = new List<Player>();
                    for (int i = 0; i < 6; i++)
                    {
                        if (tables[tn][i].tables.Last() == prev_table)
                            excess.Add(tables[tn][i]);
                    }
                    for (int pl = 0; pl < excess.Count; pl++)
                    {
                        List<Player> candidates = new List<Player>();
                        int place = (excess[pl].places.Last() - 1) / 2;
                        for (int i = 0; i < tables.Count; i++)
                        {
                            if (i != tn)
                            {
                                for (int j = 0; j < 6; j++)
                                {
                                    if (((tables[i][j].places.Last() - 1) / 2 == place)
                                        && (tables[i][j].tables.Last() != excess[pl].tables.Last()))
                                        candidates.Add(tables[i][j]);
                                }
                            }
                        }
                        List<int> change_values = new List<int>();
                        for (int i = 0; i < candidates.Count; i++)
                        {
                            int cand_con = 0,
                                excess_con = 0,
                                cand_table = candidates[i].NewTable,
                                excess_table = excess[pl].NewTable;
                            for (int j = 0; j < 6; j++)
                            {
                                if (tables[cand_table][j] != candidates[i])
                                {
                                    if (tables[cand_table][j].tables.Last() == excess[pl].tables.Last())
                                        excess_con++;
                                }
                            }

                            for (int j = 0; j < 6; j++)
                            {
                                if (tables[excess_table][j] != excess[pl])
                                {
                                    if (tables[excess_table][j].tables.Last() == candidates[i].tables.Last())
                                        cand_con++;
                                }
                            }
                            change_values.Add(cand_con + excess_con);
                            candidates[i].new_con = cand_con;
                        }

                        int min_ch_value = change_values[0],
                            ch_ind = 0;
                        for (int i = 0; i < change_values.Count; i++)
                        {
                            if (change_values[i] < min_ch_value)
                            {
                                min_ch_value = change_values[i];
                                ch_ind = i;
                            }
                        }

                        excess[pl].subst = candidates[ch_ind];
                        excess[pl].subst_v = min_ch_value;
                    }

                    int min_change_value = excess[0].subst_v,
                        min_ind = 0;
                    for (int i = 0; i < excess.Count; i++)
                    {
                        if (excess[i].subst_v < min_change_value)
                        {
                            min_ind = i;
                            min_change_value = excess[i].subst_v;
                        }
                    }
                    Player source = excess[min_ind];
                    Player destination = excess[min_ind].subst;
                    int source_t = source.NewTable;

                    source.connections = min_change_value - destination.new_con;
                    destination.connections = destination.new_con;

                    tables[source.NewTable].Remove(source);
                    tables[destination.NewTable].Remove(destination);

                    tables[destination.NewTable].Add(source);
                    source.NewTable = destination.NewTable;

                    tables[source_t].Add(destination);
                    destination.NewTable = source_t;
                }
            }
        }

        private int DefineHouse(string s)
        {
            switch (s)
            {
                case "Старк":
                        return 0;
                case "Ланнистер":
                        return 1;
                case "Баратеон":
                        return 2;
                case "Грейджой":
                        return 3;
                case "Тирелл":
                        return 4;
                case "Мартелл":
                        return 5;
                default:
                        return -1;
            }
        }

        private int[] CalculatePopularity(int num)
        {
            List<Player> table = tables[num];
            int taken = 0;
            int[] popularity = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < table.Count; i++)
            {
                if (table[i].NewHouse != "")
                {
                    taken++;
                    popularity[DefineHouse(table[i].NewHouse)] = 100;
                }
            }

            for (int i = 0; i < 6; i++)
                popularity[i] += 6 - taken;


            for (int i = 0; i < table.Count; i++)
            {
                if (table[i].NewHouse == "")
                {
                    for (int j = 0; j < table[i].houses.Count; j++)
                    {
                        string last_house = table[i].houses[j];
                        popularity[DefineHouse(last_house)]--;
                    }
                }
            }
            return popularity;
        }

        private void GetTables()
        {
            int tc = players.Count / 6;
            for (int i = 0; i < tc; i++)
                tables.Add(new List<Player>());

            for (int i = 0; i < players.Count; i++)
            {
                tables[players[i].NewTable - 1].Add(players[i]);
            }
        }

        private bool PlayedBefore(Player p, string house)
        {
            for (int j = 0; j < p.houses.Count; j++)
                if (p.houses[j] == house)
                    return true;
            return false;
        }

        private void GiveHouses(int num)
        {
            List<Player> table = tables[num];
            int[] popularity = CalculatePopularity(num);
            int p = 0;
            for (int i = 0; i < 6; i++)
                if (popularity[i] > 10)
                    p++;

            for (int picked = p; picked < 6; picked++)
            {
                int min = 10,
                    house_index = -1;
                for (int i = 0; i < 6; i++)
                {
                    if (popularity[i] < min)
                    {
                        house_index = i;
                        min = popularity[i];
                    }
                }

                Random r = new Random((int)DateTime.Now.Ticks);
                Thread.Sleep(100);
                int previous_house_count = 0;
                for (int i = 0; i < 6; i++)
                    if (table[i].NewHouse == "")
                        if (PlayedBefore(table[i],houses[house_index]))
                            previous_house_count++;

                int pl = r.Next(0, 6 - picked - previous_house_count);
                int k = 0;
                for (int i = 0; i < 6; i++)
                {
                    if ((table[i].NewHouse != "")||(PlayedBefore(table[i],houses[house_index])))
                        k++;
                    else
                    {
                        if ((i - k) == pl)
                        {
                            table[i].NewHouse = houses[house_index];
                            for (int j = 0; j < 6; j++)
                                popularity[j]--;

                            for (int j = 0; j < table[i].houses.Count; j++)
                                popularity[DefineHouse(table[i].houses[j])]++;

                            break;
                        }
                    }
                }
                popularity[house_index] = 20;
            }
        }

    }
}
