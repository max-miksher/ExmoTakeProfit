using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExmoTakeProfit
{
    class TradingTask
    {
        /* конструктор */
        public TradingTask(string baseCoin, string coinPair, double volumeTrade, double volumeProfit, double volumeStopLose, bool addProfit, double maximumOrderValue)
        {
            this.baseCoin = baseCoin;
            this.coinPair = coinPair;
            this.volumeTrade = volumeTrade;
            this.volumeProfit = volumeProfit;
            this.volumeStopLose = volumeStopLose;
            this.addProfit = addProfit;
            this.maximumOrderValue = maximumOrderValue;
            
            /*
             * создане task с функцией торговли
             */
            Trading = new Task(TradingFn);
            Trading.Start();

            
        }

        /* деструктор */
        ~TradingTask()
        {
            Trading.Dispose();
            /* todo
             * удаление задания из файла
             */
        }

        /* поля */
        private string baseCoin = null;
        private string coinPair = null;
        private double volumeTrade = 0;
        private double volumeProfit = 0;
        private double volumeStopLose = 0;
        private bool addProfit = false;
        private double maximumOrderValue = 0;
        private Task Trading;

        private string _url;
        private string apiName = null;
        private Task listOfDeals;
        private Task orderBook;
        private ListDealsOfCoinPair listDealsOfCoinPair;
        private ListOpenOrders listOpenOrders;

        private void TradingFn()
        {

            /* todo 
             * запись задния в файл
             */



            /*
             * Список сделок по валютной паре
             */
            /*this.listOfDeals =
                new Thread(new ThreadStart(this.ThreadProcSafe));
            this.listOfDeals.Start();*/
            listOfDeals = new Task(() => ThreadProcSafe("https://api.exmo.com/v1/trades/?pair=" + coinPair, "trades"));
            listOfDeals.Start();
            /*
             * Книга открытых ордеров по валютной паре
             */
            _url = "https://api.exmo.com/v1/order_book/?pair=" + coinPair;
            apiName = "order_book";
            /*this.orderBook =
                new Thread(new ThreadStart(this.ThreadProcSafe));
            this.orderBook.Start();*/
            orderBook = new Task(() => ThreadProcSafe("https://api.exmo.com/v1/order_book/?pair=" + coinPair, "order_book"));
            orderBook.Start();

        }


        /* служебные функции для осуществления запросов к бирже */
        public async Task<string> ApiQueryAsync(string apiName, IDictionary<string, string> req)
        {
            using (var client = new HttpClient())
            {

                var content = new FormUrlEncodedContent(req);
                var response = await client.PostAsync(string.Format(_url, apiName), content);

                return await response.Content.ReadAsStringAsync();
            }
        }

        private void ThreadProcSafe(string _url, string apiName)
        {
            /* сделали запрос */
            var task = ApiQueryAsync(apiName, new Dictionary<string, string>());
            JObject coinObject;
            switch (apiName)
            {
                case "trades":
                    /* создали объект из полученных данных */
                    coinObject = JObject.Parse(task.Result);
                    MessageBox.Show("1");
                    /* получил массив с информацией в виде строк о сделках */
                    /* создадим объек, который будет собирать информацию об сделках по паре */
                    listDealsOfCoinPair = ListDealsOfCoinPair.getInstance((JArray)coinObject[coinPair]);
                    break;

                case "order_book":

                    /* создали объект из полученных данных */
                    coinObject = JObject.Parse(task.Result);
                    MessageBox.Show("2");
                    /* получил массив с информацией в виде строк о сделках */
                    /* создадим объек, который будет собирать информацию об сделках по паре */
                    //listOpenOrders = ListOpenOrders.getInstance((JArray)coinObject[coinPair]);

                    break;
            }
        }

    }

    /// <summary>
    /// список открытых ордеров
    /// </summary>
    internal class ListOpenOrders
    {
        public double ask_quantity;
        public double ask_amount;
        public double ask_top;
        public double bid_quantity;
        public double bid_amount;
        public double bid_top;

        //public double ;

        public Dictionary<double, OrderInfo> arrayOrders = new Dictionary<double, OrderInfo>();

        private static ListOpenOrders instance;


        public static ListOpenOrders getInstance(JArray array)
        {
            if (instance == null)
                instance = new ListOpenOrders(array);
            return instance;
        }
        private ListOpenOrders(JArray array)
        {
            //MessageBox.Show(array.Count.ToString());
            ask_quantity = Convert.ToDouble(array["ask_quantity"]);
            ask_amount = Convert.ToDouble(array["ask_amount"]);
            ask_top = Convert.ToDouble(array["ask_top"]);
            bid_quantity = Convert.ToDouble(array["bid_quantity"]);
            bid_amount = Convert.ToDouble(array["bid_amount"]);
            bid_top = Convert.ToDouble(array["bid_top"]);

            JObject bid = JObject.Parse(array["bid"].ToString());

            JObject ask = JObject.Parse(array["ask"].ToString());

            foreach (KeyValuePair<string, JToken> b in bid)
            {
                
                //JObject tmpArray = JObject.Parse(info.ToString());
                /*
                i.date = Convert.ToDouble(tmpArray["date"]);
                i.amount = Convert.ToDouble(tmpArray["amount"]);
                i.quantity = Convert.ToDouble(tmpArray["quantity"]);
                i.type = tmpArray["type"].ToString();
                i.price = Convert.ToDouble(tmpArray["price"]);
                i.trade_id = Convert.ToInt32(tmpArray["trade_id"]);

                if (!arrayOrders.ContainsKey(i.date))
                    arrayOrders.Add(i.date, i);*/
            }
            foreach (KeyValuePair<string, JToken> a in ask)
            {
                //JObject tmpArray = JObject.Parse(info.ToString());
                /*
                i.date = Convert.ToDouble(tmpArray["date"]);
                i.amount = Convert.ToDouble(tmpArray["amount"]);
                i.quantity = Convert.ToDouble(tmpArray["quantity"]);
                i.type = tmpArray["type"].ToString();
                i.price = Convert.ToDouble(tmpArray["price"]);
                i.trade_id = Convert.ToInt32(tmpArray["trade_id"]);

                if (!arrayOrders.ContainsKey(i.date))
                    arrayOrders.Add(i.date, i);*/
            }
        }
    }


    /// <summary>
    /// список сделок
    /// </summary>
    class ListDealsOfCoinPair
    {
        public Dictionary<double, OrderInfo> arrayDeals = new Dictionary<double, OrderInfo>();

        private static ListDealsOfCoinPair instance;


        public static ListDealsOfCoinPair getInstance(JArray array)
        {
            if (instance == null)
                instance = new ListDealsOfCoinPair(array);
            return instance;
        }
        private ListDealsOfCoinPair(JArray array)
        {
            foreach(JToken info in array)
            {
                OrderInfo i = new OrderInfo();
                JObject tmpArray = JObject.Parse(info.ToString());

                i.date = Convert.ToDouble(tmpArray["date"]);
                i.amount = Convert.ToDouble(tmpArray["amount"]);
                i.quantity = Convert.ToDouble(tmpArray["quantity"]);
                i.type = tmpArray["type"].ToString();
                i.price = Convert.ToDouble(tmpArray["price"]);
                i.trade_id = Convert.ToInt32(tmpArray["trade_id"]);

                if (!arrayDeals.ContainsKey(i.date))
                    arrayDeals.Add(i.date, i);
            }
        }
    }
    class OrderInfo
    {
        public int trade_id;
        public string type;
        public double price;
        public double quantity;
        public double amount;
        public double date;
    }

}
