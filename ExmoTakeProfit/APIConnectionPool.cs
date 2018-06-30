using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ExmoTakeProfit
{
    /// <summary>
    /// Класс, экземпляр которго содержит информацию о запросах, 
    /// которые необходимо выполнить, компанует их, 
    /// выставляет приоритеты, выполняет запросы.
    /// Инициализируется при создании главного окна.
    /// </summary>
    class APIConnectionPool
    {
        /// <summary>
        /// Максимально количество запросов в минуту
        /// </summary>
        private int countRequestToMin = 0;

        /// <summary>
        /// Список наименований методов обращений к бирже
        /// </summary>
        private Dictionary<int, string> listQueryTypes = new Dictionary<int, string>();

        /// <summary>
        /// Переменная патерна одиночка
        /// </summary>
        private static APIConnectionPool instance;

        /// <summary>
        /// переменная таймера, который будет вызывать метод запросов к бирже
        /// </summary>
        private Timer timerRequest = new Timer();

        /// <summary>
        /// Метод, реализующик патерн одиночка
        /// </summary>
        /// <param name="countRequestToMin">максимальное количество запросов в минуту</param>
        /// <returns></returns>
        public static APIConnectionPool getInstance(int countRequestToMin)
        {
            if (instance == null)
                instance = new APIConnectionPool(countRequestToMin);
            return instance;
        }

        /// <summary>
        /// конструктор класса
        /// </summary>
        private APIConnectionPool(int countRequestToMin)
        {
            this.countRequestToMin = countRequestToMin;

            /* опишем таймер запросов */
            timerRequest.Interval = 500;
            timerRequest.Enabled = true;
            timerRequest.AutoReset = true;
            timerRequest.Elapsed += RequestInLine;
        }

        /// <summary>
        /// Ставит в очередь запрос к бирже
        /// </summary>
        /// <param name="pairCoin">Валютная пара</param>
        /// <param name="typeQuery">Наименование метода</param>
        /// <returns>string</returns>
        public string Request(string pairCoin, int typeQuery)
        {
            return "";
        }

        /// <summary>
        /// Ставит в очередь запрос к бирже на торговлю
        /// </summary>
        /// <param name="pairCoin">Валютная пара</param>
        /// <param name="typeQuery">Наименование метода</param>
        /// <param name="quantity">Кол-во по ордеру</param>
        /// <param name="price">Цена по ордеру</param>
        /// <param name="type">Тип ордера, может принимать следующие значения</param>
        /// <returns></returns>
        public string Request(string pairCoin, int typeQuery, double quantity, double price, int type)
        {
            return "";
        }

        /// <summary>
        /// Служебный метод, который выполняет запросы к бирже согласно очереди запросов.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="e"></param>
        private void RequestInLine(Object source, ElapsedEventArgs e)
        {

        }

        /// <summary>
        /// служебные функции для осуществления запросов к бирже без авторзации
        /// </summary>
        private async Task<string> ApiQueryAsync(string apiName, IDictionary<string, string> req)
        {
            using (var client = new HttpClient())
            {

                var content = new FormUrlEncodedContent(req);
                var response = await client.PostAsync(string.Format(_url, apiName), content);

                return await response.Content.ReadAsStringAsync();
            }
        }

        /// <summary>
        /// метод добавления запросов к бирже, которым требуется авторизация
        /// </summary>
        /// <returns></returns>
        public string AuthorizationRequest()
        {
            return "";
        }

        /* сделали запрос */
        //var task = ApiQueryAsync(apiName, new Dictionary<string, string>());

        /*
         * создание задачи на запрос
         * orderBook = new Task(() => ThreadProcSafe("https://api.exmo.com/v1/order_book/?pair=" + coinPair, "order_book"));
         * orderBook.Start();
         */
    }
}
