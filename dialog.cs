using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace NQueen
{
    public partial class dialog : Form
    {
        public dialog()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string str = count.Text;
            int amount;
            if (string.IsNullOrEmpty(str) || int.TryParse(str, out amount) == false) { return; }
            int[] list = new int[amount];
            List<string> outstring = new List<string>(10000);
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < amount; i++) list[i] = i;
            {
                outlist.Items.Clear();
                int size = amount;
                int totalCount = 0;
                do
                {
                    totalCount++;
                    bool failed = false;
                    for (int i = 0; i < size; i++)
                    {
                        for (int j = i + 1; j < size; j++)
                        {
                            int queen1X = i;
                            int queen1Y = list[i];
                            int queen2X = j;
                            int queen2Y = list[j];
                            //   failed = (queen1Y == queen2Y || queen1X == queen2X);
                            failed = Math.Abs(queen1X - queen2X) == Math.Abs(queen1Y - queen2Y);
                            failed = failed || queen1X + queen1Y == queen2X + queen2Y;
                            if (failed) break;
                        }
                        if (failed) break;
                    }
                    if (failed == false)
                        outstring.Add(String.Join(" - ", list));
                } while (nextPermutation(list));
                sw.Stop();
                Text = $"NQueen: {outstring.Count}/{totalCount} done in {sw.ElapsedMilliseconds} ms.";
                outstring.ForEach(a => outlist.Items.Add(a));
            }
        }

        public static bool nextPermutation(int[] list)
        {
            int largestI = -1, largestJ = -1;
            for (int i = list.Length - 2; i >= 0; i--)
            {
                if (list[i] >= list[i + 1]) continue;
                largestI = i;
                break;
            }
            if (largestI == -1) return false;
            for (int i = list.Length - 1; i >= 0; i--)
            {
                if (list[largestI] >= list[i]) continue;
                largestJ = i;
                break;
            }

            var tmp = list[largestI];
            list[largestI] = list[largestJ];
            list[largestJ] = tmp;

            for (int i = largestI + 1, j = list.Length - 1; i < j; i++, j--)
            {
                tmp = list[i];
                list[i] = list[j];
                list[j] = tmp;
            }

            return true;
        }

        private void outlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = outlist.SelectedIndex;
            if (index < 0) return;
            string[] parts = outlist.Items[index].ToString().Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
            int[] list = new int[parts.Length];
            int length = list.Length;
            for (int i = 0; i < length; i++) list[i] = int.Parse(parts[i].Trim());
            Graphics g = picbox.CreateGraphics();
            int size = Math.Min(picbox.Width, picbox.Height);
            float box = size / (float)length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Brush bg = ((i + j) & 1) > 0 ? Brushes.White : Brushes.Black;
                    g.FillRectangle(bg, i * box, j * box, box, box);
                    if (list[i] == j) { g.FillEllipse(Brushes.Red, i * box, j * box, box, box); }
                }
            }
            g.Dispose();
        }


        /**
            http://kisi.deu.edu.tr/murat.berberler/csc5007/NQUEENS.PAS
        */
        private void pascal_Click(object sender, EventArgs e)
        {
            string str = count.Text;
            int amount;
            if (string.IsNullOrEmpty(str) || int.TryParse(str, out amount) == false) { return; }
            _nqueens(amount);
        }

        private bool place(int k, int[] x, ref int step)
        {
            int i = 1;
            while (i < k)
            {
                if (x[i] == x[k] || Math.Abs(x[i] - x[k]) == Math.Abs(i - k))
                    return false;
                i++;
                step++;
            }
            return true;
        }

        private void _nqueens(int n)
        {
            int adim = 0;
            int[] x = new int[n + 1];
            StringBuilder sb = new StringBuilder();
            List<string> strout = new List<string>(10000);
            x[1] = 0;
            int k = 1;
            Stopwatch sw = Stopwatch.StartNew();
            while (k > 0)
            {
                x[k] = x[k] + 1;
                while (x[k] <= n && false == place(k, x, ref adim)) x[k] = x[k] + 1;
                if (x[k] <= n)
                {
                    if (k == n)
                    {
                        sb.Clear();
                        sb.Append(x[1]-1);
                        for (int i = 2;i<=n ; i++)
                        {
                            sb.Append(" - ").Append(x[i]-1);
                        }

                        strout.Add(sb.ToString());
                    }
                    else
                    {
                        k = k + 1;
                        x[k] = 0;
                    }
                }
                else k = k - 1;
                ++adim;
            }
            sw.Stop();
            Text = $"NQueen: {strout.Count}/{adim} done in {sw.ElapsedMilliseconds} ms.";
            outlist.Items.Clear();
            strout.ForEach(a => outlist.Items.Add(a));
        }


    }
}
