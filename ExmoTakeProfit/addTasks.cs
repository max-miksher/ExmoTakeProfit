using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmoTakeProfit
{
    public partial class AddTasks : Form
    {
        private float volume_coin = 0;
        private string name_coin = "";
        private Thread demoThread;

        private string _url = "https://api.exmo.com/v1/ticker/";
        private string apiName = "ticker";
        private Dictionary<string, PairInfo> rootobject;

        private List<TradingTask> listlistOfJobInstances = new List<TradingTask>();

        delegate void StringArgReturningVoidDelegate(string text);

        public AddTasks(float v, string n)
        {
            InitializeComponent();
            volume_coin = v;
            name_coin = n;

            addTasks_label_h1.Text = name_coin;
            addTasks_textBoxBalance.Text = volume_coin.ToString();

            this.demoThread =
                new Thread(new ThreadStart(this.ThreadProcSafe));
            this.demoThread.Start();
        }
        
        public async Task<string> ApiQueryAsync(string apiName, IDictionary<string, string> req)
        {
            using (var client = new HttpClient())
            {

                var content = new FormUrlEncodedContent(req);
                var response = await client.PostAsync(string.Format(_url, apiName), content);

                return await response.Content.ReadAsStringAsync();
            }
        }
        private void ThreadProcSafe()
        {
            var task = ApiQueryAsync(apiName, new Dictionary<string, string>());
            rootobject = JsonConvert.DeserializeObject<Dictionary<string, PairInfo>>(task.Result);
            this.SetText(task.Result);
        }
        private void SetText(string text)
        {
            if (addTasks_listPairToOpenTask.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {

                foreach (KeyValuePair<string, PairInfo> i in rootobject)
                {
                    if (i.Key.Contains(name_coin))
                        addTasks_listPairToOpenTask.Items.Add(i.Key);
                }

            }
        }

        private void addTasks_buttonToCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addTasks_button_25_Click(object sender, EventArgs e)
        {
            setToVolumeSell(0.25);
        }

        private void addTasks_button_50_Click(object sender, EventArgs e)
        {
            setToVolumeSell(0.5);
        }

        private void addTasks_button_75_Click(object sender, EventArgs e)
        {
            setToVolumeSell(0.75);
        }

        private void addTasks_button_100_Click(object sender, EventArgs e)
        {
            setToVolumeSell(1);
        }

        private void setToVolumeSell(double a)
        {
            if (addTasks_checkBox_useRelativeValues.Checked)
                addTasks_textBox_volumeToSell.Text = Convert.ToString(a * 100 * Convert.ToDouble(addTasks_textBoxBalance.Text));
            else
                addTasks_textBox_volumeToSell.Text = Convert.ToString(Convert.ToDouble(addTasks_textBoxBalance.Text) * a);
        }

        private void addTasks_checkBox_useRelativeValues_CheckedChanged(object sender, EventArgs e)
        {
            if (addTasks_checkBox_useRelativeValues.Checked)
            {
                addTasks_textBox_addProfit.Enabled = true;
            }
            else
            {
                addTasks_textBox_addProfit.Enabled = false;
                addTasks_textBox_addProfit.Text = "0";
            }
                

        }

        private void enabledAddTask()
        {
            if (
                addTasks_textBox_volumeToSell.Text.Length > 0 &&
                Convert.ToDouble(addTasks_textBox_volumeToSell.Text) <= Convert.ToDouble(addTasks_textBoxBalance.Text) &&
                addTasks_listPairToOpenTask.SelectedIndices.Count > 0
                )
            {
                addTasks_buttonToOpenTaks.Enabled = true;
            }
            else
            {
                addTasks_buttonToOpenTaks.Enabled = false;
            }
        }

        private void addTasks_listPairToOpenTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            enabledAddTask();
        }

        private void addTasks_textBox_volumeToSell_TextChanged(object sender, EventArgs e)
        {
            enabledAddTask();
        }

        /*при нажатии "создать задание", создается экземпляр класса задания */
        private void addTasks_buttonToOpenTaks_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection listCoin = addTasks_listPairToOpenTask.SelectedItems;
            foreach (ListViewItem item in listCoin)
            {
                listlistOfJobInstances.Add(new TradingTask(
                    name_coin,
                    item.SubItems[0].Text,
                    Convert.ToDouble(addTasks_textBox_volumeToSell.Text),
                    0.04,
                    0.04,
                    addTasks_checkBox_useRelativeValues.Checked,
                    Convert.ToDouble(addTasks_textBox_addProfit.Text)

                ));
                //MessageBox.Show(item.SubItems[0].Text);
            }

            
        }
    }
    class PairInfo
    {
        public string buy_price;
        public string sell_price;
        public string last_trade;
        public string high;
        public string low;
        public string avg;
        public string vol;
        public string vol_curr;
        public string updated;
    }
}
