using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ExmoTakeProfit
{
    public partial class ExmoTakeProfit : Form
    {
        public ToolStripLabel infoLabel;
        protected Keys keys;
        delegate void StringArgReturningVoidDelegate(string text);
        private Thread demoThread = null;
        private UserInfo rootobject;
        private Dictionary<string, ListViewItem> listCoinToBalance = new Dictionary<string, ListViewItem>();

        private static bool loginStatus = false;

        public ExmoTakeProfit()
        {
            InitializeComponent();

            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Чтение данных";
            statusStrip1.Items.Add(infoLabel);

            

            string msg = "";
            keys = WorkWithLocalFiles.ReadFile();
            if (!WorkWithLocalFiles.CheckingFile())
                switch (WorkWithLocalFiles.FileCreation())
                {
                    case 0:
                        msg = "Файлы успешно созданы";
                        break;
                    case 1:
                        msg = "Не возможно создать файлы";
                        break;
                    case 2:
                        msg = "Не возможно создать каталоги";
                        break;
                }
            else
            {
                msg = "Чтение завершено";
                infoLabel.Text = msg;
            }

            
        }
        private void login_Click(object sender, EventArgs e)
        {
            if (loginStatus)
            {
                var logout = MessageBox.Show("Вы уверены, что хотитей выйти?", "Выход",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
                if(logout == DialogResult.Yes)
                {
                    /* описать удаление переменных сред */
                }
            }
            else
            {
                Login log = new Login();
                log.Show();
            }
            
        }

        private void ExmoTakeProfit_Shown(object sender, EventArgs e)
        {
            this.demoThread =
                new Thread(new ThreadStart(this.ThreadProcSafe));
            infoLabel.Text = "Запрос к бирже";
            this.demoThread.Start();
        }
        private void ThreadProcSafe()
        {
            var api = new ExmoApi(keys.key, keys.secret);
            var task = api.ApiQueryAsync("user_info", new Dictionary<string, string>());
            rootobject = JsonConvert.DeserializeObject<UserInfo>(task.Result);
            this.SetText(task.Result);
        }
        private void SetText(string text)
        {
            if (statusStrip1.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                infoLabel.Text = "Получены актуальные балансы";

                userId.Text = "User ID " + rootobject.uid.ToString();
                userId.Visible = loginStatus = true;
                login.Text = "Выйти";

                foreach (KeyValuePair<string, float> i in rootobject.balances)
                {
                    listCoinToBalance.Add(i.Key, new ListViewItem(new string[] { i.Key, i.Value.ToString() }, 0));
                    listCoins.Items.Add(listCoinToBalance[i.Key]);
                }
                
            }
        }

        private void listCoins_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ListView.SelectedListViewItemCollection breakfast = this.listCoins.SelectedItems;
            /*
            string price = "";
            foreach (ListViewItem item in breakfast)
            {
                price += item.SubItems[0].Text;
            }

            // Output the price to TextBox1.
            textBox1.Text = breakfast.Count.ToString();*/
            if(this.listCoins.SelectedItems.Count > 0)
            {
                addTasks_button.Enabled = true;
            }
            else
            {
                addTasks_button.Enabled = false;
            }
        }

        private void addTasks_button_Click(object sender, EventArgs e)
        {
            
            ListView.SelectedListViewItemCollection breakfast = this.listCoins.SelectedItems;
            foreach (ListViewItem item in breakfast)
            {
                AddTasks add = new AddTasks(rootobject.balances[item.SubItems[0].Text], item.SubItems[0].Text);
                add.Show();
            }
            
        }
    }
    public class Keys
    {
        public string key;
        public string secret;
    }
}
